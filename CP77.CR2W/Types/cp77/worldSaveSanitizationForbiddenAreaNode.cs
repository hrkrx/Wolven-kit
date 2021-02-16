using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldSaveSanitizationForbiddenAreaNode : worldTriggerAreaNode
	{
		[Ordinal(5)] [RED("safeSpotOffset")] public Vector4 SafeSpotOffset { get; set; }

		public worldSaveSanitizationForbiddenAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
