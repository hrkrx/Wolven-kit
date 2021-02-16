using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapGameObject : gameObject
	{
		[Ordinal(40)] [RED("districts")] public CArray<gameuiDistrictTriggerData> Districts { get; set; }

		public gameuiWorldMapGameObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
