using System.Drawing;

namespace UnrealPackManager
{
    partial class UnrealPackManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnrealPackManager));
            this.MenuP = new System.Windows.Forms.TableLayoutPanel();
            this.exit = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Button();
            this.UnrealPak = new System.Windows.Forms.Button();
            this.UECastoc = new System.Windows.Forms.Button();
            this.UECastocP = new System.Windows.Forms.Panel();
            this.rdmchunkid = new System.Windows.Forms.Button();
            this.chunkid = new System.Windows.Forms.TextBox();
            this.cstmnam = new System.Windows.Forms.CheckBox();
            this.customnam = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.Unpacklb = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.aeske = new System.Windows.Forms.TextBox();
            this.runer = new System.ComponentModel.BackgroundWorker();
            this.SettingsP = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OutputSet = new System.Windows.Forms.Label();
            this.UECastocSet = new System.Windows.Forms.Label();
            this.UnrealPakSet = new System.Windows.Forms.Label();
            this.logger = new System.Windows.Forms.TextBox();
            this.UnrealPakP = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.runer2 = new System.ComponentModel.BackgroundWorker();
            this.MenuP.SuspendLayout();
            this.UECastocP.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SettingsP.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.UnrealPakP.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuP
            // 
            this.MenuP.AutoSize = true;
            this.MenuP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MenuP.ColumnCount = 5;
            this.MenuP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.9962F));
            this.MenuP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.89734F));
            this.MenuP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.01141F));
            this.MenuP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MenuP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MenuP.Controls.Add(this.exit, 4, 0);
            this.MenuP.Controls.Add(this.Settings, 3, 0);
            this.MenuP.Controls.Add(this.UnrealPak, 1, 0);
            this.MenuP.Controls.Add(this.UECastoc, 0, 0);
            this.MenuP.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuP.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.MenuP.Location = new System.Drawing.Point(0, 0);
            this.MenuP.Name = "MenuP";
            this.MenuP.RowCount = 1;
            this.MenuP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MenuP.Size = new System.Drawing.Size(284, 28);
            this.MenuP.TabIndex = 0;
            this.MenuP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UnrealPackManager_MouseDown);
            this.MenuP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UnrealPackManager_MouseMove);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exit.Location = new System.Drawing.Point(266, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(15, 28);
            this.exit.TabIndex = 4;
            this.exit.Text = "X";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Settings
            // 
            this.Settings.AutoSize = true;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Settings.Location = new System.Drawing.Point(200, 3);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(60, 22);
            this.Settings.TabIndex = 3;
            this.Settings.Text = "Settings";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            this.Settings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UnrealPackManager_MouseDown);
            this.Settings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UnrealPackManager_MouseMove);
            // 
            // UnrealPak
            // 
            this.UnrealPak.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UnrealPak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnrealPak.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.UnrealPak.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.UnrealPak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.UnrealPak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.UnrealPak.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UnrealPak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnrealPak.Location = new System.Drawing.Point(74, 3);
            this.UnrealPak.Name = "UnrealPak";
            this.UnrealPak.Size = new System.Drawing.Size(70, 22);
            this.UnrealPak.TabIndex = 1;
            this.UnrealPak.Text = "UnrealPak";
            this.UnrealPak.Click += new System.EventHandler(this.UnrealPak_Click);
            this.UnrealPak.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UnrealPackManager_MouseDown);
            this.UnrealPak.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UnrealPackManager_MouseMove);
            // 
            // UECastoc
            // 
            this.UECastoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UECastoc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.UECastoc.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.UECastoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.UECastoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.UECastoc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UECastoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UECastoc.Location = new System.Drawing.Point(3, 3);
            this.UECastoc.Name = "UECastoc";
            this.UECastoc.Size = new System.Drawing.Size(65, 22);
            this.UECastoc.TabIndex = 0;
            this.UECastoc.Text = "UECastoc";
            this.UECastoc.Click += new System.EventHandler(this.UECastoc_Click);
            this.UECastoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UnrealPackManager_MouseDown);
            this.UECastoc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UnrealPackManager_MouseMove);
            // 
            // UECastocP
            // 
            this.UECastocP.Controls.Add(this.rdmchunkid);
            this.UECastocP.Controls.Add(this.chunkid);
            this.UECastocP.Controls.Add(this.cstmnam);
            this.UECastocP.Controls.Add(this.customnam);
            this.UECastocP.Controls.Add(this.tableLayoutPanel3);
            this.UECastocP.Controls.Add(this.tableLayoutPanel2);
            this.UECastocP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UECastocP.Location = new System.Drawing.Point(0, 28);
            this.UECastocP.Name = "UECastocP";
            this.UECastocP.Size = new System.Drawing.Size(284, 133);
            this.UECastocP.TabIndex = 1;
            // 
            // rdmchunkid
            // 
            this.rdmchunkid.Location = new System.Drawing.Point(3, 82);
            this.rdmchunkid.Name = "rdmchunkid";
            this.rdmchunkid.Size = new System.Drawing.Size(136, 20);
            this.rdmchunkid.TabIndex = 7;
            this.rdmchunkid.Text = "Chunk ID Randomizer";
            this.rdmchunkid.UseVisualStyleBackColor = true;
            this.rdmchunkid.Click += new System.EventHandler(this.rdmchunkid_Click);
            // 
            // chunkid
            // 
            this.chunkid.Location = new System.Drawing.Point(3, 101);
            this.chunkid.Name = "chunkid";
            this.chunkid.Size = new System.Drawing.Size(136, 20);
            this.chunkid.TabIndex = 6;
            // 
            // cstmnam
            // 
            this.cstmnam.AutoSize = true;
            this.cstmnam.Location = new System.Drawing.Point(177, 85);
            this.cstmnam.Name = "cstmnam";
            this.cstmnam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cstmnam.Size = new System.Drawing.Size(95, 17);
            this.cstmnam.TabIndex = 5;
            this.cstmnam.Text = "Custom_Name";
            this.cstmnam.UseVisualStyleBackColor = true;
            this.cstmnam.CheckedChanged += new System.EventHandler(this.cstmnam_CheckedChanged);
            // 
            // customnam
            // 
            this.customnam.Location = new System.Drawing.Point(145, 101);
            this.customnam.Name = "customnam";
            this.customnam.Size = new System.Drawing.Size(136, 20);
            this.customnam.TabIndex = 4;
            this.customnam.TextChanged += new System.EventHandler(this.customnam_TextChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Unpacklb, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(284, 51);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 51);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pack";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.DragDrop += new System.Windows.Forms.DragEventHandler(this.Pack_DragDrop);
            this.label3.DragEnter += new System.Windows.Forms.DragEventHandler(this.Pack_DragEnter);
            // 
            // Unpacklb
            // 
            this.Unpacklb.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.Unpacklb.AllowDrop = true;
            this.Unpacklb.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Unpacklb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Unpacklb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Unpacklb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unpacklb.Location = new System.Drawing.Point(3, 0);
            this.Unpacklb.Name = "Unpacklb";
            this.Unpacklb.Size = new System.Drawing.Size(136, 51);
            this.Unpacklb.TabIndex = 5;
            this.Unpacklb.Text = "UnpackUcas or Utoc";
            this.Unpacklb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Unpacklb.DragDrop += new System.Windows.Forms.DragEventHandler(this.Unpack_DragDrop);
            this.Unpacklb.DragEnter += new System.Windows.Forms.DragEventHandler(this.Unpack_DragEnter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.aeske, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(284, 28);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "AES Key";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aeske
            // 
            this.aeske.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aeske.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aeske.Location = new System.Drawing.Point(75, 3);
            this.aeske.Name = "aeske";
            this.aeske.Size = new System.Drawing.Size(206, 20);
            this.aeske.TabIndex = 5;
            // 
            // runer
            // 
            this.runer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.runcmd_DoWork);
            this.runer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ProcessExited1);
            // 
            // SettingsP
            // 
            this.SettingsP.Controls.Add(this.tableLayoutPanel4);
            this.SettingsP.Controls.Add(this.tableLayoutPanel1);
            this.SettingsP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsP.Location = new System.Drawing.Point(0, 28);
            this.SettingsP.Name = "SettingsP";
            this.SettingsP.Size = new System.Drawing.Size(284, 133);
            this.SettingsP.TabIndex = 4;
            this.SettingsP.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.02817F));
            this.tableLayoutPanel4.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(284, 28);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "Open JSON";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.JSONOPEN_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.OutputSet, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UECastocSet, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UnrealPakSet, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 105);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // OutputSet
            // 
            this.OutputSet.AllowDrop = true;
            this.OutputSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OutputSet.Location = new System.Drawing.Point(191, 0);
            this.OutputSet.Name = "OutputSet";
            this.OutputSet.Size = new System.Drawing.Size(90, 105);
            this.OutputSet.TabIndex = 4;
            this.OutputSet.Text = "Drag and Drop Output Folder";
            this.OutputSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OutputSet.DragDrop += new System.Windows.Forms.DragEventHandler(this.OutputSet_DragDrop);
            this.OutputSet.DragEnter += new System.Windows.Forms.DragEventHandler(this.OutputSet_DragEnter);
            // 
            // UECastocSet
            // 
            this.UECastocSet.AllowDrop = true;
            this.UECastocSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UECastocSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UECastocSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UECastocSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UECastocSet.Location = new System.Drawing.Point(97, 0);
            this.UECastocSet.Name = "UECastocSet";
            this.UECastocSet.Size = new System.Drawing.Size(88, 105);
            this.UECastocSet.TabIndex = 2;
            this.UECastocSet.Text = "Drag and Drop UECastoc\'s EXE";
            this.UECastocSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UECastocSet.DragDrop += new System.Windows.Forms.DragEventHandler(this.UECastocSet_DragDrop);
            this.UECastocSet.DragEnter += new System.Windows.Forms.DragEventHandler(this.UECastocSet_DragEnter);
            // 
            // UnrealPakSet
            // 
            this.UnrealPakSet.AllowDrop = true;
            this.UnrealPakSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnrealPakSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnrealPakSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnrealPakSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UnrealPakSet.Location = new System.Drawing.Point(3, 0);
            this.UnrealPakSet.Name = "UnrealPakSet";
            this.UnrealPakSet.Size = new System.Drawing.Size(88, 105);
            this.UnrealPakSet.TabIndex = 1;
            this.UnrealPakSet.Text = "Drag and Drop UnrealPak\'s EXE";
            this.UnrealPakSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UnrealPakSet.DragDrop += new System.Windows.Forms.DragEventHandler(this.UnrealPakSet_DragDrop);
            this.UnrealPakSet.DragEnter += new System.Windows.Forms.DragEventHandler(this.UnrealPakSet_DragEnter);
            // 
            // logger
            // 
            this.logger.AcceptsReturn = true;
            this.logger.AcceptsTab = true;
            this.logger.BackColor = System.Drawing.Color.LightCoral;
            this.logger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logger.Location = new System.Drawing.Point(0, 28);
            this.logger.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.logger.MaxLength = 327670;
            this.logger.Multiline = true;
            this.logger.Name = "logger";
            this.logger.ReadOnly = true;
            this.logger.Size = new System.Drawing.Size(284, 133);
            this.logger.TabIndex = 36;
            this.logger.Visible = false;
            this.logger.WordWrap = false;
            this.logger.Click += new System.EventHandler(this.logger_Click);
            // 
            // UnrealPakP
            // 
            this.UnrealPakP.Controls.Add(this.tableLayoutPanel5);
            this.UnrealPakP.Controls.Add(this.tableLayoutPanel6);
            this.UnrealPakP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnrealPakP.Location = new System.Drawing.Point(0, 28);
            this.UnrealPakP.Name = "UnrealPakP";
            this.UnrealPakP.Size = new System.Drawing.Size(284, 133);
            this.UnrealPakP.TabIndex = 37;
            this.UnrealPakP.Visible = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(284, 102);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 51);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fix Manifest after Unpack Click Here";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 51);
            this.label6.TabIndex = 7;
            this.label6.Text = "Manifest";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 51);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pack";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label8.AllowDrop = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 51);
            this.label8.TabIndex = 5;
            this.label8.Text = "UnpackUcas or Utoc";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel6.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(284, 28);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 28);
            this.label9.TabIndex = 4;
            this.label9.Text = "AES Key";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(75, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 5;
            // 
            // runer2
            // 
            this.runer2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.runcmd2_DoWork);
            this.runer2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ProcessExited2);
            // 
            // UnrealPackManager
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.logger);
            this.Controls.Add(this.UECastocP);
            this.Controls.Add(this.UnrealPakP);
            this.Controls.Add(this.SettingsP);
            this.Controls.Add(this.MenuP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnrealPackManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnrealPackManager";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Green;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UnrealPackManager_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UnrealPackManager_MouseMove);
            this.MenuP.ResumeLayout(false);
            this.MenuP.PerformLayout();
            this.UECastocP.ResumeLayout(false);
            this.UECastocP.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.SettingsP.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.UnrealPakP.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        Point lastPoint;
        private System.Windows.Forms.TableLayoutPanel MenuP;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel UECastocP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Unpacklb;
        private System.Windows.Forms.Button UnrealPak;
        private System.Windows.Forms.Button UECastoc;
        private System.Windows.Forms.Button Settings;
        private System.ComponentModel.BackgroundWorker runer;
        private System.Windows.Forms.Panel SettingsP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label OutputSet;
        private System.Windows.Forms.Label UECastocSet;
        private System.Windows.Forms.Label UnrealPakSet;
        private System.Windows.Forms.TextBox logger;
        private System.Windows.Forms.TextBox aeske;
        private System.Windows.Forms.Panel UnrealPakP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker runer2;
        private System.Windows.Forms.Button rdmchunkid;
        private System.Windows.Forms.TextBox chunkid;
        private System.Windows.Forms.CheckBox cstmnam;
        private System.Windows.Forms.TextBox customnam;
    }
}

