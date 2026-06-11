using System;

class PagoTransferencia : Pago {
    public PagoTransferencia(string titular, double monto) : base(titular, monto) { }

    public override double ProcesarPago() {
        double costoFijo = 100; // costo fijo
        double total = Monto + costoFijo;
        Console.WriteLine($"Pago por Transferencia - Costo fijo: {costoFijo}, Total: {total}");
        return total;
    }
}
