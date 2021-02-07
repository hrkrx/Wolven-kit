using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkLanguageSpecificImageController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("textureAtlasForLanguage")] public raRef<inkTextureAtlas> TextureAtlasForLanguage { get; set; }
		[Ordinal(1)]  [RED("partNameForLanguage")] public CName PartNameForLanguage { get; set; }
		[Ordinal(2)]  [RED("languages")] public CArray<CEnum<inkLanguageId>> Languages { get; set; }
		[Ordinal(3)]  [RED("fallbackTextureAtlas")] public raRef<inkTextureAtlas> FallbackTextureAtlas { get; set; }
		[Ordinal(4)]  [RED("fallbackPartName")] public CName FallbackPartName { get; set; }

		public inkLanguageSpecificImageController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
