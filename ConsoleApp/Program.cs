using ConsoleApp.Conexion;


Console.WriteLine("Hello, World!");
var conexion = new ConexionBasica();
conexion.ObtenerPeliculas();
conexion.ObtenerPeliculas_Procedimiento();


var conexionEF = new ConexionEF();
conexionEF.GuardarPeliculas();
conexionEF.ObtenerPeliculas(); 