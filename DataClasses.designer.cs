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

namespace BloodBankWithUnitTesting
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="G:\\VISUALSTUDIOCODES\\BLOODBANK\\BLOODBANKWITHUNITTESTING\\BLOODBANKWITHUNITTESTING\\" +
		"APP_DATA\\BLOODBANKDATABASE.MDF")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertbloodDonateRecord(bloodDonateRecord instance);
    partial void UpdatebloodDonateRecord(bloodDonateRecord instance);
    partial void DeletebloodDonateRecord(bloodDonateRecord instance);
    partial void Insertuser_login(user_login instance);
    partial void Updateuser_login(user_login instance);
    partial void Deleteuser_login(user_login instance);
    partial void Insertuser_notification(user_notification instance);
    partial void Updateuser_notification(user_notification instance);
    partial void Deleteuser_notification(user_notification instance);
    partial void Insertuser_profile_info(user_profile_info instance);
    partial void Updateuser_profile_info(user_profile_info instance);
    partial void Deleteuser_profile_info(user_profile_info instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["G__VISUALSTUDIOCODES_BLOODBANK_BLOODBANKWITHUNITTESTING_BLOODBANKWITHUNITTESTING_" +
						"APP_DATA_BLOODBANKDATABASE_MDFConnectio"].ConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<bloodDonateRecord> bloodDonateRecords
		{
			get
			{
				return this.GetTable<bloodDonateRecord>();
			}
		}
		
		public System.Data.Linq.Table<user_login> user_logins
		{
			get
			{
				return this.GetTable<user_login>();
			}
		}
		
		public System.Data.Linq.Table<user_notification> user_notifications
		{
			get
			{
				return this.GetTable<user_notification>();
			}
		}
		
		public System.Data.Linq.Table<user_profile_info> user_profile_infos
		{
			get
			{
				return this.GetTable<user_profile_info>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.bloodDonateRecords")]
	public partial class bloodDonateRecord : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _recordNo;
		
		private string _donor_id;
		
		private string _client_id;
		
		private string _blood_group;
		
		private System.Data.Linq.Binary _donationDate;
		
		private EntityRef<user_profile_info> _user_profile_info;
		
		private EntityRef<user_profile_info> _user_profile_info1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnrecordNoChanging(string value);
    partial void OnrecordNoChanged();
    partial void Ondonor_idChanging(string value);
    partial void Ondonor_idChanged();
    partial void Onclient_idChanging(string value);
    partial void Onclient_idChanged();
    partial void Onblood_groupChanging(string value);
    partial void Onblood_groupChanged();
    partial void OndonationDateChanging(System.Data.Linq.Binary value);
    partial void OndonationDateChanged();
    #endregion
		
		public bloodDonateRecord()
		{
			this._user_profile_info = default(EntityRef<user_profile_info>);
			this._user_profile_info1 = default(EntityRef<user_profile_info>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_recordNo", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public string recordNo
		{
			get
			{
				return this._recordNo;
			}
			set
			{
				if ((this._recordNo != value))
				{
					this.OnrecordNoChanging(value);
					this.SendPropertyChanging();
					this._recordNo = value;
					this.SendPropertyChanged("recordNo");
					this.OnrecordNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_donor_id", DbType="VarChar(20)", UpdateCheck=UpdateCheck.Never)]
		public string donor_id
		{
			get
			{
				return this._donor_id;
			}
			set
			{
				if ((this._donor_id != value))
				{
					if (this._user_profile_info1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Ondonor_idChanging(value);
					this.SendPropertyChanging();
					this._donor_id = value;
					this.SendPropertyChanged("donor_id");
					this.Ondonor_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_client_id", DbType="VarChar(20)", UpdateCheck=UpdateCheck.Never)]
		public string client_id
		{
			get
			{
				return this._client_id;
			}
			set
			{
				if ((this._client_id != value))
				{
					if (this._user_profile_info.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onclient_idChanging(value);
					this.SendPropertyChanging();
					this._client_id = value;
					this.SendPropertyChanged("client_id");
					this.Onclient_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_blood_group", DbType="VarChar(20)", UpdateCheck=UpdateCheck.Never)]
		public string blood_group
		{
			get
			{
				return this._blood_group;
			}
			set
			{
				if ((this._blood_group != value))
				{
					this.Onblood_groupChanging(value);
					this.SendPropertyChanging();
					this._blood_group = value;
					this.SendPropertyChanged("blood_group");
					this.Onblood_groupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_donationDate", AutoSync=AutoSync.Always, DbType="rowversion NOT NULL", CanBeNull=false, IsDbGenerated=true, IsVersion=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary donationDate
		{
			get
			{
				return this._donationDate;
			}
			set
			{
				if ((this._donationDate != value))
				{
					this.OndonationDateChanging(value);
					this.SendPropertyChanging();
					this._donationDate = value;
					this.SendPropertyChanged("donationDate");
					this.OndonationDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_profile_info_bloodDonateRecord", Storage="_user_profile_info", ThisKey="client_id", OtherKey="user_PID", IsForeignKey=true)]
		public user_profile_info user_profile_info
		{
			get
			{
				return this._user_profile_info.Entity;
			}
			set
			{
				user_profile_info previousValue = this._user_profile_info.Entity;
				if (((previousValue != value) 
							|| (this._user_profile_info.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user_profile_info.Entity = null;
						previousValue.bloodDonateRecords.Remove(this);
					}
					this._user_profile_info.Entity = value;
					if ((value != null))
					{
						value.bloodDonateRecords.Add(this);
						this._client_id = value.user_PID;
					}
					else
					{
						this._client_id = default(string);
					}
					this.SendPropertyChanged("user_profile_info");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_profile_info_bloodDonateRecord1", Storage="_user_profile_info1", ThisKey="donor_id", OtherKey="user_PID", IsForeignKey=true)]
		public user_profile_info user_profile_info1
		{
			get
			{
				return this._user_profile_info1.Entity;
			}
			set
			{
				user_profile_info previousValue = this._user_profile_info1.Entity;
				if (((previousValue != value) 
							|| (this._user_profile_info1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user_profile_info1.Entity = null;
						previousValue.bloodDonateRecords1.Remove(this);
					}
					this._user_profile_info1.Entity = value;
					if ((value != null))
					{
						value.bloodDonateRecords1.Add(this);
						this._donor_id = value.user_PID;
					}
					else
					{
						this._donor_id = default(string);
					}
					this.SendPropertyChanged("user_profile_info1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.user_login")]
	public partial class user_login : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _user_mail;
		
		private string _user_pass;
		
		private System.Nullable<System.DateTime> _reg_date;
		
		private string _activity;
		
		private EntitySet<user_profile_info> _user_profile_infos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onuser_mailChanging(string value);
    partial void Onuser_mailChanged();
    partial void Onuser_passChanging(string value);
    partial void Onuser_passChanged();
    partial void Onreg_dateChanging(System.Nullable<System.DateTime> value);
    partial void Onreg_dateChanged();
    partial void OnactivityChanging(string value);
    partial void OnactivityChanged();
    #endregion
		
		public user_login()
		{
			this._user_profile_infos = new EntitySet<user_profile_info>(new Action<user_profile_info>(this.attach_user_profile_infos), new Action<user_profile_info>(this.detach_user_profile_infos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_mail", DbType="VarChar(36) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string user_mail
		{
			get
			{
				return this._user_mail;
			}
			set
			{
				if ((this._user_mail != value))
				{
					this.Onuser_mailChanging(value);
					this.SendPropertyChanging();
					this._user_mail = value;
					this.SendPropertyChanged("user_mail");
					this.Onuser_mailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_pass", DbType="VarChar(32)")]
		public string user_pass
		{
			get
			{
				return this._user_pass;
			}
			set
			{
				if ((this._user_pass != value))
				{
					this.Onuser_passChanging(value);
					this.SendPropertyChanging();
					this._user_pass = value;
					this.SendPropertyChanged("user_pass");
					this.Onuser_passChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_reg_date", DbType="Date")]
		public System.Nullable<System.DateTime> reg_date
		{
			get
			{
				return this._reg_date;
			}
			set
			{
				if ((this._reg_date != value))
				{
					this.Onreg_dateChanging(value);
					this.SendPropertyChanging();
					this._reg_date = value;
					this.SendPropertyChanged("reg_date");
					this.Onreg_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_activity", DbType="VarChar(3)")]
		public string activity
		{
			get
			{
				return this._activity;
			}
			set
			{
				if ((this._activity != value))
				{
					this.OnactivityChanging(value);
					this.SendPropertyChanging();
					this._activity = value;
					this.SendPropertyChanged("activity");
					this.OnactivityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_login_user_profile_info", Storage="_user_profile_infos", ThisKey="user_mail", OtherKey="userMail")]
		public EntitySet<user_profile_info> user_profile_infos
		{
			get
			{
				return this._user_profile_infos;
			}
			set
			{
				this._user_profile_infos.Assign(value);
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
		
		private void attach_user_profile_infos(user_profile_info entity)
		{
			this.SendPropertyChanging();
			entity.user_login = this;
		}
		
		private void detach_user_profile_infos(user_profile_info entity)
		{
			this.SendPropertyChanging();
			entity.user_login = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.user_notification")]
	public partial class user_notification : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _notificationId;
		
		private string _userId;
		
		private System.Data.Linq.Binary _notificationTime;
		
		private string _messange;
		
		private EntityRef<user_profile_info> _user_profile_info;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnotificationIdChanging(string value);
    partial void OnnotificationIdChanged();
    partial void OnuserIdChanging(string value);
    partial void OnuserIdChanged();
    partial void OnnotificationTimeChanging(System.Data.Linq.Binary value);
    partial void OnnotificationTimeChanged();
    partial void OnmessangeChanging(string value);
    partial void OnmessangeChanged();
    #endregion
		
		public user_notification()
		{
			this._user_profile_info = default(EntityRef<user_profile_info>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_notificationId", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public string notificationId
		{
			get
			{
				return this._notificationId;
			}
			set
			{
				if ((this._notificationId != value))
				{
					this.OnnotificationIdChanging(value);
					this.SendPropertyChanging();
					this._notificationId = value;
					this.SendPropertyChanged("notificationId");
					this.OnnotificationIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userId", DbType="VarChar(20)", UpdateCheck=UpdateCheck.Never)]
		public string userId
		{
			get
			{
				return this._userId;
			}
			set
			{
				if ((this._userId != value))
				{
					if (this._user_profile_info.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuserIdChanging(value);
					this.SendPropertyChanging();
					this._userId = value;
					this.SendPropertyChanged("userId");
					this.OnuserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_notificationTime", AutoSync=AutoSync.Always, DbType="rowversion NOT NULL", CanBeNull=false, IsDbGenerated=true, IsVersion=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary notificationTime
		{
			get
			{
				return this._notificationTime;
			}
			set
			{
				if ((this._notificationTime != value))
				{
					this.OnnotificationTimeChanging(value);
					this.SendPropertyChanging();
					this._notificationTime = value;
					this.SendPropertyChanged("notificationTime");
					this.OnnotificationTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_messange", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string messange
		{
			get
			{
				return this._messange;
			}
			set
			{
				if ((this._messange != value))
				{
					this.OnmessangeChanging(value);
					this.SendPropertyChanging();
					this._messange = value;
					this.SendPropertyChanged("messange");
					this.OnmessangeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_profile_info_user_notification", Storage="_user_profile_info", ThisKey="userId", OtherKey="user_PID", IsForeignKey=true)]
		public user_profile_info user_profile_info
		{
			get
			{
				return this._user_profile_info.Entity;
			}
			set
			{
				user_profile_info previousValue = this._user_profile_info.Entity;
				if (((previousValue != value) 
							|| (this._user_profile_info.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user_profile_info.Entity = null;
						previousValue.user_notifications.Remove(this);
					}
					this._user_profile_info.Entity = value;
					if ((value != null))
					{
						value.user_notifications.Add(this);
						this._userId = value.user_PID;
					}
					else
					{
						this._userId = default(string);
					}
					this.SendPropertyChanged("user_profile_info");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.user_profile_info")]
	public partial class user_profile_info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _user_PID;
		
		private string _userName;
		
		private string _userMail;
		
		private System.Nullable<System.DateTime> _dob;
		
		private string _userAddress;
		
		private string _gender;
		
		private string _bloodGroup;
		
		private string _phoneNumber;
		
		private EntitySet<bloodDonateRecord> _bloodDonateRecords;
		
		private EntitySet<bloodDonateRecord> _bloodDonateRecords1;
		
		private EntitySet<user_notification> _user_notifications;
		
		private EntityRef<user_login> _user_login;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onuser_PIDChanging(string value);
    partial void Onuser_PIDChanged();
    partial void OnuserNameChanging(string value);
    partial void OnuserNameChanged();
    partial void OnuserMailChanging(string value);
    partial void OnuserMailChanged();
    partial void OndobChanging(System.Nullable<System.DateTime> value);
    partial void OndobChanged();
    partial void OnuserAddressChanging(string value);
    partial void OnuserAddressChanged();
    partial void OngenderChanging(string value);
    partial void OngenderChanged();
    partial void OnbloodGroupChanging(string value);
    partial void OnbloodGroupChanged();
    partial void OnphoneNumberChanging(string value);
    partial void OnphoneNumberChanged();
    #endregion
		
		public user_profile_info()
		{
			this._bloodDonateRecords = new EntitySet<bloodDonateRecord>(new Action<bloodDonateRecord>(this.attach_bloodDonateRecords), new Action<bloodDonateRecord>(this.detach_bloodDonateRecords));
			this._bloodDonateRecords1 = new EntitySet<bloodDonateRecord>(new Action<bloodDonateRecord>(this.attach_bloodDonateRecords1), new Action<bloodDonateRecord>(this.detach_bloodDonateRecords1));
			this._user_notifications = new EntitySet<user_notification>(new Action<user_notification>(this.attach_user_notifications), new Action<user_notification>(this.detach_user_notifications));
			this._user_login = default(EntityRef<user_login>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_PID", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string user_PID
		{
			get
			{
				return this._user_PID;
			}
			set
			{
				if ((this._user_PID != value))
				{
					this.Onuser_PIDChanging(value);
					this.SendPropertyChanging();
					this._user_PID = value;
					this.SendPropertyChanged("user_PID");
					this.Onuser_PIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userName", DbType="VarChar(32)")]
		public string userName
		{
			get
			{
				return this._userName;
			}
			set
			{
				if ((this._userName != value))
				{
					this.OnuserNameChanging(value);
					this.SendPropertyChanging();
					this._userName = value;
					this.SendPropertyChanged("userName");
					this.OnuserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userMail", DbType="VarChar(36)")]
		public string userMail
		{
			get
			{
				return this._userMail;
			}
			set
			{
				if ((this._userMail != value))
				{
					if (this._user_login.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuserMailChanging(value);
					this.SendPropertyChanging();
					this._userMail = value;
					this.SendPropertyChanged("userMail");
					this.OnuserMailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dob", DbType="Date")]
		public System.Nullable<System.DateTime> dob
		{
			get
			{
				return this._dob;
			}
			set
			{
				if ((this._dob != value))
				{
					this.OndobChanging(value);
					this.SendPropertyChanging();
					this._dob = value;
					this.SendPropertyChanged("dob");
					this.OndobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userAddress", DbType="VarChar(36)")]
		public string userAddress
		{
			get
			{
				return this._userAddress;
			}
			set
			{
				if ((this._userAddress != value))
				{
					this.OnuserAddressChanging(value);
					this.SendPropertyChanging();
					this._userAddress = value;
					this.SendPropertyChanged("userAddress");
					this.OnuserAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="VarChar(8)")]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bloodGroup", DbType="VarChar(4)")]
		public string bloodGroup
		{
			get
			{
				return this._bloodGroup;
			}
			set
			{
				if ((this._bloodGroup != value))
				{
					this.OnbloodGroupChanging(value);
					this.SendPropertyChanging();
					this._bloodGroup = value;
					this.SendPropertyChanged("bloodGroup");
					this.OnbloodGroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phoneNumber", DbType="VarChar(10)")]
		public string phoneNumber
		{
			get
			{
				return this._phoneNumber;
			}
			set
			{
				if ((this._phoneNumber != value))
				{
					this.OnphoneNumberChanging(value);
					this.SendPropertyChanging();
					this._phoneNumber = value;
					this.SendPropertyChanged("phoneNumber");
					this.OnphoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_profile_info_bloodDonateRecord", Storage="_bloodDonateRecords", ThisKey="user_PID", OtherKey="client_id")]
		public EntitySet<bloodDonateRecord> bloodDonateRecords
		{
			get
			{
				return this._bloodDonateRecords;
			}
			set
			{
				this._bloodDonateRecords.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_profile_info_bloodDonateRecord1", Storage="_bloodDonateRecords1", ThisKey="user_PID", OtherKey="donor_id")]
		public EntitySet<bloodDonateRecord> bloodDonateRecords1
		{
			get
			{
				return this._bloodDonateRecords1;
			}
			set
			{
				this._bloodDonateRecords1.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_profile_info_user_notification", Storage="_user_notifications", ThisKey="user_PID", OtherKey="userId")]
		public EntitySet<user_notification> user_notifications
		{
			get
			{
				return this._user_notifications;
			}
			set
			{
				this._user_notifications.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_login_user_profile_info", Storage="_user_login", ThisKey="userMail", OtherKey="user_mail", IsForeignKey=true)]
		public user_login user_login
		{
			get
			{
				return this._user_login.Entity;
			}
			set
			{
				user_login previousValue = this._user_login.Entity;
				if (((previousValue != value) 
							|| (this._user_login.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user_login.Entity = null;
						previousValue.user_profile_infos.Remove(this);
					}
					this._user_login.Entity = value;
					if ((value != null))
					{
						value.user_profile_infos.Add(this);
						this._userMail = value.user_mail;
					}
					else
					{
						this._userMail = default(string);
					}
					this.SendPropertyChanged("user_login");
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
		
		private void attach_bloodDonateRecords(bloodDonateRecord entity)
		{
			this.SendPropertyChanging();
			entity.user_profile_info = this;
		}
		
		private void detach_bloodDonateRecords(bloodDonateRecord entity)
		{
			this.SendPropertyChanging();
			entity.user_profile_info = null;
		}
		
		private void attach_bloodDonateRecords1(bloodDonateRecord entity)
		{
			this.SendPropertyChanging();
			entity.user_profile_info1 = this;
		}
		
		private void detach_bloodDonateRecords1(bloodDonateRecord entity)
		{
			this.SendPropertyChanging();
			entity.user_profile_info1 = null;
		}
		
		private void attach_user_notifications(user_notification entity)
		{
			this.SendPropertyChanging();
			entity.user_profile_info = this;
		}
		
		private void detach_user_notifications(user_notification entity)
		{
			this.SendPropertyChanging();
			entity.user_profile_info = null;
		}
	}
}
#pragma warning restore 1591
