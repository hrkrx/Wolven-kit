using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldAISpotNode : worldSocketNode
	{
		[Ordinal(0)]  [RED("spot")] public CHandle<AISpot> Spot { get; set; }
		[Ordinal(1)]  [RED("isWorkspotInfinite")] public CBool IsWorkspotInfinite { get; set; }
		[Ordinal(2)]  [RED("isWorkspotStatic")] public CBool IsWorkspotStatic { get; set; }
		[Ordinal(3)]  [RED("markings")] public CArray<CName> Markings { get; set; }
		[Ordinal(4)]  [RED("spotDef")] public CHandle<worldTrafficSpotDefinition> SpotDef { get; set; }
		[Ordinal(5)]  [RED("disableBumps")] public CBool DisableBumps { get; set; }
		[Ordinal(6)]  [RED("lookAtTarget")] public NodeRef LookAtTarget { get; set; }
		[Ordinal(7)]  [RED("nearTrafficSrc")] public worldGlobalNodeID NearTrafficSrc { get; set; }
		[Ordinal(8)]  [RED("useCrowdWhitelist")] public CBool UseCrowdWhitelist { get; set; }
		[Ordinal(9)]  [RED("useCrowdBlacklist")] public CBool UseCrowdBlacklist { get; set; }
		[Ordinal(10)]  [RED("crowdWhitelist")] public redTagList CrowdWhitelist { get; set; }
		[Ordinal(11)]  [RED("crowdBlacklist")] public redTagList CrowdBlacklist { get; set; }

		public worldAISpotNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
