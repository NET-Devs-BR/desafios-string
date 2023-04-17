# Cifra de César

A [Cifra de César](https://pt.khanacademy.org/computing/computer-science/cryptography/crypt/v/caesar-cipher) é um algoritmo de criptografia mais antigo já utilizado, pois foi utilizado pelo líder militar Júlio César em torno do ano 52 a.C. para escrever mensagens criptografadas com comandos militares de forma que se alguém interceptar a mensagem não vai conseguir ler sem a chave.

Por exemplo, se Alice quer transmitir uma mensagem para Bob, mas quer manter sigilo usando a Cifra de César ela utiliza uma `chave` que é compartilhada entre eles. A mensagem a ser transmitida é:

> `Me encontre na Avenida Paulista`

A `chave` compartilhada entre eles foi o número `3`, então Alice utiliza esse parâmetro para criptografar a mensagem deslocando cada letra 3 posições a direita no alfabeto resultando na mensagem criptografada abaixo:

> `Og gpeqpvtg pc cxgpkfc rcwnkuvc`

Quando Bob receber a mensagem ele vai precisar da chave para descriptografá-la da mesma forma deslocamos 3 posições a esquerda para cada letra voltando a mensagem original.

Dado uma operação `op`, uma string `s` e um parâmetro `chave` criptografar ou descriptografar utilizando a **Cifra de César**.


## Restrições

- `1 <= tamanho de s <= 100`
- `1 <= chave <= 25`
- `Letras minúsculas ou maiusculas`

## Casos de teste

Segue abaixo, exemplos de entradas e saídas do nosso problema:

### Entrada 1
> 3

> aab

### Saída 1
> ccd

# 

### Entrada 2
> 2

> abba

### Saída 2

> bccb

# 

### Entrada 3
> 23

> Sou aluno do Metodo .NET Direto ao Ponto

### Saída 3
> Okq whqjk zk iapkzk .JAP zenapk wk lkjpk!