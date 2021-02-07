using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsPlayAnimEventExData : CVariable
	{
		[Ordinal(0)]  [RED("basic")] public scneventsPlayAnimEventData Basic { get; set; }
		[Ordinal(1)]  [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(2)]  [RED("bodyPartMask")] public CName BodyPartMask { get; set; }

		public scneventsPlayAnimEventExData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
