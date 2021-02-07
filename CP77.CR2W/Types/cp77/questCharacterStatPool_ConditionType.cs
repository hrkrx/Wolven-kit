using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterStatPool_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)]  [RED("percent")] public CFloat Percent { get; set; }
		[Ordinal(1)]  [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }
		[Ordinal(2)]  [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }

		public questCharacterStatPool_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
