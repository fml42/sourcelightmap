using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;

namespace VRADFix
{
    class Face
    {
        Bsp bsp;
        ushort hammerFaceId;
        List<ushort> bspIndices;
        List<Dface_t> bspFaces = new List<Dface_t>();

        public Face(Bsp bsp)
        {
            this.bsp = bsp;
            randoLightmap();
        }
        public Face(ushort hammerId, Bsp bsp)
        {
            this.hammerFaceId = hammerId;
            this.bsp = bsp;
            gatherDface_ts();
            gatherLightinfo();
        }

        public List<ushort> getBspIndices()
        {
            return bspIndices;
        }

        public List<Dface_t> getFaces()
        {
            return bspFaces;
        }

        private void gatherDface_ts()
        {
            bspIndices = new List<ushort>();
            ushort index = 0;

            bsp.file.Seek(bsp.offsets[11].Key, SeekOrigin.Begin);
            while (bsp.reader.BaseStream.Position < bsp.offsets[11].Key + bsp.offsets[11].Value)
            {
                if (hammerFaceId == bsp.reader.ReadUInt16())
                {
                    bspIndices.Add(index);
                }
                index++;
            }
        }

        private void gatherLightinfo()
        {
            if (bspIndices.Count() > 0)
            {
                foreach (ushort index in bspIndices)
                {
                    bspFaces.Add(new Dface_t(index, bsp));
                }
            }
        }

        public void writeFaces()
        {
            foreach (Dface_t face in bspFaces)
            {
                face.writeLightmap();
            }
        }

        public void rebuildLightmaps(string input, int face, char[] mode)
        {
            for (int i = 0; i < bspFaces.Count(); i++)
            {
                bspFaces[face].updateLightmap(input.Replace("\t", String.Empty).Split(';'), mode);
            }
        }
        public void randoLightmap()
        {

            Random rand = new Random();
            for (int i = 0; i < bsp.offsets[7].Value / 56; i++)
            {
                Dface_t face = new Dface_t(i , bsp);
                face.randoLightmaps(rand);
                face.writeLightmap();
            }
        }
    }
}
