using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldPrefabProxyMeshNode : worldMeshNode
	{
		[Ordinal(13)] [RED("nearAutoHideDistance")] public CFloat NearAutoHideDistance { get; set; }
		[Ordinal(14)] [RED("ancestorPrefabProxyMeshNodeID")] public worldGlobalNodeID AncestorPrefabProxyMeshNodeID { get; set; }
		[Ordinal(15)] [RED("ownerPrefabNodeId")] public worldGlobalNodeID OwnerPrefabNodeId { get; set; }
		[Ordinal(16)] [RED("nbNodesUnderProxy")] public CUInt32 NbNodesUnderProxy { get; set; }

		public worldPrefabProxyMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
