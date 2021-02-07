using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkColorFillEffect : inkIEffect
	{
		[Ordinal(0)]  [RED("colorR")] public CFloat ColorR { get; set; }
		[Ordinal(1)]  [RED("colorG")] public CFloat ColorG { get; set; }
		[Ordinal(2)]  [RED("colorB")] public CFloat ColorB { get; set; }
		[Ordinal(3)]  [RED("colorA")] public CFloat ColorA { get; set; }
		[Ordinal(4)]  [RED("saturation")] public CFloat Saturation { get; set; }

		public inkColorFillEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
