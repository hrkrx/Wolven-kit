using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSpawnManagerNodeType : questIRetNodeType
	{
		[Ordinal(0)] [RED("action")] public CEnum<populationSpawnerObjectCtrlAction> Action { get; set; }

		public questSpawnManagerNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
