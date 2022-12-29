Funcionalidade: Usuario - Adicionar Novo Usuario
	Como um usuario
	Eu desejo cadastrar no app
	Para que eu possa utilizar das funcionalidades do app

Cenario: Adicionar usuario com sucesso
Dado Que um usuario acesse opcao de cadastro
Quando O usuario inserir informacoes
E tocar no botao cadastrar
Entao O usuario recebera uma mensagem de boas vindas

Cenario: Adicionar usuario com email existente
Dado Que um usuario acesse opcao de cadastro
Quando O usuario inserir informacoes
E O campo e-mail existir no cadastro
Entao O usuario recebera uma mensagem de erro

Cenario: Adicionar usuario com erro
Dado Que um usuario acesse opcao de cadastro
Quando O usuario inserir informacoes
E tocar no botao cadastrar
E dados inseridos com erro
Entao O usuario recebera uma mensagem de erro