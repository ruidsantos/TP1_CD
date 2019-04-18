using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor_UDP
{
    class Packet
    {
        //pacote pode ter varios tipos
        public int Ack;
        public int FIN;
        public int RequestFile;
        public int RequestBlock;
        public int SendFile;

        //campos de um packet
        public int PacketType { get; set; }
        public byte[] Payload { get; set; } = new byte[0];

        //contrutores
        public Packet(int packetType)
        {
            //define o tipo de pacote que vai ser enviado
            PacketType = packetType;
        }

        public Packet(byte[]bytes)
        {
            Payload = new Byte[bytes.Length - 4];
            bytes.Skip(4).ToArray().CopyTo(Payload, 0);

        }
    }
}
