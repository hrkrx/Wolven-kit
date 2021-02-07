using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiInGameMenuGameController : gameuiBaseMenuGameController
	{
		[Ordinal(0)]  [RED("itemSceneInfos")] public CArray<gameuiInGameMenuGameControllerItemSceneInfo> ItemSceneInfos { get; set; }
		[Ordinal(1)]  [RED("garmentSwitchEffectControllers")] public CArray<gameuiInGameMenuGameControllerGarmentSwitchEffectController> GarmentSwitchEffectControllers { get; set; }

		public gameuiInGameMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
