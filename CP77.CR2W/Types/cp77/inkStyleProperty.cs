using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkStyleProperty : CVariable
	{
		[Ordinal(0)] [RED("propertyPath")] public CName PropertyPath { get; set; }
		[Ordinal(1)] [RED("value")] public CVariant Value { get; set; }

		public inkStyleProperty(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
