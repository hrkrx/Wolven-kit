using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TogglePreventionSystem : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("sourceName")] public CName SourceName { get; set; }
		[Ordinal(1)] [RED("isActive")] public CBool IsActive { get; set; }

		public TogglePreventionSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
