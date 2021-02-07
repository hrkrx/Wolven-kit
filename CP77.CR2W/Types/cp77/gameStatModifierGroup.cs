using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameStatModifierGroup : CVariable
	{
		[Ordinal(0)]  [RED("statModifierArray")] public CArray<CHandle<gameStatModifierData>> StatModifierArray { get; set; }
		[Ordinal(1)]  [RED("statModifiersLimit")] public CInt32 StatModifiersLimit { get; set; }
		[Ordinal(2)]  [RED("statModifiersLimitModifier")] public TweakDBID StatModifiersLimitModifier { get; set; }
		[Ordinal(3)]  [RED("drawBasedOnStatType")] public CBool DrawBasedOnStatType { get; set; }

		public gameStatModifierGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
