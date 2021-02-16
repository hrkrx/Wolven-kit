using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationPersonalLinkController : gameuiICharacterCustomizationComponent
	{
		[Ordinal(3)] [RED("simpleLinkGroup")] public CName SimpleLinkGroup { get; set; }

		public gameuiCharacterCustomizationPersonalLinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
