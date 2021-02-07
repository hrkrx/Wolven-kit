using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldSpeedSplineNodeSpeedRestriction : CVariable
	{
		[Ordinal(0)]  [RED("speed")] public CFloat Speed { get; set; }
		[Ordinal(1)]  [RED("from")] public CFloat From { get; set; }
		[Ordinal(2)]  [RED("adjustTime")] public CFloat AdjustTime { get; set; }

		public worldSpeedSplineNodeSpeedRestriction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
