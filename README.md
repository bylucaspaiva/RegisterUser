# RegisterUser

![image](https://github.com/bylucaspaiva/RegisterUser/assets/58491622/ead4804f-433a-48cc-9e47-480b96a825cd)


Este é um projeto de entrevista desenvolvido por mim para o J. Armando Batista. O projeto consiste em um aplicativo Windows Forms para cadastro de usuários.
Configuração do Banco de Dados

Antes de executar o projeto, certifique-se de ter criado um banco de dados no SQL Server e que ele esteja conectado à seguinte connection string:

```
Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RegisterUser;Integrated Security=True;
```
Após criar o banco de dados, execute o seguinte comando SQL para criar a tabela necessária para o projeto:

```
USE RegisterUser;

CREATE TABLE dbo.[User]
(
	[CPF] NVARCHAR(20) NOT NULL PRIMARY KEY, 
    [Nome] NVARCHAR(50) NULL, 
    [Telefone] NVARCHAR(15) NULL, 
    [Email] NVARCHAR(60) NULL, 
    [Sexo] NVARCHAR(15) NULL, 
    [Endereço] NCHAR(70) NULL, 
    [DataNascimento] DATE NULL
);
```
Certifique-se de executar o comando acima no contexto do banco de dados RegisterUser.
Executando o Projeto

Para executar o projeto, abra a solução no Visual Studio e defina o projeto "TelaPrincipal" como o projeto de inicialização. Em seguida, clique no botão "Iniciar" ou pressione F5 para compilar e executar o aplicativo.

O projeto consiste em uma tela principal onde é possível cadastrar novos usuários. Após preencher os campos de cadastro, clique no botão "Cadastrar" para inserir o usuário no banco de dados.

Para visualizar a lista de usuários cadastrados, clique no botão "Listar Usuários" na tela principal. Isso abrirá uma nova janela com a lista de usuários cadastrados no banco de dados.

Certifique-se de que o banco de dados esteja em execução e a conexão esteja correta para garantir o funcionamento adequado do projeto.
