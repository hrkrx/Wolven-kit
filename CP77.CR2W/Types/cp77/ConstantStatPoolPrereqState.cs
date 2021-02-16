using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ConstantStatPoolPrereqState : StatPoolPrereqState
	{
		[Ordinal(1)] [RED("listenConstantly")] public CBool ListenConstantly { get; set; }

		public ConstantStatPoolPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
