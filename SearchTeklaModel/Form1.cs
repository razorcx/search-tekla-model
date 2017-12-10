using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;

namespace SearchTeklaModel
{
	public partial class Search : Form
	{
		public Search()
		{
			InitializeComponent();
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			//searching for member part mark
			var searchValue = textBoxSearch.Text;

			ModelObjectEnumerator.AutoFetch = true;
			var modelObjects = new Model().GetModelObjectSelector()
				.GetAllObjectsWithType(ModelObject.ModelObjectEnum.BEAM)
				.ToList()
				.OfType<Beam>()
				.ToList();

			var beams = modelObjects
				.Where(b => b.GetPartMark()
				.Contains(searchValue))
				.ToList();

			beams.ForEach(b =>
			{
				var drawer = new GraphicsDrawer();
				var color = new Tekla.Structures.Model.UI.Color(1,1,1);
				var location = b.GetCoordinateSystem().Origin;
				drawer.DrawText(location, b.GetPartMark(), color);
			});
		}
	}

	public static class TeklaModelExtensions
	{
		public static List<ModelObject> ToList(this ModelObjectEnumerator enumerator)
		{
			var modelObjects = new List<ModelObject>();
			while (enumerator.MoveNext())
			{
				var modelObject = enumerator.Current;
				modelObjects.Add(modelObject);
			}
			return modelObjects;
		}
	}
}
