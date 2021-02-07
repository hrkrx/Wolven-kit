using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorOrbit : IParticleModificator
	{
		[Ordinal(0)]  [RED("offset")] public CHandle<IEvaluatorVector> Offset { get; set; }
		[Ordinal(1)]  [RED("frequency")] public CHandle<IEvaluatorVector> Frequency { get; set; }
		[Ordinal(2)]  [RED("phase")] public CHandle<IEvaluatorVector> Phase { get; set; }
		[Ordinal(3)]  [RED("overridePosition")] public CBool OverridePosition { get; set; }

		public CParticleModificatorOrbit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
