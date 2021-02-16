using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_HUDButtonHintDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("ActionsData")] public gamebbScriptID_Variant ActionsData { get; set; }

		public UI_HUDButtonHintDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
