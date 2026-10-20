namespace BaobabRidgeRecords
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAnimalId = new Label();
            lblName = new Label();
            lblSpecies = new Label();
            lblAge = new Label();
            lblScore = new Label();
            txtAnimalId = new TextBox();
            txtName = new TextBox();
            txtSpecies = new TextBox();
            txtAge = new TextBox();
            txtScore = new TextBox();
            btnAdd = new Button();
            lblTitle = new Label();
            grpAnimalDetails = new GroupBox();
            btnClear = new Button();
            btnUpdate = new Button();
            grpAnimals = new GroupBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnDelete = new Button();
            dgvAnimals = new DataGridView();
            grpSummary = new GroupBox();
            txtSummary = new TextBox();
            btnGenerateSummary = new Button();
            grpAnimalDetails.SuspendLayout();
            grpAnimals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            grpSummary.SuspendLayout();
            SuspendLayout();
            // 
            // lblAnimalId
            // 
            lblAnimalId.AutoSize = true;
            lblAnimalId.Location = new Point(13, 26);
            lblAnimalId.Name = "lblAnimalId";
            lblAnimalId.Size = new Size(59, 15);
            lblAnimalId.TabIndex = 0;
            lblAnimalId.Text = "Animal ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(13, 56);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(13, 86);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(46, 15);
            lblSpecies.TabIndex = 2;
            lblSpecies.Text = "Species";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(13, 116);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(66, 15);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age (years)";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(13, 146);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(87, 15);
            lblScore.TabIndex = 4;
            lblScore.Text = "Recovery Score";
            // 
            // txtAnimalId
            // 
            txtAnimalId.Location = new Point(127, 24);
            txtAnimalId.Margin = new Padding(3, 2, 3, 2);
            txtAnimalId.Name = "txtAnimalId";
            txtAnimalId.Size = new Size(171, 23);
            txtAnimalId.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(127, 54);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(171, 23);
            txtName.TabIndex = 6;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(127, 84);
            txtSpecies.Margin = new Padding(3, 2, 3, 2);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(171, 23);
            txtSpecies.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(127, 114);
            txtAge.Margin = new Padding(3, 2, 3, 2);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(171, 23);
            txtAge.TabIndex = 8;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(127, 144);
            txtScore.Margin = new Padding(3, 2, 3, 2);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(171, 23);
            txtScore.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(13, 180);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 26);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(0, 64, 0);
            lblTitle.Location = new Point(18, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(469, 30);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "\tBaobab Ridge Wildlife Rehabilitation Centre";
            // 
            // grpAnimalDetails
            // 
            grpAnimalDetails.Controls.Add(btnClear);
            grpAnimalDetails.Controls.Add(btnUpdate);
            grpAnimalDetails.Controls.Add(lblAnimalId);
            grpAnimalDetails.Controls.Add(txtAnimalId);
            grpAnimalDetails.Controls.Add(btnAdd);
            grpAnimalDetails.Controls.Add(lblName);
            grpAnimalDetails.Controls.Add(txtScore);
            grpAnimalDetails.Controls.Add(txtName);
            grpAnimalDetails.Controls.Add(lblScore);
            grpAnimalDetails.Controls.Add(txtAge);
            grpAnimalDetails.Controls.Add(lblSpecies);
            grpAnimalDetails.Controls.Add(txtSpecies);
            grpAnimalDetails.Controls.Add(lblAge);
            grpAnimalDetails.Location = new Point(18, 45);
            grpAnimalDetails.Margin = new Padding(3, 2, 3, 2);
            grpAnimalDetails.Name = "grpAnimalDetails";
            grpAnimalDetails.Padding = new Padding(3, 2, 3, 2);
            grpAnimalDetails.Size = new Size(315, 248);
            grpAnimalDetails.TabIndex = 12;
            grpAnimalDetails.TabStop = false;
            grpAnimalDetails.Text = "Animal Details";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(214, 180);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Location = new Point(214, 181);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(83, 26);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            btnClear.MouseCaptureChanged += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(109, 180);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(96, 26);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Save Changes";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // grpAnimals
            // 
            grpAnimals.Controls.Add(txtSearch);
            grpAnimals.Controls.Add(btnSearch);
            grpAnimals.Controls.Add(btnDelete);
            grpAnimals.Controls.Add(dgvAnimals);
            grpAnimals.Location = new Point(350, 45);
            grpAnimals.Margin = new Padding(3, 2, 3, 2);
            grpAnimals.Name = "grpAnimals";
            grpAnimals.Padding = new Padding(3, 2, 3, 2);
            grpAnimals.Size = new Size(578, 248);
            grpAnimals.TabIndex = 13;
            grpAnimals.TabStop = false;
            grpAnimals.Text = "Animals in Care";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(13, 22);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by ID, name or species";
            txtSearch.Size = new Size(219, 23);
            txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(241, 21);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(79, 20);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(442, 214);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(122, 26);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete Selected";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(13, 49);
            dgvAnimals.Margin = new Padding(3, 2, 3, 2);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(551, 158);
            dgvAnimals.TabIndex = 0;
            // 
            // grpSummary
            // 
            grpSummary.Controls.Add(txtSummary);
            grpSummary.Controls.Add(btnGenerateSummary);
            grpSummary.Location = new Point(18, 304);
            grpSummary.Margin = new Padding(3, 2, 3, 2);
            grpSummary.Name = "grpSummary";
            grpSummary.Padding = new Padding(3, 2, 3, 2);
            grpSummary.Size = new Size(910, 139);
            grpSummary.TabIndex = 14;
            grpSummary.TabStop = false;
            grpSummary.Text = "Summary Report";
            // 
            // txtSummary
            // 
            txtSummary.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSummary.Location = new Point(162, 22);
            txtSummary.Margin = new Padding(3, 2, 3, 2);
            txtSummary.Multiline = true;
            txtSummary.Name = "txtSummary";
            txtSummary.ReadOnly = true;
            txtSummary.ScrollBars = ScrollBars.Vertical;
            txtSummary.Size = new Size(736, 106);
            txtSummary.TabIndex = 1;
            // 
            // btnGenerateSummary
            // 
            btnGenerateSummary.Location = new Point(13, 22);
            btnGenerateSummary.Margin = new Padding(3, 2, 3, 2);
            btnGenerateSummary.Name = "btnGenerateSummary";
            btnGenerateSummary.Size = new Size(131, 26);
            btnGenerateSummary.TabIndex = 0;
            btnGenerateSummary.Text = "Generate Summary";
            btnGenerateSummary.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 452);
            Controls.Add(grpSummary);
            Controls.Add(grpAnimals);
            Controls.Add(grpAnimalDetails);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Baobab Ridge Wildlife Rehabilitation Records System";
            grpAnimalDetails.ResumeLayout(false);
            grpAnimalDetails.PerformLayout();
            grpAnimals.ResumeLayout(false);
            grpAnimals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            grpSummary.ResumeLayout(false);
            grpSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAnimalId;
        private Label lblName;
        private Label lblSpecies;
        private Label lblAge;
        private Label lblScore;
        private TextBox txtAnimalId;
        private TextBox txtName;
        private TextBox txtSpecies;
        private TextBox txtAge;
        private TextBox txtScore;
        private Button btnAdd;
        private Label lblTitle;
        private GroupBox grpAnimalDetails;
        private Button btnClear;
        private Button btnUpdate;
        private GroupBox grpAnimals;
        private Button btnDelete;
        private DataGridView dgvAnimals;
        private GroupBox grpSummary;
        private Button btnGenerateSummary;
        private TextBox txtSummary;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}
