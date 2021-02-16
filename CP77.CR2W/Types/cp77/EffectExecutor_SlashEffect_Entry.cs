using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_SlashEffect_Entry : CVariable
	{
		[Ordinal(0)] [RED("attackNumber")] public CInt32 AttackNumber { get; set; }
		[Ordinal(1)] [RED("effectNames")] public CArray<CName> EffectNames { get; set; }

		public EffectExecutor_SlashEffect_Entry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
