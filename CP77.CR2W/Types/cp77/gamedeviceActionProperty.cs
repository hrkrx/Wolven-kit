using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamedeviceActionProperty : IScriptable
	{
		[Ordinal(0)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(1)]  [RED("typeName")] public CName TypeName { get; set; }
		[Ordinal(2)]  [RED("first")] public CVariant First { get; set; }
		[Ordinal(3)]  [RED("second")] public CVariant Second { get; set; }
		[Ordinal(4)]  [RED("third")] public CVariant Third { get; set; }
		[Ordinal(5)]  [RED("flags")] public CEnum<gamedeviceActionPropertyFlags> Flags { get; set; }

		public gamedeviceActionProperty(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
