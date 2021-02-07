using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_ObjectTag : worldEditorDebugColoringSettings
	{
		[Ordinal(0)]  [RED("tag")] public CEnum<worldObjectTag> Tag { get; set; }
		[Ordinal(1)]  [RED("color")] public CColor Color { get; set; }

		public worldDebugColoring_ObjectTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
