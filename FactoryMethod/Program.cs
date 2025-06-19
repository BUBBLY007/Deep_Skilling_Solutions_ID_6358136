// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program
{
    static void Main()
    {
        DocumentFactory wordFactory = new WordDocumentFactory();
        DocumentFactory pdfFactory = new PdfDocumentFactory();
        DocumentFactory excelFactory = new ExcelDocumentFactory();
        
        IDocument wordDoc = wordFactory.CreateDocument();
        IDocument pdfDoc = pdfFactory.CreateDocument();
        IDocument excelDoc = excelFactory.CreateDocument();
        
        wordDoc.Open();
        pdfDoc.Save();
        excelDoc.Open();
    }
}
