using System;

class PagoTarjeta : Pago {
    public PagoTarjeta(string titular, double monto) : base(titular, monto) { }

    public override double ProcesarPago() {
        double comision = Monto * 0.05; // 5% comisión
        double total = Monto + comision;
        Console.WriteLine($"Pago con Tarjeta - Comisión: {comision}, Total: {total}");
        return total;
    }
}
