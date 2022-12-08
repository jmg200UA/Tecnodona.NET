
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using TecnodonaGenNHibernate.EN.Tecnodona;
using TecnodonaGenNHibernate.CEN.Tecnodona;
using TecnodonaGenNHibernate.CAD.Tecnodona;
using TecnodonaGenNHibernate.Enumerated.Tecnodona;
using TecnodonaGenNHibernate.CP.Tecnodona;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                // Insert the initilizations of entities using the CEN classes


                // p.e. CustomerCEN customer = new CustomerCEN();
                // customer.New_ (p_user:"user", p_password:"1234");
                AdministradorCEN admin = new AdministradorCEN ();
                ArticuloCEN articulo = new ArticuloCEN ();
                ClienteCEN cliente = new ClienteCEN ();
                FacturaCEN factura = new FacturaCEN ();
                LineaPedidoCP linea_pedido = new LineaPedidoCP ();
                MetodoPagoCEN pago = new MetodoPagoCEN ();
                PedidoCEN pedido = new PedidoCEN ();
                PedidoCP pedidoCP = new PedidoCP ();
                ProductoCEN producto = new ProductoCEN ();
                ProveedorCEN proveedor = new ProveedorCEN ();
                ValoracionCEN valoracion = new ValoracionCEN ();
                //TipoPagoEnum enum;


                //Creamos proveedores
                IList<String> list_proveedor = new List<String>();
                String proveedor1 = proveedor.New_ ("david", "David", "xdxdxdp", "p@correo.com", 674924923);
                list_proveedor.Add (proveedor1);
                String proveedor2 = proveedor.New_ ("nazar", "Nazar", "xdxdxdp", "p@correo.com", 674924923);
                list_proveedor.Add (proveedor2);
                String proveedor3 = proveedor.New_ ("javi", "Javi", "xdxdxdp", "p@correo.com", 674924923);
                list_proveedor.Add (proveedor3);
                String proveedor4 = proveedor.New_("ismael", "Ismael", "xdxdxdp", "p@correo.com", 674924923);
                list_proveedor.Add(proveedor4);

                //Creamos admins
                string admin1 = admin.New_ ("Orslok", "admin", "admin", "admin@correo.com", 612345678);
                string admin2 = admin.New_ ("Ibai", "admin", "admin", "admin@correo.com", 612345678);
                string admin3 = admin.New_ ("Auron", "admin", "admin", "admin@correo.com", 612345678);

                //Creamos clientes
                String cliente1 = cliente.New_ ("mario", "Mario", "blanco", "david@correo.com", 687654321);
                if (cliente.Login ("mario", "blanco") != null)
                        Console.WriteLine ("El login de " + cliente1 + " es correcto");
                String cliente2 = cliente.New_ ("isma", "Isma", "blanco", "david@correo.com", 687654321);
                if (cliente.Login ("isma", "blanco") != null)
                        Console.WriteLine ("El login de " + cliente2 + " es correcto");
                String cliente3 = cliente.New_ ("gonsalo", "Gonsalo", "blanco", "david@correo.com", 687654321);
                if (cliente.Login ("gonsalo", "blanco") != null)
                        Console.WriteLine ("El login de " + cliente3 + " es correcto");

                //Creamos metodos de pago
                int pago1 = pago.New_ ("paypal", (TecnodonaGenNHibernate.Enumerated.Tecnodona.TipoPagoEnum) 2);
                int pago2 = pago.New_ ("bizum", (TecnodonaGenNHibernate.Enumerated.Tecnodona.TipoPagoEnum) 1);
                int pago3 = pago.New_ ("navajazo", (TecnodonaGenNHibernate.Enumerated.Tecnodona.TipoPagoEnum) 3);

                //Creamos productos
                int producto1 = producto.New_ (list_proveedor, 2, 300, 14.35);
                int producto2 = producto.New_ (list_proveedor, 3, 300, 17.85);
                int producto3 = producto.New_ (list_proveedor, 4, 300, 20.5);


                //Creamos articulo
                int articulo1 = articulo.New_ ("PS5", 400, "Consola ultima generacion", proveedor1, producto1, true);
                int articulo2 = articulo.New_ ("Lamborghini", 400000, "Coche to flama", proveedor2, producto2, true);
                int articulo3 = articulo.New_ ("Tarta de fresa", 20, "Cocinada por los mejores chefs", proveedor3, producto3, true);

                //Creamos valoraciones
                int valoracion1 = valoracion.New_ ("Buen producto", 5, cliente1, articulo1);
                int valoracion2 = valoracion.New_ ("Un chollazo", 4, cliente2, articulo2);
                int valoracion3 = valoracion.New_ ("Pa chuparse los dedos", 3, cliente3, articulo3);

                ArticuloEN articuloEN1 = articulo.ReadOID(articulo1);
                ArticuloEN articuloEN2 = articulo.ReadOID(articulo2);

                //Creamos pedidos
                String pedido1 = pedido.CrearPedido ("1", "1", articulo1, articuloEN1.Precio, EstadoPedidoEnum.carrito, new DateTime (2020, 12, 3), new DateTime (2020, 12, 3),
                        pago1, cliente1);
                String pedido2 = pedido.CrearPedido ("2", "1", articulo1, 5.5, EstadoPedidoEnum.carrito, new DateTime (2020, 12, 3), new DateTime (2020, 12, 3),
                        pago1, cliente1);
                String pedido3 = pedido.CrearPedido ("3", "1", articulo1, articuloEN2.Precio, EstadoPedidoEnum.carrito, new DateTime (2020, 12, 3), new DateTime (2020, 12, 3),
                        pago1, cliente1);

                //Creamos lineas
                List<LineaPedidoEN> lists = new List<LineaPedidoEN>();
                IList<LineaPedidoEN> linea = lists;
                LineaPedidoEN linea1 = linea_pedido.New_ (5, producto1, pedido1);
                LineaPedidoEN linea2 = linea_pedido.New_ (5, producto2, pedido2);
                LineaPedidoEN linea3 = linea_pedido.New_ (5, producto3, pedido3);

                linea.Add (linea1);
                linea.Add (linea2);
                linea.Add (linea3);


                //testeamos Decrementar Stock
                try
                {
                        producto.DecrementarStock (producto1, 1000);
                }
                catch (Exception e)
                {
                        System.Console.WriteLine (e.Message);
                }
                try
                {
                        producto.DecrementarStock (producto1, 20);
                        ProductoEN productoEN = producto.ReadOID (producto1);
                        Console.WriteLine ("El producto 1 ha decrementado su stock a " + productoEN.Stock);
                }
                catch (Exception e)
                {
                        System.Console.WriteLine (e.Message);
                }

                //testeamos Enviar Pedido
                try
                {
                        pedido.EnviarPedido (pedido1);
                }
                catch (Exception e)
                {
                        System.Console.WriteLine (e.Message);
                }
                try
                {
                        pedido.EnviarPedido (pedido1);
                }
                catch (Exception e)
                {
                        System.Console.WriteLine (e.Message);
                }
                //testeamos Valorar Articulo
                try
                {
                        articulo.ValorarArticulo (articulo1, valoracion1, 20);
                }
                catch (Exception e)
                {
                        System.Console.WriteLine (e.Message);
                }
                try
                {
                        articulo.ValorarArticulo (articulo1, valoracion1, 2);
                }
                catch (Exception e)
                {
                        System.Console.WriteLine (e.Message);
                }
                //testeamos Rechazar Pedido
                try
                {
                        pedido.RechazarPedido (pedido1);
                }
                catch (Exception e)
                {
                        System.Console.WriteLine (e.Message);
                }
                try
                {
                        pedido.RechazarPedido (pedido2);
                }
                catch (Exception e)
                {
                        System.Console.WriteLine (e.Message);
                }
                /*
                 * //testeamos Validar Pedido
                 * try
                 * {
                 *      pedidoCP.ValidarPedido (pedido1);
                 * }
                 * catch (Exception e)
                 * {
                 *      System.Console.WriteLine (e.Message);
                 * }
                 * try
                 * {
                 *      pedidoCP.ValidarPedido (pedido2);
                 * }
                 * catch (Exception e)
                 * {
                 *      System.Console.WriteLine (e.Message);
                 * }
                 */

                Console.WriteLine("el precio del articulo " + articuloEN1.Nombre + " es " + articuloEN1.Precio);

                //testeamos la compleja de new Linea Pedido
                linea_pedido.New_ (300, producto1, pedido3);
                PedidoEN pedEN = pedido.ReadOID (pedido3);
                Console.WriteLine ("El pedido 1 tiene el total (primera linea): " + pedEN.TotalPrecio);

                linea_pedido.New_ (500, producto1, pedido3);
                pedEN = pedido.ReadOID (pedido3);
                Console.WriteLine ("El pedido 2 tiene el total (segunda linea): " + pedEN.TotalPrecio);

                linea_pedido.New_ (20, producto1, pedido3);
                pedEN = pedido.ReadOID (pedido3);
                Console.WriteLine ("El pedido 3 tiene el total (tercera linea): " + pedEN.TotalPrecio);
                
                 //testeamos Dame Pedido por Producto
                 IList<PedidoEN> listaPedidos = pedido.DamePedidoPorProducto (producto1);
                 Console.WriteLine ("Lista de pedidos que tienen el producto #" + producto1 + ":");
                 foreach (PedidoEN ped in listaPedidos) {
                      Console.WriteLine ("Pedido " + ped.Codigo);
                 }
                 /*
                 * //testeamos Dame Cliente por Pedido
                 * IList<ClienteEN> listaClientes = pedido.DameClientePorPedido (pedido2);
                 * Console.WriteLine ("El cliente que tiene el producto#" + pedido2 + ":");
                 * foreach (ClienteEN ped in listaClientes) {
                 *      Console.WriteLine ("Cliente " + ped.Usuario);
                 * }
                 */
                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
