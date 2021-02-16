using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldAudioTagNode : worldNode
	{
		[Ordinal(2)] [RED("audioTag")] public CName AudioTag { get; set; }
		[Ordinal(3)] [RED("radius")] public CFloat Radius { get; set; }

		public worldAudioTagNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
