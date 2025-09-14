using ClientesOracleEf.DBContext;
using ClientesOracleEf.Model;
//Add pacote com recursos do EF Core
using Microsoft.EntityFrameworkCore;

// É o endereço completo para acessar o Oracle: usuário, senha, host:porta/ServiceName
var connectionString = "User Id=xxxx;Password=xxxx;Data Source=oracle.fiap.com.br:1521/ORCL;";

//Cria um “pacote de opções” que diz ao EF: “use Oracle e conecte em connectionString”
//'options' vamos usar no nosso AppDbContext
var options = new DbContextOptionsBuilder<AppDbContext>()
    .UseOracle(connectionString) 
    .Options;

int opcao;
do
{
    Console.WriteLine("\n======================");
    Console.WriteLine("\n=== MENU CLIENTES ===");
    Console.WriteLine("1 - Inserir");
    Console.WriteLine("2 - Listar");
    Console.WriteLine("3 - Atualizar");
    Console.WriteLine("4 - Excluir");
    Console.WriteLine("5 - Filtrar por Nome ");
    Console.WriteLine("6 - Retornar 3 Clientes ");
    Console.WriteLine("7 - Total de Clientes ");
    Console.WriteLine("8 - A tabela está vazia? ");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("----------------------");
    Console.Write("Escolha: ");
    Console.WriteLine();

    var input = Console.ReadLine();
    if (!int.TryParse(input, out opcao)) opcao = -1;

    try
    {
        //Cria o DbContext (db), nossa ponte com o banco.
        //using: para descartar a conexão automaticamente ao final do bloco
        using AppDbContext db = new AppDbContext(options);

        switch (opcao)
        {
            case 1: // CREATE
                Console.Write("Nome: ");
                var nome = Console.ReadLine()?.Trim() ?? "";
                Console.Write("Sobrenome: ");
                var sobrenome = Console.ReadLine()?.Trim() ?? "";

                if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(sobrenome))
                {
                    Console.WriteLine("Nome e Sobrenome são obrigatórios.");
                    break;
                }

                //Cria um novo objeto Cliente
                var novo = new Cliente();
                novo.Nome = nome;
                novo.Sobrenome = sobrenome;

                //Adiciona o novo cliente ao DbSet (tabela Clientes)
                db.Clientes.Add(novo);

                //Salva as mudanças no banco (INSERT)
                db.SaveChanges();

                Console.WriteLine($"Inserido com Id: {novo.IdCliente}");
                break;

            case 2: // Lista ordenada por nome
                var lista = db.Clientes.AsNoTracking()
                                       .OrderBy(c => c.Nome)
                                       .ToList();

                if (lista.Count == 0)
                {
                    Console.WriteLine("Sem registros.");
                }
                else
                {
                    foreach (var c in lista)
                        Console.WriteLine($"{c.IdCliente}: {c.Nome} {c.Sobrenome}");
                }
                break;

            case 3: // UPDATE
                Console.Write("Informe o ID para atualizar: ");
                if (decimal.TryParse(Console.ReadLine(), out var idU))
                {
                    //Procura o cliente no banco pelo Id (chave primária)
                    var cli = db.Clientes.Find(idU);
                    if (cli == null)
                    {
                        Console.WriteLine("Não encontrado.");
                        break;
                    }

                    Console.Write($"Nome atual ({cli.Nome}), novo (Enter p/ manter): ");
                    var novoNome = Console.ReadLine();
                    Console.Write($"Sobrenome atual ({cli.Sobrenome}), novo (Enter p/ manter): ");
                    var novoSobrenome = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(novoNome)) cli.Nome = novoNome.Trim();
                    if (!string.IsNullOrWhiteSpace(novoSobrenome)) cli.Sobrenome = novoSobrenome.Trim();

                    //Marca o objeto como modificado (UPDATE)
                    db.SaveChanges();

                    Console.WriteLine("Atualizado.");
                }
                else
                {
                    Console.WriteLine("ID inválido.");
                }
                break;

            case 4: // DELETE
                Console.Write("Informe o ID para excluir: ");
                if (decimal.TryParse(Console.ReadLine(), out var idD))
                {
                    //Procura o cliente no banco pelo Id (chave primária)
                    var cli = db.Clientes.Find(idD);
                    if (cli == null)
                    {
                        Console.WriteLine("Não encontrado.");
                        break;
                    }

                    //Remove o cliente do DbSet (DELETE)
                    db.Clientes.Remove(cli);

                    //Salva as mudanças no banco
                    db.SaveChanges();
                    Console.WriteLine("Excluído.");
                }
                else
                {
                    Console.WriteLine("ID inválido.");
                }
                break;

            case 5: //Filtra por parte do Nome
                Console.Write("Digite um nome para filtrar: ");
                var nomeBusca = Console.ReadLine()?.Trim();
                var filtrados = db.Clientes
                  .Where(c => c.Nome.Contains(nomeBusca))
                  .ToList();
                
                Console.WriteLine($"Clientes com Nome '{nomeBusca}':");
                foreach (var c in filtrados)
                    Console.WriteLine($"{c.IdCliente}: {c.Nome} {c.Sobrenome}");

                Console.WriteLine("\n---------------------------------------------\n");

                break;

            case 6: //Retornar 3 Clientes
                var tres = db.Clientes
                        .Take(3)
                        .ToList();

                Console.WriteLine("Três primeiros clientes:");
                foreach (var c in tres)
                    Console.WriteLine($"{c.IdCliente}: {c.Nome} {c.Sobrenome}");

                Console.WriteLine("\n---------------------------------------------\n");

                break;

            case 7: //Total de Clientes
                var total = db.Clientes.Count();
                Console.WriteLine($"Total de Clientes cadastrados: {total}");

                Console.WriteLine("\n---------------------------------------------\n");

                break;

            case 8: //A tabela está vazia?
                bool tabelaVazia = !db.Clientes.Any(); // true se estiver vazia
                //.Any() é usado para verificar se existe pelo menos um registro que atenda a condição
                if (tabelaVazia)
                    Console.WriteLine($"Tabela vazia!");
                else
                    Console.WriteLine($"A Tabela NAO esta vazia!");
                    
                Console.WriteLine("\n---------------------------------------------\n");

                break;

            case 0:
                Console.WriteLine("Tchau!");
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }

} while (opcao != 0);
