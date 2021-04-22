using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace G_API_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const string DLLPath = "dlls\\GApiWrapper_internal.dll";
        [DllImport(DLLPath, EntryPoint = "G_Common_OpenInterface", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        private static extern int G_Common_OpenInterface(string interfaceName, uint portHandle);

        uint porthandle;
        int rc;
        private void button1_Click(object sender, EventArgs e)
        {
             rc = G_Common_OpenInterface("CAN1", porthandle);
            textBox1.Text = rc.ToString();
        }
    }
}
