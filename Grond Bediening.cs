using Kvaser.CanLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Kvaser.CanLib.Canlib;

namespace E300
{
    public partial class Grond_Bediening : Form
    {
        private string scriptPath = Properties.Settings.Default.Gscript;
        private canStatus status;
        private int envvar_size;
        private int envvar_type;
        private int chanHandle = 0;
        private int slot = 0;
        private Color aan = Color.Green;
        private Color uit = Color.White;
        bool isConnected = false;
        String[] ports;
        private string[] checkPin = new string[19] { "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none" };
        private readonly string[] serWaarde = Globaal.serWaarde;
        private readonly string[] pinnen = Globaal.pinnen;
        private readonly string[] rr = Globaal.stat;
        private readonly int ok = Globaal.ok;
        private readonly int notok = Globaal.notok;


        private bool p1d = false;
        private bool p1u = false;
        private bool p2r = false;
        private bool p2l = false;
        private bool p3d = false;
        private bool p3u = false;
        private bool p4r = false;
        private bool p4l = false;
        private bool p5d = false;
        private bool p5u = false;
        private bool p6d = false;
        private bool p6u = false;
        private bool p7r = false;
        private bool p7l = false;

        private void indicator(Button knop , string msg)
        {
            if(msg == rr[ok])
            {
                knop.BackColor = Color.Green;
            }
            else if(msg == rr[notok])
            {
                knop.BackColor = Color.Red;
            }
            else
            {
                knop.BackColor = Color.White;
            }
        }

        private void lezen()
        {
            string data = serialPort1.ReadExisting();
            string[] sub = data.Split('.');
            switch (Globaal.getCheckPin(sub[0]))
            {
                case 0:
                    checkPin[0] = sub[1];
                    indicator(btnJ3_P1, sub[1]);
                    break;
                case 1:
                    checkPin[1] = sub[1];
                    indicator(btnJ1_P8, sub[1]);
                    break;
                case 2:
                    checkPin[2] = sub[1];
                    indicator(btnJ1_P10, sub[1]);
                    break;
                case 3:
                    checkPin[3] = sub[1];
                    indicator(btnJ1_P11, sub[1]);
                    break;
                case 4:
                    checkPin[4] = sub[1];
                    indicator(btnJ2_P5, sub[1]);
                    break;
                case 5:
                    checkPin[5] = sub[1];
                    indicator(btnJ3_P3, sub[1]);
                    break;
                case 6:
                    checkPin[6] = sub[1];
                    indicator(btnJ7_P14, sub[1]);
                    break;
                case 7:
                    checkPin[7] = sub[1];
                    indicator(btnJ1_P4, sub[1]);
                    break;
                case 8:
                    checkPin[8] = sub[1];
                    indicator(btnJ1_P6, sub[1]);
                    break;
                case 9:
                    checkPin[9] = sub[1];
                    indicator(btnJ1_P7, sub[1]);
                    break;
                case 10:
                    checkPin[10] = sub[1];
                    indicator(btnJ7_P15, sub[1]);
                    break;
                case 11:
                    checkPin[11] = sub[1];
                    indicator(btnJ7_P4, sub[1]);
                    break;
                case 12:
                    checkPin[12] = sub[1];
                    indicator(btnJ7_P5, sub[1]);
                    break;
                case 13:
                    checkPin[13] = sub[1];
                    indicator(btnJ7_P6, sub[1]);
                    break;
                case 14:
                    checkPin[14] = sub[1];
                    indicator(btnJ7_P10, sub[1]);
                    break;
                case 15:
                    checkPin[15] = sub[1];
                    indicator(btnJ1_P5, sub[1]);
                    break;
                case 16:
                    checkPin[16] = sub[1];
                    indicator(btnJ2_P2, sub[1]);
                    break;
                case 17:
                    checkPin[17] = sub[1];
                    indicator(btnJ2_P3, sub[1]);
                    break;
                case 18:
                    checkPin[18] = sub[1];
                    indicator(btnJ2_P1, sub[1]);
                    break;
            }
        }

        private void getAvailableComPorts()
        {
            serialPort1.BaudRate = 500000;
            ports = SerialPort.GetPortNames();
            btnCon.Text = "Connect";
            foreach (string port in ports)
            {
                cbCom.Items.Add(port);
                if (ports[0] != null)
                {
                    cbCom.SelectedItem = ports[0];
                }
            }
        }

