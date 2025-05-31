using GerenciadorTarefas.Domain.Entidades;
using GerenciadorTarefas.Domain.Validators;

namespace Domain.Tests;


public class TarefaEdicaoValidatorTest
{
    private readonly Tarefa _tarefa;
    private readonly TarefaEdicaoValidator _tarefaEdicaoValidatorTest = new();
    public TarefaEdicaoValidatorTest()
    {
        _tarefa = new()
        {
            Titulo = "Titulo obrigatório"
        };
    }

    [Fact]
    public void DataDeConclusaoMenorQueDataDeCriacao_DeveRetornarFalse()
    {
        _tarefa.DataCriacao = new DateTime(2025, 05, 30);
        _tarefa.DataConclusao = new DateTime(2025, 05, 29);

        var resultadoEdicaoTarefaValidacao = _tarefaEdicaoValidatorTest.Validate(_tarefa);

        Assert.False(resultadoEdicaoTarefaValidacao.IsValid);
    }


    [Fact]  
    public void DataDeConclusaoMaiorQueDataDeCriacao_DeveRetornarTrue()
    {
        _tarefa.DataCriacao = new DateTime(2025, 05, 29);
        _tarefa.DataConclusao = new DateTime(2025, 05, 30);

        var resultadoEdicaoTarefaValidacao = _tarefaEdicaoValidatorTest.Validate(_tarefa);

        Assert.True(resultadoEdicaoTarefaValidacao.IsValid);
    }

}
