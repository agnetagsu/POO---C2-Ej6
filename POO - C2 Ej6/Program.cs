using System;

namespace POO___C2_Ej6
{
    class Coche
    {
        private string marca;
        private string modelo;
        private int cilindrada;
        private decimal potencia;


        public String Marca
        {
            get
            {
                return marca;
            }
            set
            {
                marca = value;
            }
        }
        public String Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                modelo = value;
            }
        }
        public int Cilindrada
        {
            get
            {
                return cilindrada;
            }
            set
            {
                cilindrada = value;
            }
        }
        public decimal Potencia
        {
            get
            {
                return potencia;
            }
            set
            {
                potencia = value;
            }
        }
        static void Main(string[] args)
        {
            Coche micoche = new Coche();

            micoche.marca = "Toyota";
            micoche.modelo = "Avensis D4D";
            micoche.cilindrada = 4;
            micoche.potencia = 3600;

            Console.WriteLine("Marca: {0} Modelo: {1} con {2} cilindros y {3} de potencia", micoche.marca, micoche.modelo,micoche.cilindrada,micoche.potencia);
        }
    }
}