        private void connectToArduino()
        {
            isConnected = true;
            serialPort1.PortName = cbCom.GetItemText(cbCom.SelectedItem);
            serialPort1.Open();
            btnCon.Text = "Disconnect";
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            serialPort1.Close();
            btnCon.Text = "Connect";
        }

        private void initCanBus()
        {
            Canlib.canInitializeLibrary();
            chanHandle = Canlib.canOpenChannel(chanHandle, Canlib.canOPEN_ACCEPT_VIRTUAL);
            status = Canlib.canSetBusParams(chanHandle, Canlib.canBITRATE_50K, 0, 0, 0, 0);
            printInTextBox("Set canbus param: " + status);
            status = Canlib.canBusOn(chanHandle);
            printInTextBox("Canbus on: " + status);
        }

        private void disableKnoppen()
        {
            btnP1D.Enabled = false;
            btnP1U.Enabled = false;
            btnP2R.Enabled = false;
            btnP2L.Enabled = false;
            btnP3D.Enabled = false;
            btnP3U.Enabled = false;
            btnP4R.Enabled = false;
            btnP4L.Enabled = false;
            btnP5D.Enabled = false;
            btnP5U.Enabled = false;
            btnP6D.Enabled = false;
            btnP6U.Enabled = false;
            btnP7R.Enabled = false;
            btnP7L.Enabled = false;
        }

        private void enableKnoppen()
        {
            btnP1D.Enabled = true;
            btnP1U.Enabled = true;
            btnP2R.Enabled = true;
            btnP2L.Enabled = true;
            btnP3D.Enabled = true;
            btnP3U.Enabled = true;
            btnP4R.Enabled = true;
            btnP4L.Enabled = true;
            btnP5D.Enabled = true;
            btnP5U.Enabled = true;
            btnP6D.Enabled = true;
            btnP6U.Enabled = true;
            btnP7R.Enabled = true;
            btnP7L.Enabled = true;
        }

        private void startScript()
        {
            status = kvScriptLoadFile(chanHandle, slot, scriptPath);
            printInTextBox("Loading script: " + status);
            status = kvScriptStart(chanHandle, slot);
            printInTextBox("Script start: " + status);
            status = kvScriptStatus(chanHandle, slot, out int o);
            printInTextBox("Script status: " + status + " - " + o);
        }

        private void stop()
        {
            status = kvScriptStop(chanHandle, slot, kvSCRIPT_STOP_NORMAL);
            printInTextBox("Script stop: " + status);
            status = kvScriptUnload(chanHandle, slot);
            printInTextBox("Script unload: " + status);
            printInTextBox("Powermodule powerd off");
            serialPort1.Write("0");
        }

        private long knop(string id)
        {
            long knop = Canlib.kvScriptEnvvarOpen(chanHandle, id, out envvar_type, out envvar_size);
            return knop;
        }

        private void printInTextBox(string massage)
        {
            tbStatus.Text += "\r\n" + massage;
            tbRun.Text = massage;
        }

        public Grond_Bediening()
        {
            InitializeComponent();
        }

        private void Grond_Bediening_Load(object sender, EventArgs e)
        {
            getAvailableComPorts();
            btnStart.Enabled = false;
            btnStop.Enabled = false;
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                disconnectFromArduino();
                isConnected = false;
                btnStart.Enabled = false;
                btnStop.Enabled = false;
            }
            else
            {
                connectToArduino();
                isConnected = true;
                btnStop.Enabled = true;
                btnStart.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                serialPort1.Write("3");
                initCanBus();
                startScript();
                enableKnoppen();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            disableKnoppen();
            stop();
        }

        private void btnP1D_Click(object sender, EventArgs e)
        {
            p1d = !p1d;
            if (p1d)
            {
                disableKnoppen();
                btnP1D.Enabled = true;
                btnP1D.BackColor = aan;
                status = kvScriptEnvvarSetInt(knop("C658D1"), 64);
            }
            else
            {
                enableKnoppen();
                btnP1D.BackColor = uit;
                status = kvScriptEnvvarSetInt(knop("C658D1"), 0);
            }
        }

