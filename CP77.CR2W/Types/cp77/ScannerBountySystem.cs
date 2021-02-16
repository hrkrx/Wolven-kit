using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerBountySystem : ScannerChunk
	{
		[Ordinal(0)] [RED("bounty")] public BountyUI Bounty { get; set; }

		public ScannerBountySystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
