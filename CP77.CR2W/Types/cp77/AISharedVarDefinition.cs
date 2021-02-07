using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AISharedVarDefinition : CVariable
	{
		[Ordinal(0)]  [RED("type")] public CEnum<AIESharedVarDefinitionType> Type { get; set; }
		[Ordinal(1)]  [RED("name")] public LibTreeSharedVarRegistrationName Name { get; set; }

		public AISharedVarDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
