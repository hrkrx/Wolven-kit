using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MenuScenario_HubMenu : MenuScenario_BaseMenu
	{
		[Ordinal(4)] [RED("hubMenuInitData")] public CHandle<HubMenuInitData> HubMenuInitData { get; set; }
		[Ordinal(5)] [RED("currentState")] public wCHandle<inkMenusState> CurrentState { get; set; }

		public MenuScenario_HubMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
