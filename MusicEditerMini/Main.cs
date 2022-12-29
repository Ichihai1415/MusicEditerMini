using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicEditerMini
{
    public partial class MEM : Form
    {
        public MEM()
        {
            InitializeComponent();
        }

        private void MEM_Load(object sender, EventArgs e)
        {
           if(!File.Exists("ffmpeg.exe"))
            {


            }
        }
    }
}
