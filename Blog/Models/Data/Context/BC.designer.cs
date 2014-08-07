﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BC.Data.Context
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DataSource")]
	public partial class BCDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBC_Category(BC.Models.BC_Category instance);
    partial void UpdateBC_Category(BC.Models.BC_Category instance);
    partial void DeleteBC_Category(BC.Models.BC_Category instance);
    partial void InsertBC_Tag(BC.Models.BC_Tag instance);
    partial void UpdateBC_Tag(BC.Models.BC_Tag instance);
    partial void DeleteBC_Tag(BC.Models.BC_Tag instance);
    partial void InsertBC_Page(BC.Models.BC_Page instance);
    partial void UpdateBC_Page(BC.Models.BC_Page instance);
    partial void DeleteBC_Page(BC.Models.BC_Page instance);
    partial void InsertBC_Post(BC.Models.BC_Post instance);
    partial void UpdateBC_Post(BC.Models.BC_Post instance);
    partial void DeleteBC_Post(BC.Models.BC_Post instance);
    partial void InsertBC_Comment(BC.Models.BC_Comment instance);
    partial void UpdateBC_Comment(BC.Models.BC_Comment instance);
    partial void DeleteBC_Comment(BC.Models.BC_Comment instance);
    partial void InsertBC_User(BC.Models.BC_User instance);
    partial void UpdateBC_User(BC.Models.BC_User instance);
    partial void DeleteBC_User(BC.Models.BC_User instance);
    #endregion
		
		public BCDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DataSourceConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BCDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BCDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BCDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BCDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BC.Models.BC_Category> BC_Categories
		{
			get
			{
				return this.GetTable<BC.Models.BC_Category>();
			}
		}
		
		public System.Data.Linq.Table<BC.Models.BC_Tag> BC_Tags
		{
			get
			{
				return this.GetTable<BC.Models.BC_Tag>();
			}
		}
		
		public System.Data.Linq.Table<BC.Models.BC_Page> BC_Pages
		{
			get
			{
				return this.GetTable<BC.Models.BC_Page>();
			}
		}
		
		public System.Data.Linq.Table<BC.Models.BC_Post> BC_Posts
		{
			get
			{
				return this.GetTable<BC.Models.BC_Post>();
			}
		}
		
		public System.Data.Linq.Table<BC.Models.BC_Comment> BC_Comments
		{
			get
			{
				return this.GetTable<BC.Models.BC_Comment>();
			}
		}
		
		public System.Data.Linq.Table<BC.Models.BC_User> BC_Users
		{
			get
			{
				return this.GetTable<BC.Models.BC_User>();
			}
		}
	}
}
namespace BC.Models
{
	using System.Runtime.Serialization;
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BC_Category")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class BC_Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CategoryID;
		
		private string _Name;
		
