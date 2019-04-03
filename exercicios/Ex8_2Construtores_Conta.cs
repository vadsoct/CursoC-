using System.Globalization;
namespace C_ {
class Ex8_2Construtores_Conta {

public int NConta { get; private set; }
public string Titular { get; set; }
public double Saldo { get; private set; }

public Ex8_2Construtores_Conta(string titular, int nConta) {
    NConta = nConta;
    Titular = titular;
    Saldo = 0;

}
public Ex8_2Construtores_Conta(string titular, int nConta, double depositoInicial ):this (titular, nConta) {
    Deposito(depositoInicial);
}

public void Deposito(double quantia){
    Saldo += quantia;
}

public void Saque(double quantia){
    Saldo -= quantia + 5.0;
}

public override string ToString() {
return "Numero da Conta: "
+ NConta
+ ", Titular: "
+ Titular
+ ", Saldo: $"
+ Saldo.ToString("F2",CultureInfo.InvariantCulture);
}
}
}