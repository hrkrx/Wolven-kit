using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StaminaPoolListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] [RED("staminaBar")] public wCHandle<StaminabarWidgetGameController> StaminaBar { get; set; }

		public StaminaPoolListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
