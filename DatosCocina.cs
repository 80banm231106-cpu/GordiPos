// La palabra 'static' significa que esta clase es única y global para todo el programa
using System.Collections.Generic;

public static class DatosCocina
{
    // Esta lista será nuestro pizarrón donde anotaremos los pedidos nuevos
    public static List<string> PedidosEnEspera = new List<string>();

    // Un contador para saber qué número de pedido es
    public static int NumeroPedidoActual = 1;
}