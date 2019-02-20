using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Umbraco.GridData;
using Skybrud.Umbraco.GridData.Values;

namespace Graph.Components.CampaignSection
{
	public class GridControlCampaignSectionValue : GridControlValueBase
	{
		public GridControlCampaignSectionItem GridControlCampaignSectionItem { get; protected set; }

		public GridControlCampaignSectionValue(GridControl control, JToken token) : base(control, token as JObject)
		{
			GridControlCampaignSectionItem = JsonConvert.DeserializeObject<GridControlCampaignSectionItem>(token.ToString());
		}

		public static GridControlCampaignSectionValue Parse(GridControl control, JToken token)
		{
			return token != null
				? new GridControlCampaignSectionValue(control, token)
				: null;
		}
	}
}
