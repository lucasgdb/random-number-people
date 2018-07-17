namespace random_numbers
{
    partial class frmSorter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSorter));
            this.pSorter = new System.Windows.Forms.Panel();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.pNumber = new System.Windows.Forms.Panel();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.rbDescendent = new System.Windows.Forms.RadioButton();
            this.rbAscendent = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.aMaximum = new System.Windows.Forms.NumericUpDown();
            this.aMinimum = new System.Windows.Forms.NumericUpDown();
            this.lblBetween = new System.Windows.Forms.Label();
            this.nAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lvGenNumbers = new System.Windows.Forms.ListView();
            this.Numbers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pPeople = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnClearLast = new System.Windows.Forms.Button();
            this.btnLastResult = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRandomName = new System.Windows.Forms.Button();
            this.btnAddName = new System.Windows.Forms.Button();
            this.lvNames = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSorter = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pAbout = new System.Windows.Forms.Panel();
            this.picGitHub = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBCurrent = new System.Windows.Forms.Label();
            this.lblVCurrent = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pUpdate = new System.Windows.Forms.Panel();
            this.picGif = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnUptoDate = new System.Windows.Forms.Button();
            this.lblCBuild = new System.Windows.Forms.Label();
            this.lblCVersion = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.btnClear2 = new System.Windows.Forms.Button();
            this.cmsOptions2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiClearAll2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pSorter.SuspendLayout();
            this.pNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMinimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAmount)).BeginInit();
            this.pPeople.SuspendLayout();
            this.cmsOptions.SuspendLayout();
            this.pAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).BeginInit();
            this.cmsOptions2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSorter
            // 
            this.pSorter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pSorter.BackColor = System.Drawing.Color.DarkOrange;
            this.pSorter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSorter.Controls.Add(this.cbSelect);
            this.pSorter.Controls.Add(this.pNumber);
            this.pSorter.Controls.Add(this.pPeople);
            this.pSorter.Location = new System.Drawing.Point(119, -1);
            this.pSorter.Name = "pSorter";
            this.pSorter.Size = new System.Drawing.Size(666, 419);
            this.pSorter.TabIndex = 2;
            this.pSorter.Click += new System.EventHandler(this.pSorter_Click);
            // 
            // cbSelect
            // 
            this.cbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Items.AddRange(new object[] {
            "Números",
            "Pessoas"});
            this.cbSelect.Location = new System.Drawing.Point(10, 7);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(121, 24);
            this.cbSelect.TabIndex = 0;
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            // 
            // pNumber
            // 
            this.pNumber.BackColor = System.Drawing.Color.Orange;
            this.pNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNumber.Controls.Add(this.btnClear2);
            this.pNumber.Controls.Add(this.rbRandom);
            this.pNumber.Controls.Add(this.rbDescendent);
            this.pNumber.Controls.Add(this.rbAscendent);
            this.pNumber.Controls.Add(this.btnGenerate);
            this.pNumber.Controls.Add(this.aMaximum);
            this.pNumber.Controls.Add(this.aMinimum);
            this.pNumber.Controls.Add(this.lblBetween);
            this.pNumber.Controls.Add(this.nAmount);
            this.pNumber.Controls.Add(this.lblAmount);
            this.pNumber.Controls.Add(this.lvGenNumbers);
            this.pNumber.Location = new System.Drawing.Point(10, 39);
            this.pNumber.Name = "pNumber";
            this.pNumber.Size = new System.Drawing.Size(644, 371);
            this.pNumber.TabIndex = 1;
            this.pNumber.Click += new System.EventHandler(this.pNumber_Click);
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Checked = true;
            this.rbRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRandom.Location = new System.Drawing.Point(5, 139);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(79, 20);
            this.rbRandom.TabIndex = 4;
            this.rbRandom.TabStop = true;
            this.rbRandom.Text = "Aleatório";
            this.rbRandom.UseVisualStyleBackColor = true;
            // 
            // rbDescendent
            // 
            this.rbDescendent.AutoSize = true;
            this.rbDescendent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDescendent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbDescendent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDescendent.Location = new System.Drawing.Point(5, 116);
            this.rbDescendent.Name = "rbDescendent";
            this.rbDescendent.Size = new System.Drawing.Size(144, 20);
            this.rbDescendent.TabIndex = 5;
            this.rbDescendent.Text = "Ordem decrescente";
            this.rbDescendent.UseVisualStyleBackColor = true;
            // 
            // rbAscendent
            // 
            this.rbAscendent.AutoSize = true;
            this.rbAscendent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAscendent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAscendent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAscendent.Location = new System.Drawing.Point(5, 93);
            this.rbAscendent.Name = "rbAscendent";
            this.rbAscendent.Size = new System.Drawing.Size(128, 20);
            this.rbAscendent.TabIndex = 6;
            this.rbAscendent.Text = "Ordem crescente";
            this.rbAscendent.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(215, 95);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(205, 60);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Gerar números";
            this.tip.SetToolTip(this.btnGenerate, "Gerar números aleatórios");
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // aMaximum
            // 
            this.aMaximum.BackColor = System.Drawing.Color.DarkOrange;
            this.aMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aMaximum.Location = new System.Drawing.Point(527, 49);
            this.aMaximum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.aMaximum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aMaximum.Name = "aMaximum";
            this.aMaximum.Size = new System.Drawing.Size(103, 38);
            this.aMaximum.TabIndex = 2;
            this.aMaximum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.aMaximum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // aMinimum
            // 
            this.aMinimum.BackColor = System.Drawing.Color.DarkOrange;
            this.aMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aMinimum.Location = new System.Drawing.Point(370, 49);
            this.aMinimum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.aMinimum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aMinimum.Name = "aMinimum";
            this.aMinimum.Size = new System.Drawing.Size(103, 38);
            this.aMinimum.TabIndex = 1;
            this.aMinimum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.aMinimum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblBetween
            // 
            this.lblBetween.AutoSize = true;
            this.lblBetween.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetween.Location = new System.Drawing.Point(274, 51);
            this.lblBetween.Name = "lblBetween";
            this.lblBetween.Size = new System.Drawing.Size(247, 32);
            this.lblBetween.TabIndex = 2;
            this.lblBetween.Text = "Entre                   e";
            // 
            // nAmount
            // 
            this.nAmount.BackColor = System.Drawing.Color.DarkOrange;
            this.nAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nAmount.Location = new System.Drawing.Point(133, 8);
            this.nAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nAmount.Name = "nAmount";
            this.nAmount.Size = new System.Drawing.Size(103, 38);
            this.nAmount.TabIndex = 0;
            this.nAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nAmount.ValueChanged += new System.EventHandler(this.aNumbers_ValueChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(10, 10);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(347, 32);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Sortear                   número";
            this.lblAmount.Click += new System.EventHandler(this.pSorter_Click);
            // 
            // lvGenNumbers
            // 
            this.lvGenNumbers.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvGenNumbers.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvGenNumbers.BackColor = System.Drawing.Color.Orange;
            this.lvGenNumbers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numbers});
            this.lvGenNumbers.ContextMenuStrip = this.cmsOptions2;
            this.lvGenNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvGenNumbers.Location = new System.Drawing.Point(3, 165);
            this.lvGenNumbers.Name = "lvGenNumbers";
            this.lvGenNumbers.ShowGroups = false;
            this.lvGenNumbers.Size = new System.Drawing.Size(636, 200);
            this.lvGenNumbers.TabIndex = 7;
            this.lvGenNumbers.TileSize = new System.Drawing.Size(50, 30);
            this.lvGenNumbers.UseCompatibleStateImageBehavior = false;
            this.lvGenNumbers.View = System.Windows.Forms.View.SmallIcon;
            // 
            // Numbers
            // 
            this.Numbers.Text = "";
            this.Numbers.Width = 10;
            // 
            // pPeople
            // 
            this.pPeople.BackColor = System.Drawing.Color.Orange;
            this.pPeople.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPeople.Controls.Add(this.btnImport);
            this.pPeople.Controls.Add(this.btnClearLast);
            this.pPeople.Controls.Add(this.btnLastResult);
            this.pPeople.Controls.Add(this.btnClear);
            this.pPeople.Controls.Add(this.btnRandomName);
            this.pPeople.Controls.Add(this.btnAddName);
            this.pPeople.Controls.Add(this.lvNames);
            this.pPeople.Controls.Add(this.txtName);
            this.pPeople.Controls.Add(this.lblName);
            this.pPeople.Location = new System.Drawing.Point(10, 39);
            this.pPeople.Name = "pPeople";
            this.pPeople.Size = new System.Drawing.Size(644, 371);
            this.pPeople.TabIndex = 2;
            this.pPeople.Visible = false;
            this.pPeople.Click += new System.EventHandler(this.pPeople_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.OrangeRed;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(501, 142);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(129, 38);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Importar nomes";
            this.tip.SetToolTip(this.btnImport, "Importar nomes via arquivo de texto (*.txt)");
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnClearLast
            // 
            this.btnClearLast.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClearLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnClearLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLast.Location = new System.Drawing.Point(501, 98);
            this.btnClearLast.Name = "btnClearLast";
            this.btnClearLast.Size = new System.Drawing.Size(129, 38);
            this.btnClearLast.TabIndex = 2;
            this.btnClearLast.Text = "Apagar último";
            this.tip.SetToolTip(this.btnClearLast, "Apagar último nome da lista");
            this.btnClearLast.UseVisualStyleBackColor = false;
            this.btnClearLast.Click += new System.EventHandler(this.btnClearLast_Click);
            // 
            // btnLastResult
            // 
            this.btnLastResult.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLastResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLastResult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnLastResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastResult.Location = new System.Drawing.Point(336, 142);
            this.btnLastResult.Name = "btnLastResult";
            this.btnLastResult.Size = new System.Drawing.Size(137, 38);
            this.btnLastResult.TabIndex = 6;
            this.btnLastResult.Text = "Resultado";
            this.tip.SetToolTip(this.btnLastResult, "Ver resultado do último sorteio");
            this.btnLastResult.UseVisualStyleBackColor = false;
            this.btnLastResult.Click += new System.EventHandler(this.btnLastResult_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(336, 98);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 38);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Limpar tudo";
            this.tip.SetToolTip(this.btnClear, "Apagar todos os nomes");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRandomName
            // 
            this.btnRandomName.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRandomName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandomName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnRandomName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomName.Location = new System.Drawing.Point(336, 53);
            this.btnRandomName.Name = "btnRandomName";
            this.btnRandomName.Size = new System.Drawing.Size(137, 38);
            this.btnRandomName.TabIndex = 4;
            this.btnRandomName.Text = "Sortear nome";
            this.tip.SetToolTip(this.btnRandomName, "Sortear um nome aleatório");
            this.btnRandomName.UseVisualStyleBackColor = false;
            this.btnRandomName.Click += new System.EventHandler(this.btnRandomName_Click);
            // 
            // btnAddName
            // 
            this.btnAddName.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAddName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnAddName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddName.Location = new System.Drawing.Point(501, 53);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(129, 38);
            this.btnAddName.TabIndex = 1;
            this.btnAddName.Text = "Adicionar nome";
            this.tip.SetToolTip(this.btnAddName, "Adicionar nome à lista");
            this.btnAddName.UseVisualStyleBackColor = false;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // lvNames
            // 
            this.lvNames.BackColor = System.Drawing.Color.Orange;
            this.lvNames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.index});
            this.lvNames.ContextMenuStrip = this.cmsOptions;
            this.lvNames.FullRowSelect = true;
            this.lvNames.GridLines = true;
            this.lvNames.Location = new System.Drawing.Point(12, 51);
            this.lvNames.Name = "lvNames";
            this.lvNames.Size = new System.Drawing.Size(316, 314);
            this.lvNames.TabIndex = 7;
            this.lvNames.UseCompatibleStateImageBehavior = false;
            this.lvNames.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Nome";
            this.name.Width = 238;
            // 
            // index
            // 
            this.index.Text = "Índice";
            this.index.Width = 72;
            // 
            // cmsOptions
            // 
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRemove,
            this.tsmiClearAll});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(140, 48);
            // 
            // tsmiRemove
            // 
            this.tsmiRemove.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRemove.Image")));
            this.tsmiRemove.Name = "tsmiRemove";
            this.tsmiRemove.Size = new System.Drawing.Size(139, 22);
            this.tsmiRemove.Text = "Remover";
            this.tsmiRemove.Click += new System.EventHandler(this.tsmiRemove_Click);
            // 
            // tsmiClearAll
            // 
            this.tsmiClearAll.Image = ((System.Drawing.Image)(resources.GetObject("tsmiClearAll.Image")));
            this.tsmiClearAll.Name = "tsmiClearAll";
            this.tsmiClearAll.Size = new System.Drawing.Size(139, 22);
            this.tsmiClearAll.Text = "Limpar tudo";
            this.tsmiClearAll.Click += new System.EventHandler(this.tsmiClearAll_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.DarkOrange;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(207, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(423, 31);
            this.txtName.TabIndex = 0;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(188, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Digite o nome:";
            this.lblName.Click += new System.EventHandler(this.pSorter_Click);
            // 
            // btnSorter
            // 
            this.btnSorter.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSorter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSorter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnSorter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSorter.Location = new System.Drawing.Point(0, 0);
            this.btnSorter.Name = "btnSorter";
            this.btnSorter.Size = new System.Drawing.Size(120, 38);
            this.btnSorter.TabIndex = 0;
            this.btnSorter.TabStop = false;
            this.btnSorter.Text = "Sorteador";
            this.tip.SetToolTip(this.btnSorter, "Sorteador de Números e Pessoas");
            this.btnSorter.UseVisualStyleBackColor = false;
            this.btnSorter.Click += new System.EventHandler(this.btnSorter_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(0, 74);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(120, 38);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.TabStop = false;
            this.btnAbout.Text = "Sobre";
            this.tip.SetToolTip(this.btnAbout, "Sobre");
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.OrangeRed;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(0, 37);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 38);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Atualizador";
            this.tip.SetToolTip(this.btnUpdate, "Atualizador de software");
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pAbout
            // 
            this.pAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pAbout.BackColor = System.Drawing.Color.DarkOrange;
            this.pAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pAbout.Controls.Add(this.picGitHub);
            this.pAbout.Controls.Add(this.lblEmail);
            this.pAbout.Controls.Add(this.lblBCurrent);
            this.pAbout.Controls.Add(this.lblVCurrent);
            this.pAbout.Controls.Add(this.lblDesc);
            this.pAbout.Controls.Add(this.picLogo);
            this.pAbout.Location = new System.Drawing.Point(119, -1);
            this.pAbout.Name = "pAbout";
            this.pAbout.Size = new System.Drawing.Size(666, 419);
            this.pAbout.TabIndex = 6;
            this.pAbout.Visible = false;
            this.pAbout.Click += new System.EventHandler(this.pAbout_Click);
            // 
            // picGitHub
            // 
            this.picGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGitHub.Image = ((System.Drawing.Image)(resources.GetObject("picGitHub.Image")));
            this.picGitHub.Location = new System.Drawing.Point(622, 378);
            this.picGitHub.Name = "picGitHub";
            this.picGitHub.Size = new System.Drawing.Size(30, 30);
            this.picGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGitHub.TabIndex = 5;
            this.picGitHub.TabStop = false;
            this.tip.SetToolTip(this.picGitHub, "GitHub");
            this.picGitHub.Click += new System.EventHandler(this.picGitHub_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(4, 384);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(471, 24);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail: lucasnaja0@gmail.com (Dicas, bugs, etc.)";
            this.lblEmail.Click += new System.EventHandler(this.pAbout_Click);
            // 
            // lblBCurrent
            // 
            this.lblBCurrent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBCurrent.AutoSize = true;
            this.lblBCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBCurrent.Location = new System.Drawing.Point(284, 302);
            this.lblBCurrent.Name = "lblBCurrent";
            this.lblBCurrent.Size = new System.Drawing.Size(134, 24);
            this.lblBCurrent.TabIndex = 3;
            this.lblBCurrent.Text = "Build atual: X";
            this.lblBCurrent.Click += new System.EventHandler(this.pAbout_Click);
            // 
            // lblVCurrent
            // 
            this.lblVCurrent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVCurrent.AutoSize = true;
            this.lblVCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVCurrent.Location = new System.Drawing.Point(265, 278);
            this.lblVCurrent.Name = "lblVCurrent";
            this.lblVCurrent.Size = new System.Drawing.Size(166, 24);
            this.lblVCurrent.TabIndex = 2;
            this.lblVCurrent.Text = "Versão atual: 1.0";
            this.lblVCurrent.Click += new System.EventHandler(this.pAbout_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(149, 254);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(376, 24);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Programa desenvolvido por Lucas Naja";
            this.lblDesc.Click += new System.EventHandler(this.pAbout_Click);
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(7, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(650, 238);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.tip.SetToolTip(this.picLogo, "Sorteador gratuito");
            this.picLogo.Click += new System.EventHandler(this.pAbout_Click);
            // 
            // pUpdate
            // 
            this.pUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.pUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pUpdate.Controls.Add(this.picGif);
            this.pUpdate.Controls.Add(this.lblStatus);
            this.pUpdate.Controls.Add(this.btnUptoDate);
            this.pUpdate.Controls.Add(this.lblCBuild);
            this.pUpdate.Controls.Add(this.lblCVersion);
            this.pUpdate.Location = new System.Drawing.Point(119, -1);
            this.pUpdate.Name = "pUpdate";
            this.pUpdate.Size = new System.Drawing.Size(666, 419);
            this.pUpdate.TabIndex = 7;
            this.pUpdate.Visible = false;
            this.pUpdate.Click += new System.EventHandler(this.pUpdate_Click);
            // 
            // picGif
            // 
            this.picGif.Image = ((System.Drawing.Image)(resources.GetObject("picGif.Image")));
            this.picGif.Location = new System.Drawing.Point(448, 85);
            this.picGif.Name = "picGif";
            this.picGif.Size = new System.Drawing.Size(40, 38);
            this.picGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGif.TabIndex = 5;
            this.picGif.TabStop = false;
            this.tip.SetToolTip(this.picGif, "Carregando...");
            this.picGif.Visible = false;
            this.picGif.Click += new System.EventHandler(this.pUpdate_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(4, 135);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(278, 31);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status: Aguardando...";
            this.lblStatus.Click += new System.EventHandler(this.pUpdate_Click);
            // 
            // btnUptoDate
            // 
            this.btnUptoDate.BackColor = System.Drawing.Color.OrangeRed;
            this.btnUptoDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUptoDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnUptoDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUptoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUptoDate.Location = new System.Drawing.Point(221, 85);
            this.btnUptoDate.Name = "btnUptoDate";
            this.btnUptoDate.Size = new System.Drawing.Size(221, 38);
            this.btnUptoDate.TabIndex = 3;
            this.btnUptoDate.Text = "Verificar atualizações";
            this.tip.SetToolTip(this.btnUptoDate, "Verificar atualização");
            this.btnUptoDate.UseVisualStyleBackColor = false;
            this.btnUptoDate.Click += new System.EventHandler(this.btnUptoDate_Click);
            // 
            // lblCBuild
            // 
            this.lblCBuild.AutoSize = true;
            this.lblCBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCBuild.Location = new System.Drawing.Point(245, 40);
            this.lblCBuild.Name = "lblCBuild";
            this.lblCBuild.Size = new System.Drawing.Size(173, 31);
            this.lblCBuild.TabIndex = 2;
            this.lblCBuild.Text = "Build atual: X";
            this.lblCBuild.Click += new System.EventHandler(this.pUpdate_Click);
            // 
            // lblCVersion
            // 
            this.lblCVersion.AutoSize = true;
            this.lblCVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVersion.Location = new System.Drawing.Point(220, 9);
            this.lblCVersion.Name = "lblCVersion";
            this.lblCVersion.Size = new System.Drawing.Size(219, 31);
            this.lblCVersion.TabIndex = 1;
            this.lblCVersion.Text = "Versão atual: 1.0";
            this.lblCVersion.Click += new System.EventHandler(this.pUpdate_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnClear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear2.Location = new System.Drawing.Point(580, 129);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(56, 30);
            this.btnClear2.TabIndex = 8;
            this.btnClear2.Text = "Limpar";
            this.tip.SetToolTip(this.btnClear2, "Limpar números sorteados");
            this.btnClear2.UseVisualStyleBackColor = false;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // cmsOptions2
            // 
            this.cmsOptions2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClearAll2});
            this.cmsOptions2.Name = "cmsOptions2";
            this.cmsOptions2.Size = new System.Drawing.Size(112, 26);
            // 
            // tsmiClearAll2
            // 
            this.tsmiClearAll2.Image = ((System.Drawing.Image)(resources.GetObject("tsmiClearAll2.Image")));
            this.tsmiClearAll2.Name = "tsmiClearAll2";
            this.tsmiClearAll2.Size = new System.Drawing.Size(111, 22);
            this.tsmiClearAll2.Text = "Limpar";
            this.tsmiClearAll2.Click += new System.EventHandler(this.tsmiClearAll2_Click);
            // 
            // frmSorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(784, 417);
            this.Controls.Add(this.btnSorter);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.pSorter);
            this.Controls.Add(this.pUpdate);
            this.Controls.Add(this.pAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSorter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorteador de Números e Pessoas";
            this.Load += new System.EventHandler(this.frmSorter_Load);
            this.pSorter.ResumeLayout(false);
            this.pNumber.ResumeLayout(false);
            this.pNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMinimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAmount)).EndInit();
            this.pPeople.ResumeLayout(false);
            this.pPeople.PerformLayout();
            this.cmsOptions.ResumeLayout(false);
            this.pAbout.ResumeLayout(false);
            this.pAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pUpdate.ResumeLayout(false);
            this.pUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).EndInit();
            this.cmsOptions2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pSorter;
        private System.Windows.Forms.Button btnSorter;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pAbout;
        private System.Windows.Forms.Panel pUpdate;
        private System.Windows.Forms.Label lblBCurrent;
        private System.Windows.Forms.Label lblVCurrent;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox picGitHub;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.Panel pNumber;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Panel pPeople;
        private System.Windows.Forms.NumericUpDown nAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown aMaximum;
        private System.Windows.Forms.NumericUpDown aMinimum;
        private System.Windows.Forms.Label lblBetween;
        private System.Windows.Forms.ListView lvGenNumbers;
        private System.Windows.Forms.ColumnHeader Numbers;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.RadioButton rbDescendent;
        private System.Windows.Forms.RadioButton rbAscendent;
        private System.Windows.Forms.Button btnClearLast;
        private System.Windows.Forms.Button btnLastResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRandomName;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.ListView lvNames;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader index;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemove;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearAll;
        private System.Windows.Forms.Button btnUptoDate;
        private System.Windows.Forms.Label lblCBuild;
        private System.Windows.Forms.Label lblCVersion;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox picGif;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.ContextMenuStrip cmsOptions2;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearAll2;
    }
}

