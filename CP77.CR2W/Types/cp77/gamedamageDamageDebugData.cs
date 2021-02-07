using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamedamageDamageDebugData : IScriptable
	{
		[Ordinal(0)]  [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }
		[Ordinal(1)]  [RED("damageType")] public CEnum<gamedataDamageType> DamageType { get; set; }
		[Ordinal(2)]  [RED("value")] public CFloat Value { get; set; }

		public gamedamageDamageDebugData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
