﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektDemo
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertclients(clients instance);
    partial void Updateclients(clients instance);
    partial void Deleteclients(clients instance);
    partial void Insertrental(rental instance);
    partial void Updaterental(rental instance);
    partial void Deleterental(rental instance);
    partial void Insertstatus(status instance);
    partial void Updatestatus(status instance);
    partial void Deletestatus(status instance);
    partial void Inserttype(type instance);
    partial void Updatetype(type instance);
    partial void Deletetype(type instance);
    partial void Insertvideo(video instance);
    partial void Updatevideo(video instance);
    partial void Deletevideo(video instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::ProjektDemo.Properties.Settings.Default.DatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<clients> clients
		{
			get
			{
				return this.GetTable<clients>();
			}
		}
		
		public System.Data.Linq.Table<rental> rental
		{
			get
			{
				return this.GetTable<rental>();
			}
		}
		
		public System.Data.Linq.Table<status> status
		{
			get
			{
				return this.GetTable<status>();
			}
		}
		
		public System.Data.Linq.Table<type> type
		{
			get
			{
				return this.GetTable<type>();
			}
		}
		
		public System.Data.Linq.Table<video> video
		{
			get
			{
				return this.GetTable<video>();
			}
		}
		
		public System.Data.Linq.Table<v_video> v_video
		{
			get
			{
				return this.GetTable<v_video>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.clients")]
	public partial class clients : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _surname;
		
		private System.DateTime _data_add;
		
		private System.DateTime _data_edit;
		
		private EntitySet<rental> _rental;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnsurnameChanging(string value);
    partial void OnsurnameChanged();
    partial void Ondata_addChanging(System.DateTime value);
    partial void Ondata_addChanged();
    partial void Ondata_editChanging(System.DateTime value);
    partial void Ondata_editChanged();
    #endregion
		
		public clients()
		{
			this._rental = new EntitySet<rental>(new Action<rental>(this.attach_rental), new Action<rental>(this.detach_rental));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_surname", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string surname
		{
			get
			{
				return this._surname;
			}
			set
			{
				if ((this._surname != value))
				{
					this.OnsurnameChanging(value);
					this.SendPropertyChanging();
					this._surname = value;
					this.SendPropertyChanged("surname");
					this.OnsurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_add", DbType="Date NOT NULL")]
		public System.DateTime data_add
		{
			get
			{
				return this._data_add;
			}
			set
			{
				if ((this._data_add != value))
				{
					this.Ondata_addChanging(value);
					this.SendPropertyChanging();
					this._data_add = value;
					this.SendPropertyChanged("data_add");
					this.Ondata_addChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_edit", DbType="Date NOT NULL")]
		public System.DateTime data_edit
		{
			get
			{
				return this._data_edit;
			}
			set
			{
				if ((this._data_edit != value))
				{
					this.Ondata_editChanging(value);
					this.SendPropertyChanging();
					this._data_edit = value;
					this.SendPropertyChanged("data_edit");
					this.Ondata_editChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="clients_rental", Storage="_rental", ThisKey="id", OtherKey="clients_id")]
		public EntitySet<rental> rental
		{
			get
			{
				return this._rental;
			}
			set
			{
				this._rental.Assign(value);
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
		
		private void attach_rental(rental entity)
		{
			this.SendPropertyChanging();
			entity.clients = this;
		}
		
		private void detach_rental(rental entity)
		{
			this.SendPropertyChanging();
			entity.clients = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.rental")]
	public partial class rental : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _clients_id;
		
		private int _video_id;
		
		private System.DateTime _data_add;
		
		private System.DateTime _data_edit;
		
		private EntityRef<clients> _clients;
		
		private EntityRef<video> _video;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onclients_idChanging(int value);
    partial void Onclients_idChanged();
    partial void Onvideo_idChanging(int value);
    partial void Onvideo_idChanged();
    partial void Ondata_addChanging(System.DateTime value);
    partial void Ondata_addChanged();
    partial void Ondata_editChanging(System.DateTime value);
    partial void Ondata_editChanged();
    #endregion
		
		public rental()
		{
			this._clients = default(EntityRef<clients>);
			this._video = default(EntityRef<video>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_clients_id", DbType="Int NOT NULL")]
		public int clients_id
		{
			get
			{
				return this._clients_id;
			}
			set
			{
				if ((this._clients_id != value))
				{
					if (this._clients.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onclients_idChanging(value);
					this.SendPropertyChanging();
					this._clients_id = value;
					this.SendPropertyChanged("clients_id");
					this.Onclients_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_video_id", DbType="Int NOT NULL")]
		public int video_id
		{
			get
			{
				return this._video_id;
			}
			set
			{
				if ((this._video_id != value))
				{
					if (this._video.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onvideo_idChanging(value);
					this.SendPropertyChanging();
					this._video_id = value;
					this.SendPropertyChanged("video_id");
					this.Onvideo_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_add", DbType="Date NOT NULL")]
		public System.DateTime data_add
		{
			get
			{
				return this._data_add;
			}
			set
			{
				if ((this._data_add != value))
				{
					this.Ondata_addChanging(value);
					this.SendPropertyChanging();
					this._data_add = value;
					this.SendPropertyChanged("data_add");
					this.Ondata_addChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_edit", DbType="Date NOT NULL")]
		public System.DateTime data_edit
		{
			get
			{
				return this._data_edit;
			}
			set
			{
				if ((this._data_edit != value))
				{
					this.Ondata_editChanging(value);
					this.SendPropertyChanging();
					this._data_edit = value;
					this.SendPropertyChanged("data_edit");
					this.Ondata_editChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="clients_rental", Storage="_clients", ThisKey="clients_id", OtherKey="id", IsForeignKey=true)]
		public clients clients
		{
			get
			{
				return this._clients.Entity;
			}
			set
			{
				clients previousValue = this._clients.Entity;
				if (((previousValue != value) 
							|| (this._clients.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._clients.Entity = null;
						previousValue.rental.Remove(this);
					}
					this._clients.Entity = value;
					if ((value != null))
					{
						value.rental.Add(this);
						this._clients_id = value.id;
					}
					else
					{
						this._clients_id = default(int);
					}
					this.SendPropertyChanged("clients");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="video_rental", Storage="_video", ThisKey="video_id", OtherKey="id", IsForeignKey=true)]
		public video video
		{
			get
			{
				return this._video.Entity;
			}
			set
			{
				video previousValue = this._video.Entity;
				if (((previousValue != value) 
							|| (this._video.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._video.Entity = null;
						previousValue.rental.Remove(this);
					}
					this._video.Entity = value;
					if ((value != null))
					{
						value.rental.Add(this);
						this._video_id = value.id;
					}
					else
					{
						this._video_id = default(int);
					}
					this.SendPropertyChanged("video");
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
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.status")]
	public partial class status : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private EntitySet<video> _video;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public status()
		{
			this._video = new EntitySet<video>(new Action<video>(this.attach_video), new Action<video>(this.detach_video));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="status_video", Storage="_video", ThisKey="id", OtherKey="status_id")]
		public EntitySet<video> video
		{
			get
			{
				return this._video;
			}
			set
			{
				this._video.Assign(value);
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
		
		private void attach_video(video entity)
		{
			this.SendPropertyChanging();
			entity.status = this;
		}
		
		private void detach_video(video entity)
		{
			this.SendPropertyChanging();
			entity.status = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.type")]
	public partial class type : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private EntitySet<video> _video;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public type()
		{
			this._video = new EntitySet<video>(new Action<video>(this.attach_video), new Action<video>(this.detach_video));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="type_video", Storage="_video", ThisKey="id", OtherKey="type_id")]
		public EntitySet<video> video
		{
			get
			{
				return this._video;
			}
			set
			{
				this._video.Assign(value);
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
		
		private void attach_video(video entity)
		{
			this.SendPropertyChanging();
			entity.type = this;
		}
		
		private void detach_video(video entity)
		{
			this.SendPropertyChanging();
			entity.type = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.video")]
	public partial class video : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _year;
		
		private int _new;
		
		private int _type_id;
		
		private int _status_id;
		
		private System.DateTime _data_add;
		
		private System.DateTime _data_edit;
		
		private EntitySet<rental> _rental;
		
		private EntityRef<type> _type;
		
		private EntityRef<status> _status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnyearChanging(string value);
    partial void OnyearChanged();
    partial void OnnewChanging(int value);
    partial void OnnewChanged();
    partial void Ontype_idChanging(int value);
    partial void Ontype_idChanged();
    partial void Onstatus_idChanging(int value);
    partial void Onstatus_idChanged();
    partial void Ondata_addChanging(System.DateTime value);
    partial void Ondata_addChanged();
    partial void Ondata_editChanging(System.DateTime value);
    partial void Ondata_editChanged();
    #endregion
		
		public video()
		{
			this._rental = new EntitySet<rental>(new Action<rental>(this.attach_rental), new Action<rental>(this.detach_rental));
			this._type = default(EntityRef<type>);
			this._status = default(EntityRef<status>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_year", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string year
		{
			get
			{
				return this._year;
			}
			set
			{
				if ((this._year != value))
				{
					this.OnyearChanging(value);
					this.SendPropertyChanging();
					this._year = value;
					this.SendPropertyChanged("year");
					this.OnyearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="new", Storage="_new", DbType="Int NOT NULL")]
		public int @new
		{
			get
			{
				return this._new;
			}
			set
			{
				if ((this._new != value))
				{
					this.OnnewChanging(value);
					this.SendPropertyChanging();
					this._new = value;
					this.SendPropertyChanged("@new");
					this.OnnewChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type_id", DbType="Int NOT NULL")]
		public int type_id
		{
			get
			{
				return this._type_id;
			}
			set
			{
				if ((this._type_id != value))
				{
					if (this._type.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Ontype_idChanging(value);
					this.SendPropertyChanging();
					this._type_id = value;
					this.SendPropertyChanged("type_id");
					this.Ontype_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status_id", DbType="Int NOT NULL")]
		public int status_id
		{
			get
			{
				return this._status_id;
			}
			set
			{
				if ((this._status_id != value))
				{
					if (this._status.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onstatus_idChanging(value);
					this.SendPropertyChanging();
					this._status_id = value;
					this.SendPropertyChanged("status_id");
					this.Onstatus_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_add", DbType="Date NOT NULL")]
		public System.DateTime data_add
		{
			get
			{
				return this._data_add;
			}
			set
			{
				if ((this._data_add != value))
				{
					this.Ondata_addChanging(value);
					this.SendPropertyChanging();
					this._data_add = value;
					this.SendPropertyChanged("data_add");
					this.Ondata_addChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_edit", DbType="Date NOT NULL")]
		public System.DateTime data_edit
		{
			get
			{
				return this._data_edit;
			}
			set
			{
				if ((this._data_edit != value))
				{
					this.Ondata_editChanging(value);
					this.SendPropertyChanging();
					this._data_edit = value;
					this.SendPropertyChanged("data_edit");
					this.Ondata_editChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="video_rental", Storage="_rental", ThisKey="id", OtherKey="video_id")]
		public EntitySet<rental> rental
		{
			get
			{
				return this._rental;
			}
			set
			{
				this._rental.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="type_video", Storage="_type", ThisKey="type_id", OtherKey="id", IsForeignKey=true)]
		public type type
		{
			get
			{
				return this._type.Entity;
			}
			set
			{
				type previousValue = this._type.Entity;
				if (((previousValue != value) 
							|| (this._type.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._type.Entity = null;
						previousValue.video.Remove(this);
					}
					this._type.Entity = value;
					if ((value != null))
					{
						value.video.Add(this);
						this._type_id = value.id;
					}
					else
					{
						this._type_id = default(int);
					}
					this.SendPropertyChanged("type");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="status_video", Storage="_status", ThisKey="status_id", OtherKey="id", IsForeignKey=true)]
		public status status
		{
			get
			{
				return this._status.Entity;
			}
			set
			{
				status previousValue = this._status.Entity;
				if (((previousValue != value) 
							|| (this._status.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._status.Entity = null;
						previousValue.video.Remove(this);
					}
					this._status.Entity = value;
					if ((value != null))
					{
						value.video.Add(this);
						this._status_id = value.id;
					}
					else
					{
						this._status_id = default(int);
					}
					this.SendPropertyChanged("status");
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
		
		private void attach_rental(rental entity)
		{
			this.SendPropertyChanging();
			entity.video = this;
		}
		
		private void detach_rental(rental entity)
		{
			this.SendPropertyChanging();
			entity.video = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.v_video")]
	public partial class v_video
	{
		
		private int _id;
		
		private string _name;
		
		private string _year;
		
		private int _new;
		
		private int _type_id;
		
		private int _status_id;
		
		private System.DateTime _data_add;
		
		private System.DateTime _data_edit;
		
		public v_video()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this._name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_year", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string year
		{
			get
			{
				return this._year;
			}
			set
			{
				if ((this._year != value))
				{
					this._year = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="new", Storage="_new", DbType="Int NOT NULL")]
		public int @new
		{
			get
			{
				return this._new;
			}
			set
			{
				if ((this._new != value))
				{
					this._new = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type_id", DbType="Int NOT NULL")]
		public int type_id
		{
			get
			{
				return this._type_id;
			}
			set
			{
				if ((this._type_id != value))
				{
					this._type_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status_id", DbType="Int NOT NULL")]
		public int status_id
		{
			get
			{
				return this._status_id;
			}
			set
			{
				if ((this._status_id != value))
				{
					this._status_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_add", DbType="Date NOT NULL")]
		public System.DateTime data_add
		{
			get
			{
				return this._data_add;
			}
			set
			{
				if ((this._data_add != value))
				{
					this._data_add = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_edit", DbType="Date NOT NULL")]
		public System.DateTime data_edit
		{
			get
			{
				return this._data_edit;
			}
			set
			{
				if ((this._data_edit != value))
				{
					this._data_edit = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
