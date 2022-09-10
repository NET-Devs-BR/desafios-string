using FluentAssertions;

namespace ProcessamentoNotas.Solucao.Test;

public class ProgramTest
{
    [Theory]
    [InlineData("ABBCABBDDAFCACD", 5, 3)]
    [InlineData("CEAABD", 2, 2)]
    [InlineData("DDAFAABFC", 3, 2)]
    public void Deve_Retornar_Total_Alunos_Aprovados(
        string notasAlunos,
        int totalAlunos,
        int alunosAprovadosEsperados
    )
    {
        var totalAlunosAprovados = Program.TotalizarAlunosAprovados(
            notasAlunos,
            totalAlunos
        );

        totalAlunosAprovados.Should().Be(alunosAprovadosEsperados);
    }
}
