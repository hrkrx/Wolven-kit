using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UpdateMiniGameProgramsEvent : redEvent
	{
		[Ordinal(0)] [RED("program")] public gameuiMinigameProgramData Program { get; set; }
		[Ordinal(1)] [RED("add")] public CBool Add { get; set; }

		public UpdateMiniGameProgramsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
