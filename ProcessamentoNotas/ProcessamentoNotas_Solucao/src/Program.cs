namespace ProcessamentoNotas.Solucao;
public class Program {
    // Quantidade de notas por aluno.
    private const int TOTAL_NOTAS_ALUNO = 3;
    // Valores associados a cada nota.
    private static readonly IDictionary<char, int> _valoresNotas = new Dictionary<char, int>
    {
        { 'A', 10 },
        { 'B',  8 },
        { 'C',  6 },
        { 'D',  4 },
        { 'E',  2 },
        { 'F',  0 }
    };

    public static int TotalizarAlunosAprovados(
        string notasTurma,
        int totalAlunos
    )
    {
        var notasAlunosLista = SepararNotasAlunos(notasTurma, totalAlunos);

        var somaNotasAlunosLista = SomarNotasAlunos(notasAlunosLista);

        var alunosAprovados = 0;
        foreach (var somaNotasAluno in somaNotasAlunosLista)
        {
            if (somaNotasAluno/3m >= 6m)
            {
                alunosAprovados++;
            }
        }

        return alunosAprovados;
    }

    private static List<string> SepararNotasAlunos(
        string notasTurma,
        int totalAlunos
    )
    {
        var notasAlunosLista = new List<string>();

        for (var i = 0; i < totalAlunos; i++)
        {
            notasAlunosLista.Add(
                notasTurma.Substring(i*TOTAL_NOTAS_ALUNO, TOTAL_NOTAS_ALUNO)
            );
        }

        return notasAlunosLista;
    }

    private static List<int> SomarNotasAlunos(List<string> notasAlunos)
    {
        var somaNotasAlunosLista = new List<int>();

        foreach (var notasAluno in notasAlunos)
        {
            somaNotasAlunosLista.Add(SomarNotasAluno(notasAluno));
        }

        return somaNotasAlunosLista;
    }

    private static int SomarNotasAluno(string notasAluno)
    {
        var somaNotasAluno = 0;

        for (int i = 0; i < notasAluno.Length; i++)
        {
            somaNotasAluno += _valoresNotas[notasAluno.ElementAt(i)];
        }

        return somaNotasAluno;
    }

    public static void Main()
    {
        string notasTurma;
        var totalAlunos = 5;

        notasTurma = "ABBCABBDDAFCACD";
        Console.WriteLine(TotalizarAlunosAprovados(notasTurma!, totalAlunos));

        totalAlunos = 2;
        notasTurma = "CEAABD";
        Console.WriteLine(TotalizarAlunosAprovados(notasTurma!, totalAlunos));

        totalAlunos = 3;
        notasTurma = "DDAFAABFC";
        Console.WriteLine(TotalizarAlunosAprovados(notasTurma!, totalAlunos));
    }
}
