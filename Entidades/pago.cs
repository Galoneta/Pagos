using System;

abstract class Pago {
    public string Titular { get; set; }
    public double Monto { get; set; }

    public Pago(string titular, double monto) {
        Titular = titular;
        Monto = monto;
    }

    public abstract double ProcesarPago();

    public virtual void MostrarInfo() {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Monto: {Monto}");
    }
}
