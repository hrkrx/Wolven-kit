using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_EffectDuration : animAnimEvent
	{
		[Ordinal(0)]  [RED("effectName")] public CName EffectName { get; set; }
		[Ordinal(1)]  [RED("sequenceShift")] public CUInt32 SequenceShift { get; set; }
		[Ordinal(2)]  [RED("breakAllLoopsOnStop")] public CBool BreakAllLoopsOnStop { get; set; }

		public animAnimEvent_EffectDuration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
