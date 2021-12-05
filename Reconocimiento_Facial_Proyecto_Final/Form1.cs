using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace Reconocimiento_Facial_Proyecto_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FaceRec faceRec = new FaceRec();
        private void btnAbrircamara_Click(object sender, EventArgs e)
        {
            faceRec.openCamera(pictureBox1, pictureBox2);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            faceRec.getPersonName(txtNombre);
            faceRec.Save_IMAGE(txtNombre.Text);
            MessageBox.Show("Muy bien " + txtNombre.Text + ", Guardado exitoso.");
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            faceRec.isTrained = true;
        }
    }
}
