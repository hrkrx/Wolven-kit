using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ReferencePoseTerminator : animAnimNode_Base
	{
        [Ordinal(999)] [RED("visWhenActive")] public new CBool visWhenActive { get; set; }

		public animAnimNode_ReferencePoseTerminator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
