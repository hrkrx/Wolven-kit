using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vgAttributeTypeValuePair : ISerializable
	{
		[Ordinal(0)]  [RED("pe")] public CEnum<vgEStyleAttributeType> Pe { get; set; }
		[Ordinal(1)]  [RED("lue")] public CVariant Lue { get; set; }

		public vgAttributeTypeValuePair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
