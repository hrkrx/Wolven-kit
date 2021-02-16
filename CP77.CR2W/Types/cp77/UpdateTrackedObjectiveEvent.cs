using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UpdateTrackedObjectiveEvent : redEvent
	{
		[Ordinal(0)] [RED("trackedObjective")] public wCHandle<gameJournalQuestObjective> TrackedObjective { get; set; }
		[Ordinal(1)] [RED("trackedQuest")] public wCHandle<gameJournalQuest> TrackedQuest { get; set; }

		public UpdateTrackedObjectiveEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
