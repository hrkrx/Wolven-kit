using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SimpleBounce : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("debug")] public CBool Debug { get; set; }
		[Ordinal(1)]  [RED("areChannelsResaved")] public CBool AreChannelsResaved { get; set; }
		[Ordinal(2)]  [RED("outputDriverTrack")] public animNamedTrackIndex OutputDriverTrack { get; set; }
		[Ordinal(3)]  [RED("startTransform")] public animTransformIndex StartTransform { get; set; }
		[Ordinal(4)]  [RED("endTransform")] public animTransformIndex EndTransform { get; set; }
		[Ordinal(5)]  [RED("multiplier")] public CFloat Multiplier { get; set; }
		[Ordinal(6)]  [RED("negativeMultiplier")] public CFloat NegativeMultiplier { get; set; }
		[Ordinal(7)]  [RED("smoothStep")] public CFloat SmoothStep { get; set; }
		[Ordinal(8)]  [RED("offset")] public CFloat Offset { get; set; }
		[Ordinal(9)]  [RED("delay")] public CFloat Delay { get; set; }
		[Ordinal(10)]  [RED("transformOutputs")] public CArray<animSimpleBounceTransformOutput> TransformOutputs { get; set; }
		[Ordinal(11)]  [RED("trackOutputs")] public CArray<animSimpleBounceTrackOutput> TrackOutputs { get; set; }

		public animAnimNode_SimpleBounce(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
