decimal valorcompra, valorpago, valortroco;

Console.WriteLine("---Troco---\n");


Console.Write("Valor de Compra:.....");
valorcompra = Convert.ToDecimal (Console.ReadLine());

Console.Write("Valor Pago:....");
valorpago = Convert.ToDecimal (Console.ReadLine());

valortroco = valorpago - valorcompra;

Console.WriteLine($"\n Troco: {valortroco:C}");