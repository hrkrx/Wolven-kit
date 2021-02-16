using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UnRegisterInputListenerRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("object")] public wCHandle<gameObject> Object { get; set; }

		public UnRegisterInputListenerRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
