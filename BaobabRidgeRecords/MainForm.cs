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

        // The grid (dgvAnimals) is created in the designer (MainForm.Designer.cs),
        // so it is not declared again here.
        private List<Animal> animals = new List<Animal>();

        public MainForm()
        {
            InitializeComponent();

            FindOrCreateGrid();
            ConfigureGrid();
            dgvAnimals.CellClick += dgvAnimals_CellClick;
            btnUpdate.Enabled= false;

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

        // Runs when the user clicks the Add button. The code is added in a later commit.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Read the boxes and remove spaces at the start and end.
            // The ID is changed to capital letters so "wr-0007" is accepted and saved as "WR-0007".
            string id = txtAnimalId.Text.Trim().ToUpper();
            string name = txtName.Text.Trim();
            string species = txtSpecies.Text.Trim();
            string ageText = txtAge.Text.Trim();
            string scoreText = txtScore.Text.Trim();

            // Check the ID format
            if (!AnimalValidator.IsValidId(id))
            {
                ShowError("Animal ID must be WR- followed by exactly 4 digits, for example WR-0007.", txtAnimalId);
                return;
            }

            // Check the ID is not already used.
            // Reading the file can fail, so it is inside try...catch to stop the program crashing.
            try
            {
                if (AnimalFileHandler.IdExists(id))
                {
                    ShowError("Animal ID " + id + " is already used. Please enter a different ID.", txtAnimalId);
                    return;
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have permission to read animals.txt.", "File error");
                return;
            }
            catch (IOException)
            {
                MessageBox.Show("animals.txt is being used by another program. Close it and try again.", "File error");
                return;
            }

            // Check the name and species
            if (!AnimalValidator.IsValidText(name))
            {
                ShowError("Name must be 1 to 30 characters and must not contain the | character.", txtName);
                return;
            }

            if (!AnimalValidator.IsValidText(species))
            {
                ShowError("Species must be 1 to 30 characters and must not contain the | character.", txtSpecies);
                return;
            }

            // Check the age and recovery score are whole numbers from 0 to 100
            int age;
            if (!AnimalValidator.IsValidNumber(ageText, out age))
            {
                ShowError("Age must be a whole number between 0 and 100.", txtAge);
                return;
            }

            int score;
            if (!AnimalValidator.IsValidNumber(scoreText, out score))
            {
                ShowError("Recovery Score must be a whole number between 0 and 100.", txtScore);
                return;
            }

            // All checks passed, so create the animal
            Animal animal = new Animal();
            animal.Id = id;
            animal.Name = name;
            animal.Species = species;
            animal.Age = age;
            animal.Score = score;

            // Work out the status and housing unit from the score (the one shared classification method)
            AnimalClassifier.ClassifyAnimal(animal);

            // Save the animal to the end of animals.txt.
            // Writing to the file can fail, so it is inside try...catch with a friendly message for each problem.
            try
            {
                AnimalFileHandler.AppendAnimalToFile(animal);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have permission to change animals.txt. It may be set to read-only.", "File error");
                return;
            }
            catch (DirectoryNotFoundException)
            {
                // This must come before IOException, because it is a type of IOException
                MessageBox.Show("The folder for animals.txt could not be found.", "File error");
                return;
            }
            catch (IOException)
            {
                MessageBox.Show("animals.txt is being used by another program. Close it and try again.", "File error");
                return;
            }

            // Show the user the status and housing unit the program worked out
            MessageBox.Show(animal.Name + " was added.\n\n" +
                            "Status: " + animal.Status + "\n" +
                            "Housing unit: " + animal.HousingUnit,
                            "Animal added");

            // Empty the boxes, ready for the next animal
            ClearInputs();

            // Reload the grid so the new animal appears (Vodka's View method)
            LoadAnimals();
        }


        /* Method to delete a record*/
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvAnimals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an animal to delete");
                return;
            }
            string id = dgvAnimals.SelectedRows[0].Cells[0].Value.ToString();
            string name = dgvAnimals.SelectedRows[0].Cells[1].Value.ToString();

            DialogResult answer = MessageBox.Show($"Delete ID: {id} ({name})? This can not be undone.", "Confirm Delete", MessageBoxButtons.YesNo);
            if (answer != DialogResult.Yes) return;
            Animal delete = null;
            foreach (Animal animal in animals)
            {

                if (animal.Id == id)
                {
                    delete = animal; break;
                }
            }
            animals.Remove(delete);
            try
            {
                AnimalFileHandler.SaveAllAnimals(
                    animals);


            }
            catch (IOException)
            {
                MessageBox.Show("animals.txt is open in another program. Close it and try again");

                LoadAnimals(); return;
            }
            LoadAnimals();

        }


        // Shows an error message and puts the cursor back in the box that has the problem.
        private void ShowError(string message, TextBox box)
        {
            MessageBox.Show(message, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            box.Focus();
            box.SelectAll();
        }

        // Empties all the input boxes and puts the cursor back in the ID box, ready for the next animal.
        private void ClearInputs()
        {
            txtAnimalId.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtScore.Clear();
            txtAnimalId.Focus();
        }

        /* Puts the form into edit mode and locks the ID box, turns off add and turns on save changes*/
        private void EditModeOn() 
        {
            txtAnimalId.ReadOnly= true;
            btnAdd.Enabled= false;
            btnUpdate.Enabled= true;
        }
        /* takes the form back to Add mode and unlocks the ID box, turns on Add and turns Off save changes*/
        private void EditModeOff()
        {
            txtAnimalId.ReadOnly = false;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            /*method to empty the box*/
            ClearInputs();
        }

        /*Copies the selected animals details into the input boxes and switches to Edit mode*/

        private void LoadAnimalsOnForm(Animal animal) 
        {
            txtAnimalId.Text = animal.Id;
            txtName.Text = animal.Name;
            txtSpecies.Text = animal.Species;
            txtAge.Text = animal.Age.ToString();
                txtScore.Text = animal.Score.ToString();
            EditModeOn();

        }
        private void dgvAnimals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* If the header row is selected, ignore it*/
            if (e.RowIndex < 0) return;         
            Animal selected = animals[e.RowIndex];
            LoadAnimalsOnForm(selected);
        }
        //runs when Clear is clicked and returns form to add mode
        private void btnClear_Click(object sender, EventArgs e) 
        {
            EditModeOff();

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id= txtAnimalId.Text.Trim().ToUpper();
            string name = txtName.Text.Trim();
            string species= txtSpecies.Text.Trim();
            string ageText= txtAge.Text.Trim();
            string scoreText= txtScore.Text.Trim();

            if (!AnimalValidator.IsValidText(name))
            {
                ShowError("Name must be between 1 and 30 characters and must not contain characters", txtName);
                   
                return;
            }
            if (!AnimalValidator.IsValidText(species))
            {
                ShowError("Species must be between 1 and 30 characters and must not contain characters", txtSpecies);
               
                return;
            }
            int age;
            if (!AnimalValidator.IsValidNumber(ageText, out age))
            {
                ShowError("Age must be a whole number between 0 and 100", txtAge);
              
                return;
            }
            int score;
            if (!AnimalValidator.IsValidNumber(scoreText, out score))
            {
                ShowError("Age must be a whole number between 0 and 100", txtScore);

                return;
            }

            //Find the animal you want to edit
            Animal update= animals.Find(a=>a.Id==id) ;
            if (update == null) 
            {
                MessageBox.Show("Animal could not be found");
                return;

            }
            update.Name= name;  
            update.Species= species;
            update.Age= age;
            update.Score = score;

            //Recalculate status and housing 
            AnimalClassifier.ClassifyAnimal(update);

            try { AnimalFileHandler.SaveAllAnimals(animals); }
            catch (IOException)
            {
                MessageBox.Show("Animals.txt is open in anoter program. Close and try again");
                LoadAnimals();
                return;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("animals.txt is read only.");
                LoadAnimals(); return;
            }

            LoadAnimals();
            MessageBox.Show(update.Name + "was updated. \n\n Status: " + update.Status + "\n Housing Unit: " + update.HousingUnit, "Animal updated");
            EditModeOff();

        }

    }
}




















