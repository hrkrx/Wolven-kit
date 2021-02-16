using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PlayerLocomotionStateMachine : animAnimFeature
	{
		[Ordinal(0)] [RED("inAirState")] public CBool InAirState { get; set; }

		public AnimFeature_PlayerLocomotionStateMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
