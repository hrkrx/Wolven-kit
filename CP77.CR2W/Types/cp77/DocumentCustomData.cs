using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DocumentCustomData : IScriptable
	{
		[Ordinal(0)] [RED("id")] public CInt32 Id { get; set; }
		[Ordinal(1)] [RED("type")] public CEnum<EDocumentType> Type { get; set; }

		public DocumentCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
