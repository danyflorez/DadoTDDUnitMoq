using System;

namespace TarjetasCreditoWeb.Tests
{
    public class JuegoAzar
    {
        private Dado dado;

        public JuegoAzar(Dado dado)
        {
            this.dado = dado;
        }

        public string jugar()
        {
            var resultado = "";
            if (dado.lanzarDado() == 5) {
                resultado = "Ganaste!!";
            }
            return resultado;
        }
    }
}