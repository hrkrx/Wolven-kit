using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_HitRepresentation_Raycast : gameEffectObjectFilter_HitRepresentation
	{
		[Ordinal(0)] [RED("isPreview")] public CBool IsPreview { get; set; }

		public gameEffectObjectFilter_HitRepresentation_Raycast(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
