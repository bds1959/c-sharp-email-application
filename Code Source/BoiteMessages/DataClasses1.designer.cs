﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BoiteMessages
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="boiteMessages")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void Insertconnexion(connexion instance);
    partial void Updateconnexion(connexion instance);
    partial void Deleteconnexion(connexion instance);
    partial void Insertlog_in(log_in instance);
    partial void Updatelog_in(log_in instance);
    partial void Deletelog_in(log_in instance);
    partial void Insertmsg(msg instance);
    partial void Updatemsg(msg instance);
    partial void Deletemsg(msg instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::BoiteMessages.Properties.Settings.Default.boiteMessagesConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<connexion> connexion
		{
			get
			{
				return this.GetTable<connexion>();
			}
		}
		
		public System.Data.Linq.Table<log_in> log_in
		{
			get
			{
				return this.GetTable<log_in>();
			}
		}
		
		public System.Data.Linq.Table<msg> msg
		{
			get
			{
				return this.GetTable<msg>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.connexion")]
	public partial class connexion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _etat;
		
		private string _Dureé;
		
		private System.Nullable<System.DateTime> _DebutSession;
		
		private System.Nullable<System.DateTime> _FinSession;
		
		private string _email;
		
		private EntityRef<log_in> _log_in;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnetatChanging(string value);
    partial void OnetatChanged();
    partial void OnDureéChanging(string value);
    partial void OnDureéChanged();
    partial void OnDebutSessionChanging(System.Nullable<System.DateTime> value);
    partial void OnDebutSessionChanged();
    partial void OnFinSessionChanging(System.Nullable<System.DateTime> value);
    partial void OnFinSessionChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    #endregion
		
		public connexion()
		{
			this._log_in = default(EntityRef<log_in>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_etat", DbType="VarChar(20)")]
		public string etat
		{
			get
			{
				return this._etat;
			}
			set
			{
				if ((this._etat != value))
				{
					this.OnetatChanging(value);
					this.SendPropertyChanging();
					this._etat = value;
					this.SendPropertyChanged("etat");
					this.OnetatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dureé", DbType="VarChar(20)")]
		public string Dureé
		{
			get
			{
				return this._Dureé;
			}
			set
			{
				if ((this._Dureé != value))
				{
					this.OnDureéChanging(value);
					this.SendPropertyChanging();
					this._Dureé = value;
					this.SendPropertyChanged("Dureé");
					this.OnDureéChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DebutSession", DbType="DateTime")]
		public System.Nullable<System.DateTime> DebutSession
		{
			get
			{
				return this._DebutSession;
			}
			set
			{
				if ((this._DebutSession != value))
				{
					this.OnDebutSessionChanging(value);
					this.SendPropertyChanging();
					this._DebutSession = value;
					this.SendPropertyChanged("DebutSession");
					this.OnDebutSessionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FinSession", DbType="DateTime")]
		public System.Nullable<System.DateTime> FinSession
		{
			get
			{
				return this._FinSession;
			}
			set
			{
				if ((this._FinSession != value))
				{
					this.OnFinSessionChanging(value);
					this.SendPropertyChanging();
					this._FinSession = value;
					this.SendPropertyChanged("FinSession");
					this.OnFinSessionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(40)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					if (this._log_in.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="log_in_connexion", Storage="_log_in", ThisKey="email", OtherKey="email", IsForeignKey=true)]
		public log_in log_in
		{
			get
			{
				return this._log_in.Entity;
			}
			set
			{
				log_in previousValue = this._log_in.Entity;
				if (((previousValue != value) 
							|| (this._log_in.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._log_in.Entity = null;
						previousValue.connexion.Remove(this);
					}
					this._log_in.Entity = value;
					if ((value != null))
					{
						value.connexion.Add(this);
						this._email = value.email;
					}
					else
					{
						this._email = default(string);
					}
					this.SendPropertyChanged("log_in");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.log_in")]
	public partial class log_in : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _email;
		
		private string _mdpss;
		
		private string _username;
		
		private System.Nullable<System.DateTime> _naissance;
		
		private System.Nullable<System.DateTime> _derniereCon;
		
		private System.Nullable<System.DateTime> _dateCreation;
		
		private EntitySet<connexion> _connexion;
		
		private EntitySet<msg> _msg;
		
		private EntitySet<msg> _msg1;
		
		private EntitySet<msg> _msg2;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnmdpssChanging(string value);
    partial void OnmdpssChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnnaissanceChanging(System.Nullable<System.DateTime> value);
    partial void OnnaissanceChanged();
    partial void OnderniereConChanging(System.Nullable<System.DateTime> value);
    partial void OnderniereConChanged();
    partial void OndateCreationChanging(System.Nullable<System.DateTime> value);
    partial void OndateCreationChanged();
    #endregion
		
		public log_in()
		{
			this._connexion = new EntitySet<connexion>(new Action<connexion>(this.attach_connexion), new Action<connexion>(this.detach_connexion));
			this._msg = new EntitySet<msg>(new Action<msg>(this.attach_msg), new Action<msg>(this.detach_msg));
			this._msg1 = new EntitySet<msg>(new Action<msg>(this.attach_msg1), new Action<msg>(this.detach_msg1));
			this._msg2 = new EntitySet<msg>(new Action<msg>(this.attach_msg2), new Action<msg>(this.detach_msg2));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(40) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mdpss", DbType="VarChar(30)")]
		public string mdpss
		{
			get
			{
				return this._mdpss;
			}
			set
			{
				if ((this._mdpss != value))
				{
					this.OnmdpssChanging(value);
					this.SendPropertyChanging();
					this._mdpss = value;
					this.SendPropertyChanged("mdpss");
					this.OnmdpssChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(30)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_naissance", DbType="DateTime")]
		public System.Nullable<System.DateTime> naissance
		{
			get
			{
				return this._naissance;
			}
			set
			{
				if ((this._naissance != value))
				{
					this.OnnaissanceChanging(value);
					this.SendPropertyChanging();
					this._naissance = value;
					this.SendPropertyChanged("naissance");
					this.OnnaissanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_derniereCon", DbType="DateTime")]
		public System.Nullable<System.DateTime> derniereCon
		{
			get
			{
				return this._derniereCon;
			}
			set
			{
				if ((this._derniereCon != value))
				{
					this.OnderniereConChanging(value);
					this.SendPropertyChanging();
					this._derniereCon = value;
					this.SendPropertyChanged("derniereCon");
					this.OnderniereConChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateCreation", DbType="DateTime")]
		public System.Nullable<System.DateTime> dateCreation
		{
			get
			{
				return this._dateCreation;
			}
			set
			{
				if ((this._dateCreation != value))
				{
					this.OndateCreationChanging(value);
					this.SendPropertyChanging();
					this._dateCreation = value;
					this.SendPropertyChanged("dateCreation");
					this.OndateCreationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="log_in_connexion", Storage="_connexion", ThisKey="email", OtherKey="email")]
		public EntitySet<connexion> connexion
		{
			get
			{
				return this._connexion;
			}
			set
			{
				this._connexion.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="log_in_msg", Storage="_msg", ThisKey="email", OtherKey="emailDes")]
		public EntitySet<msg> msg
		{
			get
			{
				return this._msg;
			}
			set
			{
				this._msg.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="log_in_msg1", Storage="_msg1", ThisKey="email", OtherKey="emailExp")]
		public EntitySet<msg> msg1
		{
			get
			{
				return this._msg1;
			}
			set
			{
				this._msg1.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="log_in_msg2", Storage="_msg2", ThisKey="email", OtherKey="emailOrigin")]
		public EntitySet<msg> msg2
		{
			get
			{
				return this._msg2;
			}
			set
			{
				this._msg2.Assign(value);
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
		
		private void attach_connexion(connexion entity)
		{
			this.SendPropertyChanging();
			entity.log_in = this;
		}
		
		private void detach_connexion(connexion entity)
		{
			this.SendPropertyChanging();
			entity.log_in = null;
		}
		
		private void attach_msg(msg entity)
		{
			this.SendPropertyChanging();
			entity.log_in = this;
		}
		
		private void detach_msg(msg entity)
		{
			this.SendPropertyChanging();
			entity.log_in = null;
		}
		
		private void attach_msg1(msg entity)
		{
			this.SendPropertyChanging();
			entity.log_in1 = this;
		}
		
		private void detach_msg1(msg entity)
		{
			this.SendPropertyChanging();
			entity.log_in1 = null;
		}
		
		private void attach_msg2(msg entity)
		{
			this.SendPropertyChanging();
			entity.log_in2 = this;
		}
		
		private void detach_msg2(msg entity)
		{
			this.SendPropertyChanging();
			entity.log_in2 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.msg")]
	public partial class msg : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private short _id;
		
		private string _titre;
		
		private string _corps;
		
		private System.Nullable<short> _imp;
		
		private System.Nullable<short> _lu;
		
		private System.Nullable<short> _supp;
		
		private System.Nullable<System.DateTime> _datee;
		
		private string _emailOrigin;
		
		private string _emailExp;
		
		private string _emailDes;
		
		private EntityRef<log_in> _log_in;
		
		private EntityRef<log_in> _log_in1;
		
		private EntityRef<log_in> _log_in2;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(short value);
    partial void OnidChanged();
    partial void OntitreChanging(string value);
    partial void OntitreChanged();
    partial void OncorpsChanging(string value);
    partial void OncorpsChanged();
    partial void OnimpChanging(System.Nullable<short> value);
    partial void OnimpChanged();
    partial void OnluChanging(System.Nullable<short> value);
    partial void OnluChanged();
    partial void OnsuppChanging(System.Nullable<short> value);
    partial void OnsuppChanged();
    partial void OndateeChanging(System.Nullable<System.DateTime> value);
    partial void OndateeChanged();
    partial void OnemailOriginChanging(string value);
    partial void OnemailOriginChanged();
    partial void OnemailExpChanging(string value);
    partial void OnemailExpChanged();
    partial void OnemailDesChanging(string value);
    partial void OnemailDesChanged();
    #endregion
		
		public msg()
		{
			this._log_in = default(EntityRef<log_in>);
			this._log_in1 = default(EntityRef<log_in>);
			this._log_in2 = default(EntityRef<log_in>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="SmallInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public short id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_titre", DbType="VarChar(100)")]
		public string titre
		{
			get
			{
				return this._titre;
			}
			set
			{
				if ((this._titre != value))
				{
					this.OntitreChanging(value);
					this.SendPropertyChanging();
					this._titre = value;
					this.SendPropertyChanged("titre");
					this.OntitreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_corps", DbType="VarChar(2000)")]
		public string corps
		{
			get
			{
				return this._corps;
			}
			set
			{
				if ((this._corps != value))
				{
					this.OncorpsChanging(value);
					this.SendPropertyChanging();
					this._corps = value;
					this.SendPropertyChanged("corps");
					this.OncorpsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imp", DbType="SmallInt")]
		public System.Nullable<short> imp
		{
			get
			{
				return this._imp;
			}
			set
			{
				if ((this._imp != value))
				{
					this.OnimpChanging(value);
					this.SendPropertyChanging();
					this._imp = value;
					this.SendPropertyChanged("imp");
					this.OnimpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lu", DbType="SmallInt")]
		public System.Nullable<short> lu
		{
			get
			{
				return this._lu;
			}
			set
			{
				if ((this._lu != value))
				{
					this.OnluChanging(value);
					this.SendPropertyChanging();
					this._lu = value;
					this.SendPropertyChanged("lu");
					this.OnluChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_supp", DbType="SmallInt")]
		public System.Nullable<short> supp
		{
			get
			{
				return this._supp;
			}
			set
			{
				if ((this._supp != value))
				{
					this.OnsuppChanging(value);
					this.SendPropertyChanging();
					this._supp = value;
					this.SendPropertyChanged("supp");
					this.OnsuppChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datee", DbType="DateTime")]
		public System.Nullable<System.DateTime> datee
		{
			get
			{
				return this._datee;
			}
			set
			{
				if ((this._datee != value))
				{
					this.OndateeChanging(value);
					this.SendPropertyChanging();
					this._datee = value;
					this.SendPropertyChanged("datee");
					this.OndateeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emailOrigin", DbType="VarChar(40)")]
		public string emailOrigin
		{
			get
			{
				return this._emailOrigin;
			}
			set
			{
				if ((this._emailOrigin != value))
				{
					if (this._log_in2.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnemailOriginChanging(value);
					this.SendPropertyChanging();
					this._emailOrigin = value;
					this.SendPropertyChanged("emailOrigin");
					this.OnemailOriginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emailExp", DbType="VarChar(40)")]
		public string emailExp
		{
			get
			{
				return this._emailExp;
			}
			set
			{
				if ((this._emailExp != value))
				{
					if (this._log_in1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnemailExpChanging(value);
					this.SendPropertyChanging();
					this._emailExp = value;
					this.SendPropertyChanged("emailExp");
					this.OnemailExpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emailDes", DbType="VarChar(40)")]
		public string emailDes
		{
			get
			{
				return this._emailDes;
			}
			set
			{
				if ((this._emailDes != value))
				{
					if (this._log_in.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnemailDesChanging(value);
					this.SendPropertyChanging();
					this._emailDes = value;
					this.SendPropertyChanged("emailDes");
					this.OnemailDesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="log_in_msg", Storage="_log_in", ThisKey="emailDes", OtherKey="email", IsForeignKey=true)]
		public log_in log_in
		{
			get
			{
				return this._log_in.Entity;
			}
			set
			{
				log_in previousValue = this._log_in.Entity;
				if (((previousValue != value) 
							|| (this._log_in.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._log_in.Entity = null;
						previousValue.msg.Remove(this);
					}
					this._log_in.Entity = value;
					if ((value != null))
					{
						value.msg.Add(this);
						this._emailDes = value.email;
					}
					else
					{
						this._emailDes = default(string);
					}
					this.SendPropertyChanged("log_in");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="log_in_msg1", Storage="_log_in1", ThisKey="emailExp", OtherKey="email", IsForeignKey=true)]
		public log_in log_in1
		{
			get
			{
				return this._log_in1.Entity;
			}
			set
			{
				log_in previousValue = this._log_in1.Entity;
				if (((previousValue != value) 
							|| (this._log_in1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._log_in1.Entity = null;
						previousValue.msg1.Remove(this);
					}
					this._log_in1.Entity = value;
					if ((value != null))
					{
						value.msg1.Add(this);
						this._emailExp = value.email;
					}
					else
					{
						this._emailExp = default(string);
					}
					this.SendPropertyChanged("log_in1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="log_in_msg2", Storage="_log_in2", ThisKey="emailOrigin", OtherKey="email", IsForeignKey=true)]
		public log_in log_in2
		{
			get
			{
				return this._log_in2.Entity;
			}
			set
			{
				log_in previousValue = this._log_in2.Entity;
				if (((previousValue != value) 
							|| (this._log_in2.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._log_in2.Entity = null;
						previousValue.msg2.Remove(this);
					}
					this._log_in2.Entity = value;
					if ((value != null))
					{
						value.msg2.Add(this);
						this._emailOrigin = value.email;
					}
					else
					{
						this._emailOrigin = default(string);
					}
					this.SendPropertyChanged("log_in2");
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
}
#pragma warning restore 1591
