using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnAnimationRid : CVariable
	{
		[Ordinal(0)]  [RED("animation")] public CHandle<animAnimation> Animation { get; set; }
		[Ordinal(1)]  [RED("bonesCount")] public CUInt32 BonesCount { get; set; }
		[Ordinal(2)]  [RED("events")] public CHandle<animEventsContainer> Events { get; set; }
		[Ordinal(3)]  [RED("motionExtracted")] public CBool MotionExtracted { get; set; }
		[Ordinal(4)]  [RED("offset")] public Transform Offset { get; set; }
		[Ordinal(5)]  [RED("tag")] public scnRidTag Tag { get; set; }
		[Ordinal(6)]  [RED("trajectoryBoneIndex")] public CInt32 TrajectoryBoneIndex { get; set; }
        
        [Ordinal(999)]  [RED("backendData")] public CHandle<IBackendData> backendData { get; set; }

		public scnAnimationRid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
