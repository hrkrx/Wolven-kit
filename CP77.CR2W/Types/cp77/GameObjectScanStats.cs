using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GameObjectScanStats : CVariable
	{
		[Ordinal(0)] [RED("scannerData")] public scannerDataStructure ScannerData { get; set; }

		public GameObjectScanStats(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
