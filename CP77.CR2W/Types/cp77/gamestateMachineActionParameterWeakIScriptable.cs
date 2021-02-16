using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineActionParameterWeakIScriptable : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("value")] public wCHandle<IScriptable> Value { get; set; }

		public gamestateMachineActionParameterWeakIScriptable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
