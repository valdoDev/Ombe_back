Funcionalidade: Avaliacao - Adicionar 
	Como um usuario
	Eu desejo cadastrar avaliacao de um produto no app
	Para que eu possa utilizar das funcionalidades do app

Cenario: Adicionar avaliacao com sucesso
Dado Que um usuario acesse opcao de cadastro avaliacao
Quando O usuario inserir informacoes
E tocar no botao cadastrar
Entao O usuario recebera uma mensagem de sucesso

Cenario: Adicionar avaliacao existente
Dado Que um usuario acesse opcao de cadastro avaliacao
Quando O usuario inserir informacoes
E tocar no botao cadastrar
E codigo produto e usuario ja estiverem cadastrado
Entao O usuario recebera uma mensagem de erro

Cenario: Adicionar avaliacao com dados incompletos
Dado Que um usuario acesse opcao de cadastro avaliacao
Quando O usuario inserir informacoes incompletas
E tocar no botao cadastrar
Entao O usuario recebera uma mensagem de erro