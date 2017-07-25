using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CWCMS.Core.Models;
using CWCMS.Application.DocumentLogic.DocumentUploadingRepositories;


namespace CWCMS.DBAccessTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Document _testDoc = new Document();

            DocumentUploadRepository _documentUpload = new DocumentUploadRepository();

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


        }
    }
}
