using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldWorldGlobalLightOverrideWithColorParameters : CVariable
	{
		[Ordinal(0)]  [RED("lightDirOverride")] public GlobalLightingTrajectoryOverride LightDirOverride { get; set; }
		[Ordinal(1)]  [RED("lightColorOverride")] public HDRColor LightColorOverride { get; set; }

		public worldWorldGlobalLightOverrideWithColorParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
