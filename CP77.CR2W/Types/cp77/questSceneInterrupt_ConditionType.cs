using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSceneInterrupt_ConditionType : questISceneConditionType
	{
		[Ordinal(0)]  [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }
		[Ordinal(1)]  [RED("onlyInSafeMoment")] public CBool OnlyInSafeMoment { get; set; }
		[Ordinal(2)]  [RED("interruptConditions")] public CArray<CHandle<scnIInterruptCondition>> InterruptConditions { get; set; }

		public questSceneInterrupt_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
