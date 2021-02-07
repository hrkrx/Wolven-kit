using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entAmbientSoundEmitterComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("Settings")] public CHandle<audioAmbientAreaSettings> Settings { get; set; }
		[Ordinal(1)]  [RED("usePhysicsObstruction")] public CBool UsePhysicsObstruction { get; set; }
		[Ordinal(2)]  [RED("occlusionEnabled")] public CBool OcclusionEnabled { get; set; }
		[Ordinal(3)]  [RED("repositionEnabled")] public CBool RepositionEnabled { get; set; }
		[Ordinal(4)]  [RED("obstructionChangeTime")] public CFloat ObstructionChangeTime { get; set; }

		public entAmbientSoundEmitterComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
