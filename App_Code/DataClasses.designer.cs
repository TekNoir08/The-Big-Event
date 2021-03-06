﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database")]
public partial class DataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertCategory(Category instance);
  partial void UpdateCategory(Category instance);
  partial void DeleteCategory(Category instance);
  partial void InsertEvent(Event instance);
  partial void UpdateEvent(Event instance);
  partial void DeleteEvent(Event instance);
  partial void InsertRegisteredEvent(RegisteredEvent instance);
  partial void UpdateRegisteredEvent(RegisteredEvent instance);
  partial void DeleteRegisteredEvent(RegisteredEvent instance);
  partial void InsertVenue(Venue instance);
  partial void UpdateVenue(Venue instance);
  partial void DeleteVenue(Venue instance);
  #endregion
	
	public DataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseConnectionString1"].ConnectionString, mappingSource)
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
	
	public System.Data.Linq.Table<Category> Categories
	{
		get
		{
			return this.GetTable<Category>();
		}
	}
	
	public System.Data.Linq.Table<Event> Events
	{
		get
		{
			return this.GetTable<Event>();
		}
	}
	
	public System.Data.Linq.Table<RegisteredEvent> RegisteredEvents
	{
		get
		{
			return this.GetTable<RegisteredEvent>();
		}
	}
	
	public System.Data.Linq.Table<Venue> Venues
	{
		get
		{
			return this.GetTable<Venue>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Category")]
public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _CategoryType;
	
	private EntitySet<Event> _Events;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCategoryTypeChanging(string value);
    partial void OnCategoryTypeChanged();
    #endregion
	
	public Category()
	{
		this._Events = new EntitySet<Event>(new Action<Event>(this.attach_Events), new Action<Event>(this.detach_Events));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryType", DbType="NChar(20) NOT NULL", CanBeNull=false)]
	public string CategoryType
	{
		get
		{
			return this._CategoryType;
		}
		set
		{
			if ((this._CategoryType != value))
			{
				this.OnCategoryTypeChanging(value);
				this.SendPropertyChanging();
				this._CategoryType = value;
				this.SendPropertyChanged("CategoryType");
				this.OnCategoryTypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Event", Storage="_Events", ThisKey="Id", OtherKey="CategoryId")]
	public EntitySet<Event> Events
	{
		get
		{
			return this._Events;
		}
		set
		{
			this._Events.Assign(value);
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
	
	private void attach_Events(Event entity)
	{
		this.SendPropertyChanging();
		entity.Category = this;
	}
	
	private void detach_Events(Event entity)
	{
		this.SendPropertyChanging();
		entity.Category = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Event")]
public partial class Event : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private int _CategoryId;
	
	private string _EventType;
	
	private int _VenueId;
	
	private decimal _Price;
	
	private System.TimeSpan _Time;
	
	private System.DateTime _Date;
	
	private int _NumOfTickets;
	
	private string _Description;
	
	private EntitySet<RegisteredEvent> _RegisteredEvents;
	
	private EntityRef<Category> _Category;
	
	private EntityRef<Venue> _Venue;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCategoryIdChanging(int value);
    partial void OnCategoryIdChanged();
    partial void OnEventTypeChanging(string value);
    partial void OnEventTypeChanged();
    partial void OnVenueIdChanging(int value);
    partial void OnVenueIdChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnTimeChanging(System.TimeSpan value);
    partial void OnTimeChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnNumOfTicketsChanging(int value);
    partial void OnNumOfTicketsChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
	
	public Event()
	{
		this._RegisteredEvents = new EntitySet<RegisteredEvent>(new Action<RegisteredEvent>(this.attach_RegisteredEvents), new Action<RegisteredEvent>(this.detach_RegisteredEvents));
		this._Category = default(EntityRef<Category>);
		this._Venue = default(EntityRef<Venue>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryId", DbType="Int NOT NULL")]
	public int CategoryId
	{
		get
		{
			return this._CategoryId;
		}
		set
		{
			if ((this._CategoryId != value))
			{
				if (this._Category.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCategoryIdChanging(value);
				this.SendPropertyChanging();
				this._CategoryId = value;
				this.SendPropertyChanged("CategoryId");
				this.OnCategoryIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventType", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string EventType
	{
		get
		{
			return this._EventType;
		}
		set
		{
			if ((this._EventType != value))
			{
				this.OnEventTypeChanging(value);
				this.SendPropertyChanging();
				this._EventType = value;
				this.SendPropertyChanged("EventType");
				this.OnEventTypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VenueId", DbType="Int NOT NULL")]
	public int VenueId
	{
		get
		{
			return this._VenueId;
		}
		set
		{
			if ((this._VenueId != value))
			{
				if (this._Venue.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnVenueIdChanging(value);
				this.SendPropertyChanging();
				this._VenueId = value;
				this.SendPropertyChanged("VenueId");
				this.OnVenueIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="SmallMoney NOT NULL")]
	public decimal Price
	{
		get
		{
			return this._Price;
		}
		set
		{
			if ((this._Price != value))
			{
				this.OnPriceChanging(value);
				this.SendPropertyChanging();
				this._Price = value;
				this.SendPropertyChanged("Price");
				this.OnPriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time", DbType="Time NOT NULL")]
	public System.TimeSpan Time
	{
		get
		{
			return this._Time;
		}
		set
		{
			if ((this._Time != value))
			{
				this.OnTimeChanging(value);
				this.SendPropertyChanging();
				this._Time = value;
				this.SendPropertyChanged("Time");
				this.OnTimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date NOT NULL")]
	public System.DateTime Date
	{
		get
		{
			return this._Date;
		}
		set
		{
			if ((this._Date != value))
			{
				this.OnDateChanging(value);
				this.SendPropertyChanging();
				this._Date = value;
				this.SendPropertyChanged("Date");
				this.OnDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumOfTickets", DbType="Int NOT NULL")]
	public int NumOfTickets
	{
		get
		{
			return this._NumOfTickets;
		}
		set
		{
			if ((this._NumOfTickets != value))
			{
				this.OnNumOfTicketsChanging(value);
				this.SendPropertyChanging();
				this._NumOfTickets = value;
				this.SendPropertyChanged("NumOfTickets");
				this.OnNumOfTicketsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
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
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Event_RegisteredEvent", Storage="_RegisteredEvents", ThisKey="Id", OtherKey="EventId")]
	public EntitySet<RegisteredEvent> RegisteredEvents
	{
		get
		{
			return this._RegisteredEvents;
		}
		set
		{
			this._RegisteredEvents.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Event", Storage="_Category", ThisKey="CategoryId", OtherKey="Id", IsForeignKey=true)]
	public Category Category
	{
		get
		{
			return this._Category.Entity;
		}
		set
		{
			Category previousValue = this._Category.Entity;
			if (((previousValue != value) 
						|| (this._Category.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Category.Entity = null;
					previousValue.Events.Remove(this);
				}
				this._Category.Entity = value;
				if ((value != null))
				{
					value.Events.Add(this);
					this._CategoryId = value.Id;
				}
				else
				{
					this._CategoryId = default(int);
				}
				this.SendPropertyChanged("Category");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Venue_Event", Storage="_Venue", ThisKey="VenueId", OtherKey="Id", IsForeignKey=true)]
	public Venue Venue
	{
		get
		{
			return this._Venue.Entity;
		}
		set
		{
			Venue previousValue = this._Venue.Entity;
			if (((previousValue != value) 
						|| (this._Venue.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Venue.Entity = null;
					previousValue.Events.Remove(this);
				}
				this._Venue.Entity = value;
				if ((value != null))
				{
					value.Events.Add(this);
					this._VenueId = value.Id;
				}
				else
				{
					this._VenueId = default(int);
				}
				this.SendPropertyChanged("Venue");
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
	
	private void attach_RegisteredEvents(RegisteredEvent entity)
	{
		this.SendPropertyChanging();
		entity.Event = this;
	}
	
	private void detach_RegisteredEvents(RegisteredEvent entity)
	{
		this.SendPropertyChanging();
		entity.Event = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RegisteredEvents")]
public partial class RegisteredEvent : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private int _EventId;
	
	private string _FirstName;
	
	private string _LastName;
	
	private string _EmailAddress;
	
	private System.Nullable<bool> _Won;
	
	private EntityRef<Event> _Event;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEventIdChanging(int value);
    partial void OnEventIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnEmailAddressChanging(string value);
    partial void OnEmailAddressChanged();
    partial void OnWonChanging(System.Nullable<bool> value);
    partial void OnWonChanged();
    #endregion
	
	public RegisteredEvent()
	{
		this._Event = default(EntityRef<Event>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventId", DbType="Int NOT NULL")]
	public int EventId
	{
		get
		{
			return this._EventId;
		}
		set
		{
			if ((this._EventId != value))
			{
				if (this._Event.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnEventIdChanging(value);
				this.SendPropertyChanging();
				this._EventId = value;
				this.SendPropertyChanged("EventId");
				this.OnEventIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string FirstName
	{
		get
		{
			return this._FirstName;
		}
		set
		{
			if ((this._FirstName != value))
			{
				this.OnFirstNameChanging(value);
				this.SendPropertyChanging();
				this._FirstName = value;
				this.SendPropertyChanged("FirstName");
				this.OnFirstNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string LastName
	{
		get
		{
			return this._LastName;
		}
		set
		{
			if ((this._LastName != value))
			{
				this.OnLastNameChanging(value);
				this.SendPropertyChanging();
				this._LastName = value;
				this.SendPropertyChanged("LastName");
				this.OnLastNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailAddress", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string EmailAddress
	{
		get
		{
			return this._EmailAddress;
		}
		set
		{
			if ((this._EmailAddress != value))
			{
				this.OnEmailAddressChanging(value);
				this.SendPropertyChanging();
				this._EmailAddress = value;
				this.SendPropertyChanged("EmailAddress");
				this.OnEmailAddressChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Won", DbType="Bit")]
	public System.Nullable<bool> Won
	{
		get
		{
			return this._Won;
		}
		set
		{
			if ((this._Won != value))
			{
				this.OnWonChanging(value);
				this.SendPropertyChanging();
				this._Won = value;
				this.SendPropertyChanged("Won");
				this.OnWonChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Event_RegisteredEvent", Storage="_Event", ThisKey="EventId", OtherKey="Id", IsForeignKey=true)]
	public Event Event
	{
		get
		{
			return this._Event.Entity;
		}
		set
		{
			Event previousValue = this._Event.Entity;
			if (((previousValue != value) 
						|| (this._Event.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Event.Entity = null;
					previousValue.RegisteredEvents.Remove(this);
				}
				this._Event.Entity = value;
				if ((value != null))
				{
					value.RegisteredEvents.Add(this);
					this._EventId = value.Id;
				}
				else
				{
					this._EventId = default(int);
				}
				this.SendPropertyChanged("Event");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Venue")]
public partial class Venue : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _Name;
	
	private string _Location;
	
	private EntitySet<Event> _Events;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnLocationChanging(string value);
    partial void OnLocationChanged();
    #endregion
	
	public Venue()
	{
		this._Events = new EntitySet<Event>(new Action<Event>(this.attach_Events), new Action<Event>(this.detach_Events));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string Location
	{
		get
		{
			return this._Location;
		}
		set
		{
			if ((this._Location != value))
			{
				this.OnLocationChanging(value);
				this.SendPropertyChanging();
				this._Location = value;
				this.SendPropertyChanged("Location");
				this.OnLocationChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Venue_Event", Storage="_Events", ThisKey="Id", OtherKey="VenueId")]
	public EntitySet<Event> Events
	{
		get
		{
			return this._Events;
		}
		set
		{
			this._Events.Assign(value);
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
	
	private void attach_Events(Event entity)
	{
		this.SendPropertyChanging();
		entity.Venue = this;
	}
	
	private void detach_Events(Event entity)
	{
		this.SendPropertyChanging();
		entity.Venue = null;
	}
}
#pragma warning restore 1591
