using Bridge.Entidades.Interfaces;
using Bridge.Servicios.Interfaces;
using System;

namespace Bridge.Servicios
{
    public class EnvioPaqueteBarco : IEnvioPaquete
    {
        protected IEmpresa _empresa;

        public EnvioPaqueteBarco(IEmpresa empresa)
        {
            _empresa = empresa;
        }

        public void ProcesarEnvio()
        {
            Console.WriteLine(string.Format(_empresa.RecogerPedido(), "barco"));
            Console.WriteLine(string.Format(_empresa.EnviarPedido(), "barco"));
            Console.WriteLine(string.Format(_empresa.EntregarPedido(), "barco"));
            Console.WriteLine();
        }
    }
}
