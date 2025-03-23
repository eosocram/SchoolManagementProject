using System.Collections.Generic;
namespace Models
{
    public class ModelProfessor : Funcionario
    {

        public virtual void RegistroDeCargaHoraria()
        {
            DateTime dataHoje = DateTime.Now;
            Console.Write($"Registre a carga horária {dataHoje:dd/MM/yy}: ");

            if (!int.TryParse(Console.ReadLine()?.Trim(), out int    cargaHoraria))
            {
                Console.WriteLine($"Dia: {dataHoje:dd/MM/yy} | Horas trabalhadas: {cargaHoraria}H");
            }
            else
            {
                Console.WriteLine($"Entrada inválida. Insira um número inteiro para a carga horária.");
            }
        }
    }
} 