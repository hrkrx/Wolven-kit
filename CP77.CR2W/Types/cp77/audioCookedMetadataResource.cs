using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioCookedMetadataResource : CResource
	{
		[Ordinal(1)] [RED("entries")] public CArray<CHandle<audioAudioMetadata>> Entries { get; set; }

		public audioCookedMetadataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
