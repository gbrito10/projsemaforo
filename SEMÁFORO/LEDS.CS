using System;

namespace projLeds
{
    internal class Leds
    {
        private byte dado;

        // Construtor padrão
        public Leds()
        {
            this.dado = 0;
        }

        // Construtor com valor inicial
        public Leds(byte dado)
        {
            this.dado = dado;
        }

        // Método para acender um LED
        public void Acender(int led)
        {
            if (led < 0 || led > 7)
                throw new ArgumentOutOfRangeException("led deve estar entre 0 e 7");
            dado |= (byte)(1 << led); // Usando deslocamento de bits
        }

        // Método para apagar um LED
        public void Apagar(int led)
        {
            if (led < 0 || led > 7)
                throw new ArgumentOutOfRangeException("led deve estar entre 0 e 7");
            dado &= (byte)~(1 << led); // Usando deslocamento de bits
        }

        // Método para obter o valor atual de dado
        public byte GetDado()
        {
            return this.dado;
        }

        // Método para verificar se um LED está aceso
        public bool GetLed(int led)
        {
            if (led < 0 || led > 7)
                throw new ArgumentOutOfRangeException("led deve estar entre 0 e 7");
            return (dado & (1 << led)) != 0; // Usando deslocamento de bits
        }
    }
}