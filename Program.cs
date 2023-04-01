decimal valorCompra, valorPago, valorTroco;
Console.WriteLine(" valor do Troco \n");
Console.Write("Valor da compra (R$)...: ");
valorCompra = Convert.ToDecimal(Console.ReadLine());
Console.Write("Valor pago (R$)........: ");
valorPago = Convert.ToDecimal(Console.ReadLine());
valorTroco = valorPago - valorCompra;

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($"\nTroco: {valorTroco:C}");
