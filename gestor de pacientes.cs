using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Pacientes 
{
    public string[] fila = new string[10]; // Vetor para armazenar os pacientes
    public int contador = 0; // Variável para controlar o número de pacientes na fila

    public void Main(string[] args)
    {
        char opcao;

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Cadastrar paciente");
            Console.WriteLine("2. Inserir paciente na fila");
            Console.WriteLine("3. Listar fila de pacientes");
            Console.WriteLine("4. Incluir paciente prioritário");
            Console.WriteLine("5. Atender paciente");
            Console.WriteLine("Q. Sair");

            Console.Write("\nEscolha uma opção: ");
            opcao = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (opcao)
            {
                case '1':
                    CadastrarPaciente();
                    break;
                case '2':
                    InserirPacienteNaFila();
                    break;
                case '3':
                    ListarFilaDePacientes();
                    break;
                case '4':
                    IncluirPacientePrioritario();
                    break;
                case '5':
                    AtenderPaciente();
                    break;
                case 'Q':
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                    break;
            }

        } while (opcao != 'Q');
    }

    public void CadastrarPaciente()
    {
        Console.Write("Digite o nome do paciente: ");
        string nome = Console.ReadLine();

       
    }

    public void InserirPacienteNaFila()
    {
        if (contador < fila.Length)
        {
            Console.Write("Digite o nome do paciente a ser inserido na fila: ");
            string nome = Console.ReadLine();
            fila[contador] = nome;
            contador++;
            Console.WriteLine("Paciente inserido na fila com sucesso.");
        }
        else
        {
            Console.WriteLine("A fila está cheia. Não é possível adicionar mais pacientes.");
        }
    }

    public void ListarFilaDePacientes()
    {
        Console.WriteLine("Fila de pacientes:");

        // Verifica se i e menor que o contador 
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine($"{i + 1}. {fila[i]}");
        }
    }

    public void IncluirPacientePrioritario()
    {
        // 
        if (contador < fila.Length)
        {
            Console.Write("Digite o nome do paciente prioritário: ");
            string nome = Console.ReadLine();

            //Coloca os pacientes na fila de prioridade
            for (int i = contador; i > 0; i--)
            {
                fila[i] = fila[i - 1];
            }

            fila[0] = nome;
            contador++;
            Console.WriteLine("Paciente prioritário incluído na fila com sucesso.");
        }
        else
        {
            Console.WriteLine("A fila está cheia. Não é possível adicionar mais pacientes.");
        }
    }

    public void AtenderPaciente()
    {
        if (contador > 0)
        {
            Console.WriteLine($"Paciente {fila[0]} atendido e removido da fila.");
            // Desloca os pacientes na fila para preencher o espaço do paciente atendido
            for (int i = 0; i < contador - 1; i++)
            {
                fila[i] = fila[i + 1];
            }
            contador--;
        }
        else
        {
            Console.WriteLine("Não há pacientes na fila para serem atendidos.");
        }
    }
}