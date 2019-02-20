using Newtonsoft.Json.Linq;
using Skybrud.Umbraco.GridData;
using Skybrud.Umbraco.GridData.Interfaces;
using Skybrud.Umbraco.GridData.Rendering;

namespace Graph.Components.CampaignSection
{
	public class CampaignSectionGridConverter : IGridConverter
	{
		public bool ConvertControlValue(GridControl control, JToken token, out IGridControlValue value)
		{
			value = null;

			if (control.Editor.Alias == "campaignSection")
			{
				value = GridControlCampaignSectionValue.Parse(control, token);
			}

			return value != null;
		}

		public bool ConvertEditorConfig(GridEditor editor, JToken token, out IGridEditorConfig config)
		{
			config = null;
			return false;
		}

		public bool GetControlWrapper(GridControl control, out GridControlWrapper wrapper)
		{
			wrapper = null;

			if (control.Editor.Alias == "campaignSection")
			{
				wrapper = control.GetControlWrapper<GridControlCampaignSectionValue>();
			}

			return wrapper != null;
		}
	}
}
