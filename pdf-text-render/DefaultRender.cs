using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace HelloJianshu.PdfRender
{
    public class DefaultRender
    {
        public static string GetResultantText(string fileName)
        {
            using (var pdfDoc = new PdfDocument(new PdfReader(fileName)))
            {
                var strategy = new LocationTextExtractionStrategy();
                var parser = new PdfCanvasProcessor(strategy);
                parser.ProcessPageContent(pdfDoc.GetFirstPage());
                var text = strategy.GetResultantText();
                return text;
            }
        }
    }
}
