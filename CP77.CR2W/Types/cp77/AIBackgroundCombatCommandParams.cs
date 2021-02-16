using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIBackgroundCombatCommandParams : questScriptedAICommandParams
	{
		[Ordinal(0)] [RED("steps")] public CArray<AIBackgroundCombatStep> Steps { get; set; }

		public AIBackgroundCombatCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
