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

namespace TrabalhoRestBLL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Bco_WebserviceWithRest")]
	public partial class webservicewithrestDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertListaTarefa(ListaTarefa instance);
    partial void UpdateListaTarefa(ListaTarefa instance);
    partial void DeleteListaTarefa(ListaTarefa instance);
    partial void InsertUsuario(Usuario instance);
    partial void UpdateUsuario(Usuario instance);
    partial void DeleteUsuario(Usuario instance);
    partial void InsertTarefa(Tarefa instance);
    partial void UpdateTarefa(Tarefa instance);
    partial void DeleteTarefa(Tarefa instance);
    #endregion
		
		public webservicewithrestDataContext() : 
				base(global::TrabalhoRestBLL.Properties.Settings.Default.Bco_WebserviceWithRestConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public webservicewithrestDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public webservicewithrestDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public webservicewithrestDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public webservicewithrestDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ListaTarefa> ListaTarefas
		{
			get
			{
				return this.GetTable<ListaTarefa>();
			}
		}
		
		public System.Data.Linq.Table<Usuario> Usuarios
		{
			get
			{
				return this.GetTable<Usuario>();
			}
		}
		
		public System.Data.Linq.Table<Tarefa> Tarefas
		{
			get
			{
				return this.GetTable<Tarefa>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ListaTarefa")]
	public partial class ListaTarefa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nome;
		
		private string _Cor;
		
		private int _UsuarioId;
		
		private EntitySet<Tarefa> _Tarefas;
		
		private EntityRef<Usuario> _Usuario;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnCorChanging(string value);
    partial void OnCorChanged();
    partial void OnUsuarioIdChanging(int value);
    partial void OnUsuarioIdChanged();
    #endregion
		
		public ListaTarefa()
		{
			this._Tarefas = new EntitySet<Tarefa>(new Action<Tarefa>(this.attach_Tarefas), new Action<Tarefa>(this.detach_Tarefas));
			this._Usuario = default(EntityRef<Usuario>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cor", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Cor
		{
			get
			{
				return this._Cor;
			}
			set
			{
				if ((this._Cor != value))
				{
					this.OnCorChanging(value);
					this.SendPropertyChanging();
					this._Cor = value;
					this.SendPropertyChanged("Cor");
					this.OnCorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsuarioId", DbType="Int NOT NULL")]
		public int UsuarioId
		{
			get
			{
				return this._UsuarioId;
			}
			set
			{
				if ((this._UsuarioId != value))
				{
					if (this._Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUsuarioIdChanging(value);
					this.SendPropertyChanging();
					this._UsuarioId = value;
					this.SendPropertyChanged("UsuarioId");
					this.OnUsuarioIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ListaTarefa_Tarefa", Storage="_Tarefas", ThisKey="Id", OtherKey="ListaTarefaId")]
		public EntitySet<Tarefa> Tarefas
		{
			get
			{
				return this._Tarefas;
			}
			set
			{
				this._Tarefas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_ListaTarefa", Storage="_Usuario", ThisKey="UsuarioId", OtherKey="Id", IsForeignKey=true)]
		public Usuario Usuario
		{
			get
			{
				return this._Usuario.Entity;
			}
			set
			{
				Usuario previousValue = this._Usuario.Entity;
				if (((previousValue != value) 
							|| (this._Usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuario.Entity = null;
						previousValue.ListaTarefas.Remove(this);
					}
					this._Usuario.Entity = value;
					if ((value != null))
					{
						value.ListaTarefas.Add(this);
						this._UsuarioId = value.Id;
					}
					else
					{
						this._UsuarioId = default(int);
					}
					this.SendPropertyChanged("Usuario");
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
		
		private void attach_Tarefas(Tarefa entity)
		{
			this.SendPropertyChanging();
			entity.ListaTarefa = this;
		}
		
		private void detach_Tarefas(Tarefa entity)
		{
			this.SendPropertyChanging();
			entity.ListaTarefa = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuario")]
	public partial class Usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nome;
		
		private string _Email;
		
		private string _Senha;
		
		private EntitySet<ListaTarefa> _ListaTarefas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnSenhaChanging(string value);
    partial void OnSenhaChanged();
    #endregion
		
		public Usuario()
		{
			this._ListaTarefas = new EntitySet<ListaTarefa>(new Action<ListaTarefa>(this.attach_ListaTarefas), new Action<ListaTarefa>(this.detach_ListaTarefas));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Senha", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Senha
		{
			get
			{
				return this._Senha;
			}
			set
			{
				if ((this._Senha != value))
				{
					this.OnSenhaChanging(value);
					this.SendPropertyChanging();
					this._Senha = value;
					this.SendPropertyChanged("Senha");
					this.OnSenhaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_ListaTarefa", Storage="_ListaTarefas", ThisKey="Id", OtherKey="UsuarioId")]
		public EntitySet<ListaTarefa> ListaTarefas
		{
			get
			{
				return this._ListaTarefas;
			}
			set
			{
				this._ListaTarefas.Assign(value);
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
		
		private void attach_ListaTarefas(ListaTarefa entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = this;
		}
		
		private void detach_ListaTarefas(ListaTarefa entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tarefa")]
	public partial class Tarefa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Descricao;
		
		private string _Status;
		
		private System.Nullable<int> _ListaTarefaId;
		
		private EntityRef<ListaTarefa> _ListaTarefa;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnDescricaoChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnListaTarefaIdChanging(System.Nullable<int> value);
    partial void OnListaTarefaIdChanged();
    #endregion
		
		public Tarefa()
		{
			this._ListaTarefa = default(EntityRef<ListaTarefa>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descricao", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Descricao
		{
			get
			{
				return this._Descricao;
			}
			set
			{
				if ((this._Descricao != value))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._Descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ListaTarefaId", DbType="Int")]
		public System.Nullable<int> ListaTarefaId
		{
			get
			{
				return this._ListaTarefaId;
			}
			set
			{
				if ((this._ListaTarefaId != value))
				{
					if (this._ListaTarefa.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnListaTarefaIdChanging(value);
					this.SendPropertyChanging();
					this._ListaTarefaId = value;
					this.SendPropertyChanged("ListaTarefaId");
					this.OnListaTarefaIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ListaTarefa_Tarefa", Storage="_ListaTarefa", ThisKey="ListaTarefaId", OtherKey="Id", IsForeignKey=true, DeleteRule="CASCADE")]
		public ListaTarefa ListaTarefa
		{
			get
			{
				return this._ListaTarefa.Entity;
			}
			set
			{
				ListaTarefa previousValue = this._ListaTarefa.Entity;
				if (((previousValue != value) 
							|| (this._ListaTarefa.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ListaTarefa.Entity = null;
						previousValue.Tarefas.Remove(this);
					}
					this._ListaTarefa.Entity = value;
					if ((value != null))
					{
						value.Tarefas.Add(this);
						this._ListaTarefaId = value.Id;
					}
					else
					{
						this._ListaTarefaId = default(Nullable<int>);
					}
					this.SendPropertyChanged("ListaTarefa");
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
