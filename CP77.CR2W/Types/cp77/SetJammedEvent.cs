using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetJammedEvent : redEvent
	{
		[Ordinal(0)] [RED("newJammedState")] public CBool NewJammedState { get; set; }
		[Ordinal(1)] [RED("instigator")] public wCHandle<gameweaponObject> Instigator { get; set; }

		public SetJammedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
