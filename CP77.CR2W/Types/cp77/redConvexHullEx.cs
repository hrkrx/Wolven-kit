using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class redConvexHullEx : CVariable
	{
		[Ordinal(0)] [RED("data")] public DataBuffer Data { get; set; }

		public redConvexHullEx(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
