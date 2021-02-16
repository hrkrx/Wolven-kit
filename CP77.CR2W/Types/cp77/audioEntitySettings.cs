using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioEntitySettings : audioAudioMetadata
	{
		[Ordinal(1)] [RED("commonSettings")] public audioCommonEntitySettings CommonSettings { get; set; }
		[Ordinal(2)] [RED("scanningSettings")] public audioScanningSettings ScanningSettings { get; set; }
		[Ordinal(3)] [RED("auxiliaryMetadata")] public audioAuxiliaryMetadata AuxiliaryMetadata { get; set; }
		[Ordinal(4)] [RED("emitterDecoratorMetadata")] public CName EmitterDecoratorMetadata { get; set; }
		[Ordinal(5)] [RED("preferSoundComponentPosition")] public CBool PreferSoundComponentPosition { get; set; }

		public audioEntitySettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
