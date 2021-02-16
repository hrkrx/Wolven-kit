using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MasterControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("clearance")] public CHandle<gamedeviceClearance> Clearance { get; set; }

		public MasterControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
