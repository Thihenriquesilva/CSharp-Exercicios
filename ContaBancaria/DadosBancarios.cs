namespace ContaBancaria
{
    public class DadosBancarios
    {
        public string Titular;
        public int Agencia;
        public int Numero;
        public double Saldo;


        public DadosBancarios (int Agencia, int Numero, string Titular) {
            this.Agencia = Agencia; 
            this.Numero = Numero;  
            this.Titular = Titular;
        } 



        public bool Saldonegativo(double saldo){
            if((saldo == 0)){
                this.Saldo = 0.0;
                return true;
            } 
            else{
                return false;
            }
        }
    }
}