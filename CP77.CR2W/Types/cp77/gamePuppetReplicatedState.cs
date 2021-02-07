using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePuppetReplicatedState : netIEntityState
	{
		[Ordinal(0)]  [RED("actionsBuffer")] public gameActionsReplicationBuffer ActionsBuffer { get; set; }
		[Ordinal(1)]  [RED("animEventsState")] public gameReplicatedAnimControllerEventsState AnimEventsState { get; set; }
		[Ordinal(2)]  [RED("entityEventsState")] public gameReplicatedEntityEventsState EntityEventsState { get; set; }
		[Ordinal(3)]  [RED("initialOrientation")] public EulerAngles InitialOrientation { get; set; }
		[Ordinal(4)]  [RED("initialLocation")] public Vector3 InitialLocation { get; set; }
		[Ordinal(5)]  [RED("initialAppearance")] public CName InitialAppearance { get; set; }
		[Ordinal(6)]  [RED("health")] public CFloat Health { get; set; }
		[Ordinal(7)]  [RED("armor")] public CFloat Armor { get; set; }
		[Ordinal(8)]  [RED("hasCPOMissionData")] public CBool HasCPOMissionData { get; set; }
		[Ordinal(9)]  [RED("CPOMissionVotedHistory")] public CArray<CName> CPOMissionVotedHistory { get; set; }

		public gamePuppetReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
