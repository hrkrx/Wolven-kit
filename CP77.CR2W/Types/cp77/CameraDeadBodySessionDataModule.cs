using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CameraDeadBodySessionDataModule : GameSessionDataModule
	{
		[Ordinal(1)] [RED("cameraDeadBodyData")] public CArray<CHandle<CameraDeadBodyInternalData>> CameraDeadBodyData { get; set; }

		public CameraDeadBodySessionDataModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
