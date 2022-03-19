namespace IspMalaPractica
{
    internal interface ITareasImpresora
    {
        void Imprimir(string contenidoAImprimir);
        void Escanear(string contenidoAEscanear);
        void Fax(string contenidoAEnviarPorFax);
        void Duplex(string contenidoAEnviarPorDuplex);
    }
}
