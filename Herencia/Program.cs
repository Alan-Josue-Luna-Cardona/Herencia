
using Herencia.ClaseHIja;

Nintendo nintendo = new Nintendo();
nintendo.anioLanzamiento = 2017;
nintendo.esPortable = true;
nintendo.Marca = "Switch";
Console.WriteLine(nintendo.MostrasDetallesNintendo());

//instancia de PS1
PlayStation ps = new PlayStation();
ps.Marca = "Play Station 1";
ps.anioLanzamiento = 1994;
ps.ModeloControlador = "DualSense";
Console.WriteLine($"{ps.MostrarDetallePlay()}");

//instancia de Xbox
Xbox xbox = new Xbox();
xbox.Marca = "Xbox 360";
xbox.anioLanzamiento = 2005;
xbox.TieneHalo = true;
Console.WriteLine(nintendo.MostrasDetallesNintendo());

//instancia de DreamCast
SegaDreamCast sega = new SegaDreamCast();
sega.Marca = "Sega DreamCast";
sega.anioLanzamiento = 1998;
sega.ControlconPantallita = true;
Console.WriteLine(nintendo.MostrasDetallesNintendo());





