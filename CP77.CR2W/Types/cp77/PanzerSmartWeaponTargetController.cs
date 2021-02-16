using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PanzerSmartWeaponTargetController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("distanceText")] public inkTextWidgetReference DistanceText { get; set; }
		[Ordinal(2)] [RED("lockingAnimationProxy")] public CHandle<inkanimProxy> LockingAnimationProxy { get; set; }

		public PanzerSmartWeaponTargetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
