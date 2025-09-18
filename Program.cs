using Models;
using System.Globalization;
using System.Runtime.InteropServices.JavaScript;

namespace SchoolManagement
{
    class Program
    {
        static void Main()
        {
            
                Console.WriteLine("Digite o número de mátricula:");
                int matricula = Convert.ToInt32(Console.ReadLine());

                DateTime dataRecisao = DateTime.MinValue;
                DateTime dataAdmissao = DateTime.MinValue;
                
                bool dataAdmissaoValida = false;
                bool dataRecisaoValida = false;
                
                while (!dataAdmissaoValida)
                {
                    string format = "MM/yyyy";
                    var culture = CultureInfo.CreateSpecificCulture("pt-BR");

                    try
                    {
                        Console.WriteLine("Digite sua data de admissão, inserindo - MÊS/ANO:");
                        string inputDataAdmissao = Console.ReadLine();
                        dataAdmissao = DateTime.ParseExact(inputDataAdmissao, format, culture);
                        Console.WriteLine($"Data de Admissão: {inputDataAdmissao}");

                        dataAdmissaoValida = true;
                    }
                    catch
                    {
                        Console.WriteLine("ERRO - Tipo de formatação inválida [DATA DE ADMISSÃO]");
                    }
                        


                }

                while (!dataRecisaoValida)
                {
                    try
                    { 
                        string format = "MM/yyyy";
                        var culture = CultureInfo.CreateSpecificCulture("pt-BR");
                        
                        Console.WriteLine($"Digite o período final de trabalho, inserindo MÊS/ANO");
                        string inputDataRecisao = Console.ReadLine();
                        dataRecisao = DateTime.ParseExact(inputDataRecisao, format, culture); 
                        Console.WriteLine($"Data Final de trabalho: {inputDataRecisao}");
                        
                        dataRecisaoValida = true;
                    }
                    catch 
                    {
                        Console.WriteLine("ERRO - Tipo de formatação inválida [DATA DE RECISÃO]"); 
                    }
                }
                Funcionario testUser = new Funcionario(matricula, dataAdmissao, dataRecisao);

                testUser.TempoDeServico();
            
         
            

        }
    }
}