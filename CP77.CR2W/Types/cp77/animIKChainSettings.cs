using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animIKChainSettings : CVariable
	{
		[Ordinal(0)] [RED("chainName")] public CName ChainName { get; set; }
		[Ordinal(1)] [RED("enableFloatTrack")] public CName EnableFloatTrack { get; set; }
		[Ordinal(2)] [RED("ikEndPointOffset")] public Vector3 IkEndPointOffset { get; set; }
		[Ordinal(3)] [RED("ikEndRotationOffset")] public Quaternion IkEndRotationOffset { get; set; }

		public animIKChainSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
