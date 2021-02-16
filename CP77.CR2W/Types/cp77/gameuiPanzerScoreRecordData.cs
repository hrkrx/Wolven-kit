using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerScoreRecordData : CVariable
	{
		[Ordinal(0)] [RED("name")] public CString Name { get; set; }
		[Ordinal(1)] [RED("score")] public CUInt32 Score { get; set; }

		public gameuiPanzerScoreRecordData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
