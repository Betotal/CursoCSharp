namespace Memb_Static {
    class ConversorDeMoeda {
        
        public static double Iof = 1.06;
        public static string NomeMoeda;
        public static double ValorMoeda;
        public static int QtdeMoeda;


        public static double ValorEmReais() {
            return ValorMoeda * QtdeMoeda * Iof;
        }

    }
}
