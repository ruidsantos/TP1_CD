﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor_UDP
{
    class Packet
    {
        public int PacketType { get; set; }

        public byte[] Payload { get; set; }
    }
}
