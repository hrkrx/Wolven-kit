using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldMeshNode : worldNode
	{
		[Ordinal(2)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
		[Ordinal(3)] [RED("meshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(4)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
		[Ordinal(5)] [RED("occluderType")] public CEnum<visWorldOccluderType> OccluderType { get; set; }
		[Ordinal(6)] [RED("occluderAutohideDistanceScale")] public CUInt8 OccluderAutohideDistanceScale { get; set; }
		[Ordinal(7)] [RED("castShadows")] public CBool CastShadows { get; set; }
		[Ordinal(8)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
		[Ordinal(9)] [RED("windImpulseEnabled")] public CBool WindImpulseEnabled { get; set; }
		[Ordinal(10)] [RED("removeFromRainMap")] public CBool RemoveFromRainMap { get; set; }
		[Ordinal(11)] [RED("renderSceneLayerMask")] public CEnum<RenderSceneLayerMask> RenderSceneLayerMask { get; set; }
		[Ordinal(12)] [RED("lodLevelScales")] public CUInt32 LodLevelScales { get; set; }

		public worldMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
