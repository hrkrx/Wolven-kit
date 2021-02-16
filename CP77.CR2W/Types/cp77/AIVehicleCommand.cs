using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIVehicleCommand : AICommand
	{
		[Ordinal(4)] [RED("useKinematic")] public CBool UseKinematic { get; set; }
		[Ordinal(5)] [RED("needDriver")] public CBool NeedDriver { get; set; }

		public AIVehicleCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
