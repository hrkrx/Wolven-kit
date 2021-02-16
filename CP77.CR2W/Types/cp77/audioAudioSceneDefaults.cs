using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAudioSceneDefaults : audioAudioMetadata
	{
		[Ordinal(1)] [RED("parameters")] public CArray<audioAudSimpleParameter> Parameters { get; set; }

		public audioAudioSceneDefaults(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
