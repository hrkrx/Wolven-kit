using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioMeleeWeaponVariations : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("playerWeaponConfigurationName")] public CName PlayerWeaponConfigurationName { get; set; }
		[Ordinal(1)]  [RED("NPCWeaponConfigurationName")] public CName NPCWeaponConfigurationName { get; set; }

		public audioMeleeWeaponVariations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
