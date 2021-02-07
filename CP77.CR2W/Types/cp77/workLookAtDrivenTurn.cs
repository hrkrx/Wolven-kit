using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workLookAtDrivenTurn : workIEntry
	{
		[Ordinal(0)]  [RED("turnAngle")] public CInt32 TurnAngle { get; set; }
		[Ordinal(1)]  [RED("turnAnimName")] public CName TurnAnimName { get; set; }
		[Ordinal(2)]  [RED("blendTime")] public CFloat BlendTime { get; set; }

		public workLookAtDrivenTurn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
