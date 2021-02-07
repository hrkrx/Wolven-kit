using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorVectorRandomUniform : IEvaluatorVector
	{
		[Ordinal(0)]  [RED("min")] public Vector4 Min { get; set; }
		[Ordinal(1)]  [RED("max")] public Vector4 Max { get; set; }
		[Ordinal(2)]  [RED("lockX")] public CBool LockX { get; set; }
		[Ordinal(3)]  [RED("lockY")] public CBool LockY { get; set; }
		[Ordinal(4)]  [RED("lockZ")] public CBool LockZ { get; set; }
		[Ordinal(5)]  [RED("lockW")] public CBool LockW { get; set; }

		public CEvaluatorVectorRandomUniform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
