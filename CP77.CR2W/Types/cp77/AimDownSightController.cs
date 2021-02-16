using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AimDownSightController : BasicAnimationController
	{
		[Ordinal(6)] [RED("isAiming")] public CBool IsAiming { get; set; }

		public AimDownSightController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
