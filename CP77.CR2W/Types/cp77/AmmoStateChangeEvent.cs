using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AmmoStateChangeEvent : redEvent
	{
		[Ordinal(0)] [RED("weaponOwner")] public wCHandle<gameObject> WeaponOwner { get; set; }

		public AmmoStateChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
