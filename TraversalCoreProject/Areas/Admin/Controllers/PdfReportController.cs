using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PDFReports/" + "pdf1.pdf");

            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            Paragraph paragraph = new Paragraph("Traversal Reservation PDF Report");

            document.Add(paragraph);

            document.Close();

            return File("/PDFReports/pdf1.pdf", "application/pdf", "pdf1.pdf");
        }

        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PDFReports/" + "PdfTable.pdf");

            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            //Claim Arial font.   
            string Arial_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.ttf");

            //Create an instance for BaseFont.
            BaseFont baseFont = BaseFont.CreateFont(Arial_TFF, BaseFont.IDENTITY_H, true);

            //Create an instance for font.
            Font font = new Font(baseFont, 12, Font.NORMAL);

            document.Open();

            PdfPTable pdfPTable = new PdfPTable(3);

            pdfPTable.AddCell(new Phrase("Misafir Adı", font));
            pdfPTable.AddCell(new Phrase("Misafir Soyadı", font));
            pdfPTable.AddCell(new Phrase("Misafir TC", font));

            pdfPTable.AddCell(new Phrase("Tuğcan", font));
            pdfPTable.AddCell(new Phrase("Aygül", font));
            pdfPTable.AddCell(new Phrase("11111111110", font));

            document.Add(pdfPTable);

            document.Close();

            return File("/PDFReports/PdfTable.pdf", "application/pdf", "PdfTable.pdf");
        }
    }
}
