CREATE PROCEDURE [dbo].[spVirtual_Insert]


    @Nombre NVARCHAR(50),
    @CorreoCliente NVARCHAR(50),
    @PrecioEstimado FLOAT,
    @Condicion NCHAR(50),
    @Descripcion TEXT,
    @ProductoImagen1 IMAGE,
    @ProductoImagen2 IMAGE,
    @ProductoImagen3 IMAGE,
    @Publicado BIT,
    @FechaRegistrado DATETIME,


    --  Caracteristicas del virtual
    @TipoDeArchivo NVARCHAR(50),
    @DerechosDeProducto NVARCHAR(50) NULL,
    @Fuentes NVARCHAR(50) NULL,
    @FechaExpiracion DATETIME NULL

AS
BEGIN
        DECLARE @ProductoVirtualID INT

        INSERT INTO [Producto] ([Nombre], [CorreoCliente], [PrecioEstimado], [Condicion], [Descripcion], [ProductoImagen1], [ProductoImagen2], [ProductoImagen3], [Publicado], [FechaRegistrado])
            VALUES(@Nombre, @CorreoCliente, @PrecioEstimado, @Condicion, @Descripcion, @ProductoImagen1, @ProductoImagen2, @ProductoImagen3, @Publicado, @FechaRegistrado)

        SET @ProductoVirtualID = (
            SELECT MAX(ProductoID)
            FROM Producto
        )

    INSERT INTO [Virtual] ([ProductoID], [CorreoCliente], [TipoDeArchivo], [DerechosDeProducto], [Fuentes], [FechaExpiracion])
        VALUES(@ProductoVirtualID, @CorreoCliente, @TipoDeArchivo, @DerechosDeProducto, @Fuentes, @FechaExpiracion)
END