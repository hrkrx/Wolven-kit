using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTargetingLocalizedEffectComponent : entIComponent
	{
		[Ordinal(3)] [RED("streamingDistance")] public CFloat StreamingDistance { get; set; }
		[Ordinal(4)] [RED("visibleTargetRange")] public CFloat VisibleTargetRange { get; set; }

		public gameTargetingLocalizedEffectComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
