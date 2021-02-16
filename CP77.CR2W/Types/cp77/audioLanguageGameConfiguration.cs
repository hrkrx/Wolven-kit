using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioLanguageGameConfiguration : audioAudioMetadata
	{
		[Ordinal(1)] [RED("langsInProject")] public CArray<audioLanguageMapItem> LangsInProject { get; set; }

		public audioLanguageGameConfiguration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
