using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceMetaData : CVariable
	{
		[Ordinal(0)]  [RED("tweakDBName")] public CString TweakDBName { get; set; }
		[Ordinal(1)]  [RED("tweakDBID")] public TweakDBID TweakDBID { get; set; }
		[Ordinal(2)]  [RED("type")] public gameinteractionsChoiceTypeWrapper Type { get; set; }

		public gameinteractionsChoiceMetaData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