        private void btnP1U_Click(object sender, EventArgs e)
        {
            p1u = !p1u;
            if (p1u)
            {
                disableKnoppen();
                btnP1U.Enabled = true;
                btnP1U.BackColor = aan;
                status = kvScriptEnvvarSetInt(knop("C658D0"), 200);
            }
            else
            {
                enableKnoppen();
                btnP1U.BackColor = uit;
                status = kvScriptEnvvarSetInt(knop("C658D0"), 192);
            }
        }

        private void btnP2R_Click(object sender, EventArgs e)
        {
            p2r = !p2r;
            if (p2r)
            {
                disableKnoppen();
                btnP2R.Enabled = true;
                btnP2R.BackColor = aan;
                status = kvScriptEnvvarSetInt(knop("C658D1"), 8);
            }
            else
            {
                enableKnoppen();
                btnP2R.BackColor = uit;
                status = kvScriptEnvvarSetInt(knop("C658D1"), 0);
            }
        }

        private void btnP2L_Click(object sender, EventArgs e)
        {
            p2l = !p2l;
            if (p2l)
            {
                disableKnoppen();
                btnP2L.Enabled = true;
                btnP2L.BackColor = aan;
                status = kvScriptEnvvarSetInt(knop("C658D1"), 128);
            }
            else
            {
                enableKnoppen();
                btnP2L.BackColor = uit;
                status = kvScriptEnvvarSetInt(knop("C658D1"), 0);
            }
        }

        private void btnP3D_Click(object sender, EventArgs e)
        {
            p3d = !p3d;
            if (p3d)
            {
                disableKnoppen();
                btnP3D.Enabled = true;
                btnP3D.BackColor = aan;
                status = kvScriptEnvvarSetInt(knop("C658D2"), 64);
            }
            else
            {
                enableKnoppen();
                btnP3D.BackColor = uit;
                status = kvScriptEnvvarSetInt(knop("C658D2"), 0);
            }
        }

        private void btnP3U_Click(object sender, EventArgs e)
        {
            p3u = !p3u;
            if (p3u)
            {
                disableKnoppen();
                btnP3U.Enabled = true;
                btnP3U.BackColor = aan;
                status = kvScriptEnvvarSetInt(knop("C658D0"), 193);
            }
            else
            {
                enableKnoppen();
                btnP3U.BackColor = uit;
                status = kvScriptEnvvarSetInt(knop("C658D0"), 192);
            }
        }

        private void btnP4R_Click(object sender, EventArgs e)
        {
            p4r = !p4r;
            if (p4r)
            {
                disableKnoppen();
                btnP4R.Enabled = true;
                btnP4R.BackColor = aan;
                status = kvScriptEnvvarSetInt(knop("C658D0"), 194);
            }
            else
            {
                enableKnoppen();
                btnP4R.BackColor = uit;
                status = kvScriptEnvvarSetInt(knop("C658D0"), 192);
            }
        }

        private void btnP4L_Click(object sender, EventArgs e)
        {
            p4l = !p4l;
            if (p4l)
            {
                disableKnoppen();
                btnP4L.Enabled = true;
                btnP4L.BackColor = aan;
                status = kvScriptEnvvarSetInt(knop("C658D1"), 4);
            }
            else
            {
                enableKnoppen();
                btnP4L.BackColor = uit;
                status = kvScriptEnvvarSetInt(knop("C658D1"), 0);
            }
        }

        private void btnP5D_Click(object sender, EventArgs e)
        {
            p5d = !p5d;
            var knopD0 = Canlib.kvScriptEnvvarOpen(chanHandle, "C658D0", out envvar_type, out envvar_size);
            if (p5d)
            {
                disableKnoppen();
                btnP5D.Enabled = true;
                btnP5D.BackColor = aan;
                status = kvScriptEnvvarSetInt(knop("C658D0"), 208);
            }
            else
            {
                enableKnoppen();
                btnP5D.BackColor = uit;
                status = kvScriptEnvvarSetInt(knop("C658D0"), 192);
            }
        }

        private void btnP5U_Click(object sender, EventArgs e)
        {
            p5u = !p5u;
            if (p5u)
            {
                disableKnoppen();
                btnP5U.Enabled = true;
                btnP5U.BackColor = aan;
                status = kvScriptEnvvarSetInt(knop("C658D1"), 2);
            }
            else
            {
                enableKnoppen();
                btnP5U.BackColor = uit;
                status = kvScriptEnvvarSetInt(knop("C658D1"), 0);
            }
        }

