using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameIObjectScriptBase : IScriptable
	{
		[Ordinal(0)] [RED("gameObject")] public CHandle<gameObject> GameObject { get; set; }

		public gameIObjectScriptBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
