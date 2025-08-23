//Onde está a classe Cliente
using ClientesOracleEf.Model;
//Traz os recursos do Entity Framework Core
using Microsoft.EntityFrameworkCore;

namespace ClientesOracleEf.DBContext;

//Cria a classe AppDbContext que herda de DbContext, que é a classe-base do EF Core para acesso ao banco
public class AppDbContext : DbContext
{
    //Propriedade que representa a tabela TB_CLIENTE
    //DbSet<Cliente> significa que cada linha da tabela vira um objeto da classe Cliente
    //Set<Cliente>() método que o EF usa para gerenciar a coleção
    public DbSet<Cliente> Clientes => Set<Cliente>();

    //Construtor da classe AppDbContext
    //DbContextOptions traz as configurações (ex.: qual banco, connection string)
    //: base(options) passa as opções para a classe “mãe” (DbContext)
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


    //Método que o EF chama quando está criando o modelo (o mapeamento das classes para o banco).
    //override: sobrescreve o comportamento
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Cliente>():  configura a entidade Cliente
        //.Property(c => c.IdCliente):  pega a propriedade IdCliente
        //.ValueGeneratedOnAdd():  diz que o valor é gerado automaticamente pelo banco (IDENTITY no Oracle).
        modelBuilder.Entity<Cliente>().Property(c => c.IdCliente).ValueGeneratedOnAdd();
    }
}
