using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameActionDieState : gameActionReplicatedState
	{
		[Ordinal(0)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(1)]  [RED("movingAgent")] public wCHandle<moveComponent> MovingAgent { get; set; }
		[Ordinal(2)]  [RED("ragdollComponent")] public wCHandle<entRagdollComponent> RagdollComponent { get; set; }
		[Ordinal(3)]  [RED("slotComponent")] public wCHandle<entSlotComponent> SlotComponent { get; set; }

		public gameActionDieState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
