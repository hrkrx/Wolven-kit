using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAudioFoliageMaterial : CVariable
	{
		[Ordinal(0)]  [RED("loopStart")] public CName LoopStart { get; set; }
		[Ordinal(1)]  [RED("loopEnd")] public CName LoopEnd { get; set; }

		public audioAudioFoliageMaterial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
