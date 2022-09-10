# Processamento de Notas

Considere os alunos de uma disciplina qualquer. Cada aluno deve, ao longo da disciplina, realizar 3 provas objetivas com 5 questões. A nota de cada prova é dada com base no sistema americano, conforme a tabela:

|Nota|Pontos|Acertos|
|---:|:----:|:------|
| A  |  10  |   5   |
| B  |   8  |   4   |
| C  |   6  |   3   |
| D  |   4  |   2   |
| E  |   2  |   1   |
| F  |   0  |   0   |

Dada uma turma com N alunos (1 <= N <= 40) e uma string de tamanho N*3, com todas as notas de cada aluno - ex "ABBCAB", onde cada **3 letras** representam as notas de **1 aluno** -, informe quantos alunos foram aprovados (média >= 6) na turma.

## Casos de Teste

- Input
  - N = 5
  - Notas = ABBCABBDDAFCACD
- Output: 3
---
- Input
  - N = 2
  - Notas = CEAABD
- Output: 2
---
- Input
  - N = 3
  - Notas = DDAFAABFC
- Output: 2
