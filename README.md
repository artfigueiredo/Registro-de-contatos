# Upload-dos-projetos
Local destinado a projetos e testes

Este espaço é destinado a orientação de um protótipo de agenda telefônica, utilizando o framework ASP.NET

Passo 1 - Criar um novo projeto no Visual Studio 2019
![passo-01](https://user-images.githubusercontent.com/87759514/126884012-c2080563-f2f6-4e7e-a925-dcf4702b6bce.png)

Passo 2 - Selecionar o modelo de projeto, no caso o "Aplicativo Web do ASP.NET Core (Model-View-Controller)
![passo-02](https://user-images.githubusercontent.com/87759514/126884060-a259c803-8fec-48b3-9e5d-789dc5814cc9.png)

Passo 3 - De um nome para o projeto
![passo-03](https://user-images.githubusercontent.com/87759514/126884072-8da26569-118c-4f87-83bc-08e5b805bcdb.png)

Passo 4 - Selecione a Estrutura e o tipo de autenticação. Para esse projeto utilizei .Net Core 3.1 e a autenticação foi Contas individuais.
![passo-04](https://user-images.githubusercontent.com/87759514/126884122-faf9eff3-6db0-439f-bfa6-7ad093368c12.png)

Passo 5 - Depois de criar o projeto, precisamos alterar o nome do banco de dados pois o projeto não irá funcionar corretamente com o padrão gerado. Então clicamos no arquivo 'appsettings.json' na janela de Solução do projeto. Assim que abrir o código, ao lado esquerdo aparecerá as características de conexão do usuário com o banco de dados (No caso utilizado o SQL Server do Visual Studio) como mostra a imagem abaixo. Insira um novo nome para o banco de dados. Exemplo: Database=MeuBanco.
![passo-06](https://user-images.githubusercontent.com/87759514/126884267-9b6636e0-fa87-4d94-93a9-7ccc81102480.png)

Passo 6 - Em seguida atualize seu banco de dados da seguinte forma. Na barra de ferramentas na parte superior do Visual Studio selecione Exibir > Outras Janelas > Console Gerenciador de Pacote. Após isso irá aparece na parte inferior do programa um cosole para digitar o comando para atualizar o banco. Então no console digite update-database. 
![passo-07](https://user-images.githubusercontent.com/87759514/126884372-899ea5b5-7e2c-4b35-b993-8259733c9263.png)

Passo 7 - Vamos criar uma classe para inserir os atributos que serão implementados na agenda.
![passo-08](https://user-images.githubusercontent.com/87759514/126884421-c3d5fd53-3e8a-4eb1-ac0f-5bec43b0b9fd.png)
![passo-09](https://user-images.githubusercontent.com/87759514/126884422-92ebaba9-3d46-4c25-b7bd-838b39bdbfd4.png)

Passo 8 - Na classe criada definimos os atributos referentes a agenda telefônica no caso o ID como identificador de registro, o Nome, Telefone e Endereço.
![passo-10](https://user-images.githubusercontent.com/87759514/126884458-87224bdd-a2d2-4393-b61e-07c3e1c4d26b.png)

Passo 9 - Agora vamos para o arquivo 'ApplicationDbContext.cs' dentro da pasta Data, para criar um comando que faça o EntityFramework olhar para o arquivo Agenda.cs (nome dado para a classe referente aos atributos da agenda) da pasta models e criar uma tabela com o nome de 'Contatos'.
![passo-11](https://user-images.githubusercontent.com/87759514/126884544-a7db77b9-eef3-4594-abac-2d7e01c3eee3.png)
Obs: Temos que incluir 'using MyAgenda.Models' para o comando estar no mesmo namespace.
![passoextra01](https://user-images.githubusercontent.com/87759514/126884600-0680159f-d26f-4b0b-8a18-2d868fcf4ccd.png)

Passo 10 - Após isso no 'Console de Gerenciador de Pacotes' digite o comando 'add-migration contatos' para o Entity verificar o Dbcontext, e entender que mapeamos um objeto para virar uma tabela e ele vai criar um script para criar essa tabela no banco de dados.
![passo-12](https://user-images.githubusercontent.com/87759514/126884644-3d213e56-5f91-4005-b17c-235831aaf3e4.png)
![passo-13](https://user-images.githubusercontent.com/87759514/126884657-d9657bd7-9563-41f5-8185-361e3df25773.png)

Passo 11 - Logo em seguida no 'Console de Gerenciador de Pacotes' digite 'update-database' para atualizar o banco de dados com as novas atualizações.

Passo 12 - Agora vamos usar o Visual Studio para criar um CRUD. É um CRUD básico, mas é o suficiente para a execução do teste. Botão direito em cima da pasta 'Controllers' de selecionamos Adicionar > Controlador.




