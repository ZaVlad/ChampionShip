using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Entities.Models;
using Parser.Interfaces;
using SautinSoft.Document;

namespace Parser
{
    public partial class Form1 : Form
    {
        List<Person> _teams = new List<Person>();
        List<Person> _members = new List<Person>();

        private readonly IDisciplineFormService _disciplineFormService;
        private readonly IOkatoFormService _okatoFormService;
        private readonly IPersonFormService _personFormService;
        public Form1(IDisciplineFormService disciplineFormService, IOkatoFormService okatoFormService, IPersonFormService personFormService)
        {
            InitializeComponent();
            _okatoFormService = okatoFormService ?? throw new ArgumentNullException(nameof(okatoFormService)); ;
            _disciplineFormService = disciplineFormService ?? throw new ArgumentNullException(nameof(disciplineFormService));
            _personFormService = personFormService ?? throw new ArgumentNullException(nameof(personFormService));
        }
        private void ParserButton_Click(object sender, EventArgs e)
        {

            int teamCounter = 1;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                var filePaths = Directory
                    .GetFiles(fbd.SelectedPath, ".")
                    .Where(file => file.ToLower().EndsWith("doc") || file.ToLower().EndsWith("docx"))
                    .ToList();

                var paths = ConvertDocToDocx(filePaths);

                foreach (var filePath in paths)
                {
                    _teams.Add(GetTeam(filePath, teamCounter));
                    _members.AddRange(GetMember(filePath, teamCounter));
                    teamCounter++;
                }

                TeamsGread.DataSource = _teams;
            }
        }

        private List<string> ConvertDocToDocx(IEnumerable<string> docPaths)
        {
            List<string> paths = new List<string>();
            foreach (var path in docPaths)
            {
                string truePath = path;
                if (path.EndsWith(".doc"))
                {
                    DocumentCore dc = DocumentCore.Load(path);

                    dc.Save(path.Replace(".doc", ".docx"));
                    File.Delete(path);
                    truePath = truePath.Replace(".doc", ".docx");
                }

                paths.Add(truePath);
            }
            return paths;
        }

        private List<Person> GetMember(string path, int teamNumber)
        {
            using (var doc = WordprocessingDocument.Open(path, true))
            {
                var table = doc.MainDocumentPart.Document.Body.Elements<Table>().Last();
                DataTable dt = new DataTable();
                FillInDataTable(table, dt);
                var members = CreateMembers(dt, teamNumber);
                return members;
            }
        }

        private Person GetTeam(string path, int teamNumber)
        {
            using (var doc = WordprocessingDocument.Open(path, true))
            {
                var table = doc.MainDocumentPart.Document.Body.Elements<Table>().First();
                DataTable dt = new DataTable();
                FillInDataTable(table, dt);
                var team = CreateTeam(dt, teamNumber);
                return team;
            }
        }

        private List<Person> CreateMembers(DataTable dt, int teamNumber)
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (string.IsNullOrEmpty(dt.Rows[i][1].ToString()) && string.IsNullOrEmpty(dt.Rows[i][2].ToString()) && string.IsNullOrEmpty(dt.Rows[i][3].ToString()))
                {
                    break;
                }
                var name = dt.Rows[i][1].ToString().Split(" ");

                var middleName = dt.Rows[i][2].ToString();

                DateTime birthDate = DateTime.Parse(dt.Rows[i][3].ToString());

                persons.Add(new Person() { Name = name[0], LastName = name[1], MiddleName = middleName, BirthDate = birthDate, Team = teamNumber });
            }
            return persons;
        }

        private Person CreateTeam(DataTable dt, int teamNumber)
        {
            var disciplineName = _disciplineFormService.Get(dt.Columns[1].ToString());

            var GroupName = dt.Rows[0][1].ToString()
                .Replace("Рус", "")
                .Replace("рус:", "")
                .Replace("Рус:","").Trim();

            var federalDistrict = _okatoFormService.GetByAbbreviatedName(dt.Rows[1][1].ToString());
            if (federalDistrict is null)
            {
                federalDistrict = _okatoFormService.GetByName(dt.Rows[1][1].ToString());
            }
            var city = dt.Rows[2][1].ToString()
                .Replace("Город", "")
                .Replace("Гор.", "")
                .Replace("г.", "").Trim();

            var trainer = dt.Rows[5][1].ToString().Split(" ");
            return new Person() { _org = disciplineName?.Code, LastName = GroupName, IssuedPlace = federalDistrict?.Id, IssuedBy = city,
                Trainer = $"{trainer[0]} {trainer[1]} {trainer[2]}", Team = teamNumber };
        }

        private void FillInDataTable(Table table, DataTable dt)
        {
            int rowCount = 0;
            IEnumerable<TableRow> rows = table.Elements<TableRow>();
            foreach (TableRow row in rows)
            {
                if (rowCount == 0)
                {
                    foreach (TableCell cell in row.Descendants<TableCell>())
                    {
                        dt.Columns.Add(cell.InnerText);
                    }
                    rowCount += 1;
                }
                else
                {
                    dt.Rows.Add();
                    int i = 0;
                    foreach (TableCell cell in row.Descendants<TableCell>())
                    {
                        if (i != dt.Columns.Count)
                        {
                            dt.Rows[dt.Rows.Count - 1][i] = cell.InnerText;
                            i++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MembersGread_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedMember = MembersGread.SelectedRows[0].DataBoundItem as Person;

                textBoxFirstName.Text = selectedMember.Name;
                textBoxLastName.Text = selectedMember.LastName;
                textBoxMiddleName.Text = selectedMember.MiddleName;
                textBoxBirthDay.Text = selectedMember.BirthDate.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured: " + ex.Message + " - " + ex.Source);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFirstName.Text)
                && !string.IsNullOrEmpty(textBoxLastName.Text)
                && !string.IsNullOrEmpty(textBoxMiddleName.Text))
            {
                var selectedMember = MembersGread.SelectedRows[0].DataBoundItem as Person;
                var member = _members.FirstOrDefault(s => s.MiddleName == selectedMember.MiddleName
                                             && s.Name == selectedMember.Name
                                             && s.LastName == selectedMember.LastName);

                member.MiddleName = textBoxMiddleName.Text;
                member.LastName= textBoxLastName.Text;
                member.Name = textBoxFirstName.Text;
                member.BirthDate= DateTime.Parse(textBoxBirthDay.Text);
                MembersGread.Refresh();
            }

        }

        private void TeamsGread_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try{
            var selectedTeam = TeamsGread.SelectedRows[0].DataBoundItem as Person;
            MembersGread.DataSource = _members.Where(s => s.Team == selectedTeam.Team).ToList();
            MembersGread.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured: " + ex.Message + " - " + ex.Source);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            foreach (var team in _teams)
            {
                var createdPersonInfo = _personFormService.Create(team).Split(" ");

                int id = int.Parse(createdPersonInfo[0]);

                int teamNumber = int.Parse(createdPersonInfo[1]);

                var memberByTeam = _members.Where(s => s.Team == teamNumber).ToList();

                memberByTeam.ForEach(s=>s.Team = id);

                foreach (var member in memberByTeam)
                {
                    _personFormService.CreateMember(member);
                }

            }

            MessageBox.Show("All teams and players have added successfully");

        }
    }
}
