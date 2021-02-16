using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InputContextSystem : gameScriptableSystem
	{
		[Ordinal(0)] [RED("activeContext")] public CEnum<inputContextType> ActiveContext { get; set; }

		public InputContextSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
