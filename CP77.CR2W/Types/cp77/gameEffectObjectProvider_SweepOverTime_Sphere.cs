using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_SweepOverTime_Sphere : gameEffectObjectProvider_SweepOverTime
	{
		[Ordinal(1)] [RED("radius")] public CFloat Radius { get; set; }

		public gameEffectObjectProvider_SweepOverTime_Sphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
