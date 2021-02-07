using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatValueDebugProvider : CVariable
	{
		[Ordinal(0)]  [RED("min")] public CFloat Min { get; set; }
		[Ordinal(1)]  [RED("max")] public CFloat Max { get; set; }
		[Ordinal(2)]  [RED("progress")] public CFloat Progress { get; set; }
		[Ordinal(3)]  [RED("speed")] public CFloat Speed { get; set; }
		[Ordinal(4)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(5)]  [RED("auto")] public CBool Auto { get; set; }
		[Ordinal(6)]  [RED("wrap")] public CBool Wrap { get; set; }

		public animAnimNode_FloatValueDebugProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
