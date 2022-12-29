Funcionalidade: Usuario - Valida 
	Como um usuario
	Eu desejo validar situacao do usuario no app
	Para que eu possa conhecer a sitacao do usuario no app

Cenario: Usuario ativo
Dado Que um usuario acesse o app
Quando O usuario acessar qualquer funcionalidade
E O usuario estiver ativo
Entao O usuario recebera uma mensagem de ola

Cenario: Usuario desativado
Dado Que um usuario acesse o app
Quando O usuario acessar qualquer funcionalidade
E O usuario estiver desativado
Entao O usuario recebera uma mensagem de erro

Cenario: Resumo dados do usuario
Dado Que um usuario acesse opcao checar cadastro
Quando O usuario inserir o email
E O usuario inserir token acesso app
Entao O usuario recebera resumo do cadastro