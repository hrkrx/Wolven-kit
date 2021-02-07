using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimSet : CResource
	{
		[Ordinal(0)]  [RED("animations")] public CArray<CHandle<animAnimSetEntry>> Animations { get; set; }
		[Ordinal(1)]  [RED("animationDataChunks")] public CArray<animAnimDataChunk> AnimationDataChunks { get; set; }
		[Ordinal(2)]  [RED("rig")] public rRef<animRig> Rig { get; set; }
		[Ordinal(3)]  [RED("tags")] public redTagList Tags { get; set; }
		[Ordinal(4)]  [RED("correspondingArchetype")] public rRef<CResource> CorrespondingArchetype { get; set; }
		[Ordinal(5)]  [RED("version")] public CUInt32 Version { get; set; }

		public animAnimSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
