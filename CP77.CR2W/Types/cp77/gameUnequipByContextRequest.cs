using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameUnequipByContextRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("itemUnequipContext")] public CEnum<gameItemUnequipContexts> ItemUnequipContext { get; set; }

		public gameUnequipByContextRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
