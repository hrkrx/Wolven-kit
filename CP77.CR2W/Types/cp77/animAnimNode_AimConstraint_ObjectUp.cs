using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AimConstraint_ObjectUp : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("targetTransform")] public animTransformIndex TargetTransform { get; set; }
		[Ordinal(1)]  [RED("upTransform")] public animTransformIndex UpTransform { get; set; }
		[Ordinal(2)]  [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
		[Ordinal(3)]  [RED("forwardAxisLS")] public Vector3 ForwardAxisLS { get; set; }
		[Ordinal(4)]  [RED("upAxisLS")] public Vector3 UpAxisLS { get; set; }
		[Ordinal(5)]  [RED("weightMode")] public CEnum<animConstraintWeightMode> WeightMode { get; set; }
		[Ordinal(6)]  [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(7)]  [RED("weightFloatTrack")] public animNamedTrackIndex WeightFloatTrack { get; set; }

		public animAnimNode_AimConstraint_ObjectUp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
