using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FilmGrainAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("strength")] public curveData<Vector4> Strength { get; set; }
		[Ordinal(1)]  [RED("luminanceBias")] public curveData<CFloat> LuminanceBias { get; set; }
		[Ordinal(2)]  [RED("grainSize")] public Vector3 GrainSize { get; set; }
		[Ordinal(3)]  [RED("applyAfterUpsampling")] public CBool ApplyAfterUpsampling { get; set; }

		public FilmGrainAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
