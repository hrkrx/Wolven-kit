using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamDestructionBonds : meshMeshParameter
	{
		[Ordinal(0)] [RED("bonds")] public CArray<meshDestructionBond> Bonds { get; set; }

		public meshMeshParamDestructionBonds(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
