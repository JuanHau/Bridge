using Bridge.Entidades.Interfaces;

namespace Bridge.Entidades
{
    public class Fedex : IEmpresa
    {
        public string EntregarPedido()
        {
            return "Fedex se encuentra entregando un pedido por medio de {0}";
        }

        public string EnviarPedido()
        {
            return "Fedex se encuentra enviando un pedido por medio de {0}";
        }

        public string RecogerPedido()
        {
            return "Fedex se encuentra recogiendo un pedido por medio de {0}";
        }
    }
}
