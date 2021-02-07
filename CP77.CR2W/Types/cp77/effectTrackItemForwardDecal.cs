using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemForwardDecal : effectTrackItem
	{
		[Ordinal(0)]  [RED("mesh")] public rRef<CMesh> Mesh { get; set; }
		[Ordinal(1)]  [RED("appearance")] public CName Appearance { get; set; }
		[Ordinal(2)]  [RED("scale")] public CHandle<IEvaluatorVector> Scale { get; set; }
		[Ordinal(3)]  [RED("additionalRotation")] public CFloat AdditionalRotation { get; set; }
		[Ordinal(4)]  [RED("sizeThreshold")] public CFloat SizeThreshold { get; set; }
		[Ordinal(5)]  [RED("randomRotation")] public CBool RandomRotation { get; set; }
		[Ordinal(6)]  [RED("randomAppearance")] public CBool RandomAppearance { get; set; }
		[Ordinal(7)]  [RED("isAttached")] public CBool IsAttached { get; set; }
		[Ordinal(8)]  [RED("subUVx")] public CUInt32 SubUVx { get; set; }
		[Ordinal(9)]  [RED("subUVy")] public CUInt32 SubUVy { get; set; }
		[Ordinal(10)]  [RED("frame")] public CUInt32 Frame { get; set; }
		[Ordinal(11)]  [RED("fadeOutTime")] public CFloat FadeOutTime { get; set; }
		[Ordinal(12)]  [RED("fadeInTime")] public CFloat FadeInTime { get; set; }

		public effectTrackItemForwardDecal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
