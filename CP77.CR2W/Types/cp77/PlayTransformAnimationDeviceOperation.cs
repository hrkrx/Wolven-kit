using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayTransformAnimationDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] [RED("transformAnimations")] public CArray<STransformAnimationData> TransformAnimations { get; set; }

		public PlayTransformAnimationDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
