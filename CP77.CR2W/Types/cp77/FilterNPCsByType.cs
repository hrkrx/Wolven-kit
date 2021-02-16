using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FilterNPCsByType : gameEffectObjectSingleFilter_Scripted
	{
		[Ordinal(0)] [RED("allowedTypes")] public CArray<CEnum<gamedataNPCType>> AllowedTypes { get; set; }
		[Ordinal(1)] [RED("invert")] public CBool Invert { get; set; }

		public FilterNPCsByType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
