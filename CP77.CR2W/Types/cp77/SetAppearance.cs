using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetAppearance : AIActionHelperTask
	{
		[Ordinal(5)] [RED("appearance")] public CName Appearance { get; set; }

		public SetAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
