using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RegisterItemUsedRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("itemUsed")] public gameItemID ItemUsed { get; set; }

		public RegisterItemUsedRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
