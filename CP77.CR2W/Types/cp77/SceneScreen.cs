using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SceneScreen : gameObject
	{
		[Ordinal(40)] [RED("uiAnimationsData")] public CHandle<SceneScreenUIAnimationsData> UiAnimationsData { get; set; }
		[Ordinal(41)] [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }

		public SceneScreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
