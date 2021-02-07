﻿using RED.CRC32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WolvenKit.Common.Model;
using CP77.CR2W.Types;

namespace CP77.CR2W
{
    public static class CR2WFileHelper
    {
        public static CR2WFile FromCResource(this CR2WFile file, CResource res, bool cooked = false)
        {
            // checks to see if the variable from which the chunk is built is properly constructed
            if (res == null || res.REDName != res.REDType || res.ParentVar != null)
                return null;

            file.CreateChunk(res);

            return file;
        }




    }



}