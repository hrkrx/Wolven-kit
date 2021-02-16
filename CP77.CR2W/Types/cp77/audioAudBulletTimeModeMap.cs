using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAudBulletTimeModeMap : audioAudioMetadata
	{
		[Ordinal(1)] [RED("bulletTimeMapItems")] public CArray<audioAudBulletTimeModeMapItem> BulletTimeMapItems { get; set; }

		public audioAudBulletTimeModeMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
