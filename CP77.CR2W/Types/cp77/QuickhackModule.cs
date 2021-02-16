using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuickhackModule : HUDModule
	{
		[Ordinal(3)] [RED("calculateClose")] public CBool CalculateClose { get; set; }

		public QuickhackModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
