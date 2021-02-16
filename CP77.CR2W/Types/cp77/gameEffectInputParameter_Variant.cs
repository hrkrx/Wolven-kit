using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectInputParameter_Variant : CVariable
	{
		[Ordinal(0)] [RED("blackboardProperty")] public gameBlackboardPropertyBindingDefinition BlackboardProperty { get; set; }

		public gameEffectInputParameter_Variant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
