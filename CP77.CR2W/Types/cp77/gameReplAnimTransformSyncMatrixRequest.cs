using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameReplAnimTransformSyncMatrixRequest : gameReplAnimTransformRequestBase
	{
		[Ordinal(1)] [RED("transform")] public Transform Transform { get; set; }

		public gameReplAnimTransformSyncMatrixRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
