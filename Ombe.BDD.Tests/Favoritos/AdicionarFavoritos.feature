Funcionalidade: Favoritos - Adicionar 
	Como um usuario
	Eu desejo cadastrar produto como favorito no app
	Para que eu possa utilizar das funcionalidades do app

Cenario: Adicionar favorito com sucesso
Dado Que um usuario acesse opcao de cadastro favorito
Quando O usuario inserir informacoes
E tocar no botao cadastrar
Entao O usuario recebera uma mensagem de sucesso

Cenario: Adicionar favorito existente
Dado Que um usuario acesse opcao de cadastro favorito
Quando O usuario inserir informacoes
E tocar no botao cadastrar
E codigo produto e usuario ja estiverem cadastrado
Entao O usuario recebera uma mensagem de erro

Cenario: Adicionar favorito com dados incompletos
Dado Que um usuario acesse opcao de cadastro favorito
Quando O usuario inserir informacoes incompletas
E tocar no botao cadastrar
Entao O usuario recebera uma mensagem de erro