using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TrafficLightResaveData : CVariable
	{
		[Ordinal(0)] [RED("transitionDuration")] public CFloat TransitionDuration { get; set; }
		[Ordinal(1)] [RED("playNotificationSounds")] public CBool PlayNotificationSounds { get; set; }
		[Ordinal(2)] [RED("invertTrafficEvents")] public CBool InvertTrafficEvents { get; set; }

		public TrafficLightResaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
