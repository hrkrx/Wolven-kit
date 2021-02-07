using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_VehiclePassengerAnimSetup : animAnimFeature
	{
		[Ordinal(0)]  [RED("enableAdditiveAnim")] public CBool EnableAdditiveAnim { get; set; }
		[Ordinal(1)]  [RED("additiveScale")] public CFloat AdditiveScale { get; set; }

		public animAnimFeature_VehiclePassengerAnimSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
