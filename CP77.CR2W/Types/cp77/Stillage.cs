using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Stillage : InteractiveDevice
	{
		[Ordinal(93)] [RED("collider")] public CHandle<entIPlacedComponent> Collider { get; set; }

		public Stillage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
