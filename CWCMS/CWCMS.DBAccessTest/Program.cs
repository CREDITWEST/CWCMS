using CWCMS.Application.BLServices;
using CWCMS.Infrastructure.Repositories;
using CWCMS.Core.Models;
using CWCMS.Application.DocumentLogic.DocumentReferencingRepositories.AdditionReferencing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CWCMS.DBAccessTest
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Document _testDoc = new Document();

            //Tests

            AdditionReferencingMainTypeLogic _referencing = new AdditionReferencingMainTypeLogic();

            DocumentServices _docService = new DocumentServices();

            object[] arrayObj = new object[2];

            FileSequenceRepository repoAct = new FileSequenceRepository();

            IEnumerable<Document> doclist;

            //_testDoc.DocumentID = Guid.NewGuid();
            _testDoc.Title = "Test Doc";
            _testDoc.Content = "I am testing fetaure";
            _testDoc.FilePath = "github.com";
            //_testDoc.PublisherID = Guid.NewGuid();
            //_testDoc.PublishDate = DateTime.Now;
            //_testDoc.SystemUpdateDate = DateTime.Now;
           //_testDoc.ReferenceNumber = _referencing.GenerateReferenceForAddingMainType(2, Guid.NewGuid());
           //_testDoc.isSigned = false;
            _testDoc.DocumentTypeID = 3;

            _docService.UploadDocument(_testDoc);


            doclist = _docService.CategorisedRetrievingActiveDocuments(1);

            Console.WriteLine(repoAct.LastSequenceNumberOfSpecificType("G") + " Geliyor");
 
            if (IsNullOrEmpty(doclist))
            {
                Console.WriteLine("Empty");
            }


            foreach (Document item in doclist)
            {
                Console.WriteLine();
                Console.WriteLine("Guid is : " + item.DocumentID + " Reference Code is : " + item.ReferenceNumber);
            }

            Console.Read();









        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable == null || !enumerable.Any();
        }
    }
}