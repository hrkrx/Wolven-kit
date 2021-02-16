using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RefreshPingEffector : gameEffector
	{
		[Ordinal(0)] [RED("squadMembers")] public CArray<entEntityID> SquadMembers { get; set; }
		[Ordinal(1)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }

		public RefreshPingEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