		private string _Description;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCategoryIDChanging(int value);
    partial void OnCategoryIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public BC_Category()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(256) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)", UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void Initialize()
		{
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BC_Tag")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class BC_Tag : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TagID;
		
		private int _PostID;
		
		private string _Tag;
		
		private EntityRef<BC_Post> _Parent_Post;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTagIDChanging(int value);
    partial void OnTagIDChanged();
    partial void OnPostIDChanging(int value);
    partial void OnPostIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public BC_Tag()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TagID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int TagID
		{
			get
			{
				return this._TagID;
			}
			set
			{
				if ((this._TagID != value))
				{
					this.OnTagIDChanging(value);
					this.SendPropertyChanging();
					this._TagID = value;
					this.SendPropertyChanged("TagID");
					this.OnTagIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostID", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public int PostID
		{
			get
			{
				return this._PostID;
			}
			set
			{
				if ((this._PostID != value))
				{
					if (this._Parent_Post.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPostIDChanging(value);
					this.SendPropertyChanging();
					this._PostID = value;
					this.SendPropertyChanged("PostID");
					this.OnPostIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tag", DbType="NVarChar(64) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string Name
		{
			get
			{
				return this._Tag;
			}
			set
			{
				if ((this._Tag != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Tag = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BC_Post_BC_Tag", Storage="_Parent_Post", ThisKey="PostID", OtherKey="PostID", IsForeignKey=true)]
		internal BC_Post Parent_Post
		{
			get
			{
				return this._Parent_Post.Entity;
			}
			set
			{
				if ((this._Parent_Post.Entity != value))
				{
					this.SendPropertyChanging();
					this._Parent_Post.Entity = value;
					this.SendPropertyChanged("Parent_Post");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void Initialize()
		{
			this._Parent_Post = default(EntityRef<BC_Post>);
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BC_Page")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class BC_Page : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PageID;
		
		private string _Title;
		
		private string _Slug;
		
		private string _Body;
		
		private System.DateTime _Created;
		
		private System.DateTime _Modified;
		
		private bool _IsPublished;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPageIDChanging(int value);
    partial void OnPageIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnSlugChanging(string value);
    partial void OnSlugChanged();
    partial void OnBodyChanging(string value);
    partial void OnBodyChanged();
    partial void OnCreatedChanging(System.DateTime value);
    partial void OnCreatedChanged();
    partial void OnModifiedChanging(System.DateTime value);
    partial void OnModifiedChanged();
    partial void OnIsPublishedChanging(bool value);
    partial void OnIsPublishedChanged();
    #endregion
		
		public BC_Page()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PageID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int PageID
		{
			get
			{
				return this._PageID;
			}
			set
			{
				if ((this._PageID != value))
				{
					this.OnPageIDChanging(value);
					this.SendPropertyChanging();
					this._PageID = value;
					this.SendPropertyChanged("PageID");
					this.OnPageIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(256) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Slug", DbType="NVarChar(256) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string Slug
		{
			get
			{
				return this._Slug;
			}
			set
			{
				if ((this._Slug != value))
				{
					this.OnSlugChanging(value);
					this.SendPropertyChanging();
					this._Slug = value;
					this.SendPropertyChanged("Slug");
					this.OnSlugChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Body", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this.OnBodyChanging(value);
					this.SendPropertyChanging();
					this._Body = value;
					this.SendPropertyChanged("Body");
					this.OnBodyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Created", DbType="DateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public System.DateTime Created
		{
			get
			{
				return this._Created;
			}
			set
			{
				if ((this._Created != value))
				{
					this.OnCreatedChanging(value);
					this.SendPropertyChanging();
					this._Created = value;
					this.SendPropertyChanged("Created");
					this.OnCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modified", DbType="DateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6)]
		public System.DateTime Modified
		{
			get
			{
				return this._Modified;
			}
			set
			{
				if ((this._Modified != value))
				{
					this.OnModifiedChanging(value);
					this.SendPropertyChanging();
					this._Modified = value;
					this.SendPropertyChanged("Modified");
					this.OnModifiedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsPublished", DbType="Bit NOT NULL", UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=7)]
		public bool IsPublished
		{
			get
			{
				return this._IsPublished;
			}
			set
			{
				if ((this._IsPublished != value))
				{
					this.OnIsPublishedChanging(value);
					this.SendPropertyChanging();
					this._IsPublished = value;
					this.SendPropertyChanged("IsPublished");
					this.OnIsPublishedChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void Initialize()
		{
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BC_Post")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class BC_Post : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PostID;
		
		private int _CategoryID;
		
		private string _Title;
		
		private string _Slug;
		
		private string _Body;
		
		private bool _IsCommentsVisible;
		
		private bool _IsCommentsOpen;
		
		private System.DateTime _Created;
		
		private System.DateTime _Modified;
		
		private bool _IsPublished;
		
		private System.DateTime _PublishDate;
		
		private EntityRef<BC_Category> _Parent_Category;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPostIDChanging(int value);
    partial void OnPostIDChanged();
    partial void OnCategoryIDChanging(int value);
    partial void OnCategoryIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnSlugChanging(string value);
    partial void OnSlugChanged();
    partial void OnBodyChanging(string value);
    partial void OnBodyChanged();
    partial void OnIsCommentsVisibleChanging(bool value);
    partial void OnIsCommentsVisibleChanged();
    partial void OnIsCommentsOpenChanging(bool value);
    partial void OnIsCommentsOpenChanged();
    partial void OnCreatedChanging(System.DateTime value);
    partial void OnCreatedChanged();
    partial void OnModifiedChanging(System.DateTime value);
    partial void OnModifiedChanged();
    partial void OnIsPublishedChanging(bool value);
    partial void OnIsPublishedChanged();
    partial void OnPublishDateChanging(System.DateTime value);
    partial void OnPublishDateChanged();
    #endregion
		
		public BC_Post()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int PostID
		{
			get
			{
				return this._PostID;
			}
			set
			{
				if ((this._PostID != value))
				{
					this.OnPostIDChanging(value);
					this.SendPropertyChanging();
					this._PostID = value;
					this.SendPropertyChanged("PostID");
					this.OnPostIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public int CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					if (this._Parent_Category.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(256) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Slug", DbType="NVarChar(256) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public string Slug
		{
			get
			{
				return this._Slug;
			}
			set
			{
				if ((this._Slug != value))
				{
					this.OnSlugChanging(value);
					this.SendPropertyChanging();
					this._Slug = value;
					this.SendPropertyChanged("Slug");
					this.OnSlugChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Body", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this.OnBodyChanging(value);
					this.SendPropertyChanging();
					this._Body = value;
					this.SendPropertyChanged("Body");
					this.OnBodyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsCommentsVisible", DbType="Bit NOT NULL", UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6)]
		public bool IsCommentsVisible
		{
			get
			{
				return this._IsCommentsVisible;
			}
			set
			{
				if ((this._IsCommentsVisible != value))
				{
					this.OnIsCommentsVisibleChanging(value);
					this.SendPropertyChanging();
					this._IsCommentsVisible = value;
					this.SendPropertyChanged("IsCommentsVisible");
					this.OnIsCommentsVisibleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsCommentsOpen", DbType="Bit NOT NULL", UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=7)]
		public bool IsCommentsOpen
		{
			get
			{
				return this._IsCommentsOpen;
			}
			set
			{
				if ((this._IsCommentsOpen != value))
				{
					this.OnIsCommentsOpenChanging(value);
					this.SendPropertyChanging();
					this._IsCommentsOpen = value;
					this.SendPropertyChanged("IsCommentsOpen");
					this.OnIsCommentsOpenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Created", DbType="DateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=8)]
		public System.DateTime Created
		{
			get
			{
				return this._Created;
			}
			set
			{
				if ((this._Created != value))
				{
					this.OnCreatedChanging(value);
					this.SendPropertyChanging();
					this._Created = value;
					this.SendPropertyChanged("Created");
					this.OnCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modified", DbType="DateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=9)]
		public System.DateTime Modified
		{
			get
			{
				return this._Modified;
			}
			set
			{
				if ((this._Modified != value))
				{
					this.OnModifiedChanging(value);
					this.SendPropertyChanging();
					this._Modified = value;
					this.SendPropertyChanged("Modified");
					this.OnModifiedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsPublished", DbType="Bit NOT NULL", UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=10)]
		public bool IsPublished
		{
			get
			{
				return this._IsPublished;
			}
			set
			{
				if ((this._IsPublished != value))
				{
					this.OnIsPublishedChanging(value);
					this.SendPropertyChanging();
					this._IsPublished = value;
					this.SendPropertyChanged("IsPublished");
					this.OnIsPublishedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PublishDate", DbType="DateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=11)]
		public System.DateTime PublishDate
		{
			get
			{
				return this._PublishDate;
			}
			set
			{
				if ((this._PublishDate != value))
				{
					this.OnPublishDateChanging(value);
					this.SendPropertyChanging();
					this._PublishDate = value;
					this.SendPropertyChanged("PublishDate");
					this.OnPublishDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BC_Category_BC_Post", Storage="_Parent_Category", ThisKey="CategoryID", OtherKey="CategoryID", IsForeignKey=true)]
		internal BC_Category Parent_Category
		{
			get
			{
				return this._Parent_Category.Entity;
			}
			set
			{
				if ((this._Parent_Category.Entity != value))
				{
					this.SendPropertyChanging();
					this._Parent_Category.Entity = value;
					this.SendPropertyChanged("Parent_Category");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void Initialize()
		{
			this._Parent_Category = default(EntityRef<BC_Category>);
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BC_Comment")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class BC_Comment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CommentID;
		
		private int _PostID;
		
		private string _Name;
		
		private bool _IsUser;
		
		private string _Email;
		
		private string _Url;
		
		private string _Text;
		
		private System.DateTime _Created;
		
		private System.DateTime _Modified;
		
		private bool _IsRead;
		
		private EntityRef<BC_Post> _Parent_Post;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCommentIDChanging(int value);
    partial void OnCommentIDChanged();
    partial void OnPostIDChanging(int value);
    partial void OnPostIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnIsUserChanging(bool value);
    partial void OnIsUserChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnUrlChanging(string value);
    partial void OnUrlChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    partial void OnCreatedChanging(System.DateTime value);
    partial void OnCreatedChanged();
    partial void OnModifiedChanging(System.DateTime value);
    partial void OnModifiedChanged();
    partial void OnIsReadChanging(bool value);
    partial void OnIsReadChanged();
    #endregion
		
		public BC_Comment()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CommentID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int CommentID
		{
			get
			{
				return this._CommentID;
			}
			set
			{
				if ((this._CommentID != value))
				{
					this.OnCommentIDChanging(value);
					this.SendPropertyChanging();
					this._CommentID = value;
					this.SendPropertyChanged("CommentID");
					this.OnCommentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostID", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public int PostID
		{
			get
			{
				return this._PostID;
			}
			set
			{
				if ((this._PostID != value))
				{
					if (this._Parent_Post.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPostIDChanging(value);
					this.SendPropertyChanging();
					this._PostID = value;
					this.SendPropertyChanged("PostID");
					this.OnPostIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(256) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsUser", DbType="Bit NOT NULL", UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public bool IsUser
		{
			get
			{
				return this._IsUser;
			}
			set
			{
				if ((this._IsUser != value))
				{
					this.OnIsUserChanging(value);
					this.SendPropertyChanging();
					this._IsUser = value;
					this.SendPropertyChanged("IsUser");
					this.OnIsUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(256)", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Url", DbType="NVarChar(256)", UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6)]
		public string Url
		{
			get
			{
				return this._Url;
			}
			set
			{
				if ((this._Url != value))
				{
					this.OnUrlChanging(value);
					this.SendPropertyChanging();
					this._Url = value;
					this.SendPropertyChanged("Url");
					this.OnUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=7)]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Created", DbType="DateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=8)]
		public System.DateTime Created
		{
			get
			{
				return this._Created;
			}
			set
			{
				if ((this._Created != value))
				{
					this.OnCreatedChanging(value);
					this.SendPropertyChanging();
					this._Created = value;
					this.SendPropertyChanged("Created");
					this.OnCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modified", DbType="DateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=9)]
		public System.DateTime Modified
		{
			get
			{
				return this._Modified;
			}
			set
			{
				if ((this._Modified != value))
				{
					this.OnModifiedChanging(value);
					this.SendPropertyChanging();
					this._Modified = value;
					this.SendPropertyChanged("Modified");
					this.OnModifiedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsRead", DbType="Bit NOT NULL", UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=10)]
		public bool IsRead
		{
			get
			{
				return this._IsRead;
			}
			set
			{
				if ((this._IsRead != value))
				{
					this.OnIsReadChanging(value);
					this.SendPropertyChanging();
					this._IsRead = value;
					this.SendPropertyChanged("IsRead");
					this.OnIsReadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BC_Post_BC_Comment", Storage="_Parent_Post", ThisKey="PostID", OtherKey="PostID", IsForeignKey=true)]
		internal BC_Post Parent_Post
		{
			get
			{
				return this._Parent_Post.Entity;
			}
			set
			{
				if ((this._Parent_Post.Entity != value))
				{
					this.SendPropertyChanging();
					this._Parent_Post.Entity = value;
					this.SendPropertyChanged("Parent_Post");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void Initialize()
		{
			this._Parent_Post = default(EntityRef<BC_Post>);
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BC_User")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class BC_User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserID;
		
		private string _Username;
		
		private string _Email;
		
		private System.Data.Linq.Binary _Password;
		
		private System.Data.Linq.Binary _PasswordSalt;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(System.Data.Linq.Binary value);
    partial void OnPasswordChanged();
    partial void OnPasswordSaltChanging(System.Data.Linq.Binary value);
    partial void OnPasswordSaltChanged();
    #endregion
		
		public BC_User()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public System.Data.Linq.Binary Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PasswordSalt", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public System.Data.Linq.Binary PasswordSalt
		{
			get
			{
				return this._PasswordSalt;
			}
			set
			{
				if ((this._PasswordSalt != value))
				{
					this.OnPasswordSaltChanging(value);
					this.SendPropertyChanging();
					this._PasswordSalt = value;
					this.SendPropertyChanged("PasswordSalt");
					this.OnPasswordSaltChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void Initialize()
		{
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
}
#pragma warning restore 1591
