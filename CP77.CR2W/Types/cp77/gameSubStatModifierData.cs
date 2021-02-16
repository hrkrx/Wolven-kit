using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSubStatModifierData : gameStatModifierData
	{
		[Ordinal(2)] [RED("refStatType")] public CEnum<gamedataStatType> RefStatType { get; set; }

		public gameSubStatModifierData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
