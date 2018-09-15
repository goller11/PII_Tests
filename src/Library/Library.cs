using System;
using System.Linq;

namespace Testing
{
    public class Library
    {
        public static bool ValidateID (string ci) {

            long verificadorFormato;

            if (ci.Length == 8 && long.TryParse (ci, out verificadorFormato)) {
                var vectorStrCI = ci.ToCharArray ();
                var vectorCI = vectorStrCI.Select (c => int.Parse (c.ToString ())).ToArray ();
                var vectorReferencia = "2987634".ToCharArray ().Select (c => int.Parse (c.ToString ())).ToArray ();

                var verificadorIngresado = vectorCI[7];

                int numeroVerificadorRaw = 0;

                for (int i = 0; i < vectorReferencia.Length; i++) {
                    numeroVerificadorRaw = numeroVerificadorRaw + (vectorCI[i] * vectorReferencia[i]);
                }

                int verificadorCalculado = 10 - (numeroVerificadorRaw % 10);

                if (verificadorCalculado != verificadorIngresado) {
                    return false;
                }
            } else {
                return false;
            }

            return true;
        }    

        public string Name { get; set; }
        string ci;
        public string CI {
            get { return this.ci; }
            set {
                if (Library.ValidateID (value)) {
                    ci = value;
                } else {
                    ci = "0";
                }
            }
        }

        public Library (string name, string cedula) {
            this.Name = name;
            this.CI = cedula;
        }

        public void IntroduceYourself () {
            Console.WriteLine ($"La cédula de {this.Name} es {this.ci}.");
        }

    }
}
