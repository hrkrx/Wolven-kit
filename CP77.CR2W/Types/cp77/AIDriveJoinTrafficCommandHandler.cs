using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIDriveJoinTrafficCommandHandler : AICommandHandlerBase
	{
		[Ordinal(1)] [RED("outUseKinematic")] public CHandle<AIArgumentMapping> OutUseKinematic { get; set; }
		[Ordinal(2)] [RED("outNeedDriver")] public CHandle<AIArgumentMapping> OutNeedDriver { get; set; }

		public AIDriveJoinTrafficCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
