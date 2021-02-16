using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TweakAIAction : TweakAIActionAbstract
	{
		[Ordinal(27)] [RED("record")] public TweakDBID Record { get; set; }

		public TweakAIAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
