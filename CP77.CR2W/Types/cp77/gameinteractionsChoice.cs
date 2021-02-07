using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoice : CVariable
	{
		[Ordinal(0)]  [RED("caption")] public CString Caption { get; set; }
		[Ordinal(1)]  [RED("captionParts")] public gameinteractionsChoiceCaption CaptionParts { get; set; }
		[Ordinal(2)]  [RED("data")] public CArray<CVariant> Data { get; set; }
		[Ordinal(3)]  [RED("choiceMetaData")] public gameinteractionsChoiceMetaData ChoiceMetaData { get; set; }
		[Ordinal(4)]  [RED("lookAtDescriptor")] public gameinteractionsChoiceLookAtDescriptor LookAtDescriptor { get; set; }

		public gameinteractionsChoice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
