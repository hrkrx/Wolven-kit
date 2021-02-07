using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questFlowControlNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(0)]  [RED("isOpen")] public CBool IsOpen { get; set; }
		[Ordinal(1)]  [RED("opensAt")] public CUInt16 OpensAt { get; set; }
		[Ordinal(2)]  [RED("closesAt")] public CUInt16 ClosesAt { get; set; }

		public questFlowControlNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
