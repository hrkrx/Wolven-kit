using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PreventionAgents : IScriptable
	{
		[Ordinal(0)] [RED("groupName")] public CName GroupName { get; set; }
		[Ordinal(1)] [RED("requsteredAgents")] public CArray<SPreventionAgentData> RequsteredAgents { get; set; }

		public PreventionAgents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
