
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BaobabRidgeRecords
{
    public partial class MainForm : Form
    {
        private readonly string filePath =
            Path.Combine(Application.StartupPath, "animals.txt");

        private DataGridView dgvAnimals;
        private List<Animal> animals = new List<Animal>();

        public MainForm()
        {
            InitializeComponent();

            FindOrCreateGrid();
            ConfigureGrid();

            Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadAnimals();
        }

        private void FindOrCreateGrid()
        {
           
            dgvAnimals = FindGrid(this);

            if (dgvAnimals == null)
            {
                dgvAnimals = new DataGridView
                {
                    Name = "dgvAnimals",
                    Dock = DockStyle.Fill
                };

                Controls.Add(dgvAnimals);
                dgvAnimals.BringToFront();
            }
        }

        private DataGridView FindGrid(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is DataGridView grid)
                    return grid;

                DataGridView nestedGrid = FindGrid(control);

                if (nestedGrid != null)
                    return nestedGrid;
            }

            return null;
        }

        private void ConfigureGrid()
        {
            dgvAnimals.AutoGenerateColumns = false;
            dgvAnimals.Columns.Clear();

            dgvAnimals.Columns.Add(CreateColumn("ID", "Id"));
            dgvAnimals.Columns.Add(CreateColumn("Name", "Name"));
            dgvAnimals.Columns.Add(CreateColumn("Species", "Species"));
            dgvAnimals.Columns.Add(CreateColumn("Age", "Age"));
            dgvAnimals.Columns.Add(CreateColumn("Score", "Score"));
            dgvAnimals.Columns.Add(CreateColumn("Status", "Status"));
            dgvAnimals.Columns.Add(
                CreateColumn("Housing Unit", "HousingUnit"));

            dgvAnimals.ReadOnly = true;
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.AllowUserToOrderColumns = false;
            dgvAnimals.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.MultiSelect = false;
            dgvAnimals.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private DataGridViewTextBoxColumn CreateColumn(
            string header, string propertyName)
        {
            return new DataGridViewTextBoxColumn
            {
                HeaderText = header,
                DataPropertyName = propertyName,
                Name = propertyName,
                ReadOnly = true
            };
        }

        private void LoadAnimals()
        {
            int skippedLines = 0;

            try
            {
                // Create an empty file if it does not exist.
                if (!File.Exists(filePath))
                {
                    File.WriteAllText(filePath, string.Empty);
                }

                List<Animal> loadedAnimals = new List<Animal>();

                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        skippedLines++;
                        continue;
                    }

                    string[] fields = line.Split('|');

                   
                    if (fields.Length != 7)
                    {
                        skippedLines++;
                        continue;
                    }

                    for (int i = 0; i < fields.Length; i++)
                    {
                        fields[i] = fields[i].Trim();
                    }

                    // Age and Score must be valid integers.
                    if (!int.TryParse(
                            fields[3],
                            NumberStyles.Integer,
                            CultureInfo.InvariantCulture,
                            out int age)
                        || !int.TryParse(
                            fields[4],
                            NumberStyles.Integer,
                            CultureInfo.InvariantCulture,
                            out int score))
                    {
                        skippedLines++;
                        continue;
                    }

                    Animal animal = new Animal
                    {
                        Id = fields[0],
                        Name = fields[1],
                        Species = fields[2],
                        Age = age,
                        Score = score,
                        Status = fields[5],
                        HousingUnit = fields[6]
                    };

                    loadedAnimals.Add(animal);
                }

                animals = loadedAnimals;

                
                dgvAnimals.DataSource = null;
                dgvAnimals.DataSource = animals;

                if (skippedLines > 0)
                {
                    MessageBox.Show(
                        $"{skippedLines} malformed line(s) " +
                        "were skipped while loading animals.txt.",
                        "File Loading Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(
                    "Unable to read animals.txt:\n" + ex.Message,
                    "File Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(
                    "Access to animals.txt was denied:\n" + ex.Message,
                    "File Access Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Call this after successfully saving additions,
        public void RefreshAnimals()
        {
            LoadAnimals();
        }
    }
}
