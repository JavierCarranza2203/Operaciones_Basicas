namespace Operaciones_Basicas
{
    public class FuncionesBasicas
    {
        private bool _blnAceptaNegativos;
        private bool _blnAceptaDecimales;

        public FuncionesBasicas(bool aceptaNegativos = true, bool aceptaDecimales = true)
        {
            this._blnAceptaDecimales = aceptaDecimales;
            this._blnAceptaDecimales = aceptaNegativos;
        }

        public double Sumar(List<double> valores) 
        {
            double suma = 0;

            foreach (double valor in valores)
            {
                if(valor < 0 && this._blnAceptaNegativos == false) throw new Exception("El valor " + valor + " no es aceptado porque no se aceptan negativos");
                suma += valor;
            }

            return suma;
        }

        public double Restar(List<double> valores)
        { 
            double resultado = valores[0];

            bool primerValor = false;
            foreach (double valor in valores)
            {
                if(primerValor == false) primerValor = true;
                else resultado -= valor;
            }

            return resultado;
        }
    }
}
