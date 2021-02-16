using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SmartHousePreset : IScriptable
	{
		[Ordinal(0)] [RED("timetable")] public SPresetTimetableEntry Timetable { get; set; }

		public SmartHousePreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
