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

namespace _21110635_Linq2SQL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Linq2Sql")]
	public partial class _21110635_NvTableDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertQLNVien(QLNVien instance);
    partial void UpdateQLNVien(QLNVien instance);
    partial void DeleteQLNVien(QLNVien instance);
    #endregion
		
		public _21110635_NvTableDataContext() : 
				base(global::_21110635_Linq2SQL.Properties.Settings.Default.Linq2SqlConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public _21110635_NvTableDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public _21110635_NvTableDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public _21110635_NvTableDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public _21110635_NvTableDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<QLNVien> QLNViens
		{
			get
			{
				return this.GetTable<QLNVien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QLNVien")]
	public partial class QLNVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _emID;
		
		private string _Name;
		
		private string _Dept;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnemIDChanging(string value);
    partial void OnemIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDeptChanging(string value);
    partial void OnDeptChanged();
    #endregion
		
		public QLNVien()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emID", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string emID
		{
			get
			{
				return this._emID;
			}
			set
			{
				if ((this._emID != value))
				{
					this.OnemIDChanging(value);
					this.SendPropertyChanging();
					this._emID = value;
					this.SendPropertyChanged("emID");
					this.OnemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="Char(30)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dept", DbType="Char(30)")]
		public string Dept
		{
			get
			{
				return this._Dept;
			}
			set
			{
				if ((this._Dept != value))
				{
					this.OnDeptChanging(value);
					this.SendPropertyChanging();
					this._Dept = value;
					this.SendPropertyChanged("Dept");
					this.OnDeptChanged();
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
