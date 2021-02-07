using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendRenderParticleBlob : IRenderResourceBlob
	{
		[Ordinal(0)]  [RED("header")] public rendRenderParticleBlobHeader Header { get; set; }
		[Ordinal(1)]  [RED("updaterData")] public rendRenderParticleUpdaterData UpdaterData { get; set; }
		[Ordinal(2)]  [RED("gpuSimShaders")] public rendEmitterSimulationShaders GpuSimShaders { get; set; }

		public rendRenderParticleBlob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
