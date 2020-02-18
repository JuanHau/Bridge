using Bridge.Entidades;
using Bridge.Servicios;
using System;

namespace Bridge
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //Empresas
            Fedex fedex = new Fedex();
            Dhl dhl = new Dhl();
            Estafeta estafeta = new Estafeta();

            //Servicios para el procesamiento de los paquetes
            EnvioPaqueteTren envioPaqueteTren;
            EnvioPaqueteBarco envioPaqueteBarco;
            EnvioPaqueteAvion envioPaqueteAvion;

            envioPaqueteBarco = new EnvioPaqueteBarco(fedex);
            envioPaqueteBarco.ProcesarEnvio();

            envioPaqueteAvion = new EnvioPaqueteAvion(dhl);
            envioPaqueteAvion.ProcesarEnvio();
            envioPaqueteBarco = new EnvioPaqueteBarco(dhl);
            envioPaqueteBarco.ProcesarEnvio();

            envioPaqueteTren = new EnvioPaqueteTren(estafeta);
            envioPaqueteTren.ProcesarEnvio();

            Console.ReadLine();
        }
    }
}
