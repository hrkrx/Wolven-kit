using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorExitWorkspotNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(0)]  [RED("skipExitAnimation")] public CHandle<AIArgumentMapping> SkipExitAnimation { get; set; }
		[Ordinal(1)]  [RED("useSlowExitAnimation")] public CHandle<AIArgumentMapping> UseSlowExitAnimation { get; set; }
		[Ordinal(2)]  [RED("doSlowIfFastExitFails")] public CHandle<AIArgumentMapping> DoSlowIfFastExitFails { get; set; }
		[Ordinal(3)]  [RED("stayInWorkspotIfExitFails")] public CHandle<AIArgumentMapping> StayInWorkspotIfExitFails { get; set; }
		[Ordinal(4)]  [RED("tryBlendFastExitToWalk")] public CHandle<AIArgumentMapping> TryBlendFastExitToWalk { get; set; }
		[Ordinal(5)]  [RED("dontRequestExit")] public CHandle<AIArgumentMapping> DontRequestExit { get; set; }
		[Ordinal(6)]  [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }

		public AIbehaviorExitWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
