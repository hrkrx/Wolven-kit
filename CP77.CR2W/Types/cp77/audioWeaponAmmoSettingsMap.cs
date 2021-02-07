using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioWeaponAmmoSettingsMap : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("standardFlyby")] public audioFlybySettings StandardFlyby { get; set; }
		[Ordinal(1)]  [RED("sniperFlyby")] public audioFlybySettings SniperFlyby { get; set; }
		[Ordinal(2)]  [RED("shotFlyby")] public audioFlybySettings ShotFlyby { get; set; }
		[Ordinal(3)]  [RED("railFlyby")] public audioFlybySettings RailFlyby { get; set; }
		[Ordinal(4)]  [RED("automaticFlyby")] public audioFlybySettings AutomaticFlyby { get; set; }
		[Ordinal(5)]  [RED("smartFlyby")] public audioFlybySettings SmartFlyby { get; set; }
		[Ordinal(6)]  [RED("smartSniperFlyby")] public audioFlybySettings SmartSniperFlyby { get; set; }
		[Ordinal(7)]  [RED("hmgFlyby")] public audioFlybySettings HmgFlyby { get; set; }
		[Ordinal(8)]  [RED("flybyMinDistance")] public CFloat FlybyMinDistance { get; set; }

		public audioWeaponAmmoSettingsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
