using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FuseBoxControllerPS : MasterControllerPS
	{
		[Ordinal(104)] [RED("fuseBoxSkillChecks")] public CHandle<EngineeringContainer> FuseBoxSkillChecks { get; set; }
		[Ordinal(105)] [RED("isGenerator")] public CBool IsGenerator { get; set; }
		[Ordinal(106)] [RED("isOverloaded")] public CBool IsOverloaded { get; set; }

		public FuseBoxControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
