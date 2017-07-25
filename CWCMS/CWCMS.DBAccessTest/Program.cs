using CWCMS.Application.DocumentLogic.DocumentRetrievingRepositories;
using CWCMS.Application.DocumentLogic.DocumentUploadingRepositories;
using CWCMS.Core.Models;

namespace CWCMS.DBAccessTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Document _testDoc = new Document();

            DocumentUploadRepository _documentUpload = new DocumentUploadRepository();
            BulkDocumentRetrievingRepository _bulkRetrieve = new BulkDocumentRetrievingRepository();

            /*
            _testDoc.DocumentID = Guid.NewGuid();
            _testDoc.Title = "Test Doc";
            _testDoc.Content = "I am testing fetaure";
            _testDoc.FilePath = "github.com";
            _testDoc.PublisherID = Guid.NewGuid();
            _testDoc.PublishDate = DateTime.Now;
            _testDoc.SystemUpdateDate = DateTime.Now;
            _testDoc.ReferenceNumber = "StStSt";
            _testDoc.isSigned = false;
            _testDoc.DocumentTypeID = 1;

            _documentUpload.UploadToServerDocument(_testDoc);

            IEnumerable<Document> docList = _bulkRetrieve.GetWholeActiveList();
            Console.WriteLine();

            foreach (Document item in docList)
            {
                Console.WriteLine();
                Console.WriteLine("Guid is : " + item.DocumentID + " Title is " + item.Title + " Content is " + item.Content + "date is " + item.PublishDate);
            }

            Console.Read();
            */
        }
    }
}