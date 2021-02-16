using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSquadMemberDataEntry : CVariable
	{
		[Ordinal(0)] [RED("squadName")] public CName SquadName { get; set; }
		[Ordinal(1)] [RED("squadType")] public CEnum<AISquadType> SquadType { get; set; }

		public gameSquadMemberDataEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
