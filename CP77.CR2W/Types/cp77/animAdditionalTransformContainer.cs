using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAdditionalTransformContainer : CVariable
	{
		[Ordinal(0)] [RED("entries")] public CArray<CHandle<animAdditionalTransformEntry>> Entries { get; set; }

		public animAdditionalTransformContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
