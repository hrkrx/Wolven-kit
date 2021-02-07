using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questShowCustomTooltip_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("setTooltip")] public CBool SetTooltip { get; set; }
		[Ordinal(1)]  [RED("text")] public LocalizationString Text { get; set; }
		[Ordinal(2)]  [RED("inputAction")] public CString InputAction { get; set; }
		[Ordinal(3)]  [RED("holdIndicationType")] public CEnum<inkInputHintHoldIndicationType> HoldIndicationType { get; set; }

		public questShowCustomTooltip_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
