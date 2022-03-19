namespace IspModificado
{
    internal interface ITareasImpresora
    {
        void Imprimir(string contenidoAImprimir);
        void Escanear(string contenidoAEscanear);
    }

    interface ITareaFax
    {
        void Fax(string contenidoAEnviarPorFax);
    }
    interface ITareaImprimirDuplex
    {
        void Duplex(string contenidoAEnviarPorDuplex);
    }
}