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
    public partial class Platform_Bediening : Form
    {
        private string scriptPath = Properties.Settings.Default.Pscript;
        private string[] checkPin = new string[20] { "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "error" };
        private readonly string[] serWaarde = Globaal.serWaarde;
        private readonly string[] pinnen = Globaal.pinnen;
        private readonly string[] rr = Globaal.stat;
        private readonly int ok = Globaal.ok;
        private readonly int notok = Globaal.notok;
        private canStatus status;
        private int envvar_size;
        private int envvar_type;
        private int chanHandle = 0;
        private readonly int slot = 0;
        private readonly Color aan = Color.Green;
        private readonly Color uit = Color.White;
        bool isConnected = false;
        String[] ports;
        private int pot = 30;
        private bool pVoet = false;

        private void indicator(Button knop, string msg)
        {
            
            if (msg == rr[ok])
            {
                knop.BackColor = Color.Green;
            }
            else if (msg == rr[notok])
            {
                knop.BackColor = Color.Red;
            }
            else
            {
                knop.BackColor = Color.White;
            }
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

        private void startScript()
        {
            status = kvScriptLoadFile(chanHandle, slot, scriptPath);
            printInTextBox("Loading script: " + status);
            status = kvScriptStart(chanHandle, slot);
            printInTextBox("Script start: " + status);
            status = kvScriptStatus(chanHandle, slot, out int o);
            printInTextBox("Script status: " + status + " - " + o);
        }

        private void btnUit()
        {
            btnP1D.BackColor = uit;
            btnP1U.BackColor = uit;
            btnP2D.BackColor = uit;
            btnP2U.BackColor = uit;
            btnP3D.BackColor = uit;
            btnP3U.BackColor = uit;
            btnP4D.BackColor = uit;
            btnP4U.BackColor = uit;
            btnY1D.BackColor = uit;
            btnY1U.BackColor = uit;
            btnY2R.BackColor = uit;
            btnY2L.BackColor = uit;
        }

        private void btnEn()
        {
            btnP1D.Enabled = true;
            btnP1U.Enabled = true;
            btnP2D.Enabled = true;
            btnP2U.Enabled = true;
            btnP3D.Enabled = true;
            btnP3U.Enabled = true;
            btnP4D.Enabled = true;
            btnP4U.Enabled = true;
            btnY1U.Enabled = true;
            btnY1D.Enabled = true;
            btnY2L.Enabled = true;
            btnY2R.Enabled = true;

        }

        private void btnDn()
        {
            btnP1D.Enabled = false;
            btnP1U.Enabled = false;
            btnP2D.Enabled = false;
            btnP2U.Enabled = false;
            btnP3D.Enabled = false;
            btnP3U.Enabled = false;
            btnP4D.Enabled = false;
            btnP4U.Enabled = false;
            btnY1U.Enabled = false;
            btnY1D.Enabled = false;
            btnY2L.Enabled = false;
            btnY2R.Enabled = false;
        }

        private void initPot()
        {
            trSnelheid.Maximum = 170;
            trSnelheid.Minimum = 30;
            trSnelheid.Value = pot;
            trSnelheid.SmallChange = 5;
            trSnelheid.LargeChange = 10;
            tbarLinks.Maximum = 128;
            tbarLinks.Minimum = 0;
            tbarLinks.Value = 128;
            tbarLinks.SmallChange = 5;
            tbarLinks.LargeChange = 10;
            tbarRechts.Maximum = 255;
            tbarRechts.Minimum = 128;
            tbarRechts.Value = 128;
            tbarRechts.SmallChange = 2;
            tbarRechts.LargeChange = 10;
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

        private void disconnectFromArduino()
        {
            isConnected = false;
            serialPort1.Close();
            serialPort1.Close();
            btnCon.Text = "Connect";
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

        public Platform_Bediening()
        {
            InitializeComponent();
        }

        private void Platform_Bediening_Load(object sender, EventArgs e)
        {
            getAvailableComPorts();
            btnDn();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                disconnectFromArduino();
                btnDn();
            }
            else
            {
                connectToArduino();
                btnEn();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            initPot();
            initCanBus();
            startScript();
            serialPort1.Write("4");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void btnVoet_Click(object sender, EventArgs e)
        {
            pVoet = !pVoet;
            if (pVoet)
            {
                btnEn();
                btnUit();
                btnVoet.BackColor = aan;
                status = kvScriptEnvvarSetInt(knop("C650D0"), 1);
                status = kvScriptEnvvarSetInt(knop("C650D1"), 8);
                status = kvScriptEnvvarSetInt(knop("C650D2"), 0);


                if (isConnected)
                    serialPort1.Write("2");
            }
            else
            {
                status = kvScriptEnvvarSetInt(knop("C649D0"), 128);
                status = kvScriptEnvvarSetInt(knop("C649D2"), 129);
                serialPort1.Write("7");
                if (isConnected)
                    serialPort1.Write("1");
                btnDn();
                btnUit();
                btnVoet.BackColor = uit;
                status = kvScriptEnvvarSetInt(knop("C650D0"), 1);
                status = kvScriptEnvvarSetInt(knop("C650D1"), 8);
                status = kvScriptEnvvarSetInt(knop("C650D2"), 2);
            }
        }

        private void btnP1D_Click(object sender, EventArgs e)
        {
            btnUit();
            btnP1D.BackColor = aan;
            status = kvScriptEnvvarSetInt(knop("C650D0"), 1);
            status = kvScriptEnvvarSetInt(knop("C650D1"), 8);
            status = kvScriptEnvvarSetInt(knop("C650D2"), 1);
        }

        private void btnP1U_Click(object sender, EventArgs e)
        {
            btnUit();
            btnP1U.BackColor = aan;
            status = kvScriptEnvvarSetInt(knop("C650D0"), 1);
            status = kvScriptEnvvarSetInt(knop("C650D1"), 8);
            status = kvScriptEnvvarSetInt(knop("C650D2"), 32);
        }

        private void btnP2D_Click(object sender, EventArgs e)
        {
            btnUit();
            btnP2D.BackColor = aan;
            status = kvScriptEnvvarSetInt(knop("C650D0"), 1);
            status = kvScriptEnvvarSetInt(knop("C650D1"), 8);
            status = kvScriptEnvvarSetInt(knop("C650D2"), 64);
        }

        private void btnP2U_Click(object sender, EventArgs e)
        {
            btnUit();
            btnP2U.BackColor = aan;
            status = kvScriptEnvvarSetInt(knop("C650D0"), 1);
            status = kvScriptEnvvarSetInt(knop("C650D1"), 8);
            status = kvScriptEnvvarSetInt(knop("C650D2"), 8);
        }

        private void btnP3D_Click(object sender, EventArgs e)
        {
            btnUit();
            btnP3D.BackColor = aan;
            status = kvScriptEnvvarSetInt(knop("C650D0"), 1);
            status = kvScriptEnvvarSetInt(knop("C650D1"), 40);
            status = kvScriptEnvvarSetInt(knop("C650D2"), 0);
        }

        private void btnP3U_Click(object sender, EventArgs e)
        {
            btnUit();
            btnP3U.BackColor = aan;
            status = kvScriptEnvvarSetInt(knop("C650D0"), 1);
            status = kvScriptEnvvarSetInt(knop("C650D1"), 72);
            status = kvScriptEnvvarSetInt(knop("C650D2"), 0);
        }

        private void btnP4D_Click(object sender, EventArgs e)
        {
            btnUit();
            btnP4D.BackColor = aan;
            status = kvScriptEnvvarSetInt(knop("C650D0"), 1);
            status = kvScriptEnvvarSetInt(knop("C650D1"), 12);
            status = kvScriptEnvvarSetInt(knop("C650D2"), 0);
        }

        private void btnP4U_Click(object sender, EventArgs e)
        {
            btnUit();
            btnP4U.BackColor = aan;
            status = kvScriptEnvvarSetInt(knop("C650D0"), 1);
            status = kvScriptEnvvarSetInt(knop("C650D1"), 10);
            status = kvScriptEnvvarSetInt(knop("C650D2"), 0);
        }

        private void btnY1D_Click(object sender, EventArgs e)
        {
            btnUit();
            btnY1D.BackColor = aan;
            status = kvScriptEnvvarSetInt(knop("C659D2"), 0);
        }

        private void btnY1U_Click(object sender, EventArgs e)
        {
            btnUit();
            btnY1U.BackColor = aan;
            status = kvScriptEnvvarSetInt(knop("C649D2"), 200);
        }

        private void btnY2R_Click(object sender, EventArgs e)
        {
            btnUit();
            btnY2R.BackColor = aan;
            status = kvScriptEnvvarSetInt(knop("C650D0"), 3);
            status = kvScriptEnvvarSetInt(knop("C650D1"), 8);
            status = kvScriptEnvvarSetInt(knop("C650D2"), 0);
        }

        private void btnY2L_Click(object sender, EventArgs e)
        {
            btnUit();
            btnY2L.BackColor = aan;
            status = kvScriptEnvvarSetInt(knop("C650D0"), 5);
            status = kvScriptEnvvarSetInt(knop("C650D1"), 8);
            status = kvScriptEnvvarSetInt(knop("C650D2"), 0);
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

        private void trSnelheid_Scroll(object sender, EventArgs e)
        {
            status = kvScriptEnvvarSetInt(knop("C649D7"), trSnelheid.Value);
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

        private void btnJ1_P5_Click(object sender, EventArgs e)
        {
            serialPort1.Write("p");
        }

        private void btnJ2_P1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("s");
        }

        private void btnJ2_P2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("q");
        }

        private void btnJ2_P3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("r");
        }

        private void btnJ7_P4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("l");
        }

        private void btnJ7_P5_Click(object sender, EventArgs e)
        {
            serialPort1.Write("m");
        }

        private void btnJ7_P6_Click(object sender, EventArgs e)
        {
            serialPort1.Write("n");
        }

        private void btnJ7_P10_Click(object sender, EventArgs e)
        {
            serialPort1.Write("o");
        }

        private void tbarRechts_Scroll(object sender, EventArgs e)
        {
            btnUit();
            serialPort1.Write("9");
            status = kvScriptEnvvarSetInt(knop("C649D0"), tbarRechts.Value);
            serialPort1.Write("6");
        }

        private void tbarLinks_Scroll(object sender, EventArgs e)
        {
            btnUit();
            serialPort1.Write("8");
            status = kvScriptEnvvarSetInt(knop("C649D0"), tbarLinks.Value);
            serialPort1.Write("6");
        }
    }
}
