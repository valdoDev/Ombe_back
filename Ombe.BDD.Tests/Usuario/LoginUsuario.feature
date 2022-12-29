Funcionalidade: Usuario - Login 
	Como um usuario
	Eu desejo realizar login no app
	Para que eu possa ter acesso as funcionalidades do app

Cenario: Login com sucesso
Dado Que um usuario acesse opcao de login
Quando O usuario inserir informacoes
E O usuario tocar no botao logar
E As credencias corretas
E O usuario estiver ativo
Entao O usuario recebera uma mensagem de boas vindas
E O usuario recebera token acesso

Cenario: Login com erro
Dado Que um usuario acesse opcao de login
Quando O usuario inserir informacoes
E O usuario tocar no botao logar
E As credencias incorretas
Entao O usuario recebera uma mensagem de erro

Cenario: Login com erro, nao preenche todos campos
Dado Que um usuario acesse opcao de login
Quando O usuario nao inserir todas informacoes
E O usuario tocar no botao logar
Entao O usuario recebera uma mensagem de erro

Cenario: Login com erro, usuario desativado
Dado Que um usuario acesse opcao de login
Quando O usuario nao inserir todas informacoes
E O usuario tocar no botao logar
E As credencias corretas
E O usuario estiver desativado
Entao O usuario recebera uma mensagem de erro

Cenario: Login em mais de um dispositivo
Dado Que um usuario acesse opcao de login
Quando O usuario inserir informacoes
E O usuario tocar no botao logar
E O usuario estiver ativo
Entao O usuario recebera uma mensagem de boas vindas
E O usuario recebera token acesso