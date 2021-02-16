using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DirectionToEuler : animAnimNode_FloatValue
	{
		[Ordinal(1)] [RED("inputNode")] public animVectorLink InputNode { get; set; }
		[Ordinal(2)] [RED("initialForwardVector")] public Vector4 InitialForwardVector { get; set; }
		[Ordinal(3)] [RED("conversionType")] public CEnum<animEDirectionToEuler> ConversionType { get; set; }

		public animAnimNode_DirectionToEuler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
