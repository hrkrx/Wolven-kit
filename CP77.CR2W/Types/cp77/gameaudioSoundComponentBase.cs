using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameaudioSoundComponentBase : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("audioName")] public CName AudioName { get; set; }
		[Ordinal(1)]  [RED("applyObstruction")] public CBool ApplyObstruction { get; set; }
		[Ordinal(2)]  [RED("applyAcousticOcclusion")] public CBool ApplyAcousticOcclusion { get; set; }
		[Ordinal(3)]  [RED("applyAcousticRepositioning")] public CBool ApplyAcousticRepositioning { get; set; }
		[Ordinal(4)]  [RED("obstructionChangeTime")] public CFloat ObstructionChangeTime { get; set; }
		[Ordinal(5)]  [RED("maxPlayDistance")] public CFloat MaxPlayDistance { get; set; }

		public gameaudioSoundComponentBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
