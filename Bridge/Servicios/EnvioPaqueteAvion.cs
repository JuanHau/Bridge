using Bridge.Entidades.Interfaces;
using Bridge.Servicios.Interfaces;
using System;

namespace Bridge.Servicios
{
    public class EnvioPaqueteAvion : IEnvioPaquete
    {
        protected IEmpresa _empresa;

        public EnvioPaqueteAvion(IEmpresa empresa)
        {
            _empresa = empresa;
        }

        public void ProcesarEnvio()
        {
            Console.WriteLine(string.Format(_empresa.RecogerPedido(), "avión"));
            Console.WriteLine(string.Format(_empresa.EnviarPedido(), "avión"));
            Console.WriteLine(string.Format(_empresa.EntregarPedido(), "avión"));
            Console.WriteLine();
        }
    }
}
