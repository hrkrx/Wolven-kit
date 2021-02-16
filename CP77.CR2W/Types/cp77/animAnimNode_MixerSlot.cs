using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MixerSlot : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("maxNormalAnimEntriesCount")] public CUInt16 MaxNormalAnimEntriesCount { get; set; }
		[Ordinal(3)] [RED("maxAdditiveAnimEntriesCount")] public CUInt16 MaxAdditiveAnimEntriesCount { get; set; }
		[Ordinal(4)] [RED("maxOverrideAnimEntriesCount")] public CUInt16 MaxOverrideAnimEntriesCount { get; set; }

		public animAnimNode_MixerSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
