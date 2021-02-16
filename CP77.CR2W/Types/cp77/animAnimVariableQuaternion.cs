using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableQuaternion : animAnimVariable
	{
		[Ordinal(1)] [RED("roll")] public CFloat Roll { get; set; }
		[Ordinal(2)] [RED("pitch")] public CFloat Pitch { get; set; }
		[Ordinal(3)] [RED("yaw")] public CFloat Yaw { get; set; }
		[Ordinal(4)] [RED("default")] public Quaternion Default { get; set; }

		public animAnimVariableQuaternion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
