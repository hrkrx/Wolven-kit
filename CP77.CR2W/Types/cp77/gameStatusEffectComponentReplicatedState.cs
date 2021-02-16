using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameStatusEffectComponentReplicatedState : netIComponentState
	{
		[Ordinal(2)] [RED("replicatedInfo")] public CArray<gameStatusEffectReplicatedInfo> ReplicatedInfo { get; set; }

		public gameStatusEffectComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
