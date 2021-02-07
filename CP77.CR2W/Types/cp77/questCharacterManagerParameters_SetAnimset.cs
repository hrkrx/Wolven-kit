using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetAnimset : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)]  [RED("variableName")] public CName VariableName { get; set; }
		[Ordinal(1)]  [RED("value")] public CFloat Value { get; set; }

		public questCharacterManagerParameters_SetAnimset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