        private void btnP6D_Click(object sender, EventArgs e)
        {
            p6d = !p6d;
            if (p6d)
            {
                disableKnoppen();
                btnP6D.Enabled = true;
                btnP6D.BackColor = aan;
                status = kvScriptEnvvarSetInt(knop("C658D1"), 16);
            }
            else
            {
                enableKnoppen();
                btnP6D.BackColor = uit;
                status = kvScriptEnvvarSetInt(knop("C658D1"), 0);
            }
        }

        private void btnP6U_Click(object sender, EventArgs e)
        {
            p6u = !p6u;
            if (p6u)
            {
                disableKnoppen();
                btnP6U.Enabled = true;
                btnP6U.BackColor = aan;
                status = kvScriptEnvvarSetInt(knop("C658D0"), 224);
            }
            else
            {
                enableKnoppen();
                btnP6U.BackColor = uit;
                status = kvScriptEnvvarSetInt(knop("C658D0"), 0);
            }
        }

        private void btnP7R_Click(object sender, EventArgs e)
        {
            p7r = !p7r;
            if (p7r)
            {
                disableKnoppen();
                btnP7R.Enabled = true;
                btnP7R.BackColor = aan;
                status = kvScriptEnvvarSetInt(knop("C658D1"), 1);
            }
            else
            {
                enableKnoppen();
                btnP7R.BackColor = uit;
                status = kvScriptEnvvarSetInt(knop("C658D1"), 0);
            }
        }

        private void btnP7L_Click(object sender, EventArgs e)
        {
            p7l = !p7l;
            if (p7l)
            {
                disableKnoppen();
                btnP7L.Enabled = true;
                btnP7L.BackColor = aan;
                status = kvScriptEnvvarSetInt(knop("C658D1"), 32);
            }
            else
            {
                enableKnoppen();
                btnP7L.BackColor = uit;
                status = kvScriptEnvvarSetInt(knop("C658D1"), 0);
            }
        }

        private void btnJ1_P8_Click(object sender, EventArgs e)
        {
            serialPort1.Write("b");
        }

        private void btnJ1_P10_Click(object sender, EventArgs e)
        {
            serialPort1.Write("c");
        }

        private void btnJ1_P11_Click(object sender, EventArgs e)
        {
            serialPort1.Write("d");
        }

        private void btnJ2_P5_Click(object sender, EventArgs e)
        {
            serialPort1.Write("e");
        }

        private void btnJ3_P3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("f");
        }

        private void btnJ7_P14_Click(object sender, EventArgs e)
        {
            serialPort1.Write("g");
        }

        private void btnJ1_P4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("h");
        }

        private void btnJ1_P6_Click(object sender, EventArgs e)
        {
            serialPort1.Write("i");
        }

        private void btnJ1_P7_Click(object sender, EventArgs e)
        {
            serialPort1.Write("j");
        }

        private void btnJ7_P15_Click(object sender, EventArgs e)
        {
            serialPort1.Write("k");
        }

        private void btnJ3_P1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("a");
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            lezen();
        }

        private async void btnGrounds_Click(object sender, EventArgs e)
        {
            btnGrounds.Enabled = false;
            for (int i = 1; i < 7; i++)
            {
                serialPort1.Write(serWaarde[i]);
                await Task.Delay(500);
                printInTextBox("Grondpin: " + pinnen[i] + " - " + checkPin[i]);
            }
            btnGrounds.Enabled = true;
        }

        private async void btn12V_Click(object sender, EventArgs e)
        {
            btn12V.Enabled = false;
            for (int i = 7; i < 11; i++)
            {
                serialPort1.Write(serWaarde[i]);
                await Task.Delay(500);
                printInTextBox("Grondpin: " + pinnen[i] + " - " + checkPin[i]);
            }
            btn12V.Enabled = true;
        }

        private async void btn5V_Click(object sender, EventArgs e)
        {
            btn5V.Enabled = false;
            serialPort1.Write(serWaarde[0]);
            await Task.Delay(500);
            printInTextBox("Grondpin: " + pinnen[0] + " - " + checkPin[0]);
            btn5V.Enabled = true;
        }

        private void btnJ2_P1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("s");
        }
    }
}
