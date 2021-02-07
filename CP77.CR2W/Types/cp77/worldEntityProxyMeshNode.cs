using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldEntityProxyMeshNode : worldPrefabProxyMeshNode
	{
		[Ordinal(0)]  [RED("ownerGlobalId")] public worldGlobalNodeID OwnerGlobalId { get; set; }
		[Ordinal(1)]  [RED("entityAttachDistance")] public CFloat EntityAttachDistance { get; set; }

		public worldEntityProxyMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
