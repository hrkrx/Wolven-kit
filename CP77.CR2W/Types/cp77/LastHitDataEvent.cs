using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LastHitDataEvent : redEvent
	{
		[Ordinal(0)] [RED("hitReactionBehaviorData")] public CHandle<HitReactionBehaviorData> HitReactionBehaviorData { get; set; }

		public LastHitDataEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
