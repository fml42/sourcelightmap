using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Reflection;

namespace VRADFix
{
    public partial class Main : Form
    {
        const int LUXEL_DISP_SIZE = 16;
        
        Bsp map;
        Dface_t surface;

        int selectedX, selectedY;

        public Main()
        {
            InitializeComponent();
            labelRGB.Text = "";
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            luxelsCanvas, new object[] { true });
        }

        private void buttonBrowseBsp_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBoxBsp.Text = openFileDialog1.FileName;
                buttonLoad.Enabled = true;
                textBoxFaceID.Enabled = true;
                textBoxFaceID.Clear();
            }
                
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (map != null)
            {
                map.file.Close();
            }

            try
            {
                FileInfo file = new FileInfo(textBoxBsp.Text);
                map = new Bsp(new FileInfo(textBoxBsp.Text));
                if (!map.valid)
                {
                    buttonUnload_Click(null, new EventArgs());
                    return;
                }
                
                //checks if there's data either for ldr or hdr lightmaps
                if (!map.LDR && !map.HDR)
                {
                    MessageBox.Show("VRAD must be run first on this BSP file!");
                    buttonUnload_Click(null, new EventArgs());
                }
                else
                {
                    //enables/disable available options for ldr/hdr
                    if (map.LDR)
                        radioButtonLDR.Enabled = true;
                    else
                    {
                        radioButtonLDR.Enabled = false;
                        radioButtonLDR.Checked = false;
                        radioButtonHDR.Checked = true;
                    }
                    if (map.HDR)
                        radioButtonHDR.Enabled = true;
                    else
                    {
                        radioButtonHDR.Enabled = false;
                        radioButtonHDR.Checked = false;
                        radioButtonLDR.Checked = true;
                    }
                    //fetchs the face, displays data and locks controls while editing
                    ushort planenum = ushort.Parse(textBoxFaceID.Text);
                    int numPlanes = map.offsets[7].Value / Dface_t.classLength;
                    if (planenum >= numPlanes)
                    {
                        MessageBox.Show("The faceID you entered is too big"); //if we were to use this offset into lump 7 we would exceed it
                        buttonUnload_Click(null, new EventArgs());
                        return;
                    }
                    surface = new Dface_t(planenum, map);

                    selectedX = 0;
                    selectedY = 0;
                    
                    updateLightmapViewer();

                    textBoxBsp.ReadOnly = true;
                    textBoxFaceID.ReadOnly = true;
                    buttonBrowseBsp.Enabled = false;
                    buttonLoad.Enabled = false;
                    buttonUnload.Enabled = true;
                    buttonUpdate.Enabled = true;
                    
                    spinnerR.Enabled = true;
                    spinnerG.Enabled = true;
                    spinnerB.Enabled = true;
                    spinnerE.Enabled = true;

                    if (checkBoxOverexp.Checked)
                    {
                        timer1.Start();
                        overexposedHighlight = true;
                    }
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("You must choose a bsp", "Error", MessageBoxButtons.OK);
            }
            catch (/*FormatException*/ Exception)
            {
                MessageBox.Show("You must enter a faceID\n\nLoad your map in-game and use the command \"mat_surfaceid 2\" to display faceIDs.\n\"mat_wireframe 3\" is also useful to see face divisions.", "Error", MessageBoxButtons.OK);
            }
        }

        private void buttonUnload_Click(object sender, EventArgs e)
        {
            //unlocks the input fields to receive a new request
            surface = null;
            updateLightmapViewer();

            textBoxBsp.ReadOnly = false;
            textBoxFaceID.ReadOnly = false;
            buttonBrowseBsp.Enabled = true;
            buttonLoad.Enabled = true;
            radioButtonHDR.Enabled = true;
            radioButtonLDR.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonUnload.Enabled = false;

            spinnerR.Value = 0;
            spinnerR.Enabled = false;
            spinnerG.Value = 0;
            spinnerG.Enabled = false;
            spinnerB.Value = 0;
            spinnerB.Enabled = false;
            spinnerE.Value = 0;
            spinnerE.Enabled = false;
            labelRGB.Text = "";

            timer1.Stop();

            map.file.Close();
        }

        private void updateLightmapViewer()
        {
            luxelsCanvas.Refresh();

            if (surface != null && selectedX >= 0 && selectedX < surface.LightmapTextureWidth
                && selectedY >= 0 && selectedY < surface.LightmapTextureLength)
            {
                ColorRGBExp32 luxel = getLuxel(selectedX, selectedY);
                spinnerR.Value = luxel.r;
                spinnerG.Value = luxel.g;
                spinnerB.Value = luxel.b;
                spinnerE.Value = luxel.e;

                double exp = Math.Pow(2, luxel.e);
                int rgbR = (int)(luxel.r * exp);
                int rgbG = (int)(luxel.g * exp);
                int rgbB = (int)(luxel.b * exp);

                labelRGB.Text = "RGB: "+rgbR+" "+rgbG+" "+rgbB;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //this method updates the bsp
            if (map != null)
            {
                //updates the model
                //surface.updateLightmap(richTextBox1.Text.Replace("\t", String.Empty).Split(';'), radioButtonLDR.Checked);
                //writes the updated model
                surface.writeLightmap();
                //updates the data in the UI with the new data from the bsp (useless, same data then before. but it reformats things)
                updateLightmapViewer();
            }
        }

        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            //this method is not accessible from the UI. It randomizes all lightmaps in a given bsp. (this power is too great to be handled by mere mortals)
            if (map != null)
            {
                map.file.Close();
            }
            map = new Bsp(new FileInfo(textBoxBsp.Text));
            surface.randoLightmaps(new Random());
        }
        

        //probably should merge these methods
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (map != null)
            {
                updateLightmapViewer();

            }
        }

        private bool overexposedHighlight = false;

        private void luxelsCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (surface != null)
            {
                
                int lSize = LUXEL_DISP_SIZE;

                luxelsCanvas.Size = new Size(surface.LightmapTextureWidth * lSize, surface.LightmapTextureLength * lSize);
                SolidBrush b = new SolidBrush(Color.Black);
                Pen p = new Pen(Color.Black);

                //this methods gathers the data from the bsp and displays it in the main window
                ColorRGBExp32 luxel;

                double s = 1;
                if (checkBoxAdjustColors.Checked)
                {
                    if (radioButton_expAuto.Checked)
                    {
                        s = findColorScaling();
                    }
                    if (radioButton_expManual.Checked)
                    {
                        s = Math.Pow(2, Convert.ToDouble(manualExposure.Value));
                    }
                }


                for (int y = 0; y < surface.LightmapTextureLength; y++)
                {
                    for (int x = 0; x < surface.LightmapTextureWidth; x++)
                    {
                        luxel = getLuxel(x,y);

                        double exp = Math.Pow(2, luxel.e);
                        int rgbR = (int) (luxel.r * exp * s);
                        int rgbG = (int) (luxel.g * exp * s);
                        int rgbB = (int) (luxel.b * exp * s);

                        if (rgbR < 0) rgbR = 0; //in case 2^e is so huge it wraps back around lol
                        if (rgbG < 0) rgbG = 0;
                        if (rgbB < 0) rgbB = 0;
                        bool overexposed = false;
                        if (rgbR > 255)
                        {
                            overexposed = true;
                            rgbR = 255;
                        }
                        if (rgbG > 255)
                        {
                            overexposed = true;
                            rgbG = 255;
                        }
                        if (rgbB > 255)
                        {
                            overexposed = true;
                            rgbB = 255;
                        }

                        if (overexposed && overexposedHighlight && checkBoxOverexp.Checked)
                        {
                            b.Color = Color.FromArgb(255-rgbR, 255 - rgbG, 255 - rgbB);

                        } else
                        {
                            b.Color = Color.FromArgb(rgbR, rgbG, rgbB);
                        }
                        g.FillRectangle(b, x * lSize, y * lSize, lSize, lSize);

                        if (x == selectedX && y == selectedY)
                        {
                            g.DrawRectangle(p, x * lSize, y * lSize, lSize-1, lSize-1);
                            p.Color = Color.Yellow;
                            g.DrawRectangle(p, x * lSize+1, y * lSize+1, lSize - 3, lSize - 3);
                        }
                    }
                    //richTextBox1.Text += "\n";
                }

                b.Dispose();
                p.Dispose();
            } else
            {
                luxelsCanvas.Size = new Size(10,10);
                g.Clear(Color.FromKnownColor(KnownColor.Control));
            }

            
        }

        private double findColorScaling()
        {
            double brightest = 0;
            ColorRGBExp32 luxel;
            for (int y = 0; y < surface.LightmapTextureLength; y++)
            {
                for (int x = 0; x < surface.LightmapTextureWidth; x++)
                {
                    luxel = getLuxel(x, y);

                    double exp = Math.Pow(2, luxel.e);
                    double r = luxel.r * exp;
                    double g = luxel.g * exp;
                    double b = luxel.b * exp;
                    if (r > brightest) brightest = r;
                    if (g > brightest) brightest = g;
                    if (b > brightest) brightest = b;
                }
            }
            return 255 / brightest;
        }


        private ColorRGBExp32 getLuxel(int x, int y)
        {
            if (radioButtonLDR.Checked)
                return surface.lightmapLDR[x, y];
            else
                return surface.lightmapHDR[x, y];
        }
        

        private void spinner_ValueChanged(object sender, EventArgs e)
        {
            if (surface != null && selectedX >= 0 && selectedX < surface.LightmapTextureWidth
               && selectedY >= 0 && selectedY < surface.LightmapTextureLength)
            {
                if (radioButtonLDR.Checked)
                {
                    if (sender == spinnerR) surface.lightmapLDR[selectedX, selectedY].r = Convert.ToByte(spinnerR.Value);
                    if (sender == spinnerG) surface.lightmapLDR[selectedX, selectedY].g = Convert.ToByte(spinnerG.Value);
                    if (sender == spinnerB) surface.lightmapLDR[selectedX, selectedY].b = Convert.ToByte(spinnerB.Value);
                    if (sender == spinnerE) surface.lightmapLDR[selectedX, selectedY].e = Convert.ToSByte(spinnerE.Value);
                }
                else
                {
                    if (sender == spinnerR) surface.lightmapHDR[selectedX, selectedY].r = Convert.ToByte(spinnerR.Value);
                    if (sender == spinnerG) surface.lightmapHDR[selectedX, selectedY].g = Convert.ToByte(spinnerG.Value);
                    if (sender == spinnerB) surface.lightmapHDR[selectedX, selectedY].b = Convert.ToByte(spinnerB.Value);
                    if (sender == spinnerE) surface.lightmapHDR[selectedX, selectedY].e = Convert.ToSByte(spinnerE.Value);
                }
            }

            updateLightmapViewer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            overexposedHighlight = !overexposedHighlight;
            luxelsCanvas.Refresh();
        }

        private void checkBoxOverexp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOverexp.Checked)
            {
                timer1.Start();
                overexposedHighlight = true;
            } else
            {
                timer1.Stop();
                overexposedHighlight = false;
            }
            luxelsCanvas.Refresh();
        }

        private void checkBoxAdjustColors_CheckedChanged(object sender, EventArgs e)
        {
            luxelsCanvas.Refresh();

            radioButton_expAuto.Enabled = checkBoxAdjustColors.Checked;
            radioButton_expManual.Enabled = checkBoxAdjustColors.Checked;
            manualExposure.Enabled = checkBoxAdjustColors.Checked && !radioButton_expAuto.Checked;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            luxelsCanvas.Refresh();
        }

        private void radioButton_exp_CheckedChanged(object sender, EventArgs e)
        {
            luxelsCanvas.Refresh();
            manualExposure.Enabled = !radioButton_expAuto.Checked;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = Program.APP_TITLE + " v" + Program.APP_VERSION;
        }

        private void luxelsCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            selectedX = e.X / LUXEL_DISP_SIZE;
            selectedY = e.Y / LUXEL_DISP_SIZE;
            if (e.Button == MouseButtons.Right)
            {
                surface.lightmapLDR[selectedX, selectedY].r = Convert.ToByte(spinnerR.Value);
                surface.lightmapLDR[selectedX, selectedY].g = Convert.ToByte(spinnerG.Value);
                surface.lightmapLDR[selectedX, selectedY].b = Convert.ToByte(spinnerB.Value);
                surface.lightmapLDR[selectedX, selectedY].e = Convert.ToSByte(spinnerE.Value);
            }
            updateLightmapViewer();
            
        }
            
        

        /*private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You must enter a faceID\n\nLoad your map and use the command \"mat_surfaceid 2\" to display faceIDs.\n\"mat_wireframe 3\" is also useful to see face divisions", "Information", MessageBoxButtons.OK);
        }*/
    }
}
