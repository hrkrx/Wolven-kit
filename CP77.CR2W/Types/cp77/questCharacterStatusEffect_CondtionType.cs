using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterStatusEffect_CondtionType : questICharacterConditionType
	{
		[Ordinal(0)]  [RED("statusEffectID")] public CString StatusEffectID { get; set; }
		[Ordinal(1)]  [RED("inverted")] public CBool Inverted { get; set; }

		public questCharacterStatusEffect_CondtionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
