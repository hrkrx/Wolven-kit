using CP77.CR2W.Reflection;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamedataAIHasWeapon_Record : gamedataAIActionSubCondition_Record
	{
		public gamedataAIHasWeapon_Record(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
