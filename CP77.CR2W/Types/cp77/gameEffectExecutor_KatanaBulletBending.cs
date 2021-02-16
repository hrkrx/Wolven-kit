using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_KatanaBulletBending : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] [RED("effects")] public CArray<gameEffectExecutor_KatanaBulletBendingEffectEntry> Effects { get; set; }

		public gameEffectExecutor_KatanaBulletBending(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
