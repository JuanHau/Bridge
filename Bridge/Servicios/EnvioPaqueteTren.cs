using Bridge.Entidades.Interfaces;
using Bridge.Servicios.Interfaces;
using System;

namespace Bridge.Servicios
{
    public class EnvioPaqueteTren : IEnvioPaquete
    {
        protected IEmpresa _empresa;

        public EnvioPaqueteTren(IEmpresa empresa)
        {
            _empresa = empresa;
        }

        public void ProcesarEnvio()
        {
            Console.WriteLine(string.Format(_empresa.RecogerPedido(), "tren"));
            Console.WriteLine(string.Format(_empresa.EnviarPedido(), "tren"));
            Console.WriteLine(string.Format(_empresa.EntregarPedido(), "tren"));
            Console.WriteLine();
        }
    }
}
