using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCyberspaceBoundaryNode : worldTriggerAreaNode
	{
		[Ordinal(5)] [RED("marker1Ref")] public NodeRef Marker1Ref { get; set; }
		[Ordinal(6)] [RED("marker2Ref")] public NodeRef Marker2Ref { get; set; }

		public gameCyberspaceBoundaryNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
