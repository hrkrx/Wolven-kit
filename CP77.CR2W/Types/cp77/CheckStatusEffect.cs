using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CheckStatusEffect : AIStatusEffectCondition
	{
		[Ordinal(0)] [RED("statusEffectID")] public TweakDBID StatusEffectID { get; set; }

		public CheckStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
