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

namespace JBTienda
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Tienda")]
	public partial class dcTiendaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public dcTiendaDataContext() : 
				base(global::JBTienda.Properties.Settings.Default.TiendaConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public dcTiendaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcTiendaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcTiendaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcTiendaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.agregarGerente")]
		public int agregarGerente([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(25)")] string usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string contraseña, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(25)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string apellidoPaterno, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string apellidoMaterno, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Char(1)")] System.Nullable<char> idSexo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> idTipoUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> idDepartamento)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuario, contraseña, nombre, apellidoPaterno, apellidoMaterno, idSexo, idTipoUsuario, idDepartamento);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.agregarProducto")]
		public int agregarProducto([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string nombreProducto, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string descripcion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1)")] string precio, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> cantidad, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Image")] System.Data.Linq.Binary imagen, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> idDepartamento)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombreProducto, descripcion, precio, cantidad, imagen, idDepartamento);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.consultarGerentes")]
		public ISingleResult<consultarGerentesResult> consultarGerentes()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<consultarGerentesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ConsultarDep")]
		public ISingleResult<ConsultarDepResult> ConsultarDep([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(25)")] string usuario)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuario);
			return ((ISingleResult<ConsultarDepResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.consultarDatosProductos2")]
		public ISingleResult<consultarDatosProductos2Result> consultarDatosProductos2([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idProducto)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idProducto);
			return ((ISingleResult<consultarDatosProductos2Result>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.cargarEstados")]
		public ISingleResult<cargarEstadosResult> cargarEstados()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<cargarEstadosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CargarDescuentos")]
		public ISingleResult<CargarDescuentosResult> CargarDescuentos()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<CargarDescuentosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.cargarCiudades")]
		public ISingleResult<cargarCiudadesResult> cargarCiudades([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> idEstado)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idEstado);
			return ((ISingleResult<cargarCiudadesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.agregarUsuarios")]
		public int agregarUsuarios([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(25)")] string nombreUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string contraseña, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string contraseña2, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(25)")] string apellidoPaterno, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string apellidoMaterno, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Char(1)")] System.Nullable<char> idSexo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(15)")] string telefono, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(25)")] string correo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(35)")] string direccion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string cp, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> idCiudad, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> idTipoUsuario)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombreUsuario, contraseña, contraseña2, nombre, apellidoPaterno, apellidoMaterno, idSexo, telefono, correo, direccion, cp, idCiudad, idTipoUsuario);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.consultarNombreGerentes")]
		public ISingleResult<consultarNombreGerentesResult> consultarNombreGerentes([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(25)")] string usuario)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuario);
			return ((ISingleResult<consultarNombreGerentesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.consultarNombreCliente")]
		public ISingleResult<consultarNombreClienteResult> consultarNombreCliente([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(25)")] string nombreusuario)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombreusuario);
			return ((ISingleResult<consultarNombreClienteResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.consultarProductos")]
		public ISingleResult<consultarProductosResult> consultarProductos([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> idDepartamento)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idDepartamento);
			return ((ISingleResult<consultarProductosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.consultarUsuario")]
		public ISingleResult<consultarUsuarioResult> consultarUsuario([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> idUsuario)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idUsuario);
			return ((ISingleResult<consultarUsuarioResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.eliminarProducto")]
		public int eliminarProducto([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> idProducto)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idProducto);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Logear")]
		public ISingleResult<LogearResult> Logear([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(25)")] string nombreUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(25)")] string contraseña)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombreUsuario, contraseña);
			return ((ISingleResult<LogearResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.modificarProducto")]
		public int modificarProducto([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> idProducto, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string nombreProduco, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string descripcion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Money")] System.Nullable<decimal> precio, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> cantidad, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Image")] System.Data.Linq.Binary imagen, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> idDescuento)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idProducto, nombreProduco, descripcion, precio, cantidad, imagen, idDescuento);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.LogearGerente")]
		public ISingleResult<LogearGerenteResult> LogearGerente([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(25)")] string usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string contraseña)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuario, contraseña);
			return ((ISingleResult<LogearGerenteResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.consultarCom")]
		public ISingleResult<consultarComResult> consultarCom()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<consultarComResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.consultarDatosComprar")]
		public ISingleResult<consultarDatosComprarResult> consultarDatosComprar([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="TinyInt")] System.Nullable<byte> idProducto)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idProducto);
			return ((ISingleResult<consultarDatosComprarResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ConsultarCompras")]
		public int ConsultarCompras([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nommnbre", DbType="VarChar(20)")] string nommnbre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Descripcion", DbType="VarChar(30)")] string descripcion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Precio", DbType="Money")] System.Nullable<decimal> precio, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> cantidad)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nommnbre, descripcion, precio, cantidad);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.consultarCarrito")]
		public ISingleResult<consultarCarritoResult> consultarCarrito()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<consultarCarritoResult>)(result.ReturnValue));
		}
	}
	
	public partial class consultarGerentesResult
	{
		
		private byte _idGerente;
		
		private string _NombreCompleto;
		
		private string _nombredepa;
		
		public consultarGerentesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idGerente", DbType="TinyInt NOT NULL")]
		public byte idGerente
		{
			get
			{
				return this._idGerente;
			}
			set
			{
				if ((this._idGerente != value))
				{
					this._idGerente = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreCompleto", DbType="VarChar(67)")]
		public string NombreCompleto
		{
			get
			{
				return this._NombreCompleto;
			}
			set
			{
				if ((this._NombreCompleto != value))
				{
					this._NombreCompleto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombredepa", DbType="VarChar(25)")]
		public string nombredepa
		{
			get
			{
				return this._nombredepa;
			}
			set
			{
				if ((this._nombredepa != value))
				{
					this._nombredepa = value;
				}
			}
		}
	}
	
	public partial class ConsultarDepResult
	{
		
		private System.Nullable<byte> _idDepartamento;
		
		public ConsultarDepResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idDepartamento", DbType="TinyInt")]
		public System.Nullable<byte> idDepartamento
		{
			get
			{
				return this._idDepartamento;
			}
			set
			{
				if ((this._idDepartamento != value))
				{
					this._idDepartamento = value;
				}
			}
		}
	}
	
	public partial class consultarDatosProductos2Result
	{
		
		private byte _idProducto;
		
		private string _nombreDepa;
		
		private string _nombreProducto;
		
		private string _descripcion;
		
		private System.Nullable<decimal> _precio;
		
		private System.Nullable<byte> _cantidad;
		
		private System.Data.Linq.Binary _imagen;
		
		private System.Nullable<byte> _idDescuento;
		
		public consultarDatosProductos2Result()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idProducto", DbType="TinyInt NOT NULL")]
		public byte idProducto
		{
			get
			{
				return this._idProducto;
			}
			set
			{
				if ((this._idProducto != value))
				{
					this._idProducto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreDepa", DbType="VarChar(25)")]
		public string nombreDepa
		{
			get
			{
				return this._nombreDepa;
			}
			set
			{
				if ((this._nombreDepa != value))
				{
					this._nombreDepa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreProducto", DbType="VarChar(30)")]
		public string nombreProducto
		{
			get
			{
				return this._nombreProducto;
			}
			set
			{
				if ((this._nombreProducto != value))
				{
					this._nombreProducto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descripcion", DbType="VarChar(100)")]
		public string descripcion
		{
			get
			{
				return this._descripcion;
			}
			set
			{
				if ((this._descripcion != value))
				{
					this._descripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precio", DbType="Money")]
		public System.Nullable<decimal> precio
		{
			get
			{
				return this._precio;
			}
			set
			{
				if ((this._precio != value))
				{
					this._precio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cantidad", DbType="TinyInt")]
		public System.Nullable<byte> cantidad
		{
			get
			{
				return this._cantidad;
			}
			set
			{
				if ((this._cantidad != value))
				{
					this._cantidad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imagen", DbType="Image")]
		public System.Data.Linq.Binary imagen
		{
			get
			{
				return this._imagen;
			}
			set
			{
				if ((this._imagen != value))
				{
					this._imagen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idDescuento", DbType="TinyInt")]
		public System.Nullable<byte> idDescuento
		{
			get
			{
				return this._idDescuento;
			}
			set
			{
				if ((this._idDescuento != value))
				{
					this._idDescuento = value;
				}
			}
		}
	}
	
	public partial class cargarEstadosResult
	{
		
		private byte _idEstado;
		
		private string _desEstado;
		
		public cargarEstadosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idEstado", DbType="TinyInt NOT NULL")]
		public byte idEstado
		{
			get
			{
				return this._idEstado;
			}
			set
			{
				if ((this._idEstado != value))
				{
					this._idEstado = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_desEstado", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string desEstado
		{
			get
			{
				return this._desEstado;
			}
			set
			{
				if ((this._desEstado != value))
				{
					this._desEstado = value;
				}
			}
		}
	}
	
	public partial class CargarDescuentosResult
	{
		
		private byte _idDescuento;
		
		private string _descuento;
		
		public CargarDescuentosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idDescuento", DbType="TinyInt NOT NULL")]
		public byte idDescuento
		{
			get
			{
				return this._idDescuento;
			}
			set
			{
				if ((this._idDescuento != value))
				{
					this._idDescuento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descuento", DbType="VarChar(10)")]
		public string descuento
		{
			get
			{
				return this._descuento;
			}
			set
			{
				if ((this._descuento != value))
				{
					this._descuento = value;
				}
			}
		}
	}
	
	public partial class cargarCiudadesResult
	{
		
		private byte _idCiudad;
		
		private string _desCiudad;
		
		private System.Nullable<byte> _idEstado;
		
		public cargarCiudadesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCiudad", DbType="TinyInt NOT NULL")]
		public byte idCiudad
		{
			get
			{
				return this._idCiudad;
			}
			set
			{
				if ((this._idCiudad != value))
				{
					this._idCiudad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_desCiudad", DbType="VarChar(30)")]
		public string desCiudad
		{
			get
			{
				return this._desCiudad;
			}
			set
			{
				if ((this._desCiudad != value))
				{
					this._desCiudad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idEstado", DbType="TinyInt")]
		public System.Nullable<byte> idEstado
		{
			get
			{
				return this._idEstado;
			}
			set
			{
				if ((this._idEstado != value))
				{
					this._idEstado = value;
				}
			}
		}
	}
	
	public partial class consultarNombreGerentesResult
	{
		
		private string _NombreCompleto;
		
		public consultarNombreGerentesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreCompleto", DbType="VarChar(67)")]
		public string NombreCompleto
		{
			get
			{
				return this._NombreCompleto;
			}
			set
			{
				if ((this._NombreCompleto != value))
				{
					this._NombreCompleto = value;
				}
			}
		}
	}
	
	public partial class consultarNombreClienteResult
	{
		
		private string _NombreCompleto;
		
		public consultarNombreClienteResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreCompleto", DbType="VarChar(67)")]
		public string NombreCompleto
		{
			get
			{
				return this._NombreCompleto;
			}
			set
			{
				if ((this._NombreCompleto != value))
				{
					this._NombreCompleto = value;
				}
			}
		}
	}
	
	public partial class consultarProductosResult
	{
		
		private string _Departamento;
		
		private System.Data.Linq.Binary _Imagen;
		
		private string _Nombre;
		
		private string _Descripcion;
		
		private System.Nullable<decimal> _Precio;
		
		private string _Descuento;
		
		private System.Nullable<byte> _Cantidad;
		
		private byte _Id;
		
		public consultarProductosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Departamento", DbType="VarChar(25)")]
		public string Departamento
		{
			get
			{
				return this._Departamento;
			}
			set
			{
				if ((this._Departamento != value))
				{
					this._Departamento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Imagen", DbType="Image")]
		public System.Data.Linq.Binary Imagen
		{
			get
			{
				return this._Imagen;
			}
			set
			{
				if ((this._Imagen != value))
				{
					this._Imagen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(30)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(100)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Precio", DbType="Money")]
		public System.Nullable<decimal> Precio
		{
			get
			{
				return this._Precio;
			}
			set
			{
				if ((this._Precio != value))
				{
					this._Precio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descuento", DbType="VarChar(10)")]
		public string Descuento
		{
			get
			{
				return this._Descuento;
			}
			set
			{
				if ((this._Descuento != value))
				{
					this._Descuento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cantidad", DbType="TinyInt")]
		public System.Nullable<byte> Cantidad
		{
			get
			{
				return this._Cantidad;
			}
			set
			{
				if ((this._Cantidad != value))
				{
					this._Cantidad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="TinyInt NOT NULL")]
		public byte Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
	}
	
	public partial class consultarUsuarioResult
	{
		
		private byte _idUsuario;
		
		private string _nombreUsuario;
		
		private string _contraseña;
		
		private string _nombre;
		
		private string _ApellidoPaterno;
		
		private string _ApellidoMaterno;
		
		private System.Nullable<char> _idSexo;
		
		private string _telefono;
		
		private string _correo;
		
		private string _direccion;
		
		private string _cp;
		
		private System.Nullable<byte> _idCiudad;
		
		private System.Nullable<byte> _idTipoUsuario;
		
		private System.Nullable<byte> _idEstado;
		
		public consultarUsuarioResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUsuario", DbType="TinyInt NOT NULL")]
		public byte idUsuario
		{
			get
			{
				return this._idUsuario;
			}
			set
			{
				if ((this._idUsuario != value))
				{
					this._idUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreUsuario", DbType="VarChar(25)")]
		public string nombreUsuario
		{
			get
			{
				return this._nombreUsuario;
			}
			set
			{
				if ((this._nombreUsuario != value))
				{
					this._nombreUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contraseña", DbType="VarChar(10)")]
		public string contraseña
		{
			get
			{
				return this._contraseña;
			}
			set
			{
				if ((this._contraseña != value))
				{
					this._contraseña = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(25)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this._nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoPaterno", DbType="VarChar(20)")]
		public string ApellidoPaterno
		{
			get
			{
				return this._ApellidoPaterno;
			}
			set
			{
				if ((this._ApellidoPaterno != value))
				{
					this._ApellidoPaterno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoMaterno", DbType="VarChar(20)")]
		public string ApellidoMaterno
		{
			get
			{
				return this._ApellidoMaterno;
			}
			set
			{
				if ((this._ApellidoMaterno != value))
				{
					this._ApellidoMaterno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idSexo", DbType="Char(1)")]
		public System.Nullable<char> idSexo
		{
			get
			{
				return this._idSexo;
			}
			set
			{
				if ((this._idSexo != value))
				{
					this._idSexo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefono", DbType="VarChar(15)")]
		public string telefono
		{
			get
			{
				return this._telefono;
			}
			set
			{
				if ((this._telefono != value))
				{
					this._telefono = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_correo", DbType="VarChar(30)")]
		public string correo
		{
			get
			{
				return this._correo;
			}
			set
			{
				if ((this._correo != value))
				{
					this._correo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_direccion", DbType="VarChar(35)")]
		public string direccion
		{
			get
			{
				return this._direccion;
			}
			set
			{
				if ((this._direccion != value))
				{
					this._direccion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cp", DbType="VarChar(10)")]
		public string cp
		{
			get
			{
				return this._cp;
			}
			set
			{
				if ((this._cp != value))
				{
					this._cp = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCiudad", DbType="TinyInt")]
		public System.Nullable<byte> idCiudad
		{
			get
			{
				return this._idCiudad;
			}
			set
			{
				if ((this._idCiudad != value))
				{
					this._idCiudad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTipoUsuario", DbType="TinyInt")]
		public System.Nullable<byte> idTipoUsuario
		{
			get
			{
				return this._idTipoUsuario;
			}
			set
			{
				if ((this._idTipoUsuario != value))
				{
					this._idTipoUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idEstado", DbType="TinyInt")]
		public System.Nullable<byte> idEstado
		{
			get
			{
				return this._idEstado;
			}
			set
			{
				if ((this._idEstado != value))
				{
					this._idEstado = value;
				}
			}
		}
	}
	
	public partial class LogearResult
	{
		
		private byte _idUsuario;
		
		private string _nombre;
		
		private System.Nullable<byte> _idTipoUSuario;
		
		public LogearResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUsuario", DbType="TinyInt NOT NULL")]
		public byte idUsuario
		{
			get
			{
				return this._idUsuario;
			}
			set
			{
				if ((this._idUsuario != value))
				{
					this._idUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(25)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this._nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTipoUSuario", DbType="TinyInt")]
		public System.Nullable<byte> idTipoUSuario
		{
			get
			{
				return this._idTipoUSuario;
			}
			set
			{
				if ((this._idTipoUSuario != value))
				{
					this._idTipoUSuario = value;
				}
			}
		}
	}
	
	public partial class LogearGerenteResult
	{
		
		private byte _idGerente;
		
		private string _nombre;
		
		private System.Nullable<byte> _idTipoUsuario;
		
		public LogearGerenteResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idGerente", DbType="TinyInt NOT NULL")]
		public byte idGerente
		{
			get
			{
				return this._idGerente;
			}
			set
			{
				if ((this._idGerente != value))
				{
					this._idGerente = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(25)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this._nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTipoUsuario", DbType="TinyInt")]
		public System.Nullable<byte> idTipoUsuario
		{
			get
			{
				return this._idTipoUsuario;
			}
			set
			{
				if ((this._idTipoUsuario != value))
				{
					this._idTipoUsuario = value;
				}
			}
		}
	}
	
	public partial class consultarComResult
	{
		
		private System.Data.Linq.Binary _Imagen;
		
		private string _Nombre;
		
		private string _Descripcion;
		
		private System.Nullable<decimal> _Precio;
		
		private string _Descuento;
		
		private byte _Id;
		
		public consultarComResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Imagen", DbType="Image")]
		public System.Data.Linq.Binary Imagen
		{
			get
			{
				return this._Imagen;
			}
			set
			{
				if ((this._Imagen != value))
				{
					this._Imagen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(30)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(100)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Precio", DbType="Money")]
		public System.Nullable<decimal> Precio
		{
			get
			{
				return this._Precio;
			}
			set
			{
				if ((this._Precio != value))
				{
					this._Precio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descuento", DbType="VarChar(10)")]
		public string Descuento
		{
			get
			{
				return this._Descuento;
			}
			set
			{
				if ((this._Descuento != value))
				{
					this._Descuento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="TinyInt NOT NULL")]
		public byte Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
	}
	
	public partial class consultarDatosComprarResult
	{
		
		private System.Data.Linq.Binary _Imagen;
		
		private string _Nombre;
		
		private string _Descripcion;
		
		private System.Nullable<decimal> _Precio;
		
		private string _Descuento;
		
		public consultarDatosComprarResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Imagen", DbType="Image")]
		public System.Data.Linq.Binary Imagen
		{
			get
			{
				return this._Imagen;
			}
			set
			{
				if ((this._Imagen != value))
				{
					this._Imagen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(30)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(100)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Precio", DbType="Money")]
		public System.Nullable<decimal> Precio
		{
			get
			{
				return this._Precio;
			}
			set
			{
				if ((this._Precio != value))
				{
					this._Precio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descuento", DbType="VarChar(10)")]
		public string Descuento
		{
			get
			{
				return this._Descuento;
			}
			set
			{
				if ((this._Descuento != value))
				{
					this._Descuento = value;
				}
			}
		}
	}
	
	public partial class consultarCarritoResult
	{
		
		private string _Nombre;
		
		private string _Descripcion;
		
		private decimal _Precio;
		
		private int _Cantidad;
		
		public consultarCarritoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Precio", DbType="Money NOT NULL")]
		public decimal Precio
		{
			get
			{
				return this._Precio;
			}
			set
			{
				if ((this._Precio != value))
				{
					this._Precio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cantidad", DbType="Int NOT NULL")]
		public int Cantidad
		{
			get
			{
				return this._Cantidad;
			}
			set
			{
				if ((this._Cantidad != value))
				{
					this._Cantidad = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
