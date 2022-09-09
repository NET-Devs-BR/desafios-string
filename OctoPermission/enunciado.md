# Linux Permission

O sistema de permissões do Linux é dividido em três partes: permissões do usuário,
permissões do grupo e permissões de outros. Ainda, cada uma das partes pode ter permissões
de execução (x), escrita (w) e leitura (r). Exemplo:

r-xrwx--x sample

Cada uma das partes pode ser representada por um número octal, conforme a tabela:

|Número|Permissão                   |Símbolo |
|------|:--------------------------:|:-------|
|0     |Nenhuma                     | \-\-\- |
|1     |Execução                    | \-\-x  |
|2     |Escrita                     | -w-    |
|3     |Execução + Escrita          | -wx    |
|4     |Leitura                     | r\-\-  |
|5     |Leitura + Execução          | r-x    |
|6     |Leitura + Escrita           | rw-    |
|7     |Leitura + Escrita + Execução| rwx    |

Dado uma string de permissão do linux, escreva um programa que devolva o valor octal
das três partes.

## Casos de teste
- input: r-xrwx--x
- output: 571
---
- input: rwxrwxrwx
- output 777
---
- input: --x--x--x
- output: 111