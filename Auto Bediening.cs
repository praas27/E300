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
    public partial class Auto_Bediening : Form
    {
        private string scriptPathPlatform = Properties.Settings.Default.Pscript;
        private string scriptPathGroud = Properties.Settings.Default.Gscript;
        private canStatus status;
        private int envvar_size;
        private int envvar_type;
        private int chanHandle = 0;
        private readonly int slot = 0;
        private bool isConnected = false;
        private String[] ports;
        private readonly int s5 = 5000;
        private readonly int s2 = 2000;
        private readonly int leesD = 100;
        private string[] checkPin = new string[20] { "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "none", "error" };
        private readonly string[] serWaarde = Globaal.serWaarde;
        private readonly string[] pinnen = Globaal.pinnen;
        private readonly string[] stat = Globaal.stat;
        private readonly int ok = Globaal.ok;
        private readonly int notok = Globaal.notok;
        private readonly string delen = "---------------------------------------------------------------------------";
        private int pass = 0;


        private void lezen()
        {
            string data = serialPort1.ReadExisting();
            string[] sub = data.Split('.');
            switch (Globaal.getCheckPin(sub[0]))
            {
                case 0:
                    checkPin[0] = sub[1];
                    break;
                case 1:
                    checkPin[1] = sub[1];
                    break;
                case 2:
                    checkPin[2] = sub[1];
                    break;
                case 3:
                    checkPin[3] = sub[1];
                    break;
                case 4:
                    checkPin[4] = sub[1];
                    break;
                case 5:
                    checkPin[5] = sub[1];
                    break;
                case 6:
                    checkPin[6] = sub[1];
                    break;
                case 7:
                    checkPin[7] = sub[1];
                    break;
                case 8:
                    checkPin[8] = sub[1];
                    break;
                case 9:
                    checkPin[9] = sub[1];
                    break;
                case 10:
                    checkPin[10] = sub[1];
                    break;
                case 11:
                    checkPin[11] = sub[1];
                    break;
                case 12:
                    checkPin[12] = sub[1];
                    break;
                case 13:
                    checkPin[13] = sub[1];
                    break;
                case 14:
                    checkPin[14] = sub[1];
                    break;
                case 15:
                    checkPin[15] = sub[1];
                    break;
                case 16:
                    checkPin[16] = sub[1];
                    break;
                case 17:
                    checkPin[17] = sub[1];
                    break;
                case 18:
                    checkPin[18] = sub[1];
                    break;
            }
        }

        private string evaluate(string a, int b)
        {
            if(b == ok)
            {
                if(a == stat[ok])
                {
                    return "pass";
                }
                else if (a == stat[notok])
                {
                    return "fail";
                }
                else
                {
                    return "error";
                }

            }
            else if (b == notok)
            {
                if (a == stat[notok])
                {
                    return "pass";
                }
                else if (a == stat[ok])
                {
                    return "fail";
                }
                else
                {
                    return "error";
                }
            }
            else
            {
                return "error";
            }
            
        }

        private void rol(string nPin, string cPin, int st, bool del)
        {
            printInTextBox(nPin + ": " + evaluate(cPin, st));
            if (cPin == stat[ok]) pass++;
            if(del)
                printInTextBox(delen);
        }

        private async void force(int nr)
        {
            for (int i = 0; i < 10; i++)
            {
                if(checkPin[nr] == stat[ok] || checkPin[nr] == stat[notok])
                {
                    i = 10;
                }
                else
                {
                    serialPort1.Write(serWaarde[nr]);
                    await Task.Delay(leesD);
                }
            }
            
        }

        private async void test()
        {
            //sturing start
            startScript(scriptPathGroud);
            serialPort1.Write("3");
            printInTextBox("Powermodule powerd in groud mode");
            await Task.Delay(6000);
            printInTextBox(delen);

            //check 12V en GND
            for (int i = 0; i < 11; i++)
            {
                serialPort1.Write(serWaarde[i]);
                await Task.Delay(leesD);
                force(i);
                rol(pinnen[i], checkPin[i], ok, false);
                //if (checkPin[i] == stat[ok]) pass++;
                //printInTextBox(pinnen[i] + ": " + evaluate(checkPin[i], ok));
            }
            printInTextBox(delen);

            //knop 1-1
            printInTextBox("platformniveu down");
            kvScriptEnvvarSetInt(knop("C658D1"), 64);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            printInTextBox("platformniveu los");
            kvScriptEnvvarSetInt(knop("C658D1"), 0);
            await Task.Delay(s2);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            //knop 1-2
            printInTextBox("platformniveu up");
            status = kvScriptEnvvarSetInt(knop("C658D0"), 200);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            printInTextBox("platformniveu los");
            status = kvScriptEnvvarSetInt(knop("C658D0"), 192);
            await Task.Delay(s2);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            //knop 2-1
            printInTextBox("platform draaien rechts");
            status = kvScriptEnvvarSetInt(knop("C658D1"), 8);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            printInTextBox("platform draaien los");
            status = kvScriptEnvvarSetInt(knop("C658D1"), 0);
            await Task.Delay(s2);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            //knop 2-2
            printInTextBox("platform draaien links");
            status = kvScriptEnvvarSetInt(knop("C658D1"), 128);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            printInTextBox("platform draaien los");
            status = kvScriptEnvvarSetInt(knop("C658D1"), 0);
            await Task.Delay(s2);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            //knop 3-1
            printInTextBox("jiblift down");
            kvScriptEnvvarSetInt(knop("C658D2"), 64);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            printInTextBox("jiblift los");
            kvScriptEnvvarSetInt(knop("C658D2"), 0);
            await Task.Delay(s2);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            //knop 3-2
            printInTextBox("jiblift up");
            kvScriptEnvvarSetInt(knop("C658D0"), 193);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            printInTextBox("jiblift los");
            kvScriptEnvvarSetInt(knop("C658D0"), 192);
            await Task.Delay(s2);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            //knop 4-1
            printInTextBox("Telescoop voor");
            kvScriptEnvvarSetInt(knop("C658D0"), 194);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            printInTextBox("Telescoop los");
            kvScriptEnvvarSetInt(knop("C658D0"), 192);
            await Task.Delay(s2);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            //knop 4-2
            printInTextBox("Telescoop achter");
            kvScriptEnvvarSetInt(knop("C658D1"), 4);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            printInTextBox("Telescoop los");
            kvScriptEnvvarSetInt(knop("C658D1"), 0);
            await Task.Delay(s2);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            //knop 5-1
            printInTextBox("Boven gieklift down");
            kvScriptEnvvarSetInt(knop("C658D0"), 208);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            printInTextBox("Boven gieklift los");
            kvScriptEnvvarSetInt(knop("C658D0"), 192);
            await Task.Delay(s2);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            //knop 5-2
            printInTextBox("Boven gieklift up");
            kvScriptEnvvarSetInt(knop("C658D1"), 2);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            printInTextBox("Boven gieklift los");
            kvScriptEnvvarSetInt(knop("C658D1"), 0);
            await Task.Delay(s2);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            //knop 6-1
            printInTextBox("Hefboom neerlaten down");
            kvScriptEnvvarSetInt(knop("C658D1"), 16);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            printInTextBox("Heftboom neerlaten los");
            kvScriptEnvvarSetInt(knop("C658D1"), 0);
            await Task.Delay(s2);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            //knop 6-2
            printInTextBox("Hefboom neerlaten up");
            kvScriptEnvvarSetInt(knop("C658D0"), 224);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            printInTextBox("Hefboom neerlaten los");
            kvScriptEnvvarSetInt(knop("C658D0"), 192);
            await Task.Delay(s2);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            //knop 7-1
            printInTextBox("schommel links");
            kvScriptEnvvarSetInt(knop("C658D1"), 1);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            printInTextBox("schommel los");
            kvScriptEnvvarSetInt(knop("C658D1"), 0);
            await Task.Delay(s2);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            //knop 7-2
            printInTextBox("schommel rechts");
            kvScriptEnvvarSetInt(knop("C658D1"), 32);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            printInTextBox("schommel los");
            kvScriptEnvvarSetInt(knop("C658D1"), 0);
            await Task.Delay(s2);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            //Grondbediening resultaat
            if (pass == 25)
            {
                printInTextBox("Grondbediening pass: " + pass + "/25");
            }
            else if (pass < 25)
            {
                printInTextBox("Grondbediening fail: " + pass + "/25");
            }
            else
            {
                printInTextBox("Grondbediening unkown: " + pass + "/25");
            }
            printInTextBox(delen);

            //stop
            stop();
            await Task.Delay(10000);
            printInTextBox(delen);

            //start sturing
            printInTextBox("Powermodule powerd in platform mode");
            serialPort1.Write("4");
            startScript(scriptPathPlatform);
            await Task.Delay(s2);
            printInTextBox(delen);

            //footswitch
            printInTextBox("Footswitch ingedrukt");
            serialPort1.Write("2");
            kvScriptEnvvarSetInt(knop("C650D2"), 0);
            await Task.Delay(s5);
            printInTextBox(delen);

            printInTextBox("Voetpedaal check");
            serialPort1.Write(serWaarde[15]);
            await Task.Delay(leesD);
            force(15);
            rol(pinnen[15], checkPin[15], ok,true);

            printInTextBox("Motor check");
            serialPort1.Write(serWaarde[18]);
            await Task.Delay(leesD);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            printInTextBox("Platform draaien rechts");
            kvScriptEnvvarSetInt(knop("C650D2"), 1);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            await Task.Delay(leesD);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            printInTextBox("Platform draaien links");
            kvScriptEnvvarSetInt(knop("C650D2"), 32);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            await Task.Delay(leesD);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            printInTextBox("Torengieklift down");
            kvScriptEnvvarSetInt(knop("C650D2"), 64);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            await Task.Delay(leesD);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            printInTextBox("Torengieklift up");
            kvScriptEnvvarSetInt(knop("C650D2"), 8);
            await Task.Delay(s5);
            await Task.Delay(leesD);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            printInTextBox("Jiblift down");
            kvScriptEnvvarSetInt(knop("C650D1"), 40);
            kvScriptEnvvarSetInt(knop("C650D2"), 0);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            await Task.Delay(leesD);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            printInTextBox("Jiblift up");
            kvScriptEnvvarSetInt(knop("C650D1"), 72);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            await Task.Delay(leesD);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            printInTextBox("Hoofdgiektelescoop down");
            kvScriptEnvvarSetInt(knop("C650D1"), 12);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            await Task.Delay(leesD);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            printInTextBox("Hoofdgiektelescoop up");
            kvScriptEnvvarSetInt(knop("C650D1"), 10);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            await Task.Delay(leesD);
            force(18);
            rol(pinnen[18], checkPin[18], ok, true);

            printInTextBox("knoppen los");
            kvScriptEnvvarSetInt(knop("C650D1"), 8);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            await Task.Delay(leesD);
            force(18);
            rol(pinnen[18], checkPin[18], ok,true);

            printInTextBox("Rij-/stuurcontroller links");
            kvScriptEnvvarSetInt(knop("C650D0"), 3);
            await Task.Delay(10);
            serialPort1.Write(serWaarde[13]);
            await Task.Delay(leesD);
            force(13);
            serialPort1.Write(serWaarde[11]);
            await Task.Delay(leesD);
            force(11);
            rol(pinnen[13], checkPin[13], ok,false);
            rol(pinnen[11], checkPin[11], ok,false);
            await Task.Delay(s5);

            printInTextBox("Rij-/stuurcontroller los");
            kvScriptEnvvarSetInt(knop("C650D0"), 1);
            await Task.Delay(s5);
            printInTextBox(delen);

            printInTextBox("Rij-/stuurcontroller rechts");
            kvScriptEnvvarSetInt(knop("C650D0"), 5);
            serialPort1.Write(serWaarde[13]);
            await Task.Delay(leesD);
            force(13);
            serialPort1.Write(serWaarde[12]);
            await Task.Delay(leesD);
            force(12);
            rol(pinnen[13], checkPin[13], ok, false);
            rol(pinnen[11], checkPin[12], ok, false);
            await Task.Delay(s5);

            printInTextBox("Rij-/stuurcontroller los");
            kvScriptEnvvarSetInt(knop("C650D0"), 1);
            await Task.Delay(s5);
            printInTextBox(delen);

            printInTextBox("Hef-/zwaairegelaar up");
            kvScriptEnvvarSetInt(knop("C649D2"), 200);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            await Task.Delay(leesD);
            force(18);
            rol(pinnen[18], checkPin[18], ok, true);


            printInTextBox("Hef-/zwaairegelaar down");
            kvScriptEnvvarSetInt(knop("C649D2"), 0);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[16]);
            await Task.Delay(leesD);
            force(18);
            rol(pinnen[18], checkPin[18], ok, true);

            printInTextBox("Hef-/zwaairegelaar los");
            kvScriptEnvvarSetInt(knop("C649D2"), 129);
            await Task.Delay(s5);
            serialPort1.Write(serWaarde[18]);
            await Task.Delay(leesD);
            force(18);
            rol(pinnen[18], checkPin[18], ok, true);

            printInTextBox("Rij-/stuurcontroller achteruit");
            serialPort1.Write("9");
            serialPort1.Write("6");
            kvScriptEnvvarSetInt(knop("C649D0"), 200);
            serialPort1.Write(serWaarde[16]);
            await Task.Delay(leesD);
            force(16);
            serialPort1.Write(serWaarde[14]);
            await Task.Delay(leesD);
            force(14);
            rol(pinnen[16], checkPin[16], ok, false);
            rol(pinnen[14], checkPin[14], ok, false);
            await Task.Delay(10000);

            printInTextBox("Rij-/stuurcontroller los");
            kvScriptEnvvarSetInt(knop("C649D0"), 128);
            await Task.Delay(s5);
            printInTextBox(delen);

            printInTextBox("Rij-/stuurcontroller vooruit");
            serialPort1.Write("8");
            kvScriptEnvvarSetInt(knop("C649D0"), 90);
            serialPort1.Write(serWaarde[17]);
            await Task.Delay(leesD);
            force(17);
            serialPort1.Write(serWaarde[14]);
            await Task.Delay(leesD);
            force(14);
            rol(pinnen[18], checkPin[17], ok, false);
            rol(pinnen[14], checkPin[14], ok, false);
            await Task.Delay(10000);

            printInTextBox("Rij-/stuurcontroller los");
            kvScriptEnvvarSetInt(knop("C649D0"), 128);
            await Task.Delay(500);
            serialPort1.Write("7");
            await Task.Delay(500);
            printInTextBox(delen);

            printInTextBox("Platformbedeining: " + pass + "/18");
            printInTextBox(delen);

            printInTextBox("Footswitch los");
            serialPort1.Write("1");
            kvScriptEnvvarSetInt(knop("C650D2"), 2);
            await Task.Delay(10000);
            printInTextBox(delen);

            stop();
            printInTextBox(delen);
        }

        private void stop()
        {
            status = kvScriptStop(chanHandle, slot, kvSCRIPT_STOP_NORMAL);
            printInTextBox("Script stop: " + status);
            status = kvScriptUnload(chanHandle, slot);
            printInTextBox("Script unload: " + status);
            printInTextBox("Powermodule powerd off");
            serialPort1.Write("0");
            pass = 0;
        }

        private void printInTextBox(string massage)
        {
            tbStatus.Text += "\r\n" + massage;
            tbRun.Text = massage;
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

        private void startScript(string scriptPath)
        {
            status = kvScriptLoadFile(chanHandle, slot, scriptPath);
            printInTextBox("Loading script: " + status);
            status = kvScriptStart(chanHandle, slot);
            printInTextBox("Script start: " + status);
            status = kvScriptStatus(chanHandle, slot, out int o);
            printInTextBox("Script status: " + status + " - " + o);
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

        private long knop(string id)
        {
            long knop = Canlib.kvScriptEnvvarOpen(chanHandle, id, out envvar_type, out envvar_size);
            return knop;
        }

        public Auto_Bediening()
        {
            InitializeComponent();
        }

        private void Auto_Bediening_Load(object sender, EventArgs e)
        {
            getAvailableComPorts();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                disconnectFromArduino();
                isConnected = false;
            }
            else
            {
                connectToArduino();
                isConnected = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                initCanBus();
                test();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            lezen();
        }

        private void cbCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
