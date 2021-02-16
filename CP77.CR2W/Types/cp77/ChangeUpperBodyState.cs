using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ChangeUpperBodyState : ChangeUpperBodyStateAbstract
	{
		[Ordinal(0)] [RED("newState")] public CEnum<gamedataNPCUpperBodyState> NewState { get; set; }

		public ChangeUpperBodyState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
