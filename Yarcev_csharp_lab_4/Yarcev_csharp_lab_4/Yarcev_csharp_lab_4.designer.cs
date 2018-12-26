﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yarcev_csharp_lab_4
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Yarcev_csharp_lab_4")]
	public partial class Yarcev_csharp_lab_4DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void Insertall_time(all_time instance);
    partial void Updateall_time(all_time instance);
    partial void Deleteall_time(all_time instance);
    partial void Insertcomplaints(complaints instance);
    partial void Updatecomplaints(complaints instance);
    partial void Deletecomplaints(complaints instance);
    partial void Insertlist_car(list_car instance);
    partial void Updatelist_car(list_car instance);
    partial void Deletelist_car(list_car instance);
    partial void Insertnumber_on_way(number_on_way instance);
    partial void Updatenumber_on_way(number_on_way instance);
    partial void Deletenumber_on_way(number_on_way instance);
    partial void Insertstart_end(start_end instance);
    partial void Updatestart_end(start_end instance);
    partial void Deletestart_end(start_end instance);
    partial void Insertway(way instance);
    partial void Updateway(way instance);
    partial void Deleteway(way instance);
    #endregion
		
		public Yarcev_csharp_lab_4DataContext() : 
				base(global::Yarcev_csharp_lab_4.Properties.Settings.Default.Yarcev_csharp_lab_4ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Yarcev_csharp_lab_4DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Yarcev_csharp_lab_4DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Yarcev_csharp_lab_4DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Yarcev_csharp_lab_4DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<all_time> all_time
		{
			get
			{
				return this.GetTable<all_time>();
			}
		}
		
		public System.Data.Linq.Table<complaints> complaints
		{
			get
			{
				return this.GetTable<complaints>();
			}
		}
		
		public System.Data.Linq.Table<list_car> list_car
		{
			get
			{
				return this.GetTable<list_car>();
			}
		}
		
		public System.Data.Linq.Table<number_on_way> number_on_way
		{
			get
			{
				return this.GetTable<number_on_way>();
			}
		}
		
		public System.Data.Linq.Table<start_end> start_end
		{
			get
			{
				return this.GetTable<start_end>();
			}
		}
		
		public System.Data.Linq.Table<way> way
		{
			get
			{
				return this.GetTable<way>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.all_time")]
	public partial class all_time : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _idway;
		
		private System.Nullable<System.TimeSpan> _time;
		
		private EntityRef<way> _way;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnidwayChanging(System.Nullable<int> value);
    partial void OnidwayChanged();
    partial void OntimeChanging(System.Nullable<System.TimeSpan> value);
    partial void OntimeChanged();
    #endregion
		
		public all_time()
		{
			this._way = default(EntityRef<way>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idway", DbType="Int")]
		public System.Nullable<int> idway
		{
			get
			{
				return this._idway;
			}
			set
			{
				if ((this._idway != value))
				{
					if (this._way.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidwayChanging(value);
					this.SendPropertyChanging();
					this._idway = value;
					this.SendPropertyChanged("idway");
					this.OnidwayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_time", DbType="Time")]
		public System.Nullable<System.TimeSpan> time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((this._time != value))
				{
					this.OntimeChanging(value);
					this.SendPropertyChanging();
					this._time = value;
					this.SendPropertyChanged("time");
					this.OntimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="way_all_time", Storage="_way", ThisKey="idway", OtherKey="Id", IsForeignKey=true)]
		public way way
		{
			get
			{
				return this._way.Entity;
			}
			set
			{
				way previousValue = this._way.Entity;
				if (((previousValue != value) 
							|| (this._way.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._way.Entity = null;
						previousValue.all_time.Remove(this);
					}
					this._way.Entity = value;
					if ((value != null))
					{
						value.all_time.Add(this);
						this._idway = value.Id;
					}
					else
					{
						this._idway = default(Nullable<int>);
					}
					this.SendPropertyChanged("way");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.complaints")]
	public partial class complaints : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _id_list_car;
		
		private string _name;
		
		private string _text;
		
		private EntityRef<list_car> _list_car;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void Onid_list_carChanging(System.Nullable<int> value);
    partial void Onid_list_carChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OntextChanging(string value);
    partial void OntextChanged();
    #endregion
		
		public complaints()
		{
			this._list_car = default(EntityRef<list_car>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_list_car", DbType="Int")]
		public System.Nullable<int> id_list_car
		{
			get
			{
				return this._id_list_car;
			}
			set
			{
				if ((this._id_list_car != value))
				{
					if (this._list_car.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_list_carChanging(value);
					this.SendPropertyChanging();
					this._id_list_car = value;
					this.SendPropertyChanged("id_list_car");
					this.Onid_list_carChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_text", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string text
		{
			get
			{
				return this._text;
			}
			set
			{
				if ((this._text != value))
				{
					this.OntextChanging(value);
					this.SendPropertyChanging();
					this._text = value;
					this.SendPropertyChanged("text");
					this.OntextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="list_car_complaints", Storage="_list_car", ThisKey="id_list_car", OtherKey="Id", IsForeignKey=true)]
		public list_car list_car
		{
			get
			{
				return this._list_car.Entity;
			}
			set
			{
				list_car previousValue = this._list_car.Entity;
				if (((previousValue != value) 
							|| (this._list_car.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._list_car.Entity = null;
						previousValue.complaints.Remove(this);
					}
					this._list_car.Entity = value;
					if ((value != null))
					{
						value.complaints.Add(this);
						this._id_list_car = value.Id;
					}
					else
					{
						this._id_list_car = default(Nullable<int>);
					}
					this.SendPropertyChanged("list_car");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.list_car")]
	public partial class list_car : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _idway;
		
		private string _number_car;
		
		private System.Nullable<System.DateTime> _date;
		
		private EntitySet<complaints> _complaints;
		
		private EntityRef<way> _way;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnidwayChanging(System.Nullable<int> value);
    partial void OnidwayChanged();
    partial void Onnumber_carChanging(string value);
    partial void Onnumber_carChanged();
    partial void OndateChanging(System.Nullable<System.DateTime> value);
    partial void OndateChanged();
    #endregion
		
		public list_car()
		{
			this._complaints = new EntitySet<complaints>(new Action<complaints>(this.attach_complaints), new Action<complaints>(this.detach_complaints));
			this._way = default(EntityRef<way>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idway", DbType="Int")]
		public System.Nullable<int> idway
		{
			get
			{
				return this._idway;
			}
			set
			{
				if ((this._idway != value))
				{
					if (this._way.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidwayChanging(value);
					this.SendPropertyChanging();
					this._idway = value;
					this.SendPropertyChanged("idway");
					this.OnidwayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_number_car", DbType="VarChar(50)")]
		public string number_car
		{
			get
			{
				return this._number_car;
			}
			set
			{
				if ((this._number_car != value))
				{
					this.Onnumber_carChanging(value);
					this.SendPropertyChanging();
					this._number_car = value;
					this.SendPropertyChanged("number_car");
					this.Onnumber_carChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="Date")]
		public System.Nullable<System.DateTime> date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="list_car_complaints", Storage="_complaints", ThisKey="Id", OtherKey="id_list_car")]
		public EntitySet<complaints> complaints
		{
			get
			{
				return this._complaints;
			}
			set
			{
				this._complaints.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="way_list_car", Storage="_way", ThisKey="idway", OtherKey="Id", IsForeignKey=true)]
		public way way
		{
			get
			{
				return this._way.Entity;
			}
			set
			{
				way previousValue = this._way.Entity;
				if (((previousValue != value) 
							|| (this._way.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._way.Entity = null;
						previousValue.list_car.Remove(this);
					}
					this._way.Entity = value;
					if ((value != null))
					{
						value.list_car.Add(this);
						this._idway = value.Id;
					}
					else
					{
						this._idway = default(Nullable<int>);
					}
					this.SendPropertyChanged("way");
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
		
		private void attach_complaints(complaints entity)
		{
			this.SendPropertyChanging();
			entity.list_car = this;
		}
		
		private void detach_complaints(complaints entity)
		{
			this.SendPropertyChanging();
			entity.list_car = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.number_on_way")]
	public partial class number_on_way : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _idway;
		
		private System.Nullable<int> _number;
		
		private System.Nullable<System.DateTime> _date;
		
		private EntityRef<way> _way;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnidwayChanging(System.Nullable<int> value);
    partial void OnidwayChanged();
    partial void OnnumberChanging(System.Nullable<int> value);
    partial void OnnumberChanged();
    partial void OndateChanging(System.Nullable<System.DateTime> value);
    partial void OndateChanged();
    #endregion
		
		public number_on_way()
		{
			this._way = default(EntityRef<way>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idway", DbType="Int")]
		public System.Nullable<int> idway
		{
			get
			{
				return this._idway;
			}
			set
			{
				if ((this._idway != value))
				{
					if (this._way.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidwayChanging(value);
					this.SendPropertyChanging();
					this._idway = value;
					this.SendPropertyChanged("idway");
					this.OnidwayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_number", DbType="Int")]
		public System.Nullable<int> number
		{
			get
			{
				return this._number;
			}
			set
			{
				if ((this._number != value))
				{
					this.OnnumberChanging(value);
					this.SendPropertyChanging();
					this._number = value;
					this.SendPropertyChanged("number");
					this.OnnumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="Date")]
		public System.Nullable<System.DateTime> date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="way_number_on_way", Storage="_way", ThisKey="idway", OtherKey="Id", IsForeignKey=true)]
		public way way
		{
			get
			{
				return this._way.Entity;
			}
			set
			{
				way previousValue = this._way.Entity;
				if (((previousValue != value) 
							|| (this._way.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._way.Entity = null;
						previousValue.number_on_way.Remove(this);
					}
					this._way.Entity = value;
					if ((value != null))
					{
						value.number_on_way.Add(this);
						this._idway = value.Id;
					}
					else
					{
						this._idway = default(Nullable<int>);
					}
					this.SendPropertyChanged("way");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.start_end")]
	public partial class start_end : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _idway;
		
		private string _start;
		
		private string _end;
		
		private EntityRef<way> _way;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnidwayChanging(System.Nullable<int> value);
    partial void OnidwayChanged();
    partial void OnstartChanging(string value);
    partial void OnstartChanged();
    partial void OnendChanging(string value);
    partial void OnendChanged();
    #endregion
		
		public start_end()
		{
			this._way = default(EntityRef<way>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idway", DbType="Int")]
		public System.Nullable<int> idway
		{
			get
			{
				return this._idway;
			}
			set
			{
				if ((this._idway != value))
				{
					if (this._way.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidwayChanging(value);
					this.SendPropertyChanging();
					this._idway = value;
					this.SendPropertyChanged("idway");
					this.OnidwayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_start", DbType="VarChar(50)")]
		public string start
		{
			get
			{
				return this._start;
			}
			set
			{
				if ((this._start != value))
				{
					this.OnstartChanging(value);
					this.SendPropertyChanging();
					this._start = value;
					this.SendPropertyChanged("start");
					this.OnstartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[end]", Storage="_end", DbType="NChar(10)")]
		public string end
		{
			get
			{
				return this._end;
			}
			set
			{
				if ((this._end != value))
				{
					this.OnendChanging(value);
					this.SendPropertyChanging();
					this._end = value;
					this.SendPropertyChanged("end");
					this.OnendChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="way_start_end", Storage="_way", ThisKey="idway", OtherKey="Id", IsForeignKey=true)]
		public way way
		{
			get
			{
				return this._way.Entity;
			}
			set
			{
				way previousValue = this._way.Entity;
				if (((previousValue != value) 
							|| (this._way.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._way.Entity = null;
						previousValue.start_end.Remove(this);
					}
					this._way.Entity = value;
					if ((value != null))
					{
						value.start_end.Add(this);
						this._idway = value.Id;
					}
					else
					{
						this._idway = default(Nullable<int>);
					}
					this.SendPropertyChanged("way");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.way")]
	public partial class way : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _name;
		
		private EntitySet<all_time> _all_time;
		
		private EntitySet<list_car> _list_car;
		
		private EntitySet<number_on_way> _number_on_way;
		
		private EntitySet<start_end> _start_end;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public way()
		{
			this._all_time = new EntitySet<all_time>(new Action<all_time>(this.attach_all_time), new Action<all_time>(this.detach_all_time));
			this._list_car = new EntitySet<list_car>(new Action<list_car>(this.attach_list_car), new Action<list_car>(this.detach_list_car));
			this._number_on_way = new EntitySet<number_on_way>(new Action<number_on_way>(this.attach_number_on_way), new Action<number_on_way>(this.detach_number_on_way));
			this._start_end = new EntitySet<start_end>(new Action<start_end>(this.attach_start_end), new Action<start_end>(this.detach_start_end));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="way_all_time", Storage="_all_time", ThisKey="Id", OtherKey="idway")]
		public EntitySet<all_time> all_time
		{
			get
			{
				return this._all_time;
			}
			set
			{
				this._all_time.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="way_list_car", Storage="_list_car", ThisKey="Id", OtherKey="idway")]
		public EntitySet<list_car> list_car
		{
			get
			{
				return this._list_car;
			}
			set
			{
				this._list_car.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="way_number_on_way", Storage="_number_on_way", ThisKey="Id", OtherKey="idway")]
		public EntitySet<number_on_way> number_on_way
		{
			get
			{
				return this._number_on_way;
			}
			set
			{
				this._number_on_way.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="way_start_end", Storage="_start_end", ThisKey="Id", OtherKey="idway")]
		public EntitySet<start_end> start_end
		{
			get
			{
				return this._start_end;
			}
			set
			{
				this._start_end.Assign(value);
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
		
		private void attach_all_time(all_time entity)
		{
			this.SendPropertyChanging();
			entity.way = this;
		}
		
		private void detach_all_time(all_time entity)
		{
			this.SendPropertyChanging();
			entity.way = null;
		}
		
		private void attach_list_car(list_car entity)
		{
			this.SendPropertyChanging();
			entity.way = this;
		}
		
		private void detach_list_car(list_car entity)
		{
			this.SendPropertyChanging();
			entity.way = null;
		}
		
		private void attach_number_on_way(number_on_way entity)
		{
			this.SendPropertyChanging();
			entity.way = this;
		}
		
		private void detach_number_on_way(number_on_way entity)
		{
			this.SendPropertyChanging();
			entity.way = null;
		}
		
		private void attach_start_end(start_end entity)
		{
			this.SendPropertyChanging();
			entity.way = this;
		}
		
		private void detach_start_end(start_end entity)
		{
			this.SendPropertyChanging();
			entity.way = null;
		}
	}
}
#pragma warning restore 1591