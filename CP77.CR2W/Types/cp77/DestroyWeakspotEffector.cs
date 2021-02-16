using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DestroyWeakspotEffector : gameEffector
	{
		[Ordinal(0)] [RED("weakspotIndex")] public CInt32 WeakspotIndex { get; set; }

		public DestroyWeakspotEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
