using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DroneActionAltitudeOffset : animAnimFeature
	{
		[Ordinal(0)] [RED("desiredOffset")] public CFloat DesiredOffset { get; set; }

		public AnimFeature_DroneActionAltitudeOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
