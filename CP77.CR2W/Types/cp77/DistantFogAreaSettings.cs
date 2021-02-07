using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DistantFogAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("range")] public curveData<CFloat> Range { get; set; }
		[Ordinal(1)]  [RED("albedoNear")] public curveData<HDRColor> AlbedoNear { get; set; }
		[Ordinal(2)]  [RED("albedoFar")] public curveData<HDRColor> AlbedoFar { get; set; }
		[Ordinal(3)]  [RED("nearDistance")] public curveData<CFloat> NearDistance { get; set; }
		[Ordinal(4)]  [RED("farDistance")] public curveData<CFloat> FarDistance { get; set; }
		[Ordinal(5)]  [RED("density")] public curveData<CFloat> Density { get; set; }
		[Ordinal(6)]  [RED("height")] public curveData<CFloat> Height { get; set; }
		[Ordinal(7)]  [RED("heightFallof")] public curveData<CFloat> HeightFallof { get; set; }
		[Ordinal(8)]  [RED("densitySecond")] public curveData<CFloat> DensitySecond { get; set; }
		[Ordinal(9)]  [RED("heightSecond")] public curveData<CFloat> HeightSecond { get; set; }
		[Ordinal(10)]  [RED("heightFallofSecond")] public curveData<CFloat> HeightFallofSecond { get; set; }
		[Ordinal(11)]  [RED("simpleColor")] public curveData<HDRColor> SimpleColor { get; set; }
		[Ordinal(12)]  [RED("simpleDensity")] public curveData<CFloat> SimpleDensity { get; set; }
		[Ordinal(13)]  [RED("envProbeColor")] public curveData<HDRColor> EnvProbeColor { get; set; }
		[Ordinal(14)]  [RED("envProbeDensity")] public curveData<CFloat> EnvProbeDensity { get; set; }

		public DistantFogAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
