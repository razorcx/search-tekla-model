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
		private readonly Model _model;

		public Search()
		{
			try
			{
				_model = new Model();

				InitializeComponent();

				InitializeUi();
			}
			catch (Exception ex)
			{
				
			}
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxSearchString.Text)) return;

			var parts = GetPartsByPartType(comboBoxPartType.Text);
			if (!parts.Any()) return;

			var results = GetSearchResults(parts, comboBoxPartProperty.Text, textBoxSearchString.Text);
			if (!results.Any()) return;

			DrawResultsInModel(results);
		}

		private void DrawResultsInModel(List<Part> parts)
		{
			var drawer = new GraphicsDrawer();
			var color = new Color(1, 1, 1);

			parts.ForEach(p =>
			{
				var location = p.GetCoordinateSystem().Origin;

				switch (comboBoxPartProperty.Text)
				{
					case "NAME":
						drawer.DrawText(location, p.Name, color);
						break;
					case "PROFILE":
						drawer.DrawText(location, p.Profile.ProfileString, color);
						break;
					case "MATERIAL":
						drawer.DrawText(location, p.Material.MaterialString, color);
						break;
					case "CLASS":
						drawer.DrawText(location, p.Class, color);
						break;
					case "FINISH":
						drawer.DrawText(location, p.Finish, color);
						break;
					case "PARTMARK":
						drawer.DrawText(location, p.GetPartMark(), color);
						break;
					default:
						drawer.DrawText(location, textBoxSearchString.Text, color);
						break;
				}
			});
		}

		private List<Part> GetPartsByPartType(string type)
		{
			switch (type)
			{
				case "BEAM":
					return _model.GetPartsByType(ModelObject.ModelObjectEnum.BEAM);
				case "CONTOUR_PLATE":
					return _model.GetPartsByType(ModelObject.ModelObjectEnum.CONTOURPLATE);
				case "POLYBEAM":
					return _model.GetPartsByType(ModelObject.ModelObjectEnum.POLYBEAM);
				case "BENT_PLATE":
					return _model.GetPartsByType(ModelObject.ModelObjectEnum.BENT_PLATE);
				default:
					return new List<Part>();
			}
		}

		private List<Part> GetSearchResults(List<Part> parts, string partProperty, string searchString)
		{
			switch (partProperty)
			{
				case "NAME":
					return parts.AsParallel()
						.Where(p => p.Name.Contains(searchString))
						.ToList();
				case "PROFILE":
					return parts.AsParallel()
						.Where(p => p.Profile.ProfileString.Contains(searchString))
						.ToList();
				case "MATERIAL":
					return parts.AsParallel()
						.Where(p => p.Material.MaterialString.Contains(searchString))
						.ToList();
				case "CLASS":
					return parts.AsParallel()
						.Where(p => p.Class.Contains(searchString))
						.ToList();
				case "FINISH":
					return parts.AsParallel()
						.Where(p => p.Finish.Contains(searchString))
						.ToList();
				case "PARTMARK":
					return parts.AsParallel()
						.Where(p => p.GetPartMark().Contains(searchString))
						.ToList();
				default:
					return new List<Part>();
			}
		}

		private void InitializeUi()
		{
			comboBoxPartType.DataSource = new List<string>
			{
				"BEAM",
				"CONTOUR_PLATE",
				"POLYBEAM",
				"BENT_PLATE"
			};

			comboBoxPartProperty.DataSource = new List<string>
			{
				"NAME",
				"PROFILE",
				"MATERIAL",
				"CLASS",
				"FINISH",
				"PARTMARK",
			};
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

		public static List<Part> GetPartsByType(this Model model, ModelObject.ModelObjectEnum modelObjectEnum)
		{
			ModelObjectEnumerator.AutoFetch = true;

			return model.GetModelObjectSelector()
				.GetAllObjectsWithType(modelObjectEnum)
				.ToList()
				.OfType<Part>()
				.ToList();
		}
	}
}
