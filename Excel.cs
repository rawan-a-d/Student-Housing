using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.ConditionalFormatting;

namespace Project
{
    public class Excel
    {
        // Export Excel
        public static void ExportToExcel(Message[] messages)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            var workbook = new ExcelFile();
            var worksheet = workbook.Worksheets.Add("Exported from messages");

            // Create headers
            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Date Added", typeof(DateTime));
            dataTable.Columns.Add("Type", typeof(string));
            dataTable.Columns.Add("Message", typeof(string));
            dataTable.Columns.Add("Reply", typeof(string));

            // Create rows
            foreach (var message in messages)
            {
                // If message is a question
                if (message.Subject == MessageSubject.Question)
                {
                    dataTable.Rows.Add(message.Id, message.DateCreated, "Question", message.MessageText, message.Reply);

                }
                // If message is a complaint
                else
                {
                    dataTable.Rows.Add(message.Id, message.DateCreated, "Complaint", message.MessageText, message.Reply);
                }
            }

            // Insert DataTable to an Excel worksheet.
            worksheet.InsertDataTable(dataTable,
                new InsertDataTableOptions()
                {
                    ColumnHeaders = true,
                    StartRow = 0
                });

            /* Style */
            // Auto fit columns, add color and background color
            int columnCount = worksheet.CalculateMaxUsedColumns();
            for (int i = 0; i < columnCount; i++)
            {
                worksheet.Columns[i].AutoFit(1, worksheet.Rows[0], worksheet.Rows[worksheet.Rows.Count - 1]);
                worksheet.Rows[0].Cells[i].Style.FillPattern.SetGradient(GradientShadingStyle.HorizontalHigh, SpreadsheetColor.FromName(ColorName.Accent5Darker25Pct), SpreadsheetColor.FromName(ColorName.Accent5Darker50Pct));
                worksheet.Rows[0].Cells[i].Style.Font.Color = SpreadsheetColor.FromName(ColorName.White);
            }

            // Apply borders to specific cells
            worksheet.ConditionalFormatting.AddContainText("C2:C" + (messages.Length + 1), ContainTextOperator.Contains, "Complaint").
                Style.Borders.SetBorders(MultipleBorders.Outside, SpreadsheetColor.FromName(ColorName.Red), LineStyle.Double);
            worksheet.ConditionalFormatting.AddContainText("C2:C" + (messages.Length + 1), ContainTextOperator.Contains, "Question").
                Style.Borders.SetBorders(MultipleBorders.Outside, SpreadsheetColor.FromName(ColorName.Green), LineStyle.Thick);

            // Font weight
            worksheet.Rows[0].Style.Font.Weight = ExcelFont.BoldWeight;
            // Wrap text
            worksheet.Cells.Style.WrapText = true;
            // Header horizontal alignment
            worksheet.Rows[0].Style.HorizontalAlignment = HorizontalAlignmentStyle.Center;
            workbook.Save("messages.xlsx");
        }
    }
}
