//Ele fornece anotações/atributos que colocamos nas propriedades
using System.ComponentModel.DataAnnotations;
//Importa atributos relacionados a mapeamento para o banco, permite usar [Table] e [Column]
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientesOracleEf.Model;

//Um atributo (annotation) que marca a classe.
//Diz ao Entity Framework: “esta classe representa a tabela TB_CLIENTE no banco”
[Table("TB_CLIENTE")]
public class Cliente
{
    //Diz ao EF que esta propriedade é a chave primária (PRIMARY KEY).
    [Key]
    //Mapeia a propriedade para a coluna ID_CLIENTE no banco (mesmo que o nome em C# seja diferente).
    [Column("ID_CLIENTE")]
    public decimal IdCliente { get; set; }

    //Diz que o campo é obrigatório e limitado a 100 caracteres
    [Required, MaxLength(100)]
    //Mapeia a propriedade para a coluna NOME no banco
    [Column("NOME")]
    public string Nome { get; set; }

    //Diz que o campo é obrigatório e limitado a 100 caracteres
    [Required, MaxLength(100)]
    //Mapeia a propriedade para a coluna SOBRENOME no banco
    [Column("SOBRENOME")]
    public string Sobrenome { get; set; }
}
