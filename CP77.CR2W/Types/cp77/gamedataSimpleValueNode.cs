using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamedataSimpleValueNode : gamedataValueDataNode
	{
		[Ordinal(0)]  [RED("type")] public CEnum<gamedataSimpleValueNodeValueType> Type { get; set; }
		[Ordinal(1)]  [RED("data")] public CString Data { get; set; }

		public gamedataSimpleValueNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
