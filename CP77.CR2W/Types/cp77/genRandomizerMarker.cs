using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class genRandomizerMarker : worldIMarker
	{
		[Ordinal(0)]  [RED("id")] public CString Id { get; set; }
		[Ordinal(1)]  [RED("templateName")] public CName TemplateName { get; set; }
		[Ordinal(2)]  [RED("probability")] public CFloat Probability { get; set; }

		public genRandomizerMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
