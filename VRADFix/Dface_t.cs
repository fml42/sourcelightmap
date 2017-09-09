using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

/* this class is inspired from valve's Dface_t class. it deals with how faces are represented in the bsp. 
   the commented out values are values we don't need for this application, they are left here as references 
   check this for reference on bsp faces https://developer.valvesoftware.com/wiki/Source_BSP_File_Format#Plane
 */

namespace VRADFix
{
    class Dface_t
        
    {
        
        public ushort planenum;	                // the plane number
        /*
        byte side;			                // faces opposite to the node's plane direction
        byte onNode;	                    // 1 of on node, 0 if in leaf
        int firstedge;		                // index into surfedges
        short numedges;		                // number of surfedges
        short texinfo;		                // texture info
        short dispinfo;		                // displacement info
        short surfaceFogVolumeID;	        // ?
        int styles;                         // switchable lighting info
        */ 
        // 20 0x14
        public int lightOfs;                // offset into lightmap lump
        /*
        float area;			                // face area in units^2
        int LightmapTextureMinsInLuxels1;	// texture lighting info
        int LightmapTextureMinsInLuxels2;
         */ 
        // 36 0x24
        public int LightmapTextureWidth;
        public int LightmapTextureLength;   // texture lighting info
        // 40 0x28
        /*
        int origFace;		                // original face this was split from
        ushort numPrims;		            // primitives
        ushort firstPrimID;
        uint smoothingGroups;	            // lightmap smoothing group
        */ 

        public ColorRGBExp32[,] lightmapLDR;
        public ColorRGBExp32[,] lightmapHDR;
        Bsp bsp;
        public static readonly int classLength = 56; // 0x38

        public Dface_t(ushort planenum, Bsp bsp) // send offset + 0x14
            //constructor that gets the basic face infos with a planenum and a bsp
        {
            this.planenum = planenum;
            bsp.file.Seek(bsp.offsets[7].Key + planenum * classLength, SeekOrigin.Begin);//seek to dface_t
            bsp.file.Seek(20, SeekOrigin.Current); //seek to lighofs
            lightOfs = bsp.reader.ReadInt32(); //read light offset
            bsp.file.Seek(12, SeekOrigin.Current); //seek to lightmap
            LightmapTextureWidth = bsp.reader.ReadInt32()+1; //read lightmap width
            LightmapTextureLength = bsp.reader.ReadInt32()+1; //read lightmap length
            this.bsp = bsp;
            retrieveLightmap();
        }

        private void retrieveLightmap()
            //gathers lightmap data from the offset in the file
        {
            lightmapLDR = new ColorRGBExp32[LightmapTextureWidth, LightmapTextureLength];
            lightmapHDR = new ColorRGBExp32[LightmapTextureWidth, LightmapTextureLength];

            if (bsp.LDR)
            {
                bsp.file.Seek(bsp.offsets[8].Key + lightOfs, SeekOrigin.Begin);
                for (int y = 0; y < LightmapTextureLength; y++)
                {
                    for (int x = 0; x < LightmapTextureWidth; x++)
                    {
                        lightmapLDR[x, y] = new ColorRGBExp32(bsp.reader);
                    }
                }
            }
            if (bsp.HDR)
            {
                bsp.file.Seek(bsp.offsets[53].Key + lightOfs, SeekOrigin.Begin);
                for (int y = 0; y < LightmapTextureLength; y++)
                {
                    for (int x = 0; x < LightmapTextureWidth; x++)
                    {
                        lightmapHDR[x, y] = new ColorRGBExp32(bsp.reader);
                    }
                }
            }
        }

        public void writeLightmap()
            //writes the lightmap data into the bsp (updated or not)
        {
            if (bsp.LDR)
            {
                bsp.file.Seek(bsp.offsets[8].Key + lightOfs, SeekOrigin.Begin);
                for (int i = 0; i < LightmapTextureLength; i++)
                {
                    for (int j = 0; j < LightmapTextureWidth; j++)
                    {
                        lightmapLDR[j, i].writeLuxel(bsp.writer);
                    }
                }
            }
            if (bsp.HDR)
            {
                bsp.file.Seek(bsp.offsets[53].Key + lightOfs, SeekOrigin.Begin);
                for (int i = 0; i < LightmapTextureLength; i++)
                {
                    for (int j = 0; j < LightmapTextureWidth; j++)
                    {
                        lightmapHDR[j, i].writeLuxel(bsp.writer);
                    }
                }
            }
            bsp.writer.Flush();
        }

        /*public void updateLightmap(string[] luxels, bool ldr)
            //updates the lightmap data in this instance only, not the bsp
            //parameters: luxels is the lightmap data from the textbox,
            //mode is the rgbe settings(to edit only specific colors)
        {
            for (int i = 0; i < (LightmapTextureLength * LightmapTextureWidth); i++)
            {
                if (ldr)
                    lightmapLDR[i / LightmapTextureLength, i % LightmapTextureLength].updateLuxel(luxels[i].Split(':'));
                else
                    lightmapHDR[i / LightmapTextureLength, i % LightmapTextureLength].updateLuxel(luxels[i].Split(':'));
            }
        }*/

        public void randoLightmaps(Random rand)
            //randomizes the lightmap for this face
        {
            retrieveLightmap();
            for (int i = 0; i < LightmapTextureLength; i++)
            {
                for (int j = 0; j < LightmapTextureWidth; j++)
                {
                    lightmapLDR[j, i].randomRGB(rand);
                    lightmapHDR[j, i].randomRGB(rand);
                }
            }
        }
    }
}
