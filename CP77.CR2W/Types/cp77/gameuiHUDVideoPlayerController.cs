using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiHUDVideoPlayerController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("playOnHud")] public CBool PlayOnHud { get; set; }

		public gameuiHUDVideoPlayerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
