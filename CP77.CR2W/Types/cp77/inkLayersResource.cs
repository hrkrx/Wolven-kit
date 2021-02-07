using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkLayersResource : CResource
	{
		[Ordinal(0)]  [RED("layerDefinitions")] public inkLayerDefinitionCollection LayerDefinitions { get; set; }
		[Ordinal(1)]  [RED("preGameLayerDefinitions")] public inkLayerDefinitionCollection PreGameLayerDefinitions { get; set; }
		[Ordinal(2)]  [RED("permanentLayerDefinitions")] public inkPermanentLayerDefinitionCollection PermanentLayerDefinitions { get; set; }

		public inkLayersResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
