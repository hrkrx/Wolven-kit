using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GameplayFunctionalTestReturnValue : CVariable
	{
		[Ordinal(0)]  [RED("value")] public CString Value { get; set; }
		[Ordinal(1)]  [RED("errorInfo")] public CString ErrorInfo { get; set; }

		public GameplayFunctionalTestReturnValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
