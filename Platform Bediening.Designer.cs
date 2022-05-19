
namespace E300
{
    partial class Platform_Bediening
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCon = new System.Windows.Forms.Button();
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.btnVoet = new System.Windows.Forms.Button();
            this.btnY2L = new System.Windows.Forms.Button();
            this.btnY2R = new System.Windows.Forms.Button();
            this.btnY1U = new System.Windows.Forms.Button();
            this.btnY1D = new System.Windows.Forms.Button();
            this.trSnelheid = new System.Windows.Forms.TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnP4D = new System.Windows.Forms.Button();
            this.btnP4U = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnP3D = new System.Windows.Forms.Button();
            this.btnP3U = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnP2D = new System.Windows.Forms.Button();
            this.btnP2U = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnP1D = new System.Windows.Forms.Button();
            this.btnP1U = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnJ3_P1 = new System.Windows.Forms.Button();
            this.btnJ7_P15 = new System.Windows.Forms.Button();
            this.btnJ1_P7 = new System.Windows.Forms.Button();
            this.btnJ1_P6 = new System.Windows.Forms.Button();
            this.btnJ1_P4 = new System.Windows.Forms.Button();
            this.btnJ7_P14 = new System.Windows.Forms.Button();
            this.btnJ3_P3 = new System.Windows.Forms.Button();
            this.btnJ2_P5 = new System.Windows.Forms.Button();
            this.btnJ1_P11 = new System.Windows.Forms.Button();
            this.btnJ1_P10 = new System.Windows.Forms.Button();
            this.btnJ1_P8 = new System.Windows.Forms.Button();
            this.tbRun = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnJ2_P3 = new System.Windows.Forms.Button();
            this.btnJ2_P2 = new System.Windows.Forms.Button();
            this.btnJ2_P1 = new System.Windows.Forms.Button();
            this.btnJ1_P5 = new System.Windows.Forms.Button();
            this.btnJ7_P10 = new System.Windows.Forms.Button();
            this.btnJ7_P6 = new System.Windows.Forms.Button();
            this.btnJ7_P5 = new System.Windows.Forms.Button();
            this.btnJ7_P4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn5V = new System.Windows.Forms.Button();
            this.btn12V = new System.Windows.Forms.Button();
            this.btnGrounds = new System.Windows.Forms.Button();
            this.tbarRechts = new System.Windows.Forms.TrackBar();
            this.tbarLinks = new System.Windows.Forms.TrackBar();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trSnelheid)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarRechts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarLinks)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStop.Location = new System.Drawing.Point(375, 761);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(121, 66);
            this.btnStop.TabIndex = 76;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.Location = new System.Drawing.Point(223, 761);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 66);
            this.btnStart.TabIndex = 75;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCon
            // 
            this.btnCon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCon.Location = new System.Drawing.Point(68, 808);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(121, 23);
            this.btnCon.TabIndex = 74;
            this.btnCon.Text = "COM";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // cbCom
            // 
            this.cbCom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(68, 768);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(121, 24);
            this.cbCom.TabIndex = 73;
            // 
            // tbStatus
            // 
            this.tbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbStatus.Location = new System.Drawing.Point(907, 124);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(250, 707);
            this.tbStatus.TabIndex = 68;
            // 
            // btnVoet
            // 
            this.btnVoet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoet.Location = new System.Drawing.Point(528, 761);
            this.btnVoet.Name = "btnVoet";
            this.btnVoet.Size = new System.Drawing.Size(121, 66);
            this.btnVoet.TabIndex = 67;
            this.btnVoet.Text = "VOET";
            this.btnVoet.UseVisualStyleBackColor = true;
            this.btnVoet.Click += new System.EventHandler(this.btnVoet_Click);
            // 
            // btnY2L
            // 
            this.btnY2L.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnY2L.BackColor = System.Drawing.Color.White;
            this.btnY2L.Image = global::E300.Properties.Resources.angle_square_left;
            this.btnY2L.Location = new System.Drawing.Point(0, 72);
            this.btnY2L.Name = "btnY2L";
            this.btnY2L.Size = new System.Drawing.Size(75, 75);
            this.btnY2L.TabIndex = 65;
            this.btnY2L.UseVisualStyleBackColor = false;
            this.btnY2L.Click += new System.EventHandler(this.btnY2L_Click);
            // 
            // btnY2R
            // 
            this.btnY2R.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnY2R.BackColor = System.Drawing.Color.White;
            this.btnY2R.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnY2R.Image = global::E300.Properties.Resources.angle_square_right;
            this.btnY2R.Location = new System.Drawing.Point(145, 72);
            this.btnY2R.Name = "btnY2R";
            this.btnY2R.Size = new System.Drawing.Size(75, 75);
            this.btnY2R.TabIndex = 64;
            this.btnY2R.UseVisualStyleBackColor = false;
            this.btnY2R.Click += new System.EventHandler(this.btnY2R_Click);
            // 
            // btnY1U
            // 
            this.btnY1U.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnY1U.Image = global::E300.Properties.Resources.angle_square_up;
            this.btnY1U.Location = new System.Drawing.Point(129, 483);
            this.btnY1U.Name = "btnY1U";
            this.btnY1U.Size = new System.Drawing.Size(75, 75);
            this.btnY1U.TabIndex = 58;
            this.btnY1U.UseVisualStyleBackColor = true;
            this.btnY1U.Click += new System.EventHandler(this.btnY1U_Click);
            // 
            // btnY1D
            // 
            this.btnY1D.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnY1D.Image = global::E300.Properties.Resources.angle_square_down;
            this.btnY1D.Location = new System.Drawing.Point(129, 625);
            this.btnY1D.Name = "btnY1D";
            this.btnY1D.Size = new System.Drawing.Size(75, 75);
            this.btnY1D.TabIndex = 57;
            this.btnY1D.UseVisualStyleBackColor = true;
            this.btnY1D.Click += new System.EventHandler(this.btnY1D_Click);
            // 
            // trSnelheid
            // 
            this.trSnelheid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trSnelheid.Location = new System.Drawing.Point(56, 394);
            this.trSnelheid.Name = "trSnelheid";
            this.trSnelheid.Size = new System.Drawing.Size(200, 56);
            this.trSnelheid.TabIndex = 56;
            this.trSnelheid.Scroll += new System.EventHandler(this.trSnelheid_Scroll);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Controls.Add(this.btnP4D);
            this.panel4.Controls.Add(this.btnP4U);
            this.panel4.Location = new System.Drawing.Point(516, 124);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 200);
            this.panel4.TabIndex = 55;
            // 
            // btnP4D
            // 
            this.btnP4D.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnP4D.BackColor = System.Drawing.Color.White;
            this.btnP4D.Image = global::E300.Properties.Resources.angle_square_down;
            this.btnP4D.Location = new System.Drawing.Point(12, 115);
            this.btnP4D.Name = "btnP4D";
            this.btnP4D.Size = new System.Drawing.Size(75, 75);
            this.btnP4D.TabIndex = 15;
            this.btnP4D.UseVisualStyleBackColor = false;
            this.btnP4D.Click += new System.EventHandler(this.btnP4D_Click);
            // 
            // btnP4U
            // 
            this.btnP4U.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnP4U.BackColor = System.Drawing.Color.White;
            this.btnP4U.Image = global::E300.Properties.Resources.angle_square_up;
            this.btnP4U.Location = new System.Drawing.Point(12, 14);
            this.btnP4U.Name = "btnP4U";
            this.btnP4U.Size = new System.Drawing.Size(75, 75);
            this.btnP4U.TabIndex = 14;
            this.btnP4U.UseVisualStyleBackColor = false;
            this.btnP4U.Click += new System.EventHandler(this.btnP4U_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.btnP3D);
            this.panel2.Controls.Add(this.btnP3U);
            this.panel2.Location = new System.Drawing.Point(396, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 200);
            this.panel2.TabIndex = 54;
            // 
            // btnP3D
            // 
            this.btnP3D.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnP3D.BackColor = System.Drawing.Color.White;
            this.btnP3D.Image = global::E300.Properties.Resources.angle_square_down;
            this.btnP3D.Location = new System.Drawing.Point(12, 115);
            this.btnP3D.Name = "btnP3D";
            this.btnP3D.Size = new System.Drawing.Size(75, 75);
            this.btnP3D.TabIndex = 15;
            this.btnP3D.UseVisualStyleBackColor = false;
            this.btnP3D.Click += new System.EventHandler(this.btnP3D_Click);
            // 
            // btnP3U
            // 
            this.btnP3U.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnP3U.BackColor = System.Drawing.Color.White;
            this.btnP3U.Image = global::E300.Properties.Resources.angle_square_up;
            this.btnP3U.Location = new System.Drawing.Point(12, 14);
            this.btnP3U.Name = "btnP3U";
            this.btnP3U.Size = new System.Drawing.Size(75, 75);
            this.btnP3U.TabIndex = 14;
            this.btnP3U.UseVisualStyleBackColor = false;
            this.btnP3U.Click += new System.EventHandler(this.btnP3U_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.btnP2D);
            this.panel1.Controls.Add(this.btnP2U);
            this.panel1.Location = new System.Drawing.Point(176, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 200);
            this.panel1.TabIndex = 53;
            // 
            // btnP2D
            // 
            this.btnP2D.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnP2D.BackColor = System.Drawing.Color.White;
            this.btnP2D.Image = global::E300.Properties.Resources.angle_square_down;
            this.btnP2D.Location = new System.Drawing.Point(12, 115);
            this.btnP2D.Name = "btnP2D";
            this.btnP2D.Size = new System.Drawing.Size(75, 75);
            this.btnP2D.TabIndex = 15;
            this.btnP2D.UseVisualStyleBackColor = false;
            this.btnP2D.Click += new System.EventHandler(this.btnP2D_Click);
            // 
            // btnP2U
            // 
            this.btnP2U.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnP2U.BackColor = System.Drawing.Color.White;
            this.btnP2U.Image = global::E300.Properties.Resources.angle_square_up;
            this.btnP2U.Location = new System.Drawing.Point(12, 14);
            this.btnP2U.Name = "btnP2U";
            this.btnP2U.Size = new System.Drawing.Size(75, 75);
            this.btnP2U.TabIndex = 14;
            this.btnP2U.UseVisualStyleBackColor = false;
            this.btnP2U.Click += new System.EventHandler(this.btnP2U_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Controls.Add(this.btnP1D);
            this.panel3.Controls.Add(this.btnP1U);
            this.panel3.Location = new System.Drawing.Point(56, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 200);
            this.panel3.TabIndex = 52;
            // 
            // btnP1D
            // 
            this.btnP1D.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnP1D.BackColor = System.Drawing.Color.White;
            this.btnP1D.Image = global::E300.Properties.Resources.angle_square_down;
            this.btnP1D.Location = new System.Drawing.Point(12, 115);
            this.btnP1D.Name = "btnP1D";
            this.btnP1D.Size = new System.Drawing.Size(75, 75);
            this.btnP1D.TabIndex = 15;
            this.btnP1D.UseVisualStyleBackColor = false;
            this.btnP1D.Click += new System.EventHandler(this.btnP1D_Click);
            // 
            // btnP1U
            // 
            this.btnP1U.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnP1U.BackColor = System.Drawing.Color.White;
            this.btnP1U.Image = global::E300.Properties.Resources.angle_square_up;
            this.btnP1U.Location = new System.Drawing.Point(12, 14);
            this.btnP1U.Name = "btnP1U";
            this.btnP1U.Size = new System.Drawing.Size(75, 75);
            this.btnP1U.TabIndex = 14;
            this.btnP1U.UseVisualStyleBackColor = false;
            this.btnP1U.Click += new System.EventHandler(this.btnP1U_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM9";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.Controls.Add(this.btnY2L);
            this.panel5.Controls.Add(this.btnY2R);
            this.panel5.Location = new System.Drawing.Point(56, 483);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 217);
            this.panel5.TabIndex = 61;
            // 
            // btnJ3_P1
            // 
            this.btnJ3_P1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJ3_P1.Location = new System.Drawing.Point(787, 669);
            this.btnJ3_P1.Name = "btnJ3_P1";
            this.btnJ3_P1.Size = new System.Drawing.Size(75, 23);
            this.btnJ3_P1.TabIndex = 98;
            this.btnJ3_P1.Text = "J3-P1";
            this.btnJ3_P1.UseVisualStyleBackColor = true;
            this.btnJ3_P1.Click += new System.EventHandler(this.btnJ3_P1_Click);
            // 
            // btnJ7_P15
            // 
            this.btnJ7_P15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJ7_P15.Location = new System.Drawing.Point(787, 611);
            this.btnJ7_P15.Name = "btnJ7_P15";
            this.btnJ7_P15.Size = new System.Drawing.Size(75, 23);
            this.btnJ7_P15.TabIndex = 97;
            this.btnJ7_P15.Text = "J7-P15";
            this.btnJ7_P15.UseVisualStyleBackColor = true;
            this.btnJ7_P15.Click += new System.EventHandler(this.btnJ7_P15_Click);
            // 
            // btnJ1_P7
            // 
            this.btnJ1_P7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJ1_P7.Location = new System.Drawing.Point(787, 581);
            this.btnJ1_P7.Name = "btnJ1_P7";
            this.btnJ1_P7.Size = new System.Drawing.Size(75, 23);
            this.btnJ1_P7.TabIndex = 96;
            this.btnJ1_P7.Text = "J1-P7";
            this.btnJ1_P7.UseVisualStyleBackColor = true;
            this.btnJ1_P7.Click += new System.EventHandler(this.btnJ1_P7_Click);
            // 
            // btnJ1_P6
            // 
            this.btnJ1_P6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJ1_P6.Location = new System.Drawing.Point(787, 552);
            this.btnJ1_P6.Name = "btnJ1_P6";
            this.btnJ1_P6.Size = new System.Drawing.Size(75, 23);
            this.btnJ1_P6.TabIndex = 95;
            this.btnJ1_P6.Text = "J1-P6";
            this.btnJ1_P6.UseVisualStyleBackColor = true;
            this.btnJ1_P6.Click += new System.EventHandler(this.btnJ1_P6_Click);
            // 
            // btnJ1_P4
            // 
            this.btnJ1_P4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJ1_P4.Location = new System.Drawing.Point(787, 523);
            this.btnJ1_P4.Name = "btnJ1_P4";
            this.btnJ1_P4.Size = new System.Drawing.Size(75, 23);
            this.btnJ1_P4.TabIndex = 94;
            this.btnJ1_P4.Text = "J1-P4";
            this.btnJ1_P4.UseVisualStyleBackColor = true;
            this.btnJ1_P4.Click += new System.EventHandler(this.btnJ1_P4_Click);
            // 
            // btnJ7_P14
            // 
            this.btnJ7_P14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJ7_P14.Location = new System.Drawing.Point(694, 669);
            this.btnJ7_P14.Name = "btnJ7_P14";
            this.btnJ7_P14.Size = new System.Drawing.Size(75, 23);
            this.btnJ7_P14.TabIndex = 93;
            this.btnJ7_P14.Text = "J7-P14";
            this.btnJ7_P14.UseVisualStyleBackColor = true;
            this.btnJ7_P14.Click += new System.EventHandler(this.btnJ7_P14_Click);
            // 
            // btnJ3_P3
            // 
            this.btnJ3_P3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJ3_P3.Location = new System.Drawing.Point(694, 640);
            this.btnJ3_P3.Name = "btnJ3_P3";
            this.btnJ3_P3.Size = new System.Drawing.Size(75, 23);
            this.btnJ3_P3.TabIndex = 92;
            this.btnJ3_P3.Text = "J3-P3";
            this.btnJ3_P3.UseVisualStyleBackColor = true;
            this.btnJ3_P3.Click += new System.EventHandler(this.btnJ3_P3_Click);
            // 
            // btnJ2_P5
            // 
            this.btnJ2_P5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJ2_P5.Location = new System.Drawing.Point(694, 611);
            this.btnJ2_P5.Name = "btnJ2_P5";
            this.btnJ2_P5.Size = new System.Drawing.Size(75, 23);
            this.btnJ2_P5.TabIndex = 91;
            this.btnJ2_P5.Text = "J2-P5";
            this.btnJ2_P5.UseVisualStyleBackColor = true;
            this.btnJ2_P5.Click += new System.EventHandler(this.btnJ2_P5_Click);
            // 
            // btnJ1_P11
            // 
            this.btnJ1_P11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJ1_P11.Location = new System.Drawing.Point(694, 581);
            this.btnJ1_P11.Name = "btnJ1_P11";
            this.btnJ1_P11.Size = new System.Drawing.Size(75, 23);
            this.btnJ1_P11.TabIndex = 90;
            this.btnJ1_P11.Text = "J1-P11";
            this.btnJ1_P11.UseVisualStyleBackColor = true;
            this.btnJ1_P11.Click += new System.EventHandler(this.btnJ1_P11_Click);
            // 
            // btnJ1_P10
            // 
            this.btnJ1_P10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJ1_P10.Location = new System.Drawing.Point(694, 552);
            this.btnJ1_P10.Name = "btnJ1_P10";
            this.btnJ1_P10.Size = new System.Drawing.Size(75, 23);
            this.btnJ1_P10.TabIndex = 89;
            this.btnJ1_P10.Text = "J1-P10";
            this.btnJ1_P10.UseVisualStyleBackColor = true;
            this.btnJ1_P10.Click += new System.EventHandler(this.btnJ1_P10_Click);
            // 
            // btnJ1_P8
            // 
            this.btnJ1_P8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJ1_P8.Location = new System.Drawing.Point(694, 523);
            this.btnJ1_P8.Name = "btnJ1_P8";
            this.btnJ1_P8.Size = new System.Drawing.Size(75, 23);
            this.btnJ1_P8.TabIndex = 88;
            this.btnJ1_P8.Text = "J1-P8";
            this.btnJ1_P8.UseVisualStyleBackColor = true;
            this.btnJ1_P8.Click += new System.EventHandler(this.btnJ1_P8_Click);
            // 
            // tbRun
            // 
            this.tbRun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRun.Location = new System.Drawing.Point(694, 124);
            this.tbRun.Multiline = true;
            this.tbRun.Name = "tbRun";
            this.tbRun.Size = new System.Drawing.Size(186, 71);
            this.tbRun.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(791, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 113;
            this.label5.Text = "12V pin";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(677, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 112;
            this.label4.Text = "48V pin";
            // 
            // btnJ2_P3
            // 
            this.btnJ2_P3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJ2_P3.Location = new System.Drawing.Point(680, 424);
            this.btnJ2_P3.Name = "btnJ2_P3";
            this.btnJ2_P3.Size = new System.Drawing.Size(75, 23);
            this.btnJ2_P3.TabIndex = 111;
            this.btnJ2_P3.Text = "J2-P3";
            this.btnJ2_P3.UseVisualStyleBackColor = true;
            this.btnJ2_P3.UseWaitCursor = true;
            this.btnJ2_P3.Click += new System.EventHandler(this.btnJ2_P3_Click);
            // 
            // btnJ2_P2
            // 
            this.btnJ2_P2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJ2_P2.Location = new System.Drawing.Point(680, 394);
            this.btnJ2_P2.Name = "btnJ2_P2";
            this.btnJ2_P2.Size = new System.Drawing.Size(75, 23);
            this.btnJ2_P2.TabIndex = 110;
            this.btnJ2_P2.Text = "J2-P2";
            this.btnJ2_P2.UseVisualStyleBackColor = true;
            this.btnJ2_P2.Click += new System.EventHandler(this.btnJ2_P2_Click);
            // 
            // btnJ2_P1
            // 
            this.btnJ2_P1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJ2_P1.Location = new System.Drawing.Point(680, 365);
            this.btnJ2_P1.Name = "btnJ2_P1";
            this.btnJ2_P1.Size = new System.Drawing.Size(75, 23);
            this.btnJ2_P1.TabIndex = 109;
            this.btnJ2_P1.Text = "J2-P1";
            this.btnJ2_P1.UseVisualStyleBackColor = true;
            this.btnJ2_P1.Click += new System.EventHandler(this.btnJ2_P1_Click);
            // 
            // btnJ1_P5
            // 
            this.btnJ1_P5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJ1_P5.Location = new System.Drawing.Point(680, 336);
            this.btnJ1_P5.Name = "btnJ1_P5";
            this.btnJ1_P5.Size = new System.Drawing.Size(75, 23);
            this.btnJ1_P5.TabIndex = 108;
            this.btnJ1_P5.Text = "J1-P5";
            this.btnJ1_P5.UseVisualStyleBackColor = true;
            this.btnJ1_P5.Click += new System.EventHandler(this.btnJ1_P5_Click);
            // 
            // btnJ7_P10
            // 
            this.btnJ7_P10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJ7_P10.Location = new System.Drawing.Point(794, 424);
            this.btnJ7_P10.Name = "btnJ7_P10";
            this.btnJ7_P10.Size = new System.Drawing.Size(75, 23);
            this.btnJ7_P10.TabIndex = 107;
            this.btnJ7_P10.Text = "J7-P10";
            this.btnJ7_P10.UseVisualStyleBackColor = true;
            this.btnJ7_P10.Click += new System.EventHandler(this.btnJ7_P10_Click);
            // 
            // btnJ7_P6
            // 
            this.btnJ7_P6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJ7_P6.Location = new System.Drawing.Point(794, 394);
            this.btnJ7_P6.Name = "btnJ7_P6";
            this.btnJ7_P6.Size = new System.Drawing.Size(75, 23);
            this.btnJ7_P6.TabIndex = 106;
            this.btnJ7_P6.Text = "J7-P6";
            this.btnJ7_P6.UseVisualStyleBackColor = true;
            this.btnJ7_P6.Click += new System.EventHandler(this.btnJ7_P6_Click);
            // 
            // btnJ7_P5
            // 
            this.btnJ7_P5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJ7_P5.Location = new System.Drawing.Point(794, 365);
            this.btnJ7_P5.Name = "btnJ7_P5";
            this.btnJ7_P5.Size = new System.Drawing.Size(75, 23);
            this.btnJ7_P5.TabIndex = 105;
            this.btnJ7_P5.Text = "J7-P5";
            this.btnJ7_P5.UseVisualStyleBackColor = true;
            this.btnJ7_P5.Click += new System.EventHandler(this.btnJ7_P5_Click);
            // 
            // btnJ7_P4
            // 
            this.btnJ7_P4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJ7_P4.Location = new System.Drawing.Point(794, 336);
            this.btnJ7_P4.Name = "btnJ7_P4";
            this.btnJ7_P4.Size = new System.Drawing.Size(75, 23);
            this.btnJ7_P4.TabIndex = 104;
            this.btnJ7_P4.Text = "J7-P4";
            this.btnJ7_P4.UseVisualStyleBackColor = true;
            this.btnJ7_P4.Click += new System.EventHandler(this.btnJ7_P4_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 114;
            this.label1.Text = "Massa pin";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(784, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 115;
            this.label2.Text = "12V vast pin";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(790, 650);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 116;
            this.label3.Text = "5V vast pin";
            // 
            // btn5V
            // 
            this.btn5V.Location = new System.Drawing.Point(516, 394);
            this.btn5V.Name = "btn5V";
            this.btn5V.Size = new System.Drawing.Size(100, 50);
            this.btn5V.TabIndex = 119;
            this.btn5V.Text = "5V";
            this.btn5V.UseVisualStyleBackColor = true;
            this.btn5V.Click += new System.EventHandler(this.btn5V_Click);
            // 
            // btn12V
            // 
            this.btn12V.Location = new System.Drawing.Point(399, 394);
            this.btn12V.Name = "btn12V";
            this.btn12V.Size = new System.Drawing.Size(100, 50);
            this.btn12V.TabIndex = 118;
            this.btn12V.Text = "12V";
            this.btn12V.UseVisualStyleBackColor = true;
            this.btn12V.Click += new System.EventHandler(this.btn12V_Click);
            // 
            // btnGrounds
            // 
            this.btnGrounds.Location = new System.Drawing.Point(278, 394);
            this.btnGrounds.Name = "btnGrounds";
            this.btnGrounds.Size = new System.Drawing.Size(100, 50);
            this.btnGrounds.TabIndex = 117;
            this.btnGrounds.Text = "Grounds";
            this.btnGrounds.UseVisualStyleBackColor = true;
            this.btnGrounds.Click += new System.EventHandler(this.btnGrounds_Click);
            // 
            // tbarRechts
            // 
            this.tbarRechts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbarRechts.BackColor = System.Drawing.Color.White;
            this.tbarRechts.Location = new System.Drawing.Point(28, 40);
            this.tbarRechts.Name = "tbarRechts";
            this.tbarRechts.Size = new System.Drawing.Size(249, 56);
            this.tbarRechts.TabIndex = 57;
            this.tbarRechts.Scroll += new System.EventHandler(this.tbarRechts_Scroll);
            // 
            // tbarLinks
            // 
            this.tbarLinks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbarLinks.BackColor = System.Drawing.Color.White;
            this.tbarLinks.Location = new System.Drawing.Point(28, 124);
            this.tbarLinks.Name = "tbarLinks";
            this.tbarLinks.Size = new System.Drawing.Size(249, 56);
            this.tbarLinks.TabIndex = 58;
            this.tbarLinks.Scroll += new System.EventHandler(this.tbarLinks_Scroll);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.Blue;
            this.panel6.Controls.Add(this.tbarLinks);
            this.panel6.Controls.Add(this.tbarRechts);
            this.panel6.Location = new System.Drawing.Point(310, 483);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(306, 217);
            this.panel6.TabIndex = 66;
            // 
            // Platform_Bediening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 1000);
            this.Controls.Add(this.btn5V);
            this.Controls.Add(this.btn12V);
            this.Controls.Add(this.btnGrounds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnJ2_P3);
            this.Controls.Add(this.btnJ2_P2);
            this.Controls.Add(this.btnJ2_P1);
            this.Controls.Add(this.btnJ1_P5);
            this.Controls.Add(this.btnJ7_P10);
            this.Controls.Add(this.btnJ7_P6);
            this.Controls.Add(this.btnJ7_P5);
            this.Controls.Add(this.btnJ7_P4);
            this.Controls.Add(this.tbRun);
            this.Controls.Add(this.btnJ3_P1);
            this.Controls.Add(this.btnJ7_P15);
            this.Controls.Add(this.btnJ1_P7);
            this.Controls.Add(this.btnJ1_P6);
            this.Controls.Add(this.btnJ1_P4);
            this.Controls.Add(this.btnJ7_P14);
            this.Controls.Add(this.btnJ3_P3);
            this.Controls.Add(this.btnJ2_P5);
            this.Controls.Add(this.btnJ1_P11);
            this.Controls.Add(this.btnJ1_P10);
            this.Controls.Add(this.btnJ1_P8);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.cbCom);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.btnVoet);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnY1U);
            this.Controls.Add(this.btnY1D);
            this.Controls.Add(this.trSnelheid);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Platform_Bediening";
            this.Text = "Platform_Bediening";
            this.Load += new System.EventHandler(this.Platform_Bediening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trSnelheid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbarRechts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarLinks)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.ComboBox cbCom;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Button btnVoet;
        private System.Windows.Forms.Button btnY2L;
        private System.Windows.Forms.Button btnY2R;
        private System.Windows.Forms.Button btnY1U;
        private System.Windows.Forms.Button btnY1D;
        private System.Windows.Forms.TrackBar trSnelheid;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnP4D;
        private System.Windows.Forms.Button btnP4U;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnP3D;
        private System.Windows.Forms.Button btnP3U;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnP2D;
        private System.Windows.Forms.Button btnP2U;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnP1D;
        private System.Windows.Forms.Button btnP1U;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnJ3_P1;
        private System.Windows.Forms.Button btnJ7_P15;
        private System.Windows.Forms.Button btnJ1_P7;
        private System.Windows.Forms.Button btnJ1_P6;
        private System.Windows.Forms.Button btnJ1_P4;
        private System.Windows.Forms.Button btnJ7_P14;
        private System.Windows.Forms.Button btnJ3_P3;
        private System.Windows.Forms.Button btnJ2_P5;
        private System.Windows.Forms.Button btnJ1_P11;
        private System.Windows.Forms.Button btnJ1_P10;
        private System.Windows.Forms.Button btnJ1_P8;
        private System.Windows.Forms.TextBox tbRun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnJ2_P3;
        private System.Windows.Forms.Button btnJ2_P2;
        private System.Windows.Forms.Button btnJ2_P1;
        private System.Windows.Forms.Button btnJ1_P5;
        private System.Windows.Forms.Button btnJ7_P10;
        private System.Windows.Forms.Button btnJ7_P6;
        private System.Windows.Forms.Button btnJ7_P5;
        private System.Windows.Forms.Button btnJ7_P4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn5V;
        private System.Windows.Forms.Button btn12V;
        private System.Windows.Forms.Button btnGrounds;
        private System.Windows.Forms.TrackBar tbarRechts;
        private System.Windows.Forms.TrackBar tbarLinks;
        private System.Windows.Forms.Panel panel6;
    }
}