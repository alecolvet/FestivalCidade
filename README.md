# 🎵 FestivalCidade - Sistema de Ingresso Express

Projeto desenvolvido em C# utilizando Console Application para simular a compra de ingressos para festivais de música da produtora FestivalCidade.

## 📋 Funcionalidades

O sistema permite:

- Informar o nome do fã
- Informar a quantidade de dias de show contratados
- Informar um cupom de desconto
- Informar a pontuação do clube de fidelidade
- Calcular o valor bruto da compra
- Aplicar desconto de 10% utilizando o cupom `ROCK10`
- Calcular o valor final da compra
- Verificar acesso ao Lounge VIP

## 🧮 Regras de Negócio

### Valor da Compra

- Taxa de serviço: R$ 15,00
- Valor por dia de show: R$ 120,00

### Desconto

Caso o cupom informado seja `ROCK10`, o cliente recebe 10% de desconto sobre o valor bruto da compra.

### Lounge VIP

O acesso será liberado quando:

```text
Quantidade de dias > 2
E
Pontuação de fidelidade >= 500
```

## 🚀 Tecnologias Utilizadas

- C#
- .NET
- Visual Studio

## 📂 Estrutura do Projeto

```text
FestivalCidade/
│
├── Program.cs
└── README.md
```

## ▶️ Como Executar

1. Abra o projeto no Visual Studio
2. Pressione `F5`
3. Informe os dados solicitados
4. Visualize o resumo da compra

## 📸 Exemplo de Execução

```text
=== FestivalCidade ===

Digite o nome do fã: Alexandre
Digite a quantidade de dias de show: 3
Digite o cupom de desconto: ROCK10
Digite a pontuação do clube de fidelidade: 600

=== RESUMO DA COMPRA ===
Fã: ALEXANDRE
Valor bruto: R$ 375,00
Desconto: R$ 37,50
Valor final: R$ 337,50
Acesso ao Lounge VIP: True
```

## 👨‍💻 Autor

Alexandre Colvet

Projeto acadêmico desenvolvido para prática de lógica de programação em C#.
