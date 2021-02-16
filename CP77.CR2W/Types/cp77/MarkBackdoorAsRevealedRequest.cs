using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MarkBackdoorAsRevealedRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("device")] public CHandle<SharedGameplayPS> Device { get; set; }

		public MarkBackdoorAsRevealedRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
