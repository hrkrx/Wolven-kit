using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariableTreeRef : LibTreeDefTreeVariable
	{
		[Ordinal(0)]  [RED("defaultValue")] public CHandle<LibTreeCTreeReference> DefaultValue { get; set; }

		public LibTreeDefTreeVariableTreeRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
