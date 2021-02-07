using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entTriggerActivatorComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(1)]  [RED("height")] public CFloat Height { get; set; }
		[Ordinal(2)]  [RED("channels")] public CEnum<TriggerChannel> Channels { get; set; }
		[Ordinal(3)]  [RED("maxContinousDistance")] public CFloat MaxContinousDistance { get; set; }
		[Ordinal(4)]  [RED("enableCCD")] public CBool EnableCCD { get; set; }

		public entTriggerActivatorComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
