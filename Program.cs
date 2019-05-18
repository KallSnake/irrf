using System;


namespace IRRF
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.Write("informe seu salário para calculo de imposto de renda: ");
            string salarioBruto = Console.ReadLine();


            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Salário bruto: " + salarioBruto);
            Console.WriteLine(); Console.WriteLine();


            float inss = 0f;
            float inssAliquota = 0f;
            float sb = Convert.ToSingle(salarioBruto);



            if (sb <= 1751.81)
            {

                inss = ((sb * 8) / 100);
                inssAliquota = 8;

            }
            else if ((sb >= 1751.82) && (sb <= 2919.72))
            {

                inss = ((sb * 9) / 100);
                inssAliquota = 9;

            }
            else if ((sb >= 2919.73) && (sb <= 5839.45))
            {

                inss = ((sb * 11) / 100);
                inssAliquota = 11;

            }
            else if ((sb > 5839.45))
            {

                inss = 642.34f;

            }



            // salario 1500 
            // inss 120
            // salario - inss 1380



            // Imposto de renda
            float impostoReda = (sb - inss);
            float impostoRetido = 0f;
            string irrfAliquota = "";


            if (!inssAliquota.Equals(0))
            {

                Console.WriteLine("INSS - Aliquota de " + inssAliquota + "%   | Desconto de: " + inss);
                Console.WriteLine(); Console.WriteLine();

            }
            else
            {

                Console.WriteLine("INSS - Valor fixo de 642.34   | Desconto de: " + inss);
                Console.WriteLine(); Console.WriteLine();

            }




            if ((impostoReda >= 1903.99) && (impostoReda <= 2826.65))
            {

                impostoRetido = Convert.ToSingle(((impostoReda * 7.5) / 100) - 142.80);
                irrfAliquota = "7.5%";

            }
            else if ((impostoReda >= 2826.66) && (impostoReda <= 3751.05))
            {

                impostoRetido = Convert.ToSingle(((impostoReda * 15) / 100) - 354.80);
                irrfAliquota = "15%";

            }
            else if ((impostoReda >= 3751.06) && (impostoReda <= 4664.68))
            {

                impostoRetido = Convert.ToSingle(((impostoReda * 22.5) / 100) - 636.13);
                irrfAliquota = "22.5%";

            }
            else if ((impostoReda > 4664.68))
            {

                impostoRetido = Convert.ToSingle(((impostoReda * 27.5) / 100) - 869.36);
                irrfAliquota = "27.5%";

            }



            // impostoReda 1380
            // 1380 * 7.5 / 100 = 103.50


            Console.WriteLine("Imposto retido (IRRF) - Aliquota " + irrfAliquota + "   | Desconto de: " + impostoRetido);
            Console.WriteLine(); Console.WriteLine();



            float salarioLiquido = ((((sb - inss) - impostoRetido)));


            Console.WriteLine("Salário Líquido: " + salarioLiquido);



            Console.ReadKey();

        }
    }
}
