# Gestor Financeiro

## Sobre o projeto

O Gestor Financeiro é uma aplicação full stack desenvolvida para fins de aprendizagem de diversos conceitos (MVVM, injeção de dependência, clean code, etc) e diversas tecnologias, principalmente WPF. Os requisitos funcionais fornecem um controle financeiro básico, que permite o cadastro de tabela de preços, entrada/saída de valores, levantamento de custos fixos (salários de funcionários, despesas, etc) e o saldo total filtrado por data.

## Nuget

Pacotes do NuGet:

https://www.nuget.org/packages/Microsoft.AspNet.Identity.Core/
https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/6.0.0-preview.5.21301.9
https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Abstractions/6.0.0-preview.5.21301.9
https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/6.0.0-preview.5.21301.9
https://www.nuget.org/packages/Microsoft.Extensions.Configuration.Abstractions/6.0.0-preview.5.21301.5
https://www.nuget.org/packages/Npgsql.EntityFrameworkCore.PostgreSQL/6.0.0-preview5
https://www.nuget.org/packages/MaterialDesignThemes/4.2.0-ci2615
https://www.nuget.org/packages/Microsoft.Extensions.Hosting/6.0.0-preview.5.21301.5
https://www.nuget.org/packages/Microsoft.Extensions.Identity.Core/6.0.0-preview.5.21301.17

## Screenshots

![Financeiro](https://user-images.githubusercontent.com/53319788/125179049-f8425800-e1c0-11eb-9d48-b4ae477bed8c.png)
![Login](https://user-images.githubusercontent.com/53319788/125179050-fbd5df00-e1c0-11eb-8fa9-42c7a8cfdbad.png)
![Tabela-Preco](https://user-images.githubusercontent.com/53319788/125179052-fd070c00-e1c0-11eb-940c-363607415217.png)
![Vendas](https://user-images.githubusercontent.com/53319788/125179054-fed0cf80-e1c0-11eb-938b-0263100d505b.png)
![Vendas-Procura](https://user-images.githubusercontent.com/53319788/125179055-009a9300-e1c1-11eb-8a34-1a260ba12d98.png)

## Login para teste

|  Login  |  Senha  |
| ------- | ------- |
| SISTEMA |  123456 |

## Info

Features adicionais:

* UserControl de base para todas as telas de cadastro
* UserControl genérico para operações de procura
* Arquivo externo para string de conexão
