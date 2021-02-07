using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questTriggerCallRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("caller")] public CName Caller { get; set; }
		[Ordinal(1)]  [RED("addressee")] public CName Addressee { get; set; }
		[Ordinal(2)]  [RED("callPhase")] public CEnum<questPhoneCallPhase> CallPhase { get; set; }
		[Ordinal(3)]  [RED("callMode")] public CEnum<questPhoneCallMode> CallMode { get; set; }

		public questTriggerCallRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
