# Documentação de Devolutiva do Teste Prático para Desenvolvedor Pleno
## Por: Pedro Henrique da Silva
## Data: 31/05/2024


## Requisitos Técnicos:
- C#
- Windows Forms
- PostgreSQL (especificar versão na entrega)
- NPGSQL (PostgreSQL 16)
- Git
- ReportViewer

## Documentação
### 1. Banco de Dados
O que foi realizado:
Criação das tabelas tbcliente, tbproduto, tbvenda e tbvendaitem.
Criação de views para vendas e itens de venda.
Utilização do PostgreSQL 16.
Padronização de nomes de colunas e tabelas (ex.: chr_ para campos de texto, id_ para identificadores, etc.).

### Observação do Tópico
Estrutura de banco de dados bem definida.
Utilizei views para facilitar consultas complexas.
Padronizei a nomenclatura, facilitando a manutenção e entendimento.

### 2. Desenvolvimento da Aplicação
O que foi realizado:
Criação de uma classe Base para padronização das operações em formulários.
Implementação de classes auxiliares (Util, Conexao, Session, TransactSQL) para modularização e clareza do código.

### Observação do Tópico
Procurei fazer boa separação de responsabilidades entre as classes.
Escolhi utilizar os padrões de design como Singleton (em Session).
A ideia é facilitar a manutenção e escalabilidade do sistema através da classe Base.

### 3. Implementação de Funcionalidades
O que foi realizado:
Tela de cadastro, edição e pesquisa de clientes.
Tela de cadastro, edição e pesquisa de produtos.
Interface de Ponto de Venda (PDV) para registrar vendas.
Relatórios para vendas, clientes e produtos.

### Observação do Tópico
Foi criado funcionalidades principais implementadas e funcionando corretamente.
Relatórios gerados de forma adequada utilizando o ReportViewer.
Interfaces de usuário intuitivas e consistentes.

### 4. Qualidade do Código
O que foi realizado:
Código limpo e organizado.
Implementação de classes genéricas para reutilização de código.

### Observação do Tópico
Procurando sempre à organização e estruturação do código.
Código modular e fácil de entender.

### 5. Estrutura do Projeto
O que foi realizado:
Projeto estruturado de maneira organizada, facilitando a navegação e manutenção.

### Observação do Tópico
Arquivos e pastas bem organizados.
Utilizei uma estrutura de pastas separando as classes principais na raiz e os módulos especificos por pastas como (Cliente, Venda e Produto)
Estrutura de projeto clara e lógica.

### 6. Documentação
O que foi realizado:
Documentação do código e das funcionalidades implementadas.

### Observação do Tópico
Documentação clara e completa do código no readmi.
Documentado via comentarios no códgio pra ser intuitivo.