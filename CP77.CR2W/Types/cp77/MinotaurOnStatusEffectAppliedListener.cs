using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MinotaurOnStatusEffectAppliedListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<NPCPuppet> Owner { get; set; }
		[Ordinal(1)] [RED("minotaurMechComponent")] public CHandle<MinotaurMechComponent> MinotaurMechComponent { get; set; }

		public MinotaurOnStatusEffectAppliedListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
