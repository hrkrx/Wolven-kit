using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WorldPosition : CVariable
	{
		[Ordinal(0)] [RED("x")] public FixedPoint X { get; set; }
		[Ordinal(1)] [RED("y")] public FixedPoint Y { get; set; }
		[Ordinal(2)] [RED("z")] public FixedPoint Z { get; set; }

		public WorldPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
