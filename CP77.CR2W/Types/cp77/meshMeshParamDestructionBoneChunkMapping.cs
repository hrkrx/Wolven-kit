using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamDestructionBoneChunkMapping : meshMeshParameter
	{
		[Ordinal(0)] [RED("boneChunkMasks")] public CArray<CUInt64> BoneChunkMasks { get; set; }

		public meshMeshParamDestructionBoneChunkMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
