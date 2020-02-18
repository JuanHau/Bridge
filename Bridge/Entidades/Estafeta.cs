using Bridge.Entidades.Interfaces;

namespace Bridge.Entidades
{
    public class Estafeta : IEmpresa
    {
        public string EntregarPedido()
        {
            return "Estafeta se encuentra entregando un pedido por medio de {0}";
        }

        public string EnviarPedido()
        {
            return "Estafeta se encuentra enviando un pedido por medio de {0}";
        }

        public string RecogerPedido()
        {
            return "Estafeta se encuentra recogiendo un pedido por medio de {0}";
        }
    }
}
