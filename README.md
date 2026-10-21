# Baobab Ridge Wildlife Rehabilitation Records System

A Windows Forms desktop application built in C# (.NET 10) for managing wildlife rehabilitation records at the Baobab Ridge Wildlife Rehabilitation Centre. The system allows staff to add, update, delete, and search animal records, automatically classifying each animal's status and housing unit based on its recovery score.

## Table of Contents

- [About](#about)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Data Storage](#data-storage)
- [Classification Rules](#classification-rules)
- [Validation Rules](#validation-rules)
- [Team Members](#team-members)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## About

The Baobab Ridge Wildlife Rehabilitation Records System is a student project (PRG282) designed to help a wildlife rehabilitation centre track animals in its care. Each animal is assigned a recovery score (0–100), and the system automatically determines the animal's status and the housing unit it should be placed in. Records are persisted to a pipe-delimited text file (`animals.txt`), making the application lightweight and easy to back up.

## Features

- **Add animals** — Capture ID, name, species, age, and recovery score with full input validation.
- **Update animals** — Select a record from the grid to load it into the form, edit it, and save changes.
- **Delete animals** — Remove a selected record with a confirmation prompt.
- **Automatic classification** — Status and housing unit are calculated from the recovery score.
- **Persistent storage** — Records are read from and written to `animals.txt`.
- **Data grid view** — View all animals in care at a glance.
- **Search** — Filter animals by ID, name, or species (UI present).
- **Summary report** — Generate a summary of the animals in care (UI present).
- **Duplicate ID protection** — The system prevents adding an animal with an ID that already exists.
- **Malformed-line handling** — Invalid lines in the data file are skipped with a warning.

## Getting Started

### Prerequisites

- Windows OS
- [.NET 10 SDK](https://dotnet.microsoft.com/download) (target framework: `net10.0-windows`)
- Visual Studio 2022+ (recommended) or the .NET CLI

### Installation

```bash
# Clone the repository
git clone https://github.com/SinqobileYende/Baobab-Ridge-Wildlife-Rehabilitation-Records-System.git

# Navigate into the project directory
cd Baobab-Ridge-Wildlife-Rehabilitation-Records-System

# Restore dependencies
dotnet restore
```

## Usage

### Running the Application

```bash
# Run via the .NET CLI
dotnet run
```

Or open the solution in Visual Studio and press **F5**.

### Adding an Animal

1. Enter the animal details in the **Animal Details** panel.
2. The ID must follow the format `WR-` followed by exactly 4 digits (e.g., `WR-0009`).
3. Name and species must be 1–30 characters and must not contain the `|` character.
4. Age and recovery score must be whole numbers between 0 and 100.
5. Click **Add**. The status and housing unit are calculated automatically and shown in a confirmation dialog.

### Editing an Animal

1. Click a row in the **Animals in Care** grid.
2. The details load into the form and the ID field is locked.
3. Make your changes and click **Save Changes**. Status and housing unit are recalculated.
4. Click **Clear** to return to Add mode.

### Deleting an Animal

1. Select a row in the grid.
2. Click **Delete Selected** and confirm.

## Project Structure

```text
BaobabRidgeRecords/
├── Program.cs                  # Application entry point
├── MainForm.cs                 # Main UI logic (add/update/delete/load)
├── MainForm.Designer.cs        # Designer-generated UI layout
├── Animal.cs                   # Animal model
├── AnimalClassifier.cs         # Score → status/housing classification
├── AnimalValidator.cs          # Input validation rules
├── AnimalFileHandler.cs        # File read/write operations
├── animals.txt                 # Data file (pipe-delimited)
└── BaobabRidgeRecords.csproj   # Project file
```

## Data Storage

Records are stored in `animals.txt` using a pipe-delimited format:

```text
Id | Name | Species | Age | Score | Status | HousingUnit
```

**Example:**

```text
WR-0001 | Liam | African Penguin | 4 | 85 | Release-Ready | Pre-Release Camp
WR-0003 | Nthato | Cape Vulture | 7 | 15 | Critical | Intensive Care Unit
```

The file is copied to the output directory on build (`PreserveNewest`) and is read/written at `Application.StartupPath`.

## Classification Rules

The recovery score determines the animal's status and housing unit:

| Score Range | Status        | Housing Unit         |
|-------------|---------------|----------------------|
| 0 – 19      | Critical      | Intensive Care Unit  |
| 20 – 39     | Serious       | High-Dependency Ward |
| 40 – 59     | Stable        | Recovery Ward        |
| 60 – 79     | Recovering    | Outdoor Enclosure    |
| 80 – 100    | Release-Ready | Pre-Release Camp     |

## Validation Rules

| Field          | Rule                                                                   |
|----------------|------------------------------------------------------------------------|
| Animal ID      | Must match `WR-` + exactly 4 digits (e.g., `WR-0007`); must be unique  |
| Name           | 1–30 characters; must not contain `\|`                                 |
| Species        | 1–30 characters; must not contain `\|`                                 |
| Age            | Whole number between 0 and 100                                         |
| Recovery Score | Whole number between 0 and 100                                         |

## Team Members

| Name            | Student Number   | Role / Contribution   | GitHub                                         |
|-----------------|------------------|-----------------------|------------------------------------------------|
| Reitumetse Mdlapo     | 605271 | Add Animal & validation; form layout & search |
| Nthato Mngadi-Molobela    | 577652 | View Animals & file loading                   | 
| Sinqobile Yende | 605083 | Update & Delete; README                       | 
| Liam Venter      | 603434 | Summary Report                                | 
## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is intended for educational purposes as part of the PRG282 module. Please contact the author regarding reuse.

## Contact

Sinqobile Yende — [GitHub](https://github.com/SinqobileYende)

Project Link: [https://github.com/SinqobileYende/Baobab-Ridge-Wildlife-Rehabilitation-Records-System](https://github.com/SinqobileYende/Baobab-Ridge-Wildlife-Rehabilitation-Records-System)
