using Bridge.Entidades.Interfaces;

namespace Bridge.Entidades
{
    public class Dhl : IEmpresa
    {
        public string EntregarPedido()
        {
            return "DHL se encuentra entregando un pedido por medio de {0}";
        }

        public string EnviarPedido()
        {
            return "DHL se encuentra enviando un pedido por medio de {0}";
        }

        public string RecogerPedido()
        {
            return "DHL se encuentra recogiendo un pedido por medio de {0}";
        }
    }
}
