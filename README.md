# Calculadora
## Introdução 

![](https://i.imgur.com/r725pEA.gif)
Calculadora Simples mas com funções úteis para o seu dia a dia

## Funcionalidades
**Operações Básicas** - Adiconar, Subtrair, Dividir e Multiplicar

**Suporte a Decimais** - Permite o Cálculo de números com vírgula

**Validação de Entrada** - Verifica se o usuário digitou números no Programa

**Tabuada** - Permite a tabuada de um número de escolha do usuário, de 1 a 10

**Mostrar Histórico** - Permite ao usuário ver o histórico de operações

**Tratamento da Divisão por Zero** - A calculadora é capaz de validar erros da divisão por zero

## Como Utilizar
1. Clone o repositório ou baixe o código fonte da Calculadora.

2. Abra ou terminal ou o prompt de comando e navegue até a pasta raiz da Calculadora.

3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```
4. Em seguida, compile a solução utilizando o comando:
```
dotnet build --configuration Release
```
5.Para executar o projeto compilando em tempo real
```
dotnet run --project Calculadora.ConsoleApp
```
6.Para executar o arquivo compilado, navegue até a pasta ./Calculadora.ConsoleApp/bin/Release/net8.0/ e execute o arquivo:
```
Calculdora.ConsoleApp.exe
```

## Requisitos 

.NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.