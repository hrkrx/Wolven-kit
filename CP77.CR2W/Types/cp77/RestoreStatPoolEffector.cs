using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RestoreStatPoolEffector : gameEffector
	{
		[Ordinal(0)] [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }
		[Ordinal(1)] [RED("valueToRestore")] public CFloat ValueToRestore { get; set; }
		[Ordinal(2)] [RED("percentage")] public CBool Percentage { get; set; }

		public RestoreStatPoolEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
