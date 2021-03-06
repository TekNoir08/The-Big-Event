﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("DatabaseModel", "FK_Event_Category", "Category", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DatabaseModel.Category), "Event", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(DatabaseModel.Event), true)]
[assembly: EdmRelationshipAttribute("DatabaseModel", "FK_Event_Venue", "Venue", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DatabaseModel.Venue), "Event", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(DatabaseModel.Event), true)]
[assembly: EdmRelationshipAttribute("DatabaseModel", "FK_RegisteredEvents_Event", "Event", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DatabaseModel.Event), "RegisteredEvent", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(DatabaseModel.RegisteredEvent), true)]

#endregion

namespace DatabaseModel
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DatabaseEntities1 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DatabaseEntities1 object using the connection string found in the 'DatabaseEntities1' section of the application configuration file.
        /// </summary>
        public DatabaseEntities1() : base("name=DatabaseEntities1", "DatabaseEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseEntities1 object.
        /// </summary>
        public DatabaseEntities1(string connectionString) : base(connectionString, "DatabaseEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseEntities1 object.
        /// </summary>
        public DatabaseEntities1(EntityConnection connection) : base(connection, "DatabaseEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Category> Categories
        {
            get
            {
                if ((_Categories == null))
                {
                    _Categories = base.CreateObjectSet<Category>("Categories");
                }
                return _Categories;
            }
        }
        private ObjectSet<Category> _Categories;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Event> Events
        {
            get
            {
                if ((_Events == null))
                {
                    _Events = base.CreateObjectSet<Event>("Events");
                }
                return _Events;
            }
        }
        private ObjectSet<Event> _Events;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Venue> Venues
        {
            get
            {
                if ((_Venues == null))
                {
                    _Venues = base.CreateObjectSet<Venue>("Venues");
                }
                return _Venues;
            }
        }
        private ObjectSet<Venue> _Venues;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<RegisteredEvent> RegisteredEvents
        {
            get
            {
                if ((_RegisteredEvents == null))
                {
                    _RegisteredEvents = base.CreateObjectSet<RegisteredEvent>("RegisteredEvents");
                }
                return _RegisteredEvents;
            }
        }
        private ObjectSet<RegisteredEvent> _RegisteredEvents;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Categories EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCategories(Category category)
        {
            base.AddObject("Categories", category);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Events EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEvents(Event @event)
        {
            base.AddObject("Events", @event);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Venues EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToVenues(Venue venue)
        {
            base.AddObject("Venues", venue);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the RegisteredEvents EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRegisteredEvents(RegisteredEvent registeredEvent)
        {
            base.AddObject("RegisteredEvents", registeredEvent);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DatabaseModel", Name="Category")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Category : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Category object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="categoryType">Initial value of the CategoryType property.</param>
        public static Category CreateCategory(global::System.Int32 id, global::System.String categoryType)
        {
            Category category = new Category();
            category.Id = id;
            category.CategoryType = categoryType;
            return category;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CategoryType
        {
            get
            {
                return _CategoryType;
            }
            set
            {
                OnCategoryTypeChanging(value);
                ReportPropertyChanging("CategoryType");
                _CategoryType = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CategoryType");
                OnCategoryTypeChanged();
            }
        }
        private global::System.String _CategoryType;
        partial void OnCategoryTypeChanging(global::System.String value);
        partial void OnCategoryTypeChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DatabaseModel", "FK_Event_Category", "Event")]
        public EntityCollection<Event> Events
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Event>("DatabaseModel.FK_Event_Category", "Event");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Event>("DatabaseModel.FK_Event_Category", "Event", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DatabaseModel", Name="Event")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Event : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Event object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="categoryId">Initial value of the CategoryId property.</param>
        /// <param name="eventType">Initial value of the EventType property.</param>
        /// <param name="venueId">Initial value of the VenueId property.</param>
        /// <param name="price">Initial value of the Price property.</param>
        /// <param name="time">Initial value of the Time property.</param>
        /// <param name="date">Initial value of the Date property.</param>
        /// <param name="numOfTickets">Initial value of the NumOfTickets property.</param>
        public static Event CreateEvent(global::System.Int32 id, global::System.Int32 categoryId, global::System.String eventType, global::System.Int32 venueId, global::System.Decimal price, global::System.TimeSpan time, global::System.DateTime date, global::System.Int32 numOfTickets)
        {
            Event @event = new Event();
            @event.Id = id;
            @event.CategoryId = categoryId;
            @event.EventType = eventType;
            @event.VenueId = venueId;
            @event.Price = price;
            @event.Time = time;
            @event.Date = date;
            @event.NumOfTickets = numOfTickets;
            return @event;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CategoryId
        {
            get
            {
                return _CategoryId;
            }
            set
            {
                OnCategoryIdChanging(value);
                ReportPropertyChanging("CategoryId");
                _CategoryId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CategoryId");
                OnCategoryIdChanged();
            }
        }
        private global::System.Int32 _CategoryId;
        partial void OnCategoryIdChanging(global::System.Int32 value);
        partial void OnCategoryIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String EventType
        {
            get
            {
                return _EventType;
            }
            set
            {
                OnEventTypeChanging(value);
                ReportPropertyChanging("EventType");
                _EventType = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("EventType");
                OnEventTypeChanged();
            }
        }
        private global::System.String _EventType;
        partial void OnEventTypeChanging(global::System.String value);
        partial void OnEventTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 VenueId
        {
            get
            {
                return _VenueId;
            }
            set
            {
                OnVenueIdChanging(value);
                ReportPropertyChanging("VenueId");
                _VenueId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("VenueId");
                OnVenueIdChanged();
            }
        }
        private global::System.Int32 _VenueId;
        partial void OnVenueIdChanging(global::System.Int32 value);
        partial void OnVenueIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Price
        {
            get
            {
                return _Price;
            }
            set
            {
                OnPriceChanging(value);
                ReportPropertyChanging("Price");
                _Price = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Price");
                OnPriceChanged();
            }
        }
        private global::System.Decimal _Price;
        partial void OnPriceChanging(global::System.Decimal value);
        partial void OnPriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.TimeSpan Time
        {
            get
            {
                return _Time;
            }
            set
            {
                OnTimeChanging(value);
                ReportPropertyChanging("Time");
                _Time = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Time");
                OnTimeChanged();
            }
        }
        private global::System.TimeSpan _Time;
        partial void OnTimeChanging(global::System.TimeSpan value);
        partial void OnTimeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                OnDateChanging(value);
                ReportPropertyChanging("Date");
                _Date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Date");
                OnDateChanged();
            }
        }
        private global::System.DateTime _Date;
        partial void OnDateChanging(global::System.DateTime value);
        partial void OnDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 NumOfTickets
        {
            get
            {
                return _NumOfTickets;
            }
            set
            {
                OnNumOfTicketsChanging(value);
                ReportPropertyChanging("NumOfTickets");
                _NumOfTickets = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("NumOfTickets");
                OnNumOfTicketsChanged();
            }
        }
        private global::System.Int32 _NumOfTickets;
        partial void OnNumOfTicketsChanging(global::System.Int32 value);
        partial void OnNumOfTicketsChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DatabaseModel", "FK_Event_Category", "Category")]
        public Category Category
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Category>("DatabaseModel.FK_Event_Category", "Category").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Category>("DatabaseModel.FK_Event_Category", "Category").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Category> CategoryReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Category>("DatabaseModel.FK_Event_Category", "Category");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Category>("DatabaseModel.FK_Event_Category", "Category", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DatabaseModel", "FK_Event_Venue", "Venue")]
        public Venue Venue
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Venue>("DatabaseModel.FK_Event_Venue", "Venue").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Venue>("DatabaseModel.FK_Event_Venue", "Venue").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Venue> VenueReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Venue>("DatabaseModel.FK_Event_Venue", "Venue");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Venue>("DatabaseModel.FK_Event_Venue", "Venue", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DatabaseModel", "FK_RegisteredEvents_Event", "RegisteredEvent")]
        public EntityCollection<RegisteredEvent> RegisteredEvents
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<RegisteredEvent>("DatabaseModel.FK_RegisteredEvents_Event", "RegisteredEvent");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<RegisteredEvent>("DatabaseModel.FK_RegisteredEvents_Event", "RegisteredEvent", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DatabaseModel", Name="RegisteredEvent")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class RegisteredEvent : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new RegisteredEvent object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="eventId">Initial value of the EventId property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="emailAddress">Initial value of the EmailAddress property.</param>
        public static RegisteredEvent CreateRegisteredEvent(global::System.Int32 id, global::System.Int32 eventId, global::System.String firstName, global::System.String lastName, global::System.String emailAddress)
        {
            RegisteredEvent registeredEvent = new RegisteredEvent();
            registeredEvent.Id = id;
            registeredEvent.EventId = eventId;
            registeredEvent.FirstName = firstName;
            registeredEvent.LastName = lastName;
            registeredEvent.EmailAddress = emailAddress;
            return registeredEvent;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EventId
        {
            get
            {
                return _EventId;
            }
            set
            {
                OnEventIdChanging(value);
                ReportPropertyChanging("EventId");
                _EventId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EventId");
                OnEventIdChanged();
            }
        }
        private global::System.Int32 _EventId;
        partial void OnEventIdChanging(global::System.Int32 value);
        partial void OnEventIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                OnEmailAddressChanging(value);
                ReportPropertyChanging("EmailAddress");
                _EmailAddress = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("EmailAddress");
                OnEmailAddressChanged();
            }
        }
        private global::System.String _EmailAddress;
        partial void OnEmailAddressChanging(global::System.String value);
        partial void OnEmailAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> Won
        {
            get
            {
                return _Won;
            }
            set
            {
                OnWonChanging(value);
                ReportPropertyChanging("Won");
                _Won = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Won");
                OnWonChanged();
            }
        }
        private Nullable<global::System.Boolean> _Won;
        partial void OnWonChanging(Nullable<global::System.Boolean> value);
        partial void OnWonChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DatabaseModel", "FK_RegisteredEvents_Event", "Event")]
        public Event Event
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Event>("DatabaseModel.FK_RegisteredEvents_Event", "Event").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Event>("DatabaseModel.FK_RegisteredEvents_Event", "Event").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Event> EventReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Event>("DatabaseModel.FK_RegisteredEvents_Event", "Event");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Event>("DatabaseModel.FK_RegisteredEvents_Event", "Event", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DatabaseModel", Name="Venue")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Venue : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Venue object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="location">Initial value of the Location property.</param>
        public static Venue CreateVenue(global::System.Int32 id, global::System.String name, global::System.String location)
        {
            Venue venue = new Venue();
            venue.Id = id;
            venue.Name = name;
            venue.Location = location;
            return venue;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Location
        {
            get
            {
                return _Location;
            }
            set
            {
                OnLocationChanging(value);
                ReportPropertyChanging("Location");
                _Location = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Location");
                OnLocationChanged();
            }
        }
        private global::System.String _Location;
        partial void OnLocationChanging(global::System.String value);
        partial void OnLocationChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DatabaseModel", "FK_Event_Venue", "Event")]
        public EntityCollection<Event> Events
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Event>("DatabaseModel.FK_Event_Venue", "Event");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Event>("DatabaseModel.FK_Event_Venue", "Event", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
