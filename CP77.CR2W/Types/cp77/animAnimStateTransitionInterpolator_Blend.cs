using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionInterpolator_Blend : animIAnimStateTransitionInterpolator
	{
		[Ordinal(0)]  [RED("interpolationType")] public CEnum<animAnimStateInterpolationType> InterpolationType { get; set; }

		[Ordinal(999)]  [RED("visTransitionDuration")] public CFloat visTransitionDuration { get; set; }

		public animAnimStateTransitionInterpolator_Blend(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
