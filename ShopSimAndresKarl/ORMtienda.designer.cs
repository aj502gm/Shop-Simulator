﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopSimAndresKarl
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="miniStoreV2")]
	public partial class ORMtiendaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertbugsReport(bugsReport instance);
    partial void UpdatebugsReport(bugsReport instance);
    partial void DeletebugsReport(bugsReport instance);
    partial void InsertOrders(Orders instance);
    partial void UpdateOrders(Orders instance);
    partial void DeleteOrders(Orders instance);
    partial void InsertOrders_Details(Orders_Details instance);
    partial void UpdateOrders_Details(Orders_Details instance);
    partial void DeleteOrders_Details(Orders_Details instance);
    partial void InsertProducts(Products instance);
    partial void UpdateProducts(Products instance);
    partial void DeleteProducts(Products instance);
    partial void InsertUsers(Users instance);
    partial void UpdateUsers(Users instance);
    partial void DeleteUsers(Users instance);
    #endregion
		
		public ORMtiendaDataContext() : 
				base(global::ShopSimAndresKarl.Properties.Settings.Default.miniStoreV2ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ORMtiendaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ORMtiendaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ORMtiendaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ORMtiendaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<bugsReport> bugsReport
		{
			get
			{
				return this.GetTable<bugsReport>();
			}
		}
		
		public System.Data.Linq.Table<Orders> Orders
		{
			get
			{
				return this.GetTable<Orders>();
			}
		}
		
		public System.Data.Linq.Table<Orders_Details> Orders_Details
		{
			get
			{
				return this.GetTable<Orders_Details>();
			}
		}
		
		public System.Data.Linq.Table<Products> Products
		{
			get
			{
				return this.GetTable<Products>();
			}
		}
		
		public System.Data.Linq.Table<Users> Users
		{
			get
			{
				return this.GetTable<Users>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.bugsReport")]
	public partial class bugsReport : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _reportID;
		
		private System.Nullable<int> _userID;
		
		private string _problemDescription;
		
		private System.Nullable<int> _isFixed;
		
		private EntityRef<Users> _Users;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnreportIDChanging(int value);
    partial void OnreportIDChanged();
    partial void OnuserIDChanging(System.Nullable<int> value);
    partial void OnuserIDChanged();
    partial void OnproblemDescriptionChanging(string value);
    partial void OnproblemDescriptionChanged();
    partial void OnisFixedChanging(System.Nullable<int> value);
    partial void OnisFixedChanged();
    #endregion
		
		public bugsReport()
		{
			this._Users = default(EntityRef<Users>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_reportID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int reportID
		{
			get
			{
				return this._reportID;
			}
			set
			{
				if ((this._reportID != value))
				{
					this.OnreportIDChanging(value);
					this.SendPropertyChanging();
					this._reportID = value;
					this.SendPropertyChanged("reportID");
					this.OnreportIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", DbType="Int")]
		public System.Nullable<int> userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					if (this._Users.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_problemDescription", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string problemDescription
		{
			get
			{
				return this._problemDescription;
			}
			set
			{
				if ((this._problemDescription != value))
				{
					this.OnproblemDescriptionChanging(value);
					this.SendPropertyChanging();
					this._problemDescription = value;
					this.SendPropertyChanged("problemDescription");
					this.OnproblemDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isFixed", DbType="Int")]
		public System.Nullable<int> isFixed
		{
			get
			{
				return this._isFixed;
			}
			set
			{
				if ((this._isFixed != value))
				{
					this.OnisFixedChanging(value);
					this.SendPropertyChanging();
					this._isFixed = value;
					this.SendPropertyChanged("isFixed");
					this.OnisFixedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Users_bugsReport", Storage="_Users", ThisKey="userID", OtherKey="userID", IsForeignKey=true)]
		public Users Users
		{
			get
			{
				return this._Users.Entity;
			}
			set
			{
				Users previousValue = this._Users.Entity;
				if (((previousValue != value) 
							|| (this._Users.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Users.Entity = null;
						previousValue.bugsReport.Remove(this);
					}
					this._Users.Entity = value;
					if ((value != null))
					{
						value.bugsReport.Add(this);
						this._userID = value.userID;
					}
					else
					{
						this._userID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Users");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Orders")]
	public partial class Orders : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _orderID;
		
		private System.Nullable<int> _userID;
		
		private System.Nullable<double> _total;
		
		private EntitySet<Orders_Details> _Orders_Details;
		
		private EntityRef<Users> _Users;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnorderIDChanging(int value);
    partial void OnorderIDChanged();
    partial void OnuserIDChanging(System.Nullable<int> value);
    partial void OnuserIDChanged();
    partial void OntotalChanging(System.Nullable<double> value);
    partial void OntotalChanged();
    #endregion
		
		public Orders()
		{
			this._Orders_Details = new EntitySet<Orders_Details>(new Action<Orders_Details>(this.attach_Orders_Details), new Action<Orders_Details>(this.detach_Orders_Details));
			this._Users = default(EntityRef<Users>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int orderID
		{
			get
			{
				return this._orderID;
			}
			set
			{
				if ((this._orderID != value))
				{
					this.OnorderIDChanging(value);
					this.SendPropertyChanging();
					this._orderID = value;
					this.SendPropertyChanged("orderID");
					this.OnorderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", DbType="Int")]
		public System.Nullable<int> userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					if (this._Users.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_total", DbType="Float")]
		public System.Nullable<double> total
		{
			get
			{
				return this._total;
			}
			set
			{
				if ((this._total != value))
				{
					this.OntotalChanging(value);
					this.SendPropertyChanging();
					this._total = value;
					this.SendPropertyChanged("total");
					this.OntotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Orders_Orders_Details", Storage="_Orders_Details", ThisKey="orderID", OtherKey="orderID")]
		public EntitySet<Orders_Details> Orders_Details
		{
			get
			{
				return this._Orders_Details;
			}
			set
			{
				this._Orders_Details.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Users_Orders", Storage="_Users", ThisKey="userID", OtherKey="userID", IsForeignKey=true)]
		public Users Users
		{
			get
			{
				return this._Users.Entity;
			}
			set
			{
				Users previousValue = this._Users.Entity;
				if (((previousValue != value) 
							|| (this._Users.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Users.Entity = null;
						previousValue.Orders.Remove(this);
					}
					this._Users.Entity = value;
					if ((value != null))
					{
						value.Orders.Add(this);
						this._userID = value.userID;
					}
					else
					{
						this._userID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Users");
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
		
		private void attach_Orders_Details(Orders_Details entity)
		{
			this.SendPropertyChanging();
			entity.Orders = this;
		}
		
		private void detach_Orders_Details(Orders_Details entity)
		{
			this.SendPropertyChanging();
			entity.Orders = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Orders_Details")]
	public partial class Orders_Details : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idRandom;
		
		private System.Nullable<int> _orderID;
		
		private string _productID;
		
		private System.Nullable<int> _quantity;
		
		private System.Nullable<double> _subtotal;
		
		private EntityRef<Orders> _Orders;
		
		private EntityRef<Products> _Products;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidRandomChanging(int value);
    partial void OnidRandomChanged();
    partial void OnorderIDChanging(System.Nullable<int> value);
    partial void OnorderIDChanged();
    partial void OnproductIDChanging(string value);
    partial void OnproductIDChanged();
    partial void OnquantityChanging(System.Nullable<int> value);
    partial void OnquantityChanged();
    partial void OnsubtotalChanging(System.Nullable<double> value);
    partial void OnsubtotalChanged();
		#endregion

		public Orders_Details(int ID, string prod, int quan, double sub)
		{
			this.orderID = ID;
			this.productID = prod;
			this.quantity = quan;
			this.subtotal = sub;
		}

		public Orders_Details()
		{
			this._Orders = default(EntityRef<Orders>);
			this._Products = default(EntityRef<Products>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idRandom", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idRandom
		{
			get
			{
				return this._idRandom;
			}
			set
			{
				if ((this._idRandom != value))
				{
					this.OnidRandomChanging(value);
					this.SendPropertyChanging();
					this._idRandom = value;
					this.SendPropertyChanged("idRandom");
					this.OnidRandomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderID", DbType="Int")]
		public System.Nullable<int> orderID
		{
			get
			{
				return this._orderID;
			}
			set
			{
				if ((this._orderID != value))
				{
					if (this._Orders.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnorderIDChanging(value);
					this.SendPropertyChanging();
					this._orderID = value;
					this.SendPropertyChanged("orderID");
					this.OnorderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productID", DbType="VarChar(10)")]
		public string productID
		{
			get
			{
				return this._productID;
			}
			set
			{
				if ((this._productID != value))
				{
					if (this._Products.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnproductIDChanging(value);
					this.SendPropertyChanging();
					this._productID = value;
					this.SendPropertyChanged("productID");
					this.OnproductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int")]
		public System.Nullable<int> quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subtotal", DbType="Float")]
		public System.Nullable<double> subtotal
		{
			get
			{
				return this._subtotal;
			}
			set
			{
				if ((this._subtotal != value))
				{
					this.OnsubtotalChanging(value);
					this.SendPropertyChanging();
					this._subtotal = value;
					this.SendPropertyChanged("subtotal");
					this.OnsubtotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Orders_Orders_Details", Storage="_Orders", ThisKey="orderID", OtherKey="orderID", IsForeignKey=true)]
		public Orders Orders
		{
			get
			{
				return this._Orders.Entity;
			}
			set
			{
				Orders previousValue = this._Orders.Entity;
				if (((previousValue != value) 
							|| (this._Orders.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Orders.Entity = null;
						previousValue.Orders_Details.Remove(this);
					}
					this._Orders.Entity = value;
					if ((value != null))
					{
						value.Orders_Details.Add(this);
						this._orderID = value.orderID;
					}
					else
					{
						this._orderID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Orders");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Products_Orders_Details", Storage="_Products", ThisKey="productID", OtherKey="productID", IsForeignKey=true)]
		public Products Products
		{
			get
			{
				return this._Products.Entity;
			}
			set
			{
				Products previousValue = this._Products.Entity;
				if (((previousValue != value) 
							|| (this._Products.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Products.Entity = null;
						previousValue.Orders_Details.Remove(this);
					}
					this._Products.Entity = value;
					if ((value != null))
					{
						value.Orders_Details.Add(this);
						this._productID = value.productID;
					}
					else
					{
						this._productID = default(string);
					}
					this.SendPropertyChanged("Products");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products")]
	public partial class Products : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _productID;
		
		private string _productName;
		
		private System.Nullable<double> _unitPrice;
		
		private string _productDescription;
		
		private EntitySet<Orders_Details> _Orders_Details;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnproductIDChanging(string value);
    partial void OnproductIDChanged();
    partial void OnproductNameChanging(string value);
    partial void OnproductNameChanged();
    partial void OnunitPriceChanging(System.Nullable<double> value);
    partial void OnunitPriceChanged();
    partial void OnproductDescriptionChanging(string value);
    partial void OnproductDescriptionChanged();
    #endregion
		
		public Products()
		{
			this._Orders_Details = new EntitySet<Orders_Details>(new Action<Orders_Details>(this.attach_Orders_Details), new Action<Orders_Details>(this.detach_Orders_Details));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productID", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string productID
		{
			get
			{
				return this._productID;
			}
			set
			{
				if ((this._productID != value))
				{
					this.OnproductIDChanging(value);
					this.SendPropertyChanging();
					this._productID = value;
					this.SendPropertyChanged("productID");
					this.OnproductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productName", DbType="VarChar(30)")]
		public string productName
		{
			get
			{
				return this._productName;
			}
			set
			{
				if ((this._productName != value))
				{
					this.OnproductNameChanging(value);
					this.SendPropertyChanging();
					this._productName = value;
					this.SendPropertyChanged("productName");
					this.OnproductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_unitPrice", DbType="Float")]
		public System.Nullable<double> unitPrice
		{
			get
			{
				return this._unitPrice;
			}
			set
			{
				if ((this._unitPrice != value))
				{
					this.OnunitPriceChanging(value);
					this.SendPropertyChanging();
					this._unitPrice = value;
					this.SendPropertyChanged("unitPrice");
					this.OnunitPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productDescription", DbType="VarChar(20)")]
		public string productDescription
		{
			get
			{
				return this._productDescription;
			}
			set
			{
				if ((this._productDescription != value))
				{
					this.OnproductDescriptionChanging(value);
					this.SendPropertyChanging();
					this._productDescription = value;
					this.SendPropertyChanged("productDescription");
					this.OnproductDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Products_Orders_Details", Storage="_Orders_Details", ThisKey="productID", OtherKey="productID")]
		public EntitySet<Orders_Details> Orders_Details
		{
			get
			{
				return this._Orders_Details;
			}
			set
			{
				this._Orders_Details.Assign(value);
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
		
		private void attach_Orders_Details(Orders_Details entity)
		{
			this.SendPropertyChanging();
			entity.Products = this;
		}
		
		private void detach_Orders_Details(Orders_Details entity)
		{
			this.SendPropertyChanging();
			entity.Products = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class Users : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _userID;
		
		private string _userName;
		
		private string _personalPassword;
		
		private EntitySet<bugsReport> _bugsReport;
		
		private EntitySet<Orders> _Orders;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserIDChanging(int value);
    partial void OnuserIDChanged();
    partial void OnuserNameChanging(string value);
    partial void OnuserNameChanged();
    partial void OnpersonalPasswordChanging(string value);
    partial void OnpersonalPasswordChanged();
    #endregion
		
		public Users()
		{
			this._bugsReport = new EntitySet<bugsReport>(new Action<bugsReport>(this.attach_bugsReport), new Action<bugsReport>(this.detach_bugsReport));
			this._Orders = new EntitySet<Orders>(new Action<Orders>(this.attach_Orders), new Action<Orders>(this.detach_Orders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userName", DbType="VarChar(25)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_personalPassword", DbType="VarChar(30)")]
		public string personalPassword
		{
			get
			{
				return this._personalPassword;
			}
			set
			{
				if ((this._personalPassword != value))
				{
					this.OnpersonalPasswordChanging(value);
					this.SendPropertyChanging();
					this._personalPassword = value;
					this.SendPropertyChanged("personalPassword");
					this.OnpersonalPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Users_bugsReport", Storage="_bugsReport", ThisKey="userID", OtherKey="userID")]
		public EntitySet<bugsReport> bugsReport
		{
			get
			{
				return this._bugsReport;
			}
			set
			{
				this._bugsReport.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Users_Orders", Storage="_Orders", ThisKey="userID", OtherKey="userID")]
		public EntitySet<Orders> Orders
		{
			get
			{
				return this._Orders;
			}
			set
			{
				this._Orders.Assign(value);
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
		
		private void attach_bugsReport(bugsReport entity)
		{
			this.SendPropertyChanging();
			entity.Users = this;
		}
		
		private void detach_bugsReport(bugsReport entity)
		{
			this.SendPropertyChanging();
			entity.Users = null;
		}
		
		private void attach_Orders(Orders entity)
		{
			this.SendPropertyChanging();
			entity.Users = this;
		}
		
		private void detach_Orders(Orders entity)
		{
			this.SendPropertyChanging();
			entity.Users = null;
		}
	}
}
#pragma warning restore 1591
