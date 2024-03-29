﻿namespace IES_2
{
    partial class frmMain
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

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvParameters;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvErrors;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnConnect;
        private System.ComponentModel.BackgroundWorker bgwIsoWait;
        private System.ComponentModel.BackgroundWorker bgwParameters;
        private System.ComponentModel.BackgroundWorker bgwTest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabPage tabPage0;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCOM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvECU;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblEcuType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblRepCode;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblIsoCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn comCOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ecuECU;
        private System.ComponentModel.BackgroundWorker bgwDemo;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label infoOptions;
        private System.Windows.Forms.Label infoMessage;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox cblTraces;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.CheckBox cbLOG;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.DataGridViewTextBoxColumn errDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn errReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn errState;
        private System.Windows.Forms.DataGridViewCheckBoxColumn errMIL;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox cbCompat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn parChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn parName;
        private System.Windows.Forms.DataGridViewTextBoxColumn parValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn parUnit;
        private System.Windows.Forms.TextBox tbHelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.DataGridView dgvAdjusts;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnAdj;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.lblIsoCode = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblEcuType = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblRepCode = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage0 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCOM = new System.Windows.Forms.DataGridView();
            this.comCOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbCompat = new System.Windows.Forms.CheckBox();
            this.cbLOG = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvECU = new System.Windows.Forms.DataGridView();
            this.ecuECU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbHelp = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvParameters = new System.Windows.Forms.DataGridView();
            this.parChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.parName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cbQueryErrors = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvErrors = new System.Windows.Forms.DataGridView();
            this.errDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errMIL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cblTraces = new System.Windows.Forms.CheckedListBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnGraph = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAdjusts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAdj = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.bgwIsoWait = new System.ComponentModel.BackgroundWorker();
            this.bgwParameters = new System.ComponentModel.BackgroundWorker();
            this.bgwTest = new System.ComponentModel.BackgroundWorker();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.infoOptions = new System.Windows.Forms.Label();
            this.infoMessage = new System.Windows.Forms.Label();
            this.bgwDemo = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage0.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCOM)).BeginInit();
            this.panel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvECU)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameters)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrors)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjusts)).BeginInit();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.lblIsoCode);
            this.panel2.Controls.Add(this.lblCarModel);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.lblEcuType);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.lblRepCode);
            this.panel2.Controls.Add(this.btnConnect);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // lblIsoCode
            // 
            resources.ApplyResources(this.lblIsoCode, "lblIsoCode");
            this.lblIsoCode.Name = "lblIsoCode";
            // 
            // lblCarModel
            // 
            resources.ApplyResources(this.lblCarModel, "lblCarModel");
            this.lblCarModel.Name = "lblCarModel";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // lblEcuType
            // 
            resources.ApplyResources(this.lblEcuType, "lblEcuType");
            this.lblEcuType.Name = "lblEcuType";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // lblRepCode
            // 
            resources.ApplyResources(this.lblRepCode, "lblRepCode");
            this.lblRepCode.Name = "lblRepCode";
            // 
            // btnConnect
            // 
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.ForeColor = System.Drawing.Color.Red;
            this.btnConnect.Name = "btnConnect";
            this.toolTip1.SetToolTip(this.btnConnect, resources.GetString("btnConnect.ToolTip"));
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage0);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.HotTrack = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage0
            // 
            this.tabPage0.Controls.Add(this.tableLayoutPanel4);
            resources.ApplyResources(this.tabPage0, "tabPage0");
            this.tabPage0.Name = "tabPage0";
            this.tabPage0.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel7);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.dgvCOM, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // dgvCOM
            // 
            this.dgvCOM.AllowUserToAddRows = false;
            this.dgvCOM.AllowUserToDeleteRows = false;
            this.dgvCOM.AllowUserToResizeColumns = false;
            this.dgvCOM.AllowUserToResizeRows = false;
            this.dgvCOM.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCOM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCOM.ColumnHeadersVisible = false;
            this.dgvCOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comCOM});
            resources.ApplyResources(this.dgvCOM, "dgvCOM");
            this.dgvCOM.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCOM.MultiSelect = false;
            this.dgvCOM.Name = "dgvCOM";
            this.dgvCOM.ReadOnly = true;
            this.dgvCOM.RowHeadersVisible = false;
            this.dgvCOM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCOM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCOM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCOM_CellClick);
            // 
            // comCOM
            // 
            this.comCOM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.comCOM, "comCOM");
            this.comCOM.Name = "comCOM";
            this.comCOM.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbCompat);
            this.panel7.Controls.Add(this.cbLOG);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // cbCompat
            // 
            resources.ApplyResources(this.cbCompat, "cbCompat");
            this.cbCompat.Name = "cbCompat";
            this.toolTip1.SetToolTip(this.cbCompat, resources.GetString("cbCompat.ToolTip"));
            this.cbCompat.UseVisualStyleBackColor = true;
            this.cbCompat.CheckedChanged += new System.EventHandler(this.cbCompat_CheckedChanged);
            // 
            // cbLOG
            // 
            resources.ApplyResources(this.cbLOG, "cbLOG");
            this.cbLOG.Name = "cbLOG";
            this.toolTip1.SetToolTip(this.cbLOG, resources.GetString("cbLOG.ToolTip"));
            this.cbLOG.UseVisualStyleBackColor = true;
            this.cbLOG.CheckedChanged += new System.EventHandler(this.cbLOG_CheckedChanged);
            // 
            // groupBox1
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.dgvECU);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dgvECU
            // 
            this.dgvECU.AllowUserToAddRows = false;
            this.dgvECU.AllowUserToDeleteRows = false;
            this.dgvECU.AllowUserToResizeColumns = false;
            this.dgvECU.AllowUserToResizeRows = false;
            this.dgvECU.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvECU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvECU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvECU.ColumnHeadersVisible = false;
            this.dgvECU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ecuECU});
            resources.ApplyResources(this.dgvECU, "dgvECU");
            this.dgvECU.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvECU.MultiSelect = false;
            this.dgvECU.Name = "dgvECU";
            this.dgvECU.ReadOnly = true;
            this.dgvECU.RowHeadersVisible = false;
            this.dgvECU.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvECU.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // ecuECU
            // 
            this.ecuECU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.ecuECU, "ecuECU");
            this.ecuECU.Name = "ecuECU";
            this.ecuECU.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbHelp);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // tbHelp
            // 
            this.tbHelp.BackColor = System.Drawing.SystemColors.Window;
            this.tbHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbHelp, "tbHelp");
            this.tbHelp.Name = "tbHelp";
            this.tbHelp.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.dgvParameters, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // dgvParameters
            // 
            this.dgvParameters.AllowUserToAddRows = false;
            this.dgvParameters.AllowUserToDeleteRows = false;
            this.dgvParameters.AllowUserToResizeRows = false;
            this.dgvParameters.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvParameters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parChecked,
            this.parName,
            this.parValue,
            this.parUnit});
            resources.ApplyResources(this.dgvParameters, "dgvParameters");
            this.dgvParameters.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvParameters.MultiSelect = false;
            this.dgvParameters.Name = "dgvParameters";
            this.dgvParameters.ReadOnly = true;
            this.dgvParameters.RowHeadersVisible = false;
            this.dgvParameters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParameters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParameters_CellClick);
            // 
            // parChecked
            // 
            resources.ApplyResources(this.parChecked, "parChecked");
            this.parChecked.Name = "parChecked";
            this.parChecked.ReadOnly = true;
            // 
            // parName
            // 
            this.parName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.parName, "parName");
            this.parName.Name = "parName";
            this.parName.ReadOnly = true;
            this.parName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // parValue
            // 
            resources.ApplyResources(this.parValue, "parValue");
            this.parValue.Name = "parValue";
            this.parValue.ReadOnly = true;
            this.parValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // parUnit
            // 
            resources.ApplyResources(this.parUnit, "parUnit");
            this.parUnit.Name = "parUnit";
            this.parUnit.ReadOnly = true;
            this.parUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.cbQueryErrors});
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::IES_2.Properties.Resources.ic_fluent_select_all_on_24_filled;
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::IES_2.Properties.Resources.ic_fluent_select_all_off_24_filled;
            resources.ApplyResources(this.toolStripButton3, "toolStripButton3");
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // cbQueryErrors
            // 
            this.cbQueryErrors.Checked = true;
            this.cbQueryErrors.CheckOnClick = true;
            this.cbQueryErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbQueryErrors.Image = global::IES_2.Properties.Resources.ic_fluent_search_info_24_filled;
            resources.ApplyResources(this.cbQueryErrors, "cbQueryErrors");
            this.cbQueryErrors.Name = "cbQueryErrors";
            this.cbQueryErrors.CheckedChanged += new System.EventHandler(this.cbQueryErrors_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.dgvErrors, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // dgvErrors
            // 
            this.dgvErrors.AllowUserToAddRows = false;
            this.dgvErrors.AllowUserToDeleteRows = false;
            this.dgvErrors.AllowUserToResizeRows = false;
            this.dgvErrors.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.errDescr,
            this.errReason,
            this.errState,
            this.errMIL});
            resources.ApplyResources(this.dgvErrors, "dgvErrors");
            this.dgvErrors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvErrors.MultiSelect = false;
            this.dgvErrors.Name = "dgvErrors";
            this.dgvErrors.ReadOnly = true;
            this.dgvErrors.RowHeadersVisible = false;
            this.dgvErrors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // errDescr
            // 
            this.errDescr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.errDescr.FillWeight = 65F;
            resources.ApplyResources(this.errDescr, "errDescr");
            this.errDescr.Name = "errDescr";
            this.errDescr.ReadOnly = true;
            this.errDescr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // errReason
            // 
            this.errReason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.errReason.FillWeight = 35F;
            resources.ApplyResources(this.errReason, "errReason");
            this.errReason.Name = "errReason";
            this.errReason.ReadOnly = true;
            this.errReason.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // errState
            // 
            resources.ApplyResources(this.errState, "errState");
            this.errState.Name = "errState";
            this.errState.ReadOnly = true;
            this.errState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // errMIL
            // 
            resources.ApplyResources(this.errMIL, "errMIL");
            this.errMIL.Name = "errMIL";
            this.errMIL.ReadOnly = true;
            this.errMIL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnClear);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.toolTip1.SetToolTip(this.btnClear, resources.GetString("btnClear.ToolTip"));
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel5);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.dgvTests, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // dgvTests
            // 
            this.dgvTests.AllowUserToAddRows = false;
            this.dgvTests.AllowUserToDeleteRows = false;
            this.dgvTests.AllowUserToResizeRows = false;
            this.dgvTests.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            resources.ApplyResources(this.dgvTests, "dgvTests");
            this.dgvTests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTests.MultiSelect = false;
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.ReadOnly = true;
            this.dgvTests.RowHeadersVisible = false;
            this.dgvTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 65F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 35F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnExecute);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            // 
            // btnExecute
            // 
            resources.ApplyResources(this.btnExecute, "btnExecute");
            this.btnExecute.Name = "btnExecute";
            this.toolTip1.SetToolTip(this.btnExecute, resources.GetString("btnExecute.ToolTip"));
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel6);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.zedGraphControl1, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cblTraces);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // cblTraces
            // 
            this.cblTraces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblTraces.CheckOnClick = true;
            resources.ApplyResources(this.cblTraces, "cblTraces");
            this.cblTraces.FormattingEnabled = true;
            this.cblTraces.Name = "cblTraces";
            // 
            // zedGraphControl1
            // 
            resources.ApplyResources(this.zedGraphControl1, "zedGraphControl1");
            this.zedGraphControl1.IsAntiAlias = true;
            this.zedGraphControl1.IsAutoScrollRange = true;
            this.zedGraphControl1.IsShowHScrollBar = true;
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.tableLayoutPanel6.SetRowSpan(this.zedGraphControl1, 2);
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnGraph);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // btnGraph
            // 
            resources.ApplyResources(this.btnGraph, "btnGraph");
            this.btnGraph.Name = "btnGraph";
            this.toolTip1.SetToolTip(this.btnGraph, resources.GetString("btnGraph.ToolTip"));
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel8);
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.dgvAdjusts, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.panel8, 1, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            // 
            // dgvAdjusts
            // 
            this.dgvAdjusts.AllowUserToAddRows = false;
            this.dgvAdjusts.AllowUserToDeleteRows = false;
            this.dgvAdjusts.AllowUserToResizeRows = false;
            this.dgvAdjusts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAdjusts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdjusts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdjusts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            resources.ApplyResources(this.dgvAdjusts, "dgvAdjusts");
            this.dgvAdjusts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAdjusts.MultiSelect = false;
            this.dgvAdjusts.Name = "dgvAdjusts";
            this.dgvAdjusts.ReadOnly = true;
            this.dgvAdjusts.RowHeadersVisible = false;
            this.dgvAdjusts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 65F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.FillWeight = 35F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnAdj);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // btnAdj
            // 
            resources.ApplyResources(this.btnAdj, "btnAdj");
            this.btnAdj.Name = "btnAdj";
            this.toolTip1.SetToolTip(this.btnAdj, resources.GetString("btnAdj.ToolTip"));
            this.btnAdj.UseVisualStyleBackColor = true;
            this.btnAdj.Click += new System.EventHandler(this.btnAdj_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::IES_2.Properties.Resources.ic_fluent_info_24_filled;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // bgwIsoWait
            // 
            this.bgwIsoWait.WorkerSupportsCancellation = true;
            this.bgwIsoWait.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwIsoWait_DoWork);
            this.bgwIsoWait.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwIsoWait_RunWorkerCompleted);
            // 
            // bgwParameters
            // 
            this.bgwParameters.WorkerReportsProgress = true;
            this.bgwParameters.WorkerSupportsCancellation = true;
            this.bgwParameters.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwParameters_DoWork);
            this.bgwParameters.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwParameters_ProgressChanged);
            this.bgwParameters.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwParameters_RunWorkerCompleted);
            // 
            // bgwTest
            // 
            this.bgwTest.WorkerSupportsCancellation = true;
            this.bgwTest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwTest_DoWork);
            this.bgwTest.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwTest_RunWorkerCompleted);
            // 
            // infoPanel
            // 
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.infoOptions);
            this.infoPanel.Controls.Add(this.infoMessage);
            resources.ApplyResources(this.infoPanel, "infoPanel");
            this.infoPanel.Name = "infoPanel";
            // 
            // infoOptions
            // 
            resources.ApplyResources(this.infoOptions, "infoOptions");
            this.infoOptions.Name = "infoOptions";
            // 
            // infoMessage
            // 
            resources.ApplyResources(this.infoMessage, "infoMessage");
            this.infoMessage.Name = "infoMessage";
            // 
            // bgwDemo
            // 
            this.bgwDemo.WorkerReportsProgress = true;
            this.bgwDemo.WorkerSupportsCancellation = true;
            this.bgwDemo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDemo_DoWork);
            this.bgwDemo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwDemo_ProgressChanged);
            this.bgwDemo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwDemo_RunWorkerCompleted);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1000;
            this.toolTip1.IsBalloon = true;
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage0.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCOM)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvECU)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameters)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrors)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjusts)).EndInit();
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton cbQueryErrors;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

