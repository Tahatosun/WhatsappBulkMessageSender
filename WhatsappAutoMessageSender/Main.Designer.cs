namespace WhatsappAutoMessageSender
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnStart = new MetroFramework.Controls.MetroTile();
            this.btnStop = new MetroFramework.Controls.MetroTile();
            this.btnLoginWhatsapp = new MetroFramework.Controls.MetroTile();
            this.grpBxMessage = new System.Windows.Forms.GroupBox();
            this.radioBtnFile = new MetroFramework.Controls.MetroRadioButton();
            this.radioBtnImageOrvideo = new MetroFramework.Controls.MetroRadioButton();
            this.radioBtnText = new MetroFramework.Controls.MetroRadioButton();
            this.txtBxMessageText = new System.Windows.Forms.RichTextBox();
            this.grpBxFilePath = new System.Windows.Forms.GroupBox();
            this.txtBxFilePath = new System.Windows.Forms.TextBox();
            this.btnFind = new MetroFramework.Controls.MetroButton();
            this.grpBxPhoneNumbers = new System.Windows.Forms.GroupBox();
            this.lblNumbersCount = new System.Windows.Forms.Label();
            this.lstBxNumbers = new System.Windows.Forms.ListBox();
            this.btnImprotNumbers = new MetroFramework.Controls.MetroTile();
            this.dataGridİnfos = new MetroFramework.Controls.MetroGrid();
            this.grpBxInfos = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFailedProcess = new MetroFramework.Controls.MetroLabel();
            this.l = new System.Windows.Forms.Label();
            this.lblSuccedProcess = new MetroFramework.Controls.MetroLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBxSettings = new System.Windows.Forms.GroupBox();
            this.txtWaitBeforeEveryMessage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMessageCountForWait = new System.Windows.Forms.TextBox();
            this.txtWait = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpBxMessage.SuspendLayout();
            this.grpBxFilePath.SuspendLayout();
            this.grpBxPhoneNumbers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridİnfos)).BeginInit();
            this.grpBxInfos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpBxSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.ActiveControl = null;
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(644, 38);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 36);
            this.btnStart.Style = MetroFramework.MetroColorStyle.Green;
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.ActiveControl = null;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(781, 38);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(122, 36);
            this.btnStop.Style = MetroFramework.MetroColorStyle.Red;
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "STOP";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStop.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnStop.UseSelectable = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLoginWhatsapp
            // 
            this.btnLoginWhatsapp.ActiveControl = null;
            this.btnLoginWhatsapp.Location = new System.Drawing.Point(429, 38);
            this.btnLoginWhatsapp.Name = "btnLoginWhatsapp";
            this.btnLoginWhatsapp.Size = new System.Drawing.Size(209, 36);
            this.btnLoginWhatsapp.Style = MetroFramework.MetroColorStyle.Green;
            this.btnLoginWhatsapp.TabIndex = 3;
            this.btnLoginWhatsapp.Text = "LOGİN WEB WHATSAPP";
            this.btnLoginWhatsapp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoginWhatsapp.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnLoginWhatsapp.UseSelectable = true;
            this.btnLoginWhatsapp.Click += new System.EventHandler(this.btnLoginWhatsapp_Click);
            // 
            // grpBxMessage
            // 
            this.grpBxMessage.BackColor = System.Drawing.Color.White;
            this.grpBxMessage.Controls.Add(this.radioBtnFile);
            this.grpBxMessage.Controls.Add(this.radioBtnImageOrvideo);
            this.grpBxMessage.Controls.Add(this.radioBtnText);
            this.grpBxMessage.Controls.Add(this.txtBxMessageText);
            this.grpBxMessage.Controls.Add(this.grpBxFilePath);
            this.grpBxMessage.Location = new System.Drawing.Point(389, 80);
            this.grpBxMessage.Name = "grpBxMessage";
            this.grpBxMessage.Size = new System.Drawing.Size(514, 291);
            this.grpBxMessage.TabIndex = 8;
            this.grpBxMessage.TabStop = false;
            this.grpBxMessage.Text = "Message";
            // 
            // radioBtnFile
            // 
            this.radioBtnFile.AutoSize = true;
            this.radioBtnFile.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radioBtnFile.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.radioBtnFile.Location = new System.Drawing.Point(434, 12);
            this.radioBtnFile.Name = "radioBtnFile";
            this.radioBtnFile.Size = new System.Drawing.Size(48, 19);
            this.radioBtnFile.TabIndex = 13;
            this.radioBtnFile.Text = "File";
            this.radioBtnFile.UseSelectable = true;
            this.radioBtnFile.CheckedChanged += new System.EventHandler(this.radioButtonCheckControl);
            // 
            // radioBtnImageOrvideo
            // 
            this.radioBtnImageOrvideo.AutoSize = true;
            this.radioBtnImageOrvideo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radioBtnImageOrvideo.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.radioBtnImageOrvideo.ForeColor = System.Drawing.Color.Black;
            this.radioBtnImageOrvideo.Location = new System.Drawing.Point(292, 12);
            this.radioBtnImageOrvideo.Name = "radioBtnImageOrvideo";
            this.radioBtnImageOrvideo.Size = new System.Drawing.Size(131, 19);
            this.radioBtnImageOrvideo.TabIndex = 12;
            this.radioBtnImageOrvideo.Text = "Image Or Video";
            this.radioBtnImageOrvideo.UseSelectable = true;
            this.radioBtnImageOrvideo.CheckedChanged += new System.EventHandler(this.radioButtonCheckControl);
            // 
            // radioBtnText
            // 
            this.radioBtnText.AutoSize = true;
            this.radioBtnText.Checked = true;
            this.radioBtnText.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radioBtnText.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.radioBtnText.Location = new System.Drawing.Point(229, 12);
            this.radioBtnText.Name = "radioBtnText";
            this.radioBtnText.Size = new System.Drawing.Size(53, 19);
            this.radioBtnText.TabIndex = 11;
            this.radioBtnText.TabStop = true;
            this.radioBtnText.Text = "Text";
            this.radioBtnText.UseSelectable = true;
            this.radioBtnText.CheckedChanged += new System.EventHandler(this.radioButtonCheckControl);
            // 
            // txtBxMessageText
            // 
            this.txtBxMessageText.Location = new System.Drawing.Point(7, 37);
            this.txtBxMessageText.Name = "txtBxMessageText";
            this.txtBxMessageText.Size = new System.Drawing.Size(498, 164);
            this.txtBxMessageText.TabIndex = 10;
            this.txtBxMessageText.Text = "";
            // 
            // grpBxFilePath
            // 
            this.grpBxFilePath.Controls.Add(this.txtBxFilePath);
            this.grpBxFilePath.Controls.Add(this.btnFind);
            this.grpBxFilePath.Enabled = false;
            this.grpBxFilePath.Location = new System.Drawing.Point(10, 207);
            this.grpBxFilePath.Name = "grpBxFilePath";
            this.grpBxFilePath.Size = new System.Drawing.Size(498, 71);
            this.grpBxFilePath.TabIndex = 9;
            this.grpBxFilePath.TabStop = false;
            this.grpBxFilePath.Text = "File Path";
            // 
            // txtBxFilePath
            // 
            this.txtBxFilePath.Location = new System.Drawing.Point(7, 27);
            this.txtBxFilePath.Name = "txtBxFilePath";
            this.txtBxFilePath.Size = new System.Drawing.Size(411, 24);
            this.txtBxFilePath.TabIndex = 6;
            // 
            // btnFind
            // 
            this.btnFind.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnFind.Location = new System.Drawing.Point(424, 23);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(68, 28);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find";
            this.btnFind.UseSelectable = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // grpBxPhoneNumbers
            // 
            this.grpBxPhoneNumbers.BackColor = System.Drawing.Color.White;
            this.grpBxPhoneNumbers.Controls.Add(this.lblNumbersCount);
            this.grpBxPhoneNumbers.Controls.Add(this.lstBxNumbers);
            this.grpBxPhoneNumbers.Controls.Add(this.btnImprotNumbers);
            this.grpBxPhoneNumbers.Location = new System.Drawing.Point(14, 80);
            this.grpBxPhoneNumbers.Name = "grpBxPhoneNumbers";
            this.grpBxPhoneNumbers.Size = new System.Drawing.Size(369, 291);
            this.grpBxPhoneNumbers.TabIndex = 7;
            this.grpBxPhoneNumbers.TabStop = false;
            this.grpBxPhoneNumbers.Text = "Phone Numbers";
            // 
            // lblNumbersCount
            // 
            this.lblNumbersCount.AutoSize = true;
            this.lblNumbersCount.Location = new System.Drawing.Point(179, 20);
            this.lblNumbersCount.Name = "lblNumbersCount";
            this.lblNumbersCount.Size = new System.Drawing.Size(132, 19);
            this.lblNumbersCount.TabIndex = 3;
            this.lblNumbersCount.Text = "Numbers Count: 0";
            // 
            // lstBxNumbers
            // 
            this.lstBxNumbers.FormattingEnabled = true;
            this.lstBxNumbers.ItemHeight = 19;
            this.lstBxNumbers.Location = new System.Drawing.Point(183, 53);
            this.lstBxNumbers.Name = "lstBxNumbers";
            this.lstBxNumbers.Size = new System.Drawing.Size(180, 213);
            this.lstBxNumbers.TabIndex = 1;
            // 
            // btnImprotNumbers
            // 
            this.btnImprotNumbers.ActiveControl = null;
            this.btnImprotNumbers.Location = new System.Drawing.Point(18, 53);
            this.btnImprotNumbers.Name = "btnImprotNumbers";
            this.btnImprotNumbers.Size = new System.Drawing.Size(139, 45);
            this.btnImprotNumbers.Style = MetroFramework.MetroColorStyle.Green;
            this.btnImprotNumbers.TabIndex = 0;
            this.btnImprotNumbers.Text = "İmport Number";
            this.btnImprotNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImprotNumbers.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnImprotNumbers.UseSelectable = true;
            this.btnImprotNumbers.Click += new System.EventHandler(this.btnImprotNumbers_Click);
            // 
            // dataGridİnfos
            // 
            this.dataGridİnfos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridİnfos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridİnfos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridİnfos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridİnfos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridİnfos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridİnfos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridİnfos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridİnfos.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridİnfos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridİnfos.EnableHeadersVisualStyles = false;
            this.dataGridİnfos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridİnfos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridİnfos.Location = new System.Drawing.Point(6, 29);
            this.dataGridİnfos.Name = "dataGridİnfos";
            this.dataGridİnfos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridİnfos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridİnfos.RowHeadersWidth = 40;
            this.dataGridİnfos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridİnfos.RowTemplate.Height = 30;
            this.dataGridİnfos.RowTemplate.ReadOnly = true;
            this.dataGridİnfos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridİnfos.Size = new System.Drawing.Size(877, 234);
            this.dataGridİnfos.Style = MetroFramework.MetroColorStyle.Green;
            this.dataGridİnfos.TabIndex = 6;
            // 
            // grpBxInfos
            // 
            this.grpBxInfos.Controls.Add(this.dataGridİnfos);
            this.grpBxInfos.Location = new System.Drawing.Point(14, 457);
            this.grpBxInfos.Name = "grpBxInfos";
            this.grpBxInfos.Size = new System.Drawing.Size(889, 263);
            this.grpBxInfos.TabIndex = 10;
            this.grpBxInfos.TabStop = false;
            this.grpBxInfos.Text = "INFOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFailedProcess);
            this.panel1.Controls.Add(this.l);
            this.panel1.Controls.Add(this.lblSuccedProcess);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(14, 726);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 48);
            this.panel1.TabIndex = 11;
            // 
            // lblFailedProcess
            // 
            this.lblFailedProcess.AutoSize = true;
            this.lblFailedProcess.BackColor = System.Drawing.Color.Red;
            this.lblFailedProcess.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblFailedProcess.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblFailedProcess.ForeColor = System.Drawing.Color.White;
            this.lblFailedProcess.Location = new System.Drawing.Point(813, 12);
            this.lblFailedProcess.Name = "lblFailedProcess";
            this.lblFailedProcess.Size = new System.Drawing.Size(22, 25);
            this.lblFailedProcess.TabIndex = 3;
            this.lblFailedProcess.Text = "0";
            this.lblFailedProcess.UseCustomBackColor = true;
            this.lblFailedProcess.UseCustomForeColor = true;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l.Location = new System.Drawing.Point(659, 14);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(148, 23);
            this.l.TabIndex = 2;
            this.l.Text = "Failed process:";
            // 
            // lblSuccedProcess
            // 
            this.lblSuccedProcess.AutoSize = true;
            this.lblSuccedProcess.BackColor = System.Drawing.Color.Lime;
            this.lblSuccedProcess.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSuccedProcess.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSuccedProcess.ForeColor = System.Drawing.Color.White;
            this.lblSuccedProcess.Location = new System.Drawing.Point(571, 14);
            this.lblSuccedProcess.Name = "lblSuccedProcess";
            this.lblSuccedProcess.Size = new System.Drawing.Size(22, 25);
            this.lblSuccedProcess.TabIndex = 1;
            this.lblSuccedProcess.Text = "0";
            this.lblSuccedProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSuccedProcess.UseCustomBackColor = true;
            this.lblSuccedProcess.UseCustomForeColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(409, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Succed process:";
            // 
            // grpBxSettings
            // 
            this.grpBxSettings.Controls.Add(this.txtWaitBeforeEveryMessage);
            this.grpBxSettings.Controls.Add(this.label7);
            this.grpBxSettings.Controls.Add(this.label8);
            this.grpBxSettings.Controls.Add(this.panel2);
            this.grpBxSettings.Controls.Add(this.label5);
            this.grpBxSettings.Controls.Add(this.txtMessageCountForWait);
            this.grpBxSettings.Controls.Add(this.txtWait);
            this.grpBxSettings.Controls.Add(this.label4);
            this.grpBxSettings.Controls.Add(this.label2);
            this.grpBxSettings.Location = new System.Drawing.Point(14, 378);
            this.grpBxSettings.Name = "grpBxSettings";
            this.grpBxSettings.Size = new System.Drawing.Size(889, 70);
            this.grpBxSettings.TabIndex = 12;
            this.grpBxSettings.TabStop = false;
            // 
            // txtWaitBeforeEveryMessage
            // 
            this.txtWaitBeforeEveryMessage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtWaitBeforeEveryMessage.Location = new System.Drawing.Point(483, 23);
            this.txtWaitBeforeEveryMessage.Name = "txtWaitBeforeEveryMessage";
            this.txtWaitBeforeEveryMessage.Size = new System.Drawing.Size(35, 27);
            this.txtWaitBeforeEveryMessage.TabIndex = 8;
            this.txtWaitBeforeEveryMessage.Text = "5";
            this.txtWaitBeforeEveryMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(522, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "seconds before sending new messages";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(437, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Wait";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(422, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 40);
            this.panel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(324, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "message.";
            // 
            // txtMessageCountForWait
            // 
            this.txtMessageCountForWait.Location = new System.Drawing.Point(286, 24);
            this.txtMessageCountForWait.Name = "txtMessageCountForWait";
            this.txtMessageCountForWait.Size = new System.Drawing.Size(35, 24);
            this.txtMessageCountForWait.TabIndex = 3;
            this.txtMessageCountForWait.Text = "10";
            this.txtMessageCountForWait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWait
            // 
            this.txtWait.Location = new System.Drawing.Point(77, 24);
            this.txtWait.Name = "txtWait";
            this.txtWait.Size = new System.Drawing.Size(35, 24);
            this.txtWait.TabIndex = 2;
            this.txtWait.Text = "600";
            this.txtWait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(118, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "seconds after every";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wait";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(920, 800);
            this.Controls.Add(this.grpBxSettings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpBxInfos);
            this.Controls.Add(this.grpBxMessage);
            this.Controls.Add(this.grpBxPhoneNumbers);
            this.Controls.Add(this.btnLoginWhatsapp);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Main";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBxMessage.ResumeLayout(false);
            this.grpBxMessage.PerformLayout();
            this.grpBxFilePath.ResumeLayout(false);
            this.grpBxFilePath.PerformLayout();
            this.grpBxPhoneNumbers.ResumeLayout(false);
            this.grpBxPhoneNumbers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridİnfos)).EndInit();
            this.grpBxInfos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpBxSettings.ResumeLayout(false);
            this.grpBxSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile btnStart;
        private MetroFramework.Controls.MetroTile btnStop;
        private MetroFramework.Controls.MetroTile btnLoginWhatsapp;
        private System.Windows.Forms.GroupBox grpBxMessage;
        private MetroFramework.Controls.MetroRadioButton radioBtnFile;
        private MetroFramework.Controls.MetroRadioButton radioBtnImageOrvideo;
        private MetroFramework.Controls.MetroRadioButton radioBtnText;
        private System.Windows.Forms.RichTextBox txtBxMessageText;
        private System.Windows.Forms.GroupBox grpBxFilePath;
        private System.Windows.Forms.TextBox txtBxFilePath;
        private MetroFramework.Controls.MetroButton btnFind;
        private System.Windows.Forms.GroupBox grpBxPhoneNumbers;
        private System.Windows.Forms.ListBox lstBxNumbers;
        private MetroFramework.Controls.MetroTile btnImprotNumbers;
        private MetroFramework.Controls.MetroGrid dataGridİnfos;
        private System.Windows.Forms.GroupBox grpBxInfos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroLabel lblFailedProcess;
        private System.Windows.Forms.Label l;
        private MetroFramework.Controls.MetroLabel lblSuccedProcess;
        private System.Windows.Forms.GroupBox grpBxSettings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMessageCountForWait;
        private System.Windows.Forms.TextBox txtWait;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWaitBeforeEveryMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNumbersCount;
        private System.Windows.Forms.Timer timer1;
    }
}

