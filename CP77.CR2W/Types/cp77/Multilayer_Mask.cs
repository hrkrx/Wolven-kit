using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Multilayer_Mask : CResource
	{
		[Ordinal(1)] [RED("renderResourceBlob")] public rendRenderMultilayerMaskResource RenderResourceBlob { get; set; }

		public Multilayer_Mask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
