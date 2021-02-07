using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldCurvePathNode : worldSplineNode
	{
		[Ordinal(0)]  [RED("userInput")] public animCurvePathBakerUserInput UserInput { get; set; }
		[Ordinal(1)]  [RED("defaultForwardVector")] public Vector4 DefaultForwardVector { get; set; }
		[Ordinal(2)]  [RED("globalInBlendTime")] public CFloat GlobalInBlendTime { get; set; }
		[Ordinal(3)]  [RED("globalOutBlendTime")] public CFloat GlobalOutBlendTime { get; set; }
		[Ordinal(4)]  [RED("defaultPoseAnimationName")] public CName DefaultPoseAnimationName { get; set; }
		[Ordinal(5)]  [RED("defaultPoseSampleTime")] public CFloat DefaultPoseSampleTime { get; set; }
		[Ordinal(6)]  [RED("initialDiffYaw")] public CFloat InitialDiffYaw { get; set; }
		[Ordinal(7)]  [RED("turnCharacterToMatchVelocity")] public CBool TurnCharacterToMatchVelocity { get; set; }
		[Ordinal(8)]  [RED("rig")] public rRef<animRig> Rig { get; set; }
		[Ordinal(9)]  [RED("animSets")] public CArray<rRef<animAnimSet>> AnimSets { get; set; }
		[Ordinal(10)]  [RED("timeDeltaMultiplier")] public CFloat TimeDeltaMultiplier { get; set; }

		public worldCurvePathNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
