using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class STextureGroupSetup : CVariable
	{
		[Ordinal(0)]  [RED("group")] public CEnum<GpuWrapApieTextureGroup> Group { get; set; }
		[Ordinal(2)]  [RED("compression")] public CEnum<ETextureCompression> Compression { get; set; }
		[Ordinal(1)]  [RED("rawFormat")] public CEnum<ETextureRawFormat> RawFormat { get; set; }
		[Ordinal(3)]  [RED("platformMipBiasPC")] public CUInt8 PlatformMipBiasPC { get; set; }
		[Ordinal(4)]  [RED("platformMipBiasConsole")] public CUInt8 PlatformMipBiasConsole { get; set; }
		[Ordinal(5)]  [RED("isStreamable")] public CBool IsStreamable { get; set; }
		[Ordinal(6)]  [RED("hasMipchain")] public CBool HasMipchain { get; set; }
		[Ordinal(7)]  [RED("isGamma")] public CBool IsGamma { get; set; }
		[Ordinal(8)]  [RED("allowTextureDowngrade")] public CBool AllowTextureDowngrade { get; set; }

        [Ordinal(999)] [RED("alphaToCoverageThreshold")] public CUInt8 AlphaToCoverageThreshold { get; set; }

		public STextureGroupSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
