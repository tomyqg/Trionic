﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TrionicCANLib.Firmware
{
    public class FileT8 : BaseFile
    {
        public const uint Length = 0x100000;
        public const uint SRAMAddress = 0x100000;

        static public new bool VerifyFileSize(long size)
        {
            return size == Length;
        }
    }
}
