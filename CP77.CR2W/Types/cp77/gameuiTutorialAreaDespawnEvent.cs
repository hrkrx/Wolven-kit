using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiTutorialAreaDespawnEvent : redEvent
	{
		[Ordinal(0)]  [RED("bracketID")] public CName BracketID { get; set; }
		[Ordinal(1)]  [RED("areaID")] public CUInt32 AreaID { get; set; }

		public gameuiTutorialAreaDespawnEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
