using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Route("Admin/[controller]/[action]")]

    public class ExcelController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public List<DestinationViewModel> DestinationList()
        {
            List<DestinationViewModel> destinationViewModels = new List<DestinationViewModel>();

            using (var context = new Context())
            {
                destinationViewModels = context.Destinations.Select(x => new DestinationViewModel
                {
                    City = x.DestinationCity,
                    DayNight = x.DestinationDayNight,
                    Price = x.DestinationPrice,
                    Capacity = x.DestinationCapacity
                }).ToList();
            }

            return destinationViewModels;
        }

        public IActionResult StaticExcelReport()
        {
            return File(_excelService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniExcel.xlsx");
        }

        public IActionResult DestinationExcelReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Tur Listesi");

                //Appearance for the headers.
                var headerRow = workSheet.Row(1);
                headerRow.Style.Font.Bold = true;
                headerRow.Style.Font.FontColor = XLColor.Red;

                workSheet.Cell(1, 1).Value = "Şehir";
                workSheet.Cell(1, 2).Value = "Konaklama Süresi";
                workSheet.Cell(1, 3).Value = "Fiyat";
                workSheet.Cell(1, 4).Value = "Kapasite";

                var cellRange = workSheet.Range(workSheet.Cell(1, 1), workSheet.Cell(1, 4));
                cellRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                cellRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thick;

                cellRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                cellRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                workSheet.Row(1).Height = 25;

                //Start the data row.
                int rowCount = 2;

                foreach (var item in DestinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.City;
                    workSheet.Cell(rowCount, 2).Value = item.DayNight;
                    workSheet.Cell(rowCount, 3).Value = "$" + item.Price;
                    workSheet.Cell(rowCount, 4).Value = item.Capacity + " kişi";

                    //Adjust cells with borders.
                    cellRange = workSheet.Range(workSheet.Cell(rowCount, 1), workSheet.Cell(rowCount, 4));
                    cellRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                    cellRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thick;

                    //Rearrange the texts.
                    cellRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    cellRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                    //Adjust columns width.
                    workSheet.Column(1).AdjustToContents();
                    workSheet.Column(2).AdjustToContents();
                    workSheet.Column(3).AdjustToContents();
                    workSheet.Column(4).AdjustToContents();

                    //Adjust rows height.
                    workSheet.Row(rowCount).Height = 25;

                    rowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);

                    var content = stream.ToArray();

                    Guid guid = Guid.NewGuid();

                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"Liste-{guid}.xlsx");
                }
            }
        }
    }
}
