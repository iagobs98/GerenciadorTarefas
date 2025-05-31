using GerenciadorTarefas.Domain.Entidades;
using GerenciadorTarefas.Domain.Validators;

namespace Domain.Tests;

public class TarefaCadastroValidatorTest
{
    private readonly Tarefa _tarefa;
    private readonly TarefaCadastroValidator validator = new();
    public TarefaCadastroValidatorTest()
    {
        _tarefa = new();
        
    }

    [Theory]
    [InlineData("")]
    [InlineData(null)]
    public void TituloNullOuVazio_DeveRetornarFalse(string? titulo)
    {
        _tarefa.Titulo = titulo;

        var resultadoCadastroTarefaValidacao = validator.Validate(_tarefa);

        Assert.False(resultadoCadastroTarefaValidacao.IsValid);
    }

    [Fact]
    public void TituloComMaisDe100Caracteres_DeveRetornarFalse()
    {
        _tarefa.Titulo = new string('*',101);

        var resultadoCadastroTarefaValidacao = validator.Validate(_tarefa);

        Assert.False(resultadoCadastroTarefaValidacao.IsValid);
    }

    [Fact]
    public void TituloValido_DeveRetornarTrue()
    {
        _tarefa.Titulo = "Nova Tarefa";

        var resultadoCadastroTarefaValidacao = validator.Validate(_tarefa);

        Assert.True(resultadoCadastroTarefaValidacao.IsValid);
    }
}
