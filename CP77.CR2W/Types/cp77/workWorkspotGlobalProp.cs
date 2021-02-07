using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workWorkspotGlobalProp : CVariable
	{
		[Ordinal(0)]  [RED("id")] public CName Id { get; set; }
		[Ordinal(1)]  [RED("boneName")] public CName BoneName { get; set; }
		[Ordinal(2)]  [RED("prop")] public raRef<entEntityTemplate> Prop { get; set; }

		public workWorkspotGlobalProp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
