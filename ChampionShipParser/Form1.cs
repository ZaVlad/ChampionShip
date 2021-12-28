using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Word = Microsoft.Office.Interop.Word;
using Task = System.Threading.Tasks.Task;

namespace ChampionShipParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private  async void ParseFile_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                var filePaths = Directory
                    .GetFiles(fbd.SelectedPath,".")
                    .Where(file =>file.ToLower().EndsWith("doc")|| file.ToLower().EndsWith("docx"))
                    .ToList();
                foreach (var item in filePaths)
                {
                    using (var doc = WordprocessingDocument.Open(item, true))
                    {
                        DataTable dt = new DataTable();
                        int rowCount = 0;

                        Table table = doc.MainDocumentPart.Document.Body.Elements<Table>().First();

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
                                    if(i!=2){
                                        dt.Rows[dt.Rows.Count - 1][i] = cell.InnerText;
                                    i++;
                                    }
                                    else
                                    {
                                        i = 0;
                                    }
                                }
                            }
                        }
                        TeamDataGread.DataSource = dt;
                    }
                }

            }
        }

    }
}
