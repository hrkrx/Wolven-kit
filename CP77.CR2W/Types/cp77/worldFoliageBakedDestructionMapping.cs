using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldFoliageBakedDestructionMapping : worldFoliageDestructionMapping
	{
		[Ordinal(0)]  [RED("numFrames")] public CFloat NumFrames { get; set; }
		[Ordinal(1)]  [RED("frameRate")] public CFloat FrameRate { get; set; }
		[Ordinal(2)]  [RED("audioMetadata")] public CName AudioMetadata { get; set; }
		[Ordinal(3)]  [RED("destructionEffect")] public raRef<worldEffect> DestructionEffect { get; set; }
		[Ordinal(4)]  [RED("filterDataSource")] public CEnum<physicsFilterDataSource> FilterDataSource { get; set; }
		[Ordinal(5)]  [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }

		public worldFoliageBakedDestructionMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
