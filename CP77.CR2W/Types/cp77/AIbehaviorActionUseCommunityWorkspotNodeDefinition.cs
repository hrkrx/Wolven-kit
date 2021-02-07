using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionUseCommunityWorkspotNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
		[Ordinal(1)]  [RED("dependentWorkspotData")] public CHandle<AIArgumentMapping> DependentWorkspotData { get; set; }
		[Ordinal(2)]  [RED("playExitAutomatically")] public CHandle<AIArgumentMapping> PlayExitAutomatically { get; set; }
		[Ordinal(3)]  [RED("fastForwardAfterTeleport")] public CHandle<AIArgumentMapping> FastForwardAfterTeleport { get; set; }

		public AIbehaviorActionUseCommunityWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
