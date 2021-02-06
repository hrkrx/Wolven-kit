using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entIVisualComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("autoHideDistance")] public CFloat AutoHideDistance { get; set; }
		[Ordinal(1)]  [RED("forceLODLevel")] public CInt8 ForceLODLevel { get; set; }
		[Ordinal(2)]  [RED("renderSceneLayerMask")] public CEnum<RenderSceneLayerMask> RenderSceneLayerMask { get; set; }

		public entIVisualComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
