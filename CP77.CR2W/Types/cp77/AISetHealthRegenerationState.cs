using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AISetHealthRegenerationState : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("healthRegeneration")] public CBool HealthRegeneration { get; set; }

		public AISetHealthRegenerationState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
