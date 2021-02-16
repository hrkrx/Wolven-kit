using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TargetAssessmentRequest : ScriptableDeviceAction
	{
		[Ordinal(25)] [RED("targetToAssess")] public wCHandle<gameObject> TargetToAssess { get; set; }

		public TargetAssessmentRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
