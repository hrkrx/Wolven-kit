using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPrefabVariantMapArrayElement : CVariable
	{
		[Ordinal(0)] [RED("globalNodeRef")] public worldGlobalNodeRef GlobalNodeRef { get; set; }
		[Ordinal(1)] [RED("PrefabVariantsReplicatedInfos")] public CArray<questPrefabVariantReplicatedInfo> PrefabVariantsReplicatedInfos { get; set; }

		public questPrefabVariantMapArrayElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
