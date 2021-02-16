using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineparameterTypeRequestItem : IScriptable
	{
		[Ordinal(0)] [RED("requests")] public CArray<gameEquipParam> Requests { get; set; }

		public gamestateMachineparameterTypeRequestItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
