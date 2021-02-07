using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldRenderProxyTransformBuffer : CVariable
	{
		[Ordinal(0)]  [RED("sharedDataBuffer")] public CHandle<worldSharedDataBuffer> SharedDataBuffer { get; set; }
		[Ordinal(1)]  [RED("startIndex")] public CUInt32 StartIndex { get; set; }
		[Ordinal(2)]  [RED("numElements")] public CUInt32 NumElements { get; set; }

		public worldRenderProxyTransformBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
