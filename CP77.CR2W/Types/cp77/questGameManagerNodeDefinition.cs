using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questGameManagerNodeDefinition : questTypedSignalStoppingNodeDefinition
	{
		[Ordinal(2)] [RED("type")] public CHandle<questIGameManagerNodeType> Type { get; set; }

		public questGameManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
