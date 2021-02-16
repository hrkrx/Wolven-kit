using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GameObjectListener : IScriptable
	{
		[Ordinal(0)] [RED("prereqOwner")] public CHandle<gamePrereqState> PrereqOwner { get; set; }
		[Ordinal(1)] [RED("e3HackBlock")] public CBool E3HackBlock { get; set; }

		public GameObjectListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
