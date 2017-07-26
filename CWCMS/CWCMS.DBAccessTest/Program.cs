using CWCMS.Application.BLServices;
using CWCMS.Infrastructure.Repositories;
using CWCMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CWCMS.DBAccessTest
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            //Document _testDoc = new Document();
            //DocumentRepository _docRepo = new DocumentRepository();
            //DocumentUploadRepository _documentUpload = new DocumentUploadRepository();
            //BulkDocumentRetrievingRepository _bulkRetrieve = new BulkDocumentRetrievingRepository();
            //DateTime testDT;

            //_testDoc.DocumentID = Guid.NewGuid();
            //_testDoc.Title = "Test Doc";
            //_testDoc.Content = "I am testing fetaure";
            //_testDoc.FilePath = "github.com";
            //_testDoc.PublisherID = Guid.NewGuid();
            //_testDoc.PublishDate = DateTime.Now;
            //_testDoc.SystemUpdateDate = DateTime.Now;
            //_testDoc.ReferenceNumber = "StStSt";
            //_testDoc.isSigned = false;
            //_testDoc.DocumentTypeID = 1;

            //_documentUpload.UploadToServerDocument(_testDoc);

            //testDT = _testDoc.PublishDate;

            //IEnumerable<Document> docList = _docRepo.ListDocumentByPublishDate(testDT);



            //if (IsNullOrEmpty(docList))
            //{
            //    Console.WriteLine("Empty");
            //}


            

            //foreach (Document item in docList)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Guid is : " + item.DocumentID);
            //}

            //Console.Read();
            
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable == null || !enumerable.Any();
        }
    }
}