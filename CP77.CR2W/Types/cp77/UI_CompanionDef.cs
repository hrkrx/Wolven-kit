using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_CompanionDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("flatHeadSpawned")] public gamebbScriptID_Bool FlatHeadSpawned { get; set; }

		public UI_CompanionDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
