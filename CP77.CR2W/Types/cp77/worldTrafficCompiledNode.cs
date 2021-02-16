using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficCompiledNode : worldNode
	{
		[Ordinal(2)] [RED("aabb")] public Box Aabb { get; set; }

		public worldTrafficCompiledNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
