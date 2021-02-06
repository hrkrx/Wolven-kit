using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta(EREDMetaInfo.REDStruct)]
	public class AreaShapeOutline : ISerializable
	{
		[Ordinal(0)] [RED("points")] public CArray<SVector4> Points { get; set; }
        [Ordinal(1)] [RED("height")] public CFloat Height { get; set; }


        public AreaShapeOutline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

        }

      
    }
}
