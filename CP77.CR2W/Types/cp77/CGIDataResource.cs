using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CGIDataResource : resStreamedResource
	{
		[Ordinal(1)] [RED("data")] public serializationDeferredDataBuffer Data { get; set; }
		[Ordinal(2)] [RED("sectorHash")] public CUInt64 SectorHash { get; set; }

		public CGIDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
