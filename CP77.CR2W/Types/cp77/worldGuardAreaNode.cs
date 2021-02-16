using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldGuardAreaNode : worldAreaShapeNode
	{
		[Ordinal(4)] [RED("communityEntries")] public CArray<AIGuardAreaConnectedCommunity> CommunityEntries { get; set; }
		[Ordinal(5)] [RED("combatCommunityEntries")] public CArray<AICombatGuardAreaConnectedCommunity> CombatCommunityEntries { get; set; }
		[Ordinal(6)] [RED("pursuitArea")] public NodeRef PursuitArea { get; set; }
		[Ordinal(7)] [RED("pursuitRange")] public CFloat PursuitRange { get; set; }

		public worldGuardAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
