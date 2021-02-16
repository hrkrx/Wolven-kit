using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WeakFenceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("weakfenceSkillChecks")] public CHandle<EngDemoContainer> WeakfenceSkillChecks { get; set; }
		[Ordinal(104)] [RED("weakFenceSetup")] public WeakFenceSetup WeakFenceSetup { get; set; }

		public WeakFenceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
