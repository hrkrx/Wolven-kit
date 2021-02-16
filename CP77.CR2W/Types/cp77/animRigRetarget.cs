using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animRigRetarget : CVariable
	{
		[Ordinal(0)] [RED("sourceRig")] public rRef<animRig> SourceRig { get; set; }

		public animRigRetarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
