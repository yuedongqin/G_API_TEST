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
using GApiWrapper;

namespace G_API_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //const string DLLPath = "D:\\NEXT\\G_API_Test\\dlls\\GApiWrapper_internal.dll";
        //[DllImport(DLLPath, EntryPoint = "G_Common_OpenInterface", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        //private static extern int G_Common_OpenInterface(string interfaceName, uint portHandle);
        //InterfaceInfo interfaceInfo = new InterfaceInfo();
        G_Api.InterfaceInfo interfaceInfo = new G_Api.InterfaceInfo();
        uint porthandle;
        int rc;
        private void button1_Click(object sender, EventArgs e)
        {
            // rc = G_Common_OpenInterface("CAN1", porthandle);
            //textBox1.Text = rc.ToString();
            interfaceInfo.HostInterfaceType = G_Api.HostInterfaceType.basicCAN;
            interfaceInfo.ControllerNumber = 1;
            interfaceInfo.InterfaceNumber = 1;
            interfaceInfo.Flags = G_Api.InterfaceInfo_Flags.NONE;
            interfaceInfo.CardNumber = 1;

            G_Api.OpenInterface(G_Api.OpenInterface_CmdFlags.NONE, interfaceInfo, out porthandle);
            textBox1.Text = porthandle.ToString();
        }
    }

    //class InterfaceInfo
    //{
    //    public G_Api.HostInterfaceType HostInterfaceType;
    //    public byte ControllerNumber;
    //    public byte InterfaceNumber;
    //    public G_Api.InterfaceInfo_Flags Flags;
    //    public uint CardNumber;
    //    public ushort TcpPort;
    //    public uint IpAddress;
    //    public byte PortNumber;
    //    public int num;
    //}

}
