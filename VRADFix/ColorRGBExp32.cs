using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace VRADFix
{
    //this class stores the data for a single luxel
    class ColorRGBExp32
    {
        public byte r, g, b;
        public sbyte e;

        public ColorRGBExp32(BinaryReader reader)
            //constructor, pulls the data from the binaryReader
            //BinaryReader MUST be at the correct offset
        {
            r = reader.ReadByte();
            g = reader.ReadByte();
            b = reader.ReadByte();
            e = unchecked((sbyte)reader.ReadByte());
        }

        public void updateLuxel(string[] value)
            //reads the textbox and updates values
        {
            r = byte.Parse(value[0]);
            g = byte.Parse(value[1]);
            b = byte.Parse(value[2]);
            e = sbyte.Parse(value[3]);
        }
        
        public void writeLuxel(BinaryWriter writer)
            //writes the luxel in the binary writer
            //BinaryWriter MUST be at the correct position
        {
            writer.Write(r);
            writer.Write(g);
            writer.Write(b);
            writer.Write(unchecked((byte)e));
        }

        public void randomRGB(Random rand)
            //randomizes data
        {
            r = (byte)(rand.Next(0, 2) * 255);
            g = (byte)(rand.Next(0, 2) * 255);
            b = (byte)(rand.Next(0, 2) * 255);
        }
    }
}
