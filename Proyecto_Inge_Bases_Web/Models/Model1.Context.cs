﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Inge_Bases_Web.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TempPIEntities : DbContext
    {
        public TempPIEntities()
            : base("name=TempPIEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Canton> Cantons { get; set; }
        public virtual DbSet<Resena> Resenas { get; set; }
        public virtual DbSet<Subasta> Subastas { get; set; }
        public virtual DbSet<Administrador> Administradors { get; set; }
        public virtual DbSet<Apelacion> Apelacions { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Contrasenas_Anteriores> Contrasenas_Anteriores { get; set; }
        public virtual DbSet<Denuncia> Denuncias { get; set; }
        public virtual DbSet<Fisico> Fisicoes { get; set; }
        public virtual DbSet<ListaAmigo> ListaAmigos { get; set; }
        public virtual DbSet<ListaCliente> ListaClientes { get; set; }
        public virtual DbSet<Pai> Pais { get; set; }
        public virtual DbSet<Producto> Productoes { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<Registrado> Registradoes { get; set; }
        public virtual DbSet<Relacion_ClienteOfertaEnSubasta> Relacion_ClienteOfertaEnSubasta { get; set; }
        public virtual DbSet<Relacion_ClienteTieneInteresCategoria> Relacion_ClienteTieneInteresCategoria { get; set; }
        public virtual DbSet<Relacion_Sublista_Amigos> Relacion_Sublista_Amigos { get; set; }
        public virtual DbSet<Sublista> Sublistas { get; set; }
        public virtual DbSet<Suspension> Suspensions { get; set; }
        public virtual DbSet<Telefono_Administrador> Telefono_Administrador { get; set; }
        public virtual DbSet<Trueque> Trueques { get; set; }
        public virtual DbSet<Virtual> Virtuals { get; set; }
        public virtual DbSet<Calificaciones_Cliente> Calificaciones_Cliente { get; set; }
        public virtual DbSet<CategoriaConTruequeActivo> CategoriaConTruequeActivoes { get; set; }
        public virtual DbSet<ClientesRegistrado> ClientesRegistrados { get; set; }
        public virtual DbSet<PanelSublista> PanelSublistas { get; set; }
        public virtual DbSet<Productos_Info_Clientes> Productos_Info_Clientes { get; set; }
        public virtual DbSet<ProductosUsuario> ProductosUsuarios { get; set; }
        public virtual DbSet<subastasPorCategoria> subastasPorCategorias { get; set; }
        public virtual DbSet<VistaAmigo> VistaAmigos { get; set; }
        public virtual DbSet<VistaCruzada> VistaCruzadas { get; set; }
        public virtual DbSet<VistaEstaEnSublista> VistaEstaEnSublistas { get; set; }
        public virtual DbSet<VistaInteresesCliente> VistaInteresesClientes { get; set; }
        public virtual DbSet<VistaMisProducto> VistaMisProductos { get; set; }
        public virtual DbSet<VistaNoAmigo> VistaNoAmigoes { get; set; }
    
        public virtual int Insertar(string correoCliente, string nombre, Nullable<double> precioEstimado, string condicion, string descripcion, string productoImagen1, string productoImagen2, string productoImagen3, Nullable<bool> publicado, Nullable<System.DateTime> fechaRegistrado)
        {
            var correoClienteParameter = correoCliente != null ?
                new ObjectParameter("CorreoCliente", correoCliente) :
                new ObjectParameter("CorreoCliente", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var precioEstimadoParameter = precioEstimado.HasValue ?
                new ObjectParameter("PrecioEstimado", precioEstimado) :
                new ObjectParameter("PrecioEstimado", typeof(double));
    
            var condicionParameter = condicion != null ?
                new ObjectParameter("Condicion", condicion) :
                new ObjectParameter("Condicion", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var productoImagen1Parameter = productoImagen1 != null ?
                new ObjectParameter("ProductoImagen1", productoImagen1) :
                new ObjectParameter("ProductoImagen1", typeof(string));
    
            var productoImagen2Parameter = productoImagen2 != null ?
                new ObjectParameter("ProductoImagen2", productoImagen2) :
                new ObjectParameter("ProductoImagen2", typeof(string));
    
            var productoImagen3Parameter = productoImagen3 != null ?
                new ObjectParameter("ProductoImagen3", productoImagen3) :
                new ObjectParameter("ProductoImagen3", typeof(string));
    
            var publicadoParameter = publicado.HasValue ?
                new ObjectParameter("Publicado", publicado) :
                new ObjectParameter("Publicado", typeof(bool));
    
            var fechaRegistradoParameter = fechaRegistrado.HasValue ?
                new ObjectParameter("FechaRegistrado", fechaRegistrado) :
                new ObjectParameter("FechaRegistrado", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insertar", correoClienteParameter, nombreParameter, precioEstimadoParameter, condicionParameter, descripcionParameter, productoImagen1Parameter, productoImagen2Parameter, productoImagen3Parameter, publicadoParameter, fechaRegistradoParameter);
        }
    
        public virtual int spProducto_InsertarProducto(string correoCliente, string nombre, Nullable<double> precioEstimado, string condicion, string descripcion, string productoImagen1, string productoImagen2, string productoImagen3, Nullable<bool> publicado, Nullable<System.DateTime> fechaRegistrado)
        {
            var correoClienteParameter = correoCliente != null ?
                new ObjectParameter("CorreoCliente", correoCliente) :
                new ObjectParameter("CorreoCliente", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var precioEstimadoParameter = precioEstimado.HasValue ?
                new ObjectParameter("PrecioEstimado", precioEstimado) :
                new ObjectParameter("PrecioEstimado", typeof(double));
    
            var condicionParameter = condicion != null ?
                new ObjectParameter("Condicion", condicion) :
                new ObjectParameter("Condicion", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var productoImagen1Parameter = productoImagen1 != null ?
                new ObjectParameter("ProductoImagen1", productoImagen1) :
                new ObjectParameter("ProductoImagen1", typeof(string));
    
            var productoImagen2Parameter = productoImagen2 != null ?
                new ObjectParameter("ProductoImagen2", productoImagen2) :
                new ObjectParameter("ProductoImagen2", typeof(string));
    
            var productoImagen3Parameter = productoImagen3 != null ?
                new ObjectParameter("ProductoImagen3", productoImagen3) :
                new ObjectParameter("ProductoImagen3", typeof(string));
    
            var publicadoParameter = publicado.HasValue ?
                new ObjectParameter("Publicado", publicado) :
                new ObjectParameter("Publicado", typeof(bool));
    
            var fechaRegistradoParameter = fechaRegistrado.HasValue ?
                new ObjectParameter("FechaRegistrado", fechaRegistrado) :
                new ObjectParameter("FechaRegistrado", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spProducto_InsertarProducto", correoClienteParameter, nombreParameter, precioEstimadoParameter, condicionParameter, descripcionParameter, productoImagen1Parameter, productoImagen2Parameter, productoImagen3Parameter, publicadoParameter, fechaRegistradoParameter);
        }
    
        public virtual int spTrueque_InsertarOferta(Nullable<int> productoIdPublicado, string correoPublicador, Nullable<int> productoIdOfertado, string correoOfertante, Nullable<System.DateTime> fecha)
        {
            var productoIdPublicadoParameter = productoIdPublicado.HasValue ?
                new ObjectParameter("productoIdPublicado", productoIdPublicado) :
                new ObjectParameter("productoIdPublicado", typeof(int));
    
            var correoPublicadorParameter = correoPublicador != null ?
                new ObjectParameter("correoPublicador", correoPublicador) :
                new ObjectParameter("correoPublicador", typeof(string));
    
            var productoIdOfertadoParameter = productoIdOfertado.HasValue ?
                new ObjectParameter("productoIdOfertado", productoIdOfertado) :
                new ObjectParameter("productoIdOfertado", typeof(int));
    
            var correoOfertanteParameter = correoOfertante != null ?
                new ObjectParameter("correoOfertante", correoOfertante) :
                new ObjectParameter("correoOfertante", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spTrueque_InsertarOferta", productoIdPublicadoParameter, correoPublicadorParameter, productoIdOfertadoParameter, correoOfertanteParameter, fechaParameter);
        }
    
        public virtual int spFisico_Insert(string nombre, string correoCliente, Nullable<double> precioEstimado, string condicion, string descripcion, byte[] productoImagen1, byte[] productoImagen2, byte[] productoImagen3, Nullable<bool> publicado, Nullable<System.DateTime> fechaRegistrado)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var correoClienteParameter = correoCliente != null ?
                new ObjectParameter("CorreoCliente", correoCliente) :
                new ObjectParameter("CorreoCliente", typeof(string));
    
            var precioEstimadoParameter = precioEstimado.HasValue ?
                new ObjectParameter("PrecioEstimado", precioEstimado) :
                new ObjectParameter("PrecioEstimado", typeof(double));
    
            var condicionParameter = condicion != null ?
                new ObjectParameter("Condicion", condicion) :
                new ObjectParameter("Condicion", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var productoImagen1Parameter = productoImagen1 != null ?
                new ObjectParameter("ProductoImagen1", productoImagen1) :
                new ObjectParameter("ProductoImagen1", typeof(byte[]));
    
            var productoImagen2Parameter = productoImagen2 != null ?
                new ObjectParameter("ProductoImagen2", productoImagen2) :
                new ObjectParameter("ProductoImagen2", typeof(byte[]));
    
            var productoImagen3Parameter = productoImagen3 != null ?
                new ObjectParameter("ProductoImagen3", productoImagen3) :
                new ObjectParameter("ProductoImagen3", typeof(byte[]));
    
            var publicadoParameter = publicado.HasValue ?
                new ObjectParameter("Publicado", publicado) :
                new ObjectParameter("Publicado", typeof(bool));
    
            var fechaRegistradoParameter = fechaRegistrado.HasValue ?
                new ObjectParameter("FechaRegistrado", fechaRegistrado) :
                new ObjectParameter("FechaRegistrado", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spFisico_Insert", nombreParameter, correoClienteParameter, precioEstimadoParameter, condicionParameter, descripcionParameter, productoImagen1Parameter, productoImagen2Parameter, productoImagen3Parameter, publicadoParameter, fechaRegistradoParameter);
        }
    
        public virtual int spFisico_Delete(Nullable<int> productoID)
        {
            var productoIDParameter = productoID.HasValue ?
                new ObjectParameter("ProductoID", productoID) :
                new ObjectParameter("ProductoID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spFisico_Delete", productoIDParameter);
        }
    
        public virtual int sqFisico_Update(Nullable<int> productoID, string correoCliente)
        {
            var productoIDParameter = productoID.HasValue ?
                new ObjectParameter("ProductoID", productoID) :
                new ObjectParameter("ProductoID", typeof(int));
    
            var correoClienteParameter = correoCliente != null ?
                new ObjectParameter("CorreoCliente", correoCliente) :
                new ObjectParameter("CorreoCliente", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sqFisico_Update", productoIDParameter, correoClienteParameter);
        }
    
        [DbFunction("TempPIEntities", "funcionNoAmigos")]
        public virtual IQueryable<funcionNoAmigos_Result> funcionNoAmigos(string correoUser)
        {
            var correoUserParameter = correoUser != null ?
                new ObjectParameter("correoUser", correoUser) :
                new ObjectParameter("correoUser", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<funcionNoAmigos_Result>("[TempPIEntities].[funcionNoAmigos](@correoUser)", correoUserParameter);
        }
    
        public virtual ObjectResult<spProducto_SelectUltimosDiez_Result> spProducto_SelectUltimosDiez()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spProducto_SelectUltimosDiez_Result>("spProducto_SelectUltimosDiez");
        }
    
        public virtual int spVirtual_Insert(string nombre, string correoCliente, Nullable<double> precioEstimado, string condicion, string descripcion, byte[] productoImagen1, byte[] productoImagen2, byte[] productoImagen3, Nullable<bool> publicado, Nullable<System.DateTime> fechaRegistrado, string tipoDeArchivo, string derechosDeProducto, string fuentes, Nullable<System.DateTime> fechaExpiracion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var correoClienteParameter = correoCliente != null ?
                new ObjectParameter("CorreoCliente", correoCliente) :
                new ObjectParameter("CorreoCliente", typeof(string));
    
            var precioEstimadoParameter = precioEstimado.HasValue ?
                new ObjectParameter("PrecioEstimado", precioEstimado) :
                new ObjectParameter("PrecioEstimado", typeof(double));
    
            var condicionParameter = condicion != null ?
                new ObjectParameter("Condicion", condicion) :
                new ObjectParameter("Condicion", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var productoImagen1Parameter = productoImagen1 != null ?
                new ObjectParameter("ProductoImagen1", productoImagen1) :
                new ObjectParameter("ProductoImagen1", typeof(byte[]));
    
            var productoImagen2Parameter = productoImagen2 != null ?
                new ObjectParameter("ProductoImagen2", productoImagen2) :
                new ObjectParameter("ProductoImagen2", typeof(byte[]));
    
            var productoImagen3Parameter = productoImagen3 != null ?
                new ObjectParameter("ProductoImagen3", productoImagen3) :
                new ObjectParameter("ProductoImagen3", typeof(byte[]));
    
            var publicadoParameter = publicado.HasValue ?
                new ObjectParameter("Publicado", publicado) :
                new ObjectParameter("Publicado", typeof(bool));
    
            var fechaRegistradoParameter = fechaRegistrado.HasValue ?
                new ObjectParameter("FechaRegistrado", fechaRegistrado) :
                new ObjectParameter("FechaRegistrado", typeof(System.DateTime));
    
            var tipoDeArchivoParameter = tipoDeArchivo != null ?
                new ObjectParameter("TipoDeArchivo", tipoDeArchivo) :
                new ObjectParameter("TipoDeArchivo", typeof(string));
    
            var derechosDeProductoParameter = derechosDeProducto != null ?
                new ObjectParameter("DerechosDeProducto", derechosDeProducto) :
                new ObjectParameter("DerechosDeProducto", typeof(string));
    
            var fuentesParameter = fuentes != null ?
                new ObjectParameter("Fuentes", fuentes) :
                new ObjectParameter("Fuentes", typeof(string));
    
            var fechaExpiracionParameter = fechaExpiracion.HasValue ?
                new ObjectParameter("FechaExpiracion", fechaExpiracion) :
                new ObjectParameter("FechaExpiracion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spVirtual_Insert", nombreParameter, correoClienteParameter, precioEstimadoParameter, condicionParameter, descripcionParameter, productoImagen1Parameter, productoImagen2Parameter, productoImagen3Parameter, publicadoParameter, fechaRegistradoParameter, tipoDeArchivoParameter, derechosDeProductoParameter, fuentesParameter, fechaExpiracionParameter);
        }
    
        public virtual int spVirtual_Delete(Nullable<int> productoID)
        {
            var productoIDParameter = productoID.HasValue ?
                new ObjectParameter("ProductoID", productoID) :
                new ObjectParameter("ProductoID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spVirtual_Delete", productoIDParameter);
        }
    
        public virtual int sqVirtual_Update(Nullable<int> productoID, string correoCliente, string tipoDeArchivo, string derechosDeProducto, string fuentes, Nullable<System.DateTime> fechaExpiracion)
        {
            var productoIDParameter = productoID.HasValue ?
                new ObjectParameter("ProductoID", productoID) :
                new ObjectParameter("ProductoID", typeof(int));
    
            var correoClienteParameter = correoCliente != null ?
                new ObjectParameter("CorreoCliente", correoCliente) :
                new ObjectParameter("CorreoCliente", typeof(string));
    
            var tipoDeArchivoParameter = tipoDeArchivo != null ?
                new ObjectParameter("TipoDeArchivo", tipoDeArchivo) :
                new ObjectParameter("TipoDeArchivo", typeof(string));
    
            var derechosDeProductoParameter = derechosDeProducto != null ?
                new ObjectParameter("DerechosDeProducto", derechosDeProducto) :
                new ObjectParameter("DerechosDeProducto", typeof(string));
    
            var fuentesParameter = fuentes != null ?
                new ObjectParameter("Fuentes", fuentes) :
                new ObjectParameter("Fuentes", typeof(string));
    
            var fechaExpiracionParameter = fechaExpiracion.HasValue ?
                new ObjectParameter("FechaExpiracion", fechaExpiracion) :
                new ObjectParameter("FechaExpiracion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sqVirtual_Update", productoIDParameter, correoClienteParameter, tipoDeArchivoParameter, derechosDeProductoParameter, fuentesParameter, fechaExpiracionParameter);
        }
    
        public virtual int spFisico_Update(Nullable<int> productoID, string correoCliente)
        {
            var productoIDParameter = productoID.HasValue ?
                new ObjectParameter("ProductoID", productoID) :
                new ObjectParameter("ProductoID", typeof(int));
    
            var correoClienteParameter = correoCliente != null ?
                new ObjectParameter("CorreoCliente", correoCliente) :
                new ObjectParameter("CorreoCliente", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spFisico_Update", productoIDParameter, correoClienteParameter);
        }
    
        public virtual int spVirtual_Update(Nullable<int> productoID, string correoCliente, string tipoDeArchivo, string derechosDeProducto, string fuentes, Nullable<System.DateTime> fechaExpiracion)
        {
            var productoIDParameter = productoID.HasValue ?
                new ObjectParameter("ProductoID", productoID) :
                new ObjectParameter("ProductoID", typeof(int));
    
            var correoClienteParameter = correoCliente != null ?
                new ObjectParameter("CorreoCliente", correoCliente) :
                new ObjectParameter("CorreoCliente", typeof(string));
    
            var tipoDeArchivoParameter = tipoDeArchivo != null ?
                new ObjectParameter("TipoDeArchivo", tipoDeArchivo) :
                new ObjectParameter("TipoDeArchivo", typeof(string));
    
            var derechosDeProductoParameter = derechosDeProducto != null ?
                new ObjectParameter("DerechosDeProducto", derechosDeProducto) :
                new ObjectParameter("DerechosDeProducto", typeof(string));
    
            var fuentesParameter = fuentes != null ?
                new ObjectParameter("Fuentes", fuentes) :
                new ObjectParameter("Fuentes", typeof(string));
    
            var fechaExpiracionParameter = fechaExpiracion.HasValue ?
                new ObjectParameter("FechaExpiracion", fechaExpiracion) :
                new ObjectParameter("FechaExpiracion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spVirtual_Update", productoIDParameter, correoClienteParameter, tipoDeArchivoParameter, derechosDeProductoParameter, fuentesParameter, fechaExpiracionParameter);
        }
    
        public virtual int ExisteInteres(Nullable<int> interes, string amigo)
        {
            var interesParameter = interes.HasValue ?
                new ObjectParameter("interes", interes) :
                new ObjectParameter("interes", typeof(int));
    
            var amigoParameter = amigo != null ?
                new ObjectParameter("amigo", amigo) :
                new ObjectParameter("amigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ExisteInteres", interesParameter, amigoParameter);
        }
    
        public virtual ObjectResult<Subasta> spRelacion_Subasta_Visible_A_Insertar(string correoDuenoLista, Nullable<int> sublistaID, Nullable<int> productoID, string correoDuenoSubasta, Nullable<System.DateTime> fechaPublicado)
        {
            var correoDuenoListaParameter = correoDuenoLista != null ?
                new ObjectParameter("CorreoDuenoLista", correoDuenoLista) :
                new ObjectParameter("CorreoDuenoLista", typeof(string));
    
            var sublistaIDParameter = sublistaID.HasValue ?
                new ObjectParameter("SublistaID", sublistaID) :
                new ObjectParameter("SublistaID", typeof(int));
    
            var productoIDParameter = productoID.HasValue ?
                new ObjectParameter("ProductoID", productoID) :
                new ObjectParameter("ProductoID", typeof(int));
    
            var correoDuenoSubastaParameter = correoDuenoSubasta != null ?
                new ObjectParameter("CorreoDuenoSubasta", correoDuenoSubasta) :
                new ObjectParameter("CorreoDuenoSubasta", typeof(string));
    
            var fechaPublicadoParameter = fechaPublicado.HasValue ?
                new ObjectParameter("FechaPublicado", fechaPublicado) :
                new ObjectParameter("FechaPublicado", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Subasta>("spRelacion_Subasta_Visible_A_Insertar", correoDuenoListaParameter, sublistaIDParameter, productoIDParameter, correoDuenoSubastaParameter, fechaPublicadoParameter);
        }
    
        public virtual ObjectResult<Subasta> spRelacion_Subasta_Visible_A_Insertar(string correoDuenoLista, Nullable<int> sublistaID, Nullable<int> productoID, string correoDuenoSubasta, Nullable<System.DateTime> fechaPublicado, MergeOption mergeOption)
        {
            var correoDuenoListaParameter = correoDuenoLista != null ?
                new ObjectParameter("CorreoDuenoLista", correoDuenoLista) :
                new ObjectParameter("CorreoDuenoLista", typeof(string));
    
            var sublistaIDParameter = sublistaID.HasValue ?
                new ObjectParameter("SublistaID", sublistaID) :
                new ObjectParameter("SublistaID", typeof(int));
    
            var productoIDParameter = productoID.HasValue ?
                new ObjectParameter("ProductoID", productoID) :
                new ObjectParameter("ProductoID", typeof(int));
    
            var correoDuenoSubastaParameter = correoDuenoSubasta != null ?
                new ObjectParameter("CorreoDuenoSubasta", correoDuenoSubasta) :
                new ObjectParameter("CorreoDuenoSubasta", typeof(string));
    
            var fechaPublicadoParameter = fechaPublicado.HasValue ?
                new ObjectParameter("FechaPublicado", fechaPublicado) :
                new ObjectParameter("FechaPublicado", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Subasta>("spRelacion_Subasta_Visible_A_Insertar", mergeOption, correoDuenoListaParameter, sublistaIDParameter, productoIDParameter, correoDuenoSubastaParameter, fechaPublicadoParameter);
        }
    
        public virtual ObjectResult<Subasta> sp_Subasta_Select(string correo)
        {
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Subasta>("sp_Subasta_Select", correoParameter);
        }
    
        public virtual ObjectResult<Subasta> sp_Subasta_Select(string correo, MergeOption mergeOption)
        {
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Subasta>("sp_Subasta_Select", mergeOption, correoParameter);
        }
    
        public virtual int spRelacion_Producto_Visible_A_Insertar(string correoDuenoLista, Nullable<int> sublistaID, Nullable<int> productoID, string correoDuenoProducto)
        {
            var correoDuenoListaParameter = correoDuenoLista != null ?
                new ObjectParameter("CorreoDuenoLista", correoDuenoLista) :
                new ObjectParameter("CorreoDuenoLista", typeof(string));
    
            var sublistaIDParameter = sublistaID.HasValue ?
                new ObjectParameter("SublistaID", sublistaID) :
                new ObjectParameter("SublistaID", typeof(int));
    
            var productoIDParameter = productoID.HasValue ?
                new ObjectParameter("ProductoID", productoID) :
                new ObjectParameter("ProductoID", typeof(int));
    
            var correoDuenoProductoParameter = correoDuenoProducto != null ?
                new ObjectParameter("CorreoDuenoProducto", correoDuenoProducto) :
                new ObjectParameter("CorreoDuenoProducto", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRelacion_Producto_Visible_A_Insertar", correoDuenoListaParameter, sublistaIDParameter, productoIDParameter, correoDuenoProductoParameter);
        }
    
        public virtual int ExisteEnSublista(Nullable<int> subid, string amigo, ObjectParameter existe)
        {
            var subidParameter = subid.HasValue ?
                new ObjectParameter("subid", subid) :
                new ObjectParameter("subid", typeof(int));
    
            var amigoParameter = amigo != null ?
                new ObjectParameter("amigo", amigo) :
                new ObjectParameter("amigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ExisteEnSublista", subidParameter, amigoParameter, existe);
        }
    
        public virtual ObjectResult<Nullable<int>> spSubasta_Contar(string correoSublista, Nullable<int> sublistaId, Nullable<int> productoID, string correoSubasta, Nullable<System.DateTime> fecha, Nullable<short> publicoEspecial)
        {
            var correoSublistaParameter = correoSublista != null ?
                new ObjectParameter("correoSublista", correoSublista) :
                new ObjectParameter("correoSublista", typeof(string));
    
            var sublistaIdParameter = sublistaId.HasValue ?
                new ObjectParameter("SublistaId", sublistaId) :
                new ObjectParameter("SublistaId", typeof(int));
    
            var productoIDParameter = productoID.HasValue ?
                new ObjectParameter("ProductoID", productoID) :
                new ObjectParameter("ProductoID", typeof(int));
    
            var correoSubastaParameter = correoSubasta != null ?
                new ObjectParameter("correoSubasta", correoSubasta) :
                new ObjectParameter("correoSubasta", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            var publicoEspecialParameter = publicoEspecial.HasValue ?
                new ObjectParameter("PublicoEspecial", publicoEspecial) :
                new ObjectParameter("PublicoEspecial", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spSubasta_Contar", correoSublistaParameter, sublistaIdParameter, productoIDParameter, correoSubastaParameter, fechaParameter, publicoEspecialParameter);
        }
    
        public virtual ObjectResult<Subasta> spSubasta_ContarAmigos(Nullable<int> productoID, string correoSubasta, Nullable<System.DateTime> fecha)
        {
            var productoIDParameter = productoID.HasValue ?
                new ObjectParameter("ProductoID", productoID) :
                new ObjectParameter("ProductoID", typeof(int));
    
            var correoSubastaParameter = correoSubasta != null ?
                new ObjectParameter("correoSubasta", correoSubasta) :
                new ObjectParameter("correoSubasta", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Subasta>("spSubasta_ContarAmigos", productoIDParameter, correoSubastaParameter, fechaParameter);
        }
    
        public virtual ObjectResult<Subasta> spSubasta_ContarAmigos(Nullable<int> productoID, string correoSubasta, Nullable<System.DateTime> fecha, MergeOption mergeOption)
        {
            var productoIDParameter = productoID.HasValue ?
                new ObjectParameter("ProductoID", productoID) :
                new ObjectParameter("ProductoID", typeof(int));
    
            var correoSubastaParameter = correoSubasta != null ?
                new ObjectParameter("correoSubasta", correoSubasta) :
                new ObjectParameter("correoSubasta", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Subasta>("spSubasta_ContarAmigos", mergeOption, productoIDParameter, correoSubastaParameter, fechaParameter);
        }
    
        public virtual ObjectResult<Subasta> spSubasta_ContarSublistas(Nullable<int> productoID, string correoSubasta, Nullable<System.DateTime> fecha)
        {
            var productoIDParameter = productoID.HasValue ?
                new ObjectParameter("ProductoID", productoID) :
                new ObjectParameter("ProductoID", typeof(int));
    
            var correoSubastaParameter = correoSubasta != null ?
                new ObjectParameter("correoSubasta", correoSubasta) :
                new ObjectParameter("correoSubasta", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Subasta>("spSubasta_ContarSublistas", productoIDParameter, correoSubastaParameter, fechaParameter);
        }
    
        public virtual ObjectResult<Subasta> spSubasta_ContarSublistas(Nullable<int> productoID, string correoSubasta, Nullable<System.DateTime> fecha, MergeOption mergeOption)
        {
            var productoIDParameter = productoID.HasValue ?
                new ObjectParameter("ProductoID", productoID) :
                new ObjectParameter("ProductoID", typeof(int));
    
            var correoSubastaParameter = correoSubasta != null ?
                new ObjectParameter("correoSubasta", correoSubasta) :
                new ObjectParameter("correoSubasta", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Subasta>("spSubasta_ContarSublistas", mergeOption, productoIDParameter, correoSubastaParameter, fechaParameter);
        }
    
        public virtual int spCategoriaProducto_Insert(Nullable<int> iDCategoria, Nullable<int> productoID, string correoClienteProducto)
        {
            var iDCategoriaParameter = iDCategoria.HasValue ?
                new ObjectParameter("IDCategoria", iDCategoria) :
                new ObjectParameter("IDCategoria", typeof(int));
    
            var productoIDParameter = productoID.HasValue ?
                new ObjectParameter("ProductoID", productoID) :
                new ObjectParameter("ProductoID", typeof(int));
    
            var correoClienteProductoParameter = correoClienteProducto != null ?
                new ObjectParameter("CorreoClienteProducto", correoClienteProducto) :
                new ObjectParameter("CorreoClienteProducto", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCategoriaProducto_Insert", iDCategoriaParameter, productoIDParameter, correoClienteProductoParameter);
        }
    }
}