using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateMachineListDefinition : IScriptable
	{
		[Ordinal(0)] [RED("stateMachinesStorage")] public CArray<CHandle<gamestateMachineStateMachineDefinition>> StateMachinesStorage { get; set; }

		public gamestateMachineStateMachineListDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
