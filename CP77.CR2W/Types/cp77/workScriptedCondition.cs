using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workScriptedCondition : workIWorkspotCondition
	{
		[Ordinal(2)] [RED("script")] public CHandle<workIScriptedCondition> Script { get; set; }

		public workScriptedCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
