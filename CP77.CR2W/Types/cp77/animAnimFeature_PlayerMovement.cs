using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_PlayerMovement : animAnimFeature_Movement
	{
		[Ordinal(0)]  [RED("facingDirection")] public Vector4 FacingDirection { get; set; }
		[Ordinal(1)]  [RED("verticalSpeed")] public CFloat VerticalSpeed { get; set; }
		[Ordinal(2)]  [RED("movementDirectionHorizontalAngle")] public CFloat MovementDirectionHorizontalAngle { get; set; }
		[Ordinal(3)]  [RED("inAir")] public CBool InAir { get; set; }
		[Ordinal(4)]  [RED("standingTerrainAngle")] public CFloat StandingTerrainAngle { get; set; }

		public animAnimFeature_PlayerMovement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
