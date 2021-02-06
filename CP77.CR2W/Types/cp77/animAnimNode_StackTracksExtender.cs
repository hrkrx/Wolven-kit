using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StackTracksExtender : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("newTracks")] public CArray<animFloatTrackInfo> NewTracks { get; set; }
		[Ordinal(1)]  [RED("tag")] public CName Tag { get; set; }

		[Ordinal(999)]  [RED("shrinkerNodeId")] public CUInt32 shrinkerNodeId { get; set; }

		public animAnimNode_StackTracksExtender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
