




















// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `CWCMSConnection`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=192.168.100.101;Initial Catalog=CreditwestDocSystemDB;Persist Security Info=True;User ID=cwsoftgenious;Password=c36en105!`
//     Schema:                 ``
//     Include Views:          `False`



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace CWCMSConnection
{

	public partial class CWCMSConnectionDB : Database
	{
		public CWCMSConnectionDB() 
			: base("CWCMSConnection")
		{
			CommonConstruct();
		}

		public CWCMSConnectionDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			CWCMSConnectionDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static CWCMSConnectionDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new CWCMSConnectionDB();
        }

		[ThreadStatic] static CWCMSConnectionDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static CWCMSConnectionDB repo { get { return CWCMSConnectionDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }

		}

	}
	



    

	[TableName("dbo.Active")]



	[PrimaryKey("ActiveID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class Active : CWCMSConnectionDB.Record<Active>  
    {



		[Column] public int ActiveID { get; set; }





		[Column] public Guid DocumentID { get; set; }



	}

    

	[TableName("dbo.Cancelled")]



	[PrimaryKey("CancelledID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class Cancelled : CWCMSConnectionDB.Record<Cancelled>  
    {



		[Column] public int CancelledID { get; set; }





		[Column] public Guid DocumentID { get; set; }





		[Column] public string Feedback { get; set; }



	}

    

	[TableName("dbo.CompletedFeedback")]



	[PrimaryKey("CompFeedID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class CompletedFeedback : CWCMSConnectionDB.Record<CompletedFeedback>  
    {



		[Column] public int CompFeedID { get; set; }





		[Column] public int FeedbackID { get; set; }



	}

    

	[TableName("dbo.ConfirmedSignatures")]



	[PrimaryKey("ConfirmedSignatureID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class ConfirmedSignature : CWCMSConnectionDB.Record<ConfirmedSignature>  
    {



		[Column] public int ConfirmedSignatureID { get; set; }





		[Column] public Guid DocumentID { get; set; }





		[Column] public Guid UserID { get; set; }





		[Column] public DateTime SignDate { get; set; }



	}

    

	[TableName("dbo.Deleted")]



	[PrimaryKey("DeletedID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class Deleted : CWCMSConnectionDB.Record<Deleted>  
    {



		[Column] public int DeletedID { get; set; }





		[Column] public Guid DocumentID { get; set; }



	}

    

	[TableName("dbo.Dependency")]



	[PrimaryKey("DependID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class Dependency : CWCMSConnectionDB.Record<Dependency>  
    {



		[Column] public int DependID { get; set; }





		[Column] public Guid DocumentID1 { get; set; }





		[Column] public Guid DocumentID2 { get; set; }



	}

    

	[TableName("dbo.Document")]



	[PrimaryKey("DocumentID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class Document : CWCMSConnectionDB.Record<Document>  
    {



		[Column] public Guid DocumentID { get; set; }





		[Column] public string Title { get; set; }





		[Column] public string Content { get; set; }





		[Column] public string FilePath { get; set; }





		[Column] public Guid PublisherID { get; set; }





		[Column] public DateTime PublishDate { get; set; }





		[Column] public DateTime SystemUpdateDate { get; set; }





		[Column] public string ReferenceNumber { get; set; }





		[Column] public bool isSigned { get; set; }



	}

    

	[TableName("dbo.EndDate")]



	[PrimaryKey("EndDateID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class EndDate : CWCMSConnectionDB.Record<EndDate>  
    {



		[Column] public int EndDateID { get; set; }





		[Column] public Guid DocumentID { get; set; }





		[Column] public DateTime? ExpirationDate { get; set; }



	}

    

	[TableName("dbo.Feedback")]



	[PrimaryKey("FeedbackID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class Feedback : CWCMSConnectionDB.Record<Feedback>  
    {



		[Column] public int FeedbackID { get; set; }





		[Column] public Guid UserID { get; set; }





		[Column] public Guid DocumentID { get; set; }





		[Column] public string Comment { get; set; }





		[Column] public DateTime? SendDate { get; set; }





		[Column] public DateTime? EndDate { get; set; }





		[Column] public DateTime? ResponseDate { get; set; }



	}

    

	[TableName("dbo.FileRevisions")]



	[PrimaryKey("FileReID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class FileRevision : CWCMSConnectionDB.Record<FileRevision>  
    {



		[Column] public int FileReID { get; set; }





		[Column] public string FileType { get; set; }





		[Column] public int SequenceNumber { get; set; }





		[Column] public int? RevisionNumber { get; set; }



	}

    

	[TableName("dbo.FileSequence")]



	[PrimaryKey("FileSeqID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class FileSequence : CWCMSConnectionDB.Record<FileSequence>  
    {



		[Column] public int FileSeqID { get; set; }





		[Column] public string FileType { get; set; }





		[Column] public int SequenceNumber { get; set; }



	}

    

	[TableName("dbo.IncompletedFeedback")]



	[PrimaryKey("IncFeedID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class IncompletedFeedback : CWCMSConnectionDB.Record<IncompletedFeedback>  
    {



		[Column] public int IncFeedID { get; set; }





		[Column] public int FeedbackID { get; set; }



	}

    

	[TableName("dbo.LinkRolePermission")]



	[PrimaryKey("LinkRolePermissonID")]




	[ExplicitColumns]

    public partial class LinkRolePermission : CWCMSConnectionDB.Record<LinkRolePermission>  
    {



		[Column] public int LinkRolePermissonID { get; set; }





		[Column] public int RoleID { get; set; }





		[Column] public int PermissionID { get; set; }



	}

    

	[TableName("dbo.LinkUserFile")]



	[PrimaryKey("LinkUserFileID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class LinkUserFile : CWCMSConnectionDB.Record<LinkUserFile>  
    {



		[Column] public int LinkUserFileID { get; set; }





		[Column] public Guid UserID { get; set; }





		[Column] public Guid DocumentID { get; set; }



	}

    

	[TableName("dbo.LinkUserRole")]



	[PrimaryKey("LurID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class LinkUserRole : CWCMSConnectionDB.Record<LinkUserRole>  
    {



		[Column] public int LurID { get; set; }





		[Column] public Guid UserID { get; set; }





		[Column] public int RoleID { get; set; }



	}

    

	[TableName("dbo.Permission")]



	[PrimaryKey("PermissionID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class Permission : CWCMSConnectionDB.Record<Permission>  
    {



		[Column] public int PermissionID { get; set; }





		[Column] public string PermissionName { get; set; }



	}

    

	[TableName("dbo.PostCheck")]



	[PrimaryKey("PostID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class PostCheck : CWCMSConnectionDB.Record<PostCheck>  
    {



		[Column] public int PostID { get; set; }





		[Column] public Guid DocumentID { get; set; }



	}

    

	[TableName("dbo.PreCheck")]



	[PrimaryKey("PrecheckID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class PreCheck : CWCMSConnectionDB.Record<PreCheck>  
    {



		[Column] public int PrecheckID { get; set; }





		[Column] public Guid DocumentID { get; set; }





		[Column] public int SignatureCount { get; set; }



	}

    

	[TableName("dbo.QueuedSignatures")]



	[PrimaryKey("QueuedSignatureID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class QueuedSignature : CWCMSConnectionDB.Record<QueuedSignature>  
    {



		[Column] public int QueuedSignatureID { get; set; }





		[Column] public Guid DocumentID { get; set; }





		[Column] public Guid UserID { get; set; }





		[Column] public int? LineNumber { get; set; }



	}

    

	[TableName("dbo.Revised")]



	[PrimaryKey("RevisedID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class Revised : CWCMSConnectionDB.Record<Revised>  
    {



		[Column] public int RevisedID { get; set; }





		[Column] public Guid DocumentID { get; set; }



	}

    

	[TableName("dbo.Role")]



	[PrimaryKey("RoleID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class Role : CWCMSConnectionDB.Record<Role>  
    {



		[Column] public int RoleID { get; set; }





		[Column] public string RoleName { get; set; }



	}

    

	[TableName("dbo.SubFileRevisions")]



	[PrimaryKey("SubFileRevID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class SubFileRevision : CWCMSConnectionDB.Record<SubFileRevision>  
    {



		[Column] public int SubFileRevID { get; set; }





		[Column] public string FileType { get; set; }





		[Column] public int SequenceNumber { get; set; }





		[Column] public string SubFileType { get; set; }





		[Column] public int SubFileSequence { get; set; }





		[Column] public int? RevisionNumber { get; set; }



	}

    

	[TableName("dbo.SubFileSequence")]



	[PrimaryKey("SubFileSeqID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class SubFileSequence : CWCMSConnectionDB.Record<SubFileSequence>  
    {



		[Column] public int SubFileSeqID { get; set; }





		[Column] public string FileType { get; set; }





		[Column] public int SequenceNumber { get; set; }





		[Column] public string SubFileType { get; set; }





		[Column] public int SubFileSequenceNumber { get; set; }



	}

    

	[TableName("dbo.sysdiagrams")]



	[PrimaryKey("diagram_id")]




	[ExplicitColumns]

    public partial class sysdiagram : CWCMSConnectionDB.Record<sysdiagram>  
    {



		[Column] public string name { get; set; }





		[Column] public int principal_id { get; set; }





		[Column] public int diagram_id { get; set; }





		[Column] public int? version { get; set; }





		[Column] public byte[] definition { get; set; }



	}

    

	[TableName("dbo.ValidDate")]



	[PrimaryKey("ValidDateID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class ValidDate : CWCMSConnectionDB.Record<ValidDate>  
    {



		[Column] public int ValidDateID { get; set; }





		[Column] public Guid DocumentID { get; set; }





		[Column] public DateTime ValidationDate { get; set; }



	}

    

	[TableName("dbo.WaitingForFeedback")]



	[PrimaryKey("WFFID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class WaitingForFeedback : CWCMSConnectionDB.Record<WaitingForFeedback>  
    {



		[Column] public int WFFID { get; set; }





		[Column] public Guid DocumentID { get; set; }



	}

    

	[TableName("dbo.WaitingSignatures")]



	[PrimaryKey("WaitingSignatureID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class WaitingSignature : CWCMSConnectionDB.Record<WaitingSignature>  
    {



		[Column] public int WaitingSignatureID { get; set; }





		[Column] public Guid DocumentID { get; set; }





		[Column] public Guid UserID { get; set; }





		[Column] public int? LineNumber { get; set; }



	}

    

	[TableName("dbo.WaitSignature")]



	[PrimaryKey("WaitSignID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class WaitSignature : CWCMSConnectionDB.Record<WaitSignature>  
    {



		[Column] public int WaitSignID { get; set; }





		[Column] public Guid DocumentID { get; set; }





		[Column] public int? SignatureCount { get; set; }



	}


}
