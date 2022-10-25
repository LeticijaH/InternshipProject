
namespace Zadaca2
{
    partial class FormFunctions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFunctions));
            this.tabDefineMachine = new System.Windows.Forms.TabControl();
            this.tpDefineM = new System.Windows.Forms.TabPage();
            this.paneltbDefineMachine = new System.Windows.Forms.Panel();
            this.tbDescriptionM = new System.Windows.Forms.TextBox();
            this.cbTypeM = new System.Windows.Forms.ComboBox();
            this.labelNameM = new System.Windows.Forms.Label();
            this.tbNameM = new System.Windows.Forms.TextBox();
            this.labelDescM = new System.Windows.Forms.Label();
            this.labelTypeM = new System.Windows.Forms.Label();
            this.btDefineM = new System.Windows.Forms.Button();
            this.tpDefinePiece = new System.Windows.Forms.TabPage();
            this.cbMaterialType = new System.Windows.Forms.ComboBox();
            this.btDefinePiece = new System.Windows.Forms.Button();
            this.labelMagnifyingGlass = new System.Windows.Forms.Label();
            this.btMagnifyingGlass = new System.Windows.Forms.Button();
            this.tbProducedByP = new System.Windows.Forms.TextBox();
            this.cbTypeP = new System.Windows.Forms.ComboBox();
            this.tbSerialNum = new System.Windows.Forms.TextBox();
            this.labelMadeByP = new System.Windows.Forms.Label();
            this.labelMaterialP = new System.Windows.Forms.Label();
            this.labelTypeP = new System.Windows.Forms.Label();
            this.labelSerialNum = new System.Windows.Forms.Label();
            this.tpDefineProperty = new System.Windows.Forms.TabPage();
            this.btSearch = new System.Windows.Forms.Button();
            this.dtpSearchT = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSearchM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchSN = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelDefineProp = new System.Windows.Forms.Label();
            this.panelDefineProp = new System.Windows.Forms.Panel();
            this.btDefineProp = new System.Windows.Forms.Button();
            this.labelProperty = new System.Windows.Forms.Label();
            this.tbProperty = new System.Windows.Forms.TextBox();
            this.rbAFP = new System.Windows.Forms.RadioButton();
            this.rbATL = new System.Windows.Forms.RadioButton();
            this.rbGeneric = new System.Windows.Forms.RadioButton();
            this.PiecesPropDataGridView = new System.Windows.Forms.DataGridView();
            this.listViewPieces = new System.Windows.Forms.ListView();
            this.tpReport = new System.Windows.Forms.TabPage();
            this.btGenerateReport = new System.Windows.Forms.Button();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.dtpTimeRange2 = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeRange1 = new System.Windows.Forms.DateTimePicker();
            this.rbTimeRange = new System.Windows.Forms.RadioButton();
            this.rbSerialNumber = new System.Windows.Forms.RadioButton();
            this.btReport = new System.Windows.Forms.Button();
            this.listViewReport = new System.Windows.Forms.ListView();
            this.tbSerNum = new System.Windows.Forms.TextBox();
            this.tpManagement = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCreateNewDataBase = new System.Windows.Forms.Button();
            this.labelCreateNewDB = new System.Windows.Forms.Label();
            this.labelBackUp = new System.Windows.Forms.Label();
            this.labelNewDB = new System.Windows.Forms.Label();
            this.btBackUp = new System.Windows.Forms.Button();
            this.tbNewDBName = new System.Windows.Forms.TextBox();
            this.buttonDBProject = new System.Windows.Forms.Button();
            this.cmbDataBaseNames = new System.Windows.Forms.ComboBox();
            this.labelDBChoice = new System.Windows.Forms.Label();
            this.DataBaseName = new System.Windows.Forms.Label();
            this.labelDBForProject = new System.Windows.Forms.Label();
            this.cmbDBForProject = new System.Windows.Forms.ComboBox();
            this.tbSizeOfDB = new System.Windows.Forms.TextBox();
            this.labelDBSIze = new System.Windows.Forms.Label();
            this.btSettings = new System.Windows.Forms.Button();
            this.btOdjava = new System.Windows.Forms.Button();
            this.listViewMachines = new System.Windows.Forms.ListView();
            this.productionDBDataSet = new Zadaca2.ProductionDBDataSet();
            this.productionPiecePropertiesDefinitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sfdBackUpDB = new System.Windows.Forms.SaveFileDialog();
            this.tabDefineMachine.SuspendLayout();
            this.tpDefineM.SuspendLayout();
            this.paneltbDefineMachine.SuspendLayout();
            this.tpDefinePiece.SuspendLayout();
            this.tpDefineProperty.SuspendLayout();
            this.panelDefineProp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PiecesPropDataGridView)).BeginInit();
            this.tpReport.SuspendLayout();
            this.tpManagement.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionPiecePropertiesDefinitionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDefineMachine
            // 
            this.tabDefineMachine.Controls.Add(this.tpDefineM);
            this.tabDefineMachine.Controls.Add(this.tpDefinePiece);
            this.tabDefineMachine.Controls.Add(this.tpDefineProperty);
            this.tabDefineMachine.Controls.Add(this.tpReport);
            this.tabDefineMachine.Controls.Add(this.tpManagement);
            this.tabDefineMachine.Location = new System.Drawing.Point(243, 3);
            this.tabDefineMachine.Margin = new System.Windows.Forms.Padding(4);
            this.tabDefineMachine.Name = "tabDefineMachine";
            this.tabDefineMachine.SelectedIndex = 0;
            this.tabDefineMachine.Size = new System.Drawing.Size(1263, 679);
            this.tabDefineMachine.TabIndex = 0;
            // 
            // tpDefineM
            // 
            this.tpDefineM.Controls.Add(this.paneltbDefineMachine);
            this.tpDefineM.Controls.Add(this.btDefineM);
            this.tpDefineM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpDefineM.Location = new System.Drawing.Point(4, 29);
            this.tpDefineM.Margin = new System.Windows.Forms.Padding(4);
            this.tpDefineM.Name = "tpDefineM";
            this.tpDefineM.Padding = new System.Windows.Forms.Padding(4);
            this.tpDefineM.Size = new System.Drawing.Size(1255, 646);
            this.tpDefineM.TabIndex = 0;
            this.tpDefineM.Text = "Дефинирање на машина";
            this.tpDefineM.UseVisualStyleBackColor = true;
            // 
            // paneltbDefineMachine
            // 
            this.paneltbDefineMachine.BackColor = System.Drawing.Color.LightGray;
            this.paneltbDefineMachine.Controls.Add(this.tbDescriptionM);
            this.paneltbDefineMachine.Controls.Add(this.cbTypeM);
            this.paneltbDefineMachine.Controls.Add(this.labelNameM);
            this.paneltbDefineMachine.Controls.Add(this.tbNameM);
            this.paneltbDefineMachine.Controls.Add(this.labelDescM);
            this.paneltbDefineMachine.Controls.Add(this.labelTypeM);
            this.paneltbDefineMachine.Location = new System.Drawing.Point(358, 68);
            this.paneltbDefineMachine.Name = "paneltbDefineMachine";
            this.paneltbDefineMachine.Size = new System.Drawing.Size(512, 445);
            this.paneltbDefineMachine.TabIndex = 7;
            // 
            // tbDescriptionM
            // 
            this.tbDescriptionM.Location = new System.Drawing.Point(141, 199);
            this.tbDescriptionM.Multiline = true;
            this.tbDescriptionM.Name = "tbDescriptionM";
            this.tbDescriptionM.Size = new System.Drawing.Size(326, 190);
            this.tbDescriptionM.TabIndex = 5;
            // 
            // cbTypeM
            // 
            this.cbTypeM.FormattingEnabled = true;
            this.cbTypeM.Location = new System.Drawing.Point(141, 122);
            this.cbTypeM.Name = "cbTypeM";
            this.cbTypeM.Size = new System.Drawing.Size(201, 28);
            this.cbTypeM.TabIndex = 0;
            // 
            // labelNameM
            // 
            this.labelNameM.AutoSize = true;
            this.labelNameM.Location = new System.Drawing.Point(39, 53);
            this.labelNameM.Name = "labelNameM";
            this.labelNameM.Size = new System.Drawing.Size(42, 20);
            this.labelNameM.TabIndex = 1;
            this.labelNameM.Text = "Име";
            // 
            // tbNameM
            // 
            this.tbNameM.Location = new System.Drawing.Point(141, 50);
            this.tbNameM.Name = "tbNameM";
            this.tbNameM.Size = new System.Drawing.Size(201, 27);
            this.tbNameM.TabIndex = 4;
            // 
            // labelDescM
            // 
            this.labelDescM.AutoSize = true;
            this.labelDescM.Location = new System.Drawing.Point(39, 202);
            this.labelDescM.Name = "labelDescM";
            this.labelDescM.Size = new System.Drawing.Size(51, 20);
            this.labelDescM.TabIndex = 2;
            this.labelDescM.Text = "Опис";
            // 
            // labelTypeM
            // 
            this.labelTypeM.AutoSize = true;
            this.labelTypeM.Location = new System.Drawing.Point(39, 125);
            this.labelTypeM.Name = "labelTypeM";
            this.labelTypeM.Size = new System.Drawing.Size(39, 20);
            this.labelTypeM.TabIndex = 3;
            this.labelTypeM.Text = "Тип";
            // 
            // btDefineM
            // 
            this.btDefineM.Location = new System.Drawing.Point(499, 535);
            this.btDefineM.Name = "btDefineM";
            this.btDefineM.Size = new System.Drawing.Size(258, 37);
            this.btDefineM.TabIndex = 6;
            this.btDefineM.Text = "Вметни ги податоците";
            this.btDefineM.UseVisualStyleBackColor = true;
            this.btDefineM.Click += new System.EventHandler(this.btDefineM_Click);
            // 
            // tpDefinePiece
            // 
            this.tpDefinePiece.Controls.Add(this.cbMaterialType);
            this.tpDefinePiece.Controls.Add(this.btDefinePiece);
            this.tpDefinePiece.Controls.Add(this.labelMagnifyingGlass);
            this.tpDefinePiece.Controls.Add(this.btMagnifyingGlass);
            this.tpDefinePiece.Controls.Add(this.tbProducedByP);
            this.tpDefinePiece.Controls.Add(this.cbTypeP);
            this.tpDefinePiece.Controls.Add(this.tbSerialNum);
            this.tpDefinePiece.Controls.Add(this.labelMadeByP);
            this.tpDefinePiece.Controls.Add(this.labelMaterialP);
            this.tpDefinePiece.Controls.Add(this.labelTypeP);
            this.tpDefinePiece.Controls.Add(this.labelSerialNum);
            this.tpDefinePiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpDefinePiece.Location = new System.Drawing.Point(4, 29);
            this.tpDefinePiece.Margin = new System.Windows.Forms.Padding(4);
            this.tpDefinePiece.Name = "tpDefinePiece";
            this.tpDefinePiece.Padding = new System.Windows.Forms.Padding(4);
            this.tpDefinePiece.Size = new System.Drawing.Size(1255, 646);
            this.tpDefinePiece.TabIndex = 1;
            this.tpDefinePiece.Text = "Дефинирање на парче";
            this.tpDefinePiece.UseVisualStyleBackColor = true;
            // 
            // cbMaterialType
            // 
            this.cbMaterialType.FormattingEnabled = true;
            this.cbMaterialType.Location = new System.Drawing.Point(540, 295);
            this.cbMaterialType.Name = "cbMaterialType";
            this.cbMaterialType.Size = new System.Drawing.Size(213, 28);
            this.cbMaterialType.TabIndex = 42;
            // 
            // btDefinePiece
            // 
            this.btDefinePiece.Location = new System.Drawing.Point(507, 461);
            this.btDefinePiece.Name = "btDefinePiece";
            this.btDefinePiece.Size = new System.Drawing.Size(258, 37);
            this.btDefinePiece.TabIndex = 32;
            this.btDefinePiece.Text = "Вметни ги податоците";
            this.btDefinePiece.UseVisualStyleBackColor = true;
            this.btDefinePiece.Click += new System.EventHandler(this.btDefinePiece_Click_1);
            // 
            // labelMagnifyingGlass
            // 
            this.labelMagnifyingGlass.AutoSize = true;
            this.labelMagnifyingGlass.Location = new System.Drawing.Point(806, 148);
            this.labelMagnifyingGlass.Name = "labelMagnifyingGlass";
            this.labelMagnifyingGlass.Size = new System.Drawing.Size(195, 20);
            this.labelMagnifyingGlass.TabIndex = 41;
            this.labelMagnifyingGlass.Text = "Избор на сериски број";
            // 
            // btMagnifyingGlass
            // 
            this.btMagnifyingGlass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btMagnifyingGlass.BackgroundImage")));
            this.btMagnifyingGlass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMagnifyingGlass.FlatAppearance.BorderSize = 0;
            this.btMagnifyingGlass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMagnifyingGlass.Location = new System.Drawing.Point(759, 149);
            this.btMagnifyingGlass.Name = "btMagnifyingGlass";
            this.btMagnifyingGlass.Size = new System.Drawing.Size(24, 26);
            this.btMagnifyingGlass.TabIndex = 40;
            this.btMagnifyingGlass.UseVisualStyleBackColor = true;
            this.btMagnifyingGlass.Click += new System.EventHandler(this.btMagnifyingGlass_Click_1);
            this.btMagnifyingGlass.MouseLeave += new System.EventHandler(this.btMagnifyingGlass_MouseLeave_1);
            this.btMagnifyingGlass.MouseHover += new System.EventHandler(this.btMagnifyingGlass_MouseHover_1);
            // 
            // tbProducedByP
            // 
            this.tbProducedByP.Location = new System.Drawing.Point(540, 373);
            this.tbProducedByP.Name = "tbProducedByP";
            this.tbProducedByP.Size = new System.Drawing.Size(213, 27);
            this.tbProducedByP.TabIndex = 39;
            // 
            // cbTypeP
            // 
            this.cbTypeP.FormattingEnabled = true;
            this.cbTypeP.Location = new System.Drawing.Point(540, 221);
            this.cbTypeP.Name = "cbTypeP";
            this.cbTypeP.Size = new System.Drawing.Size(213, 28);
            this.cbTypeP.TabIndex = 38;
            // 
            // tbSerialNum
            // 
            this.tbSerialNum.Location = new System.Drawing.Point(540, 148);
            this.tbSerialNum.Name = "tbSerialNum";
            this.tbSerialNum.Size = new System.Drawing.Size(213, 27);
            this.tbSerialNum.TabIndex = 37;
            // 
            // labelMadeByP
            // 
            this.labelMadeByP.AutoSize = true;
            this.labelMadeByP.Location = new System.Drawing.Point(254, 376);
            this.labelMadeByP.Name = "labelMadeByP";
            this.labelMadeByP.Size = new System.Drawing.Size(249, 20);
            this.labelMadeByP.TabIndex = 36;
            this.labelMadeByP.Text = "Производител на материјал";
            // 
            // labelMaterialP
            // 
            this.labelMaterialP.AutoSize = true;
            this.labelMaterialP.Location = new System.Drawing.Point(254, 298);
            this.labelMaterialP.Name = "labelMaterialP";
            this.labelMaterialP.Size = new System.Drawing.Size(97, 20);
            this.labelMaterialP.TabIndex = 35;
            this.labelMaterialP.Text = "Материјал";
            // 
            // labelTypeP
            // 
            this.labelTypeP.AutoSize = true;
            this.labelTypeP.Location = new System.Drawing.Point(254, 224);
            this.labelTypeP.Name = "labelTypeP";
            this.labelTypeP.Size = new System.Drawing.Size(39, 20);
            this.labelTypeP.TabIndex = 34;
            this.labelTypeP.Text = "Тип";
            // 
            // labelSerialNum
            // 
            this.labelSerialNum.AutoSize = true;
            this.labelSerialNum.Location = new System.Drawing.Point(254, 151);
            this.labelSerialNum.Name = "labelSerialNum";
            this.labelSerialNum.Size = new System.Drawing.Size(118, 20);
            this.labelSerialNum.TabIndex = 33;
            this.labelSerialNum.Text = "Сериски број";
            // 
            // tpDefineProperty
            // 
            this.tpDefineProperty.Controls.Add(this.btSearch);
            this.tpDefineProperty.Controls.Add(this.dtpSearchT);
            this.tpDefineProperty.Controls.Add(this.label3);
            this.tpDefineProperty.Controls.Add(this.cbSearchM);
            this.tpDefineProperty.Controls.Add(this.label2);
            this.tpDefineProperty.Controls.Add(this.label1);
            this.tpDefineProperty.Controls.Add(this.tbSearchSN);
            this.tpDefineProperty.Controls.Add(this.labelSearch);
            this.tpDefineProperty.Controls.Add(this.labelDefineProp);
            this.tpDefineProperty.Controls.Add(this.panelDefineProp);
            this.tpDefineProperty.Controls.Add(this.PiecesPropDataGridView);
            this.tpDefineProperty.Controls.Add(this.listViewPieces);
            this.tpDefineProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpDefineProperty.Location = new System.Drawing.Point(4, 29);
            this.tpDefineProperty.Margin = new System.Windows.Forms.Padding(4);
            this.tpDefineProperty.Name = "tpDefineProperty";
            this.tpDefineProperty.Size = new System.Drawing.Size(1255, 646);
            this.tpDefineProperty.TabIndex = 2;
            this.tpDefineProperty.Text = "Дефинирање на особини";
            this.tpDefineProperty.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            this.btSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSearch.BackgroundImage")));
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSearch.FlatAppearance.BorderSize = 0;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Location = new System.Drawing.Point(457, 152);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(59, 49);
            this.btSearch.TabIndex = 19;
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // dtpSearchT
            // 
            this.dtpSearchT.Location = new System.Drawing.Point(160, 173);
            this.dtpSearchT.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpSearchT.Name = "dtpSearchT";
            this.dtpSearchT.Size = new System.Drawing.Size(246, 27);
            this.dtpSearchT.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Време\r\n";
            // 
            // cbSearchM
            // 
            this.cbSearchM.FormattingEnabled = true;
            this.cbSearchM.Location = new System.Drawing.Point(160, 127);
            this.cbSearchM.Name = "cbSearchM";
            this.cbSearchM.Size = new System.Drawing.Size(246, 28);
            this.cbSearchM.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Машина";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Сериски број";
            // 
            // tbSearchSN
            // 
            this.tbSearchSN.Location = new System.Drawing.Point(160, 75);
            this.tbSearchSN.Name = "tbSearchSN";
            this.tbSearchSN.Size = new System.Drawing.Size(225, 27);
            this.tbSearchSN.TabIndex = 7;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(29, 30);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(260, 20);
            this.labelSearch.TabIndex = 6;
            this.labelSearch.Text = "Пребарај парчиња според:\r\n";
            // 
            // labelDefineProp
            // 
            this.labelDefineProp.AutoSize = true;
            this.labelDefineProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDefineProp.Location = new System.Drawing.Point(626, 27);
            this.labelDefineProp.Name = "labelDefineProp";
            this.labelDefineProp.Size = new System.Drawing.Size(348, 20);
            this.labelDefineProp.TabIndex = 5;
            this.labelDefineProp.Text = "Дефинирај особина за одреден дел";
            // 
            // panelDefineProp
            // 
            this.panelDefineProp.BackColor = System.Drawing.Color.Silver;
            this.panelDefineProp.Controls.Add(this.btDefineProp);
            this.panelDefineProp.Controls.Add(this.labelProperty);
            this.panelDefineProp.Controls.Add(this.tbProperty);
            this.panelDefineProp.Controls.Add(this.rbAFP);
            this.panelDefineProp.Controls.Add(this.rbATL);
            this.panelDefineProp.Controls.Add(this.rbGeneric);
            this.panelDefineProp.Location = new System.Drawing.Point(630, 61);
            this.panelDefineProp.Name = "panelDefineProp";
            this.panelDefineProp.Size = new System.Drawing.Size(600, 155);
            this.panelDefineProp.TabIndex = 4;
            // 
            // btDefineProp
            // 
            this.btDefineProp.Location = new System.Drawing.Point(302, 91);
            this.btDefineProp.Name = "btDefineProp";
            this.btDefineProp.Size = new System.Drawing.Size(262, 48);
            this.btDefineProp.TabIndex = 7;
            this.btDefineProp.Text = "Дефинирај особина";
            this.btDefineProp.UseVisualStyleBackColor = true;
            this.btDefineProp.Click += new System.EventHandler(this.btDefineProp_Click);
            // 
            // labelProperty
            // 
            this.labelProperty.AutoSize = true;
            this.labelProperty.Location = new System.Drawing.Point(179, 18);
            this.labelProperty.Name = "labelProperty";
            this.labelProperty.Size = new System.Drawing.Size(81, 20);
            this.labelProperty.TabIndex = 6;
            this.labelProperty.Text = "Oсобина";
            // 
            // tbProperty
            // 
            this.tbProperty.Location = new System.Drawing.Point(183, 41);
            this.tbProperty.Name = "tbProperty";
            this.tbProperty.Size = new System.Drawing.Size(272, 27);
            this.tbProperty.TabIndex = 3;
            // 
            // rbAFP
            // 
            this.rbAFP.AutoSize = true;
            this.rbAFP.Location = new System.Drawing.Point(28, 116);
            this.rbAFP.Name = "rbAFP";
            this.rbAFP.Size = new System.Drawing.Size(62, 24);
            this.rbAFP.TabIndex = 2;
            this.rbAFP.TabStop = true;
            this.rbAFP.Text = "AFP";
            this.rbAFP.UseVisualStyleBackColor = true;
            // 
            // rbATL
            // 
            this.rbATL.AutoSize = true;
            this.rbATL.Location = new System.Drawing.Point(28, 66);
            this.rbATL.Name = "rbATL";
            this.rbATL.Size = new System.Drawing.Size(61, 24);
            this.rbATL.TabIndex = 1;
            this.rbATL.TabStop = true;
            this.rbATL.Text = "ATL";
            this.rbATL.UseVisualStyleBackColor = true;
            // 
            // rbGeneric
            // 
            this.rbGeneric.AutoSize = true;
            this.rbGeneric.Location = new System.Drawing.Point(28, 15);
            this.rbGeneric.Name = "rbGeneric";
            this.rbGeneric.Size = new System.Drawing.Size(89, 24);
            this.rbGeneric.TabIndex = 0;
            this.rbGeneric.TabStop = true;
            this.rbGeneric.Text = "Generic";
            this.rbGeneric.UseVisualStyleBackColor = true;
            // 
            // PiecesPropDataGridView
            // 
            this.PiecesPropDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PiecesPropDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.PiecesPropDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PiecesPropDataGridView.Location = new System.Drawing.Point(630, 255);
            this.PiecesPropDataGridView.MultiSelect = false;
            this.PiecesPropDataGridView.Name = "PiecesPropDataGridView";
            this.PiecesPropDataGridView.RowHeadersWidth = 51;
            this.PiecesPropDataGridView.RowTemplate.Height = 24;
            this.PiecesPropDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PiecesPropDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PiecesPropDataGridView.Size = new System.Drawing.Size(600, 383);
            this.PiecesPropDataGridView.TabIndex = 3;
            this.PiecesPropDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.PiecesPropDataGridView_CellEndEdit_1);
            this.PiecesPropDataGridView.SelectionChanged += new System.EventHandler(this.PiecesPropDataGridView_SelectionChanged);
            // 
            // listViewPieces
            // 
            this.listViewPieces.HideSelection = false;
            this.listViewPieces.Location = new System.Drawing.Point(14, 255);
            this.listViewPieces.MultiSelect = false;
            this.listViewPieces.Name = "listViewPieces";
            this.listViewPieces.Size = new System.Drawing.Size(600, 383);
            this.listViewPieces.TabIndex = 0;
            this.listViewPieces.UseCompatibleStateImageBehavior = false;
            this.listViewPieces.SelectedIndexChanged += new System.EventHandler(this.listViewPieces_SelectedIndexChanged);
            // 
            // tpReport
            // 
            this.tpReport.Controls.Add(this.btGenerateReport);
            this.tpReport.Controls.Add(this.labelTo);
            this.tpReport.Controls.Add(this.labelFrom);
            this.tpReport.Controls.Add(this.dtpTimeRange2);
            this.tpReport.Controls.Add(this.dtpTimeRange1);
            this.tpReport.Controls.Add(this.rbTimeRange);
            this.tpReport.Controls.Add(this.rbSerialNumber);
            this.tpReport.Controls.Add(this.btReport);
            this.tpReport.Controls.Add(this.listViewReport);
            this.tpReport.Controls.Add(this.tbSerNum);
            this.tpReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpReport.Location = new System.Drawing.Point(4, 29);
            this.tpReport.Margin = new System.Windows.Forms.Padding(4);
            this.tpReport.Name = "tpReport";
            this.tpReport.Size = new System.Drawing.Size(1255, 646);
            this.tpReport.TabIndex = 3;
            this.tpReport.Text = "Извештај";
            this.tpReport.UseVisualStyleBackColor = true;
            // 
            // btGenerateReport
            // 
            this.btGenerateReport.Location = new System.Drawing.Point(571, 176);
            this.btGenerateReport.Name = "btGenerateReport";
            this.btGenerateReport.Size = new System.Drawing.Size(183, 41);
            this.btGenerateReport.TabIndex = 28;
            this.btGenerateReport.Text = "Генерирај извештај";
            this.btGenerateReport.UseVisualStyleBackColor = true;
            this.btGenerateReport.Click += new System.EventHandler(this.btGenerateReport_Click);
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTo.Location = new System.Drawing.Point(566, 109);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(35, 25);
            this.labelTo.TabIndex = 27;
            this.labelTo.Text = "до";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFrom.Location = new System.Drawing.Point(221, 109);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(35, 25);
            this.labelFrom.TabIndex = 26;
            this.labelFrom.Text = "од";
            // 
            // dtpTimeRange2
            // 
            this.dtpTimeRange2.Enabled = false;
            this.dtpTimeRange2.Location = new System.Drawing.Point(616, 109);
            this.dtpTimeRange2.MinDate = new System.DateTime(1999, 12, 1, 0, 0, 0, 0);
            this.dtpTimeRange2.Name = "dtpTimeRange2";
            this.dtpTimeRange2.Size = new System.Drawing.Size(289, 27);
            this.dtpTimeRange2.TabIndex = 25;
            // 
            // dtpTimeRange1
            // 
            this.dtpTimeRange1.Enabled = false;
            this.dtpTimeRange1.Location = new System.Drawing.Point(262, 109);
            this.dtpTimeRange1.MinDate = new System.DateTime(1999, 12, 1, 0, 0, 0, 0);
            this.dtpTimeRange1.Name = "dtpTimeRange1";
            this.dtpTimeRange1.Size = new System.Drawing.Size(289, 27);
            this.dtpTimeRange1.TabIndex = 24;
            // 
            // rbTimeRange
            // 
            this.rbTimeRange.AutoSize = true;
            this.rbTimeRange.Location = new System.Drawing.Point(51, 111);
            this.rbTimeRange.Name = "rbTimeRange";
            this.rbTimeRange.Size = new System.Drawing.Size(165, 24);
            this.rbTimeRange.TabIndex = 23;
            this.rbTimeRange.TabStop = true;
            this.rbTimeRange.Text = "Временски ранг";
            this.rbTimeRange.UseVisualStyleBackColor = true;
            this.rbTimeRange.CheckedChanged += new System.EventHandler(this.rbTimeRange_CheckedChanged);
            // 
            // rbSerialNumber
            // 
            this.rbSerialNumber.AutoSize = true;
            this.rbSerialNumber.Location = new System.Drawing.Point(51, 47);
            this.rbSerialNumber.Name = "rbSerialNumber";
            this.rbSerialNumber.Size = new System.Drawing.Size(139, 24);
            this.rbSerialNumber.TabIndex = 22;
            this.rbSerialNumber.TabStop = true;
            this.rbSerialNumber.Text = "Сериски број";
            this.rbSerialNumber.UseVisualStyleBackColor = true;
            this.rbSerialNumber.CheckedChanged += new System.EventHandler(this.rbSerialNumber_CheckedChanged);
            // 
            // btReport
            // 
            this.btReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btReport.BackgroundImage")));
            this.btReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btReport.FlatAppearance.BorderSize = 0;
            this.btReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReport.Location = new System.Drawing.Point(448, 41);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(39, 36);
            this.btReport.TabIndex = 20;
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // listViewReport
            // 
            this.listViewReport.HideSelection = false;
            this.listViewReport.Location = new System.Drawing.Point(51, 176);
            this.listViewReport.Name = "listViewReport";
            this.listViewReport.Size = new System.Drawing.Size(500, 433);
            this.listViewReport.TabIndex = 5;
            this.listViewReport.UseCompatibleStateImageBehavior = false;
            this.listViewReport.SelectedIndexChanged += new System.EventHandler(this.listViewReport_SelectedIndexChanged);
            // 
            // tbSerNum
            // 
            this.tbSerNum.Enabled = false;
            this.tbSerNum.Location = new System.Drawing.Point(222, 47);
            this.tbSerNum.Name = "tbSerNum";
            this.tbSerNum.Size = new System.Drawing.Size(199, 27);
            this.tbSerNum.TabIndex = 2;
            // 
            // tpManagement
            // 
            this.tpManagement.Controls.Add(this.panel1);
            this.tpManagement.Controls.Add(this.tbSizeOfDB);
            this.tpManagement.Controls.Add(this.labelDBSIze);
            this.tpManagement.Location = new System.Drawing.Point(4, 29);
            this.tpManagement.Margin = new System.Windows.Forms.Padding(4);
            this.tpManagement.Name = "tpManagement";
            this.tpManagement.Size = new System.Drawing.Size(1255, 646);
            this.tpManagement.TabIndex = 4;
            this.tpManagement.Text = "Менаџирање на базата";
            this.tpManagement.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btCreateNewDataBase);
            this.panel1.Controls.Add(this.labelCreateNewDB);
            this.panel1.Controls.Add(this.labelBackUp);
            this.panel1.Controls.Add(this.labelNewDB);
            this.panel1.Controls.Add(this.btBackUp);
            this.panel1.Controls.Add(this.tbNewDBName);
            this.panel1.Controls.Add(this.buttonDBProject);
            this.panel1.Controls.Add(this.cmbDataBaseNames);
            this.panel1.Controls.Add(this.labelDBChoice);
            this.panel1.Controls.Add(this.DataBaseName);
            this.panel1.Controls.Add(this.labelDBForProject);
            this.panel1.Controls.Add(this.cmbDBForProject);
            this.panel1.Location = new System.Drawing.Point(67, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 539);
            this.panel1.TabIndex = 13;
            // 
            // btCreateNewDataBase
            // 
            this.btCreateNewDataBase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btCreateNewDataBase.Location = new System.Drawing.Point(154, 450);
            this.btCreateNewDataBase.Name = "btCreateNewDataBase";
            this.btCreateNewDataBase.Size = new System.Drawing.Size(232, 36);
            this.btCreateNewDataBase.TabIndex = 17;
            this.btCreateNewDataBase.Text = "Креирај нова дата база";
            this.btCreateNewDataBase.UseVisualStyleBackColor = false;
            this.btCreateNewDataBase.Click += new System.EventHandler(this.btCreateNewDataBase_Click);
            // 
            // labelCreateNewDB
            // 
            this.labelCreateNewDB.AutoSize = true;
            this.labelCreateNewDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCreateNewDB.Location = new System.Drawing.Point(25, 357);
            this.labelCreateNewDB.Name = "labelCreateNewDB";
            this.labelCreateNewDB.Size = new System.Drawing.Size(244, 20);
            this.labelCreateNewDB.TabIndex = 16;
            this.labelCreateNewDB.Text = "Креирај нова дата база :\r\n";
            // 
            // labelBackUp
            // 
            this.labelBackUp.AutoSize = true;
            this.labelBackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBackUp.Location = new System.Drawing.Point(15, 24);
            this.labelBackUp.Name = "labelBackUp";
            this.labelBackUp.Size = new System.Drawing.Size(297, 20);
            this.labelBackUp.TabIndex = 13;
            this.labelBackUp.Text = "Зачувајте избрана дата база :\r\n";
            // 
            // labelNewDB
            // 
            this.labelNewDB.AutoSize = true;
            this.labelNewDB.Location = new System.Drawing.Point(16, 403);
            this.labelNewDB.Name = "labelNewDB";
            this.labelNewDB.Size = new System.Drawing.Size(168, 20);
            this.labelNewDB.TabIndex = 15;
            this.labelNewDB.Text = "Име на дата база :";
            // 
            // btBackUp
            // 
            this.btBackUp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btBackUp.Location = new System.Drawing.Point(218, 114);
            this.btBackUp.Name = "btBackUp";
            this.btBackUp.Size = new System.Drawing.Size(110, 37);
            this.btBackUp.TabIndex = 8;
            this.btBackUp.Text = "Зачувај";
            this.btBackUp.UseVisualStyleBackColor = false;
            this.btBackUp.Click += new System.EventHandler(this.btBackUp_Click);
            // 
            // tbNewDBName
            // 
            this.tbNewDBName.Location = new System.Drawing.Point(201, 396);
            this.tbNewDBName.Name = "tbNewDBName";
            this.tbNewDBName.Size = new System.Drawing.Size(185, 27);
            this.tbNewDBName.TabIndex = 14;
            // 
            // buttonDBProject
            // 
            this.buttonDBProject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDBProject.Location = new System.Drawing.Point(154, 285);
            this.buttonDBProject.Name = "buttonDBProject";
            this.buttonDBProject.Size = new System.Drawing.Size(232, 34);
            this.buttonDBProject.TabIndex = 12;
            this.buttonDBProject.Text = "Поврзи се со дата база";
            this.buttonDBProject.UseVisualStyleBackColor = false;
            this.buttonDBProject.Click += new System.EventHandler(this.buttonDBProject_Click);
            // 
            // cmbDataBaseNames
            // 
            this.cmbDataBaseNames.FormattingEnabled = true;
            this.cmbDataBaseNames.Location = new System.Drawing.Point(154, 63);
            this.cmbDataBaseNames.Name = "cmbDataBaseNames";
            this.cmbDataBaseNames.Size = new System.Drawing.Size(232, 28);
            this.cmbDataBaseNames.TabIndex = 4;
            // 
            // labelDBChoice
            // 
            this.labelDBChoice.AutoSize = true;
            this.labelDBChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDBChoice.Location = new System.Drawing.Point(16, 174);
            this.labelDBChoice.Name = "labelDBChoice";
            this.labelDBChoice.Size = new System.Drawing.Size(481, 20);
            this.labelDBChoice.TabIndex = 11;
            this.labelDBChoice.Text = "Изберете Дата База која сакате да ја користите :\r\n";
            // 
            // DataBaseName
            // 
            this.DataBaseName.AutoSize = true;
            this.DataBaseName.Location = new System.Drawing.Point(16, 66);
            this.DataBaseName.Name = "DataBaseName";
            this.DataBaseName.Size = new System.Drawing.Size(106, 20);
            this.DataBaseName.TabIndex = 3;
            this.DataBaseName.Text = "Дата база :";
            // 
            // labelDBForProject
            // 
            this.labelDBForProject.AutoSize = true;
            this.labelDBForProject.Location = new System.Drawing.Point(16, 227);
            this.labelDBForProject.Name = "labelDBForProject";
            this.labelDBForProject.Size = new System.Drawing.Size(106, 20);
            this.labelDBForProject.TabIndex = 9;
            this.labelDBForProject.Text = "Дата база :";
            // 
            // cmbDBForProject
            // 
            this.cmbDBForProject.FormattingEnabled = true;
            this.cmbDBForProject.Location = new System.Drawing.Point(154, 224);
            this.cmbDBForProject.Name = "cmbDBForProject";
            this.cmbDBForProject.Size = new System.Drawing.Size(232, 28);
            this.cmbDBForProject.TabIndex = 10;
            // 
            // tbSizeOfDB
            // 
            this.tbSizeOfDB.Location = new System.Drawing.Point(285, 27);
            this.tbSizeOfDB.Name = "tbSizeOfDB";
            this.tbSizeOfDB.Size = new System.Drawing.Size(110, 27);
            this.tbSizeOfDB.TabIndex = 1;
            // 
            // labelDBSIze
            // 
            this.labelDBSIze.AutoSize = true;
            this.labelDBSIze.Location = new System.Drawing.Point(61, 30);
            this.labelDBSIze.Name = "labelDBSIze";
            this.labelDBSIze.Size = new System.Drawing.Size(218, 20);
            this.labelDBSIze.TabIndex = 0;
            this.labelDBSIze.Text = "Големина на Дата база :";
            // 
            // btSettings
            // 
            this.btSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSettings.BackgroundImage")));
            this.btSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSettings.FlatAppearance.BorderSize = 0;
            this.btSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSettings.Image = ((System.Drawing.Image)(resources.GetObject("btSettings.Image")));
            this.btSettings.Location = new System.Drawing.Point(2, 692);
            this.btSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(44, 51);
            this.btSettings.TabIndex = 0;
            this.btSettings.UseVisualStyleBackColor = true;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // btOdjava
            // 
            this.btOdjava.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btOdjava.BackgroundImage")));
            this.btOdjava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btOdjava.FlatAppearance.BorderSize = 0;
            this.btOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOdjava.Location = new System.Drawing.Point(2, 3);
            this.btOdjava.Name = "btOdjava";
            this.btOdjava.Size = new System.Drawing.Size(48, 52);
            this.btOdjava.TabIndex = 0;
            this.btOdjava.UseVisualStyleBackColor = true;
            this.btOdjava.Click += new System.EventHandler(this.btOdjava_Click);
            // 
            // listViewMachines
            // 
            this.listViewMachines.HideSelection = false;
            this.listViewMachines.Location = new System.Drawing.Point(12, 62);
            this.listViewMachines.Name = "listViewMachines";
            this.listViewMachines.Size = new System.Drawing.Size(224, 620);
            this.listViewMachines.TabIndex = 1;
            this.listViewMachines.UseCompatibleStateImageBehavior = false;
            // 
            // productionDBDataSet
            // 
            this.productionDBDataSet.DataSetName = "ProductionDBDataSet";
            this.productionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productionPiecePropertiesDefinitionBindingSource
            // 
            this.productionPiecePropertiesDefinitionBindingSource.DataMember = "ProductionPiecePropertiesDefinition";
            this.productionPiecePropertiesDefinitionBindingSource.DataSource = this.productionDBDataSet;
            // 
            // FormFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 751);
            this.Controls.Add(this.listViewMachines);
            this.Controls.Add(this.btOdjava);
            this.Controls.Add(this.btSettings);
            this.Controls.Add(this.tabDefineMachine);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormFunctions";
            this.Text = "Функционалности на системот";
            this.Load += new System.EventHandler(this.FormFunctions_Load);
            this.tabDefineMachine.ResumeLayout(false);
            this.tpDefineM.ResumeLayout(false);
            this.paneltbDefineMachine.ResumeLayout(false);
            this.paneltbDefineMachine.PerformLayout();
            this.tpDefinePiece.ResumeLayout(false);
            this.tpDefinePiece.PerformLayout();
            this.tpDefineProperty.ResumeLayout(false);
            this.tpDefineProperty.PerformLayout();
            this.panelDefineProp.ResumeLayout(false);
            this.panelDefineProp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PiecesPropDataGridView)).EndInit();
            this.tpReport.ResumeLayout(false);
            this.tpReport.PerformLayout();
            this.tpManagement.ResumeLayout(false);
            this.tpManagement.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionPiecePropertiesDefinitionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDefineMachine;
        private System.Windows.Forms.TabPage tpDefineM;
        private System.Windows.Forms.TabPage tpDefinePiece;
        private System.Windows.Forms.TabPage tpDefineProperty;
        private System.Windows.Forms.TabPage tpReport;
        private System.Windows.Forms.TabPage tpManagement;
        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.Button btOdjava;
        private System.Windows.Forms.Button btDefineM;
        private System.Windows.Forms.TextBox tbDescriptionM;
        private System.Windows.Forms.TextBox tbNameM;
        private System.Windows.Forms.Label labelTypeM;
        private System.Windows.Forms.Label labelDescM;
        private System.Windows.Forms.Label labelNameM;
        private System.Windows.Forms.ComboBox cbTypeM;
        private System.Windows.Forms.ListView listViewPieces;
        private System.Windows.Forms.ListView listViewReport;
        private System.Windows.Forms.TextBox tbSerNum;
        private System.Windows.Forms.ListView listViewMachines;
        private System.Windows.Forms.DataGridView PiecesPropDataGridView;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.DateTimePicker dtpSearchT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSearchM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchSN;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelDefineProp;
        private System.Windows.Forms.Panel panelDefineProp;
        private System.Windows.Forms.Button btDefineProp;
        private System.Windows.Forms.Label labelProperty;
        private System.Windows.Forms.TextBox tbProperty;
        private System.Windows.Forms.RadioButton rbAFP;
        private System.Windows.Forms.RadioButton rbATL;
        private System.Windows.Forms.RadioButton rbGeneric;
        private ProductionDBDataSet productionDBDataSet;
        private System.Windows.Forms.BindingSource productionPiecePropertiesDefinitionBindingSource;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.RadioButton rbTimeRange;
        private System.Windows.Forms.RadioButton rbSerialNumber;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.DateTimePicker dtpTimeRange2;
        private System.Windows.Forms.DateTimePicker dtpTimeRange1;
        private System.Windows.Forms.Button btGenerateReport;
        private System.Windows.Forms.TextBox tbSizeOfDB;
        private System.Windows.Forms.Label labelDBSIze;
        private System.Windows.Forms.ComboBox cmbDataBaseNames;
        private System.Windows.Forms.Label DataBaseName;
        private System.Windows.Forms.Button btBackUp;
        private System.Windows.Forms.Button buttonDBProject;
        private System.Windows.Forms.Label labelDBChoice;
        private System.Windows.Forms.Label labelDBForProject;
        private System.Windows.Forms.ComboBox cmbDBForProject;
        private System.Windows.Forms.SaveFileDialog sfdBackUpDB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCreateNewDB;
        private System.Windows.Forms.Label labelNewDB;
        private System.Windows.Forms.TextBox tbNewDBName;
        private System.Windows.Forms.Label labelBackUp;
        private System.Windows.Forms.Panel paneltbDefineMachine;
        private System.Windows.Forms.ComboBox cbMaterialType;
        private System.Windows.Forms.Button btDefinePiece;
        private System.Windows.Forms.Label labelMagnifyingGlass;
        private System.Windows.Forms.Button btMagnifyingGlass;
        private System.Windows.Forms.TextBox tbProducedByP;
        private System.Windows.Forms.ComboBox cbTypeP;
        private System.Windows.Forms.TextBox tbSerialNum;
        private System.Windows.Forms.Label labelMadeByP;
        private System.Windows.Forms.Label labelMaterialP;
        private System.Windows.Forms.Label labelTypeP;
        private System.Windows.Forms.Label labelSerialNum;
        private System.Windows.Forms.Button btCreateNewDataBase;
    }
}