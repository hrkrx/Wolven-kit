using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldAcousticDataResource : resStreamedResource
	{
		[Ordinal(1)] [RED("cells")] public CArray<worldAcousticDataCell> Cells { get; set; }

		public worldAcousticDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
