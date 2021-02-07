using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterKilled_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)]  [RED("comparisonParams")] public CHandle<questComparisonParam> ComparisonParams { get; set; }
		[Ordinal(1)]  [RED("killed")] public CBool Killed { get; set; }
		[Ordinal(2)]  [RED("unconscious")] public CBool Unconscious { get; set; }
		[Ordinal(3)]  [RED("defeated")] public CBool Defeated { get; set; }

		public questCharacterKilled_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
