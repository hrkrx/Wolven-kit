using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnBraindanceResetting_ConditionType : scnIBraindanceConditionType
	{
		[Ordinal(0)] [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }

		public scnBraindanceResetting_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
