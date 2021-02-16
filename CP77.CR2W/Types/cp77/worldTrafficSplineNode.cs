using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficSplineNode : worldTrafficSourceNode
	{
		[Ordinal(7)] [RED("usage")] public CEnum<worldTrafficSplineNodeUsage> Usage { get; set; }
		[Ordinal(8)] [RED("maxSlotMaxSpeed")] public CFloat MaxSlotMaxSpeed { get; set; }
		[Ordinal(9)] [RED("width")] public CFloat Width { get; set; }
		[Ordinal(10)] [RED("pathSamplingDistance")] public CFloat PathSamplingDistance { get; set; }
		[Ordinal(11)] [RED("bidirectional")] public CBool Bidirectional { get; set; }
		[Ordinal(12)] [RED("autoConnectionRange")] public CFloat AutoConnectionRange { get; set; }
		[Ordinal(13)] [RED("markings")] public CArray<CName> Markings { get; set; }
		[Ordinal(14)] [RED("outLanes")] public CArray<worldTrafficLaneExitDefinition> OutLanes { get; set; }
		[Ordinal(15)] [RED("lights")] public CArray<worldTrafficLightDefinition> Lights { get; set; }
		[Ordinal(16)] [RED("neverDeadEnd")] public CBool NeverDeadEnd { get; set; }
		[Ordinal(17)] [RED("trafficDisabled")] public CBool TrafficDisabled { get; set; }
		[Ordinal(18)] [RED("laneSamplingAngle")] public CFloat LaneSamplingAngle { get; set; }

		public worldTrafficSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
