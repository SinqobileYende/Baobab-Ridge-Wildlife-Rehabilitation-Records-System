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
            lblAnimalId.Location = new Point(15, 35);
            lblAnimalId.Name = "lblAnimalId";
            lblAnimalId.Size = new Size(75, 20);
            lblAnimalId.TabIndex = 0;
            lblAnimalId.Text = "Animal ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(15, 75);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(15, 115);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(59, 20);
            lblSpecies.TabIndex = 2;
            lblSpecies.Text = "Species";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(15, 155);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(84, 20);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age (years)";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(15, 195);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(110, 20);
            lblScore.TabIndex = 4;
            lblScore.Text = "Recovery Score";
            // 
            // txtAnimalId
            // 
            txtAnimalId.Location = new Point(145, 32);
            txtAnimalId.Name = "txtAnimalId";
            txtAnimalId.Size = new Size(195, 27);
            txtAnimalId.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(145, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(195, 27);
            txtName.TabIndex = 6;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(145, 112);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(195, 27);
            txtSpecies.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(145, 152);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(195, 27);
            txtAge.TabIndex = 8;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(145, 192);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(195, 27);
            txtScore.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 240);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
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
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(596, 38);
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
            grpAnimalDetails.Location = new Point(20, 60);
            grpAnimalDetails.Name = "grpAnimalDetails";
            grpAnimalDetails.Size = new Size(360, 330);
            grpAnimalDetails.TabIndex = 12;
            grpAnimalDetails.TabStop = false;
            grpAnimalDetails.Text = "Animal Details";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(245, 240);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 35);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(125, 240);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 35);
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
            grpAnimals.Location = new Point(400, 60);
            grpAnimals.Name = "grpAnimals";
            grpAnimals.Size = new Size(660, 330);
            grpAnimals.TabIndex = 13;
            grpAnimals.TabStop = false;
            grpAnimals.Text = "Animals in Care";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(15, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by ID, name or species";
            txtSearch.Size = new Size(250, 27);
            txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(275, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 27);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(505, 285);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 35);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete Selected";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(15, 65);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(630, 210);
            dgvAnimals.TabIndex = 0;
            // 
            // grpSummary
            // 
            grpSummary.Controls.Add(txtSummary);
            grpSummary.Controls.Add(btnGenerateSummary);
            grpSummary.Location = new Point(20, 405);
            grpSummary.Name = "grpSummary";
            grpSummary.Size = new Size(1040, 185);
            grpSummary.TabIndex = 14;
            grpSummary.TabStop = false;
            grpSummary.Text = "Summary Report";
            // 
            // txtSummary
            // 
            txtSummary.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSummary.Location = new Point(185, 30);
            txtSummary.Multiline = true;
            txtSummary.Name = "txtSummary";
            txtSummary.ReadOnly = true;
            txtSummary.ScrollBars = ScrollBars.Vertical;
            txtSummary.Size = new Size(840, 140);
            txtSummary.TabIndex = 1;
            // 
            // btnGenerateSummary
            // 
            btnGenerateSummary.Location = new Point(15, 30);
            btnGenerateSummary.Name = "btnGenerateSummary";
            btnGenerateSummary.Size = new Size(150, 35);
            btnGenerateSummary.TabIndex = 0;
            btnGenerateSummary.Text = "Generate Summary";
            btnGenerateSummary.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 603);
            Controls.Add(grpSummary);
            Controls.Add(grpAnimals);
            Controls.Add(grpAnimalDetails);
            Controls.Add(lblTitle);
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
