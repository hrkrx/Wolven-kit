using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WeakFenceSetup : CVariable
	{
		[Ordinal(0)] [RED("hasGenericInteraction")] public CBool HasGenericInteraction { get; set; }

		public WeakFenceSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
