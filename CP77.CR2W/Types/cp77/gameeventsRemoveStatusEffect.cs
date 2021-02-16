using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameeventsRemoveStatusEffect : gameeventsStatusEffectEvent
	{
		[Ordinal(2)] [RED("isFinalRemoval")] public CBool IsFinalRemoval { get; set; }

		public gameeventsRemoveStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
