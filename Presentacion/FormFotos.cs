using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class FormFotos : Form
    {
        public string Path = "C:\\Users\\BRAYAN\\Desktop\\Proyectos C#\\Capa de Presentacion\\TomarFotos\\Presentacion\\Path";
        private bool HayDispositivos;
        public FilterInfoCollection MisDispositivos;
        public VideoCaptureDevice MiWebCam;

        public FormFotos()
        {
            InitializeComponent();
        }

        private void FormFotos_Load(object sender, EventArgs e)
        {
            CargarDispositivos();
        }

        public void CargarDispositivos()
        {
            MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MisDispositivos.Count > 0)
            {
                HayDispositivos = true;
                for (int i = 0; i < MisDispositivos.Count; i++)
                {
                    comboBox1.Items.Add(MisDispositivos[i].Name.ToString());
                    comboBox1.Text = MisDispositivos[0].Name.ToString();
                }
            }
            else
            {
                HayDispositivos = false;
            }
        }

        public void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = imagen;
        }

        private void CerrarWebCam()
        {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                MiWebCam.SignalToStop();
                MiWebCam = null;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            CerrarWebCam();
            int i = comboBox1.SelectedIndex;
            string NombreVideo = MisDispositivos[i].MonikerString;
            MiWebCam = new VideoCaptureDevice(NombreVideo);
            MiWebCam.NewFrame += new NewFrameEventHandler(Capturando);
            MiWebCam.Start();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                pictureBox2.Image = pictureBox1.Image;
                pictureBox2.Image.Save(Path + "imagen.jpg", ImageFormat.Jpeg);
            }
        }

        private void FormFotos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            FormInventario formInventario = new FormInventario();
            formInventario.ShowDialog();
        }
    }
}
