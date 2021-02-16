using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_SceneItem : animAnimEvent
	{
		[Ordinal(3)] [RED("boneName")] public CName BoneName { get; set; }

		public animAnimEvent_SceneItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
