using UmbracoGridConfigLoader.Attributes;
using UmbracoGridConfigLoader.Models;

namespace Graph.Components.CampaignSection
{
	public class CampaignSection : IGridConfigLoader
	{
		[GridLayoutProperty(Label = "Campaign Section", AllowedEditors = new[] { "campaignSection" }, MaxItems = 1)]
		public IGridLayout Layout { get; set; }
	}
}
