Funcionalidade: Produto - Adicionar Produto
	Como um usuario
	Eu desejo cadastrar produto no app
	Para que eu possa utilizar das funcionalidades do app

Cenario: Adicionar produto com sucesso
Dado Que um usuario acesse opcao de cadastro produto
Quando O usuario inserir informacoes
E tocar no botao cadastrar
Entao O usuario recebera uma mensagem de sucesso

Cenario: Adicionar produto existente
Dado Que um usuario acesse opcao de cadastro produto
Quando O usuario inserir informacoes
E tocar no botao cadastrar
E codigo ncm ja existir na base
Entao O usuario recebera uma mensagem de erro

Cenario: Adicionar produto com dados incompletos
Dado Que um usuario acesse opcao de cadastro produto
Quando O usuario inserir informacoes incompletas
E tocar no botao cadastrar
Entao O usuario recebera uma mensagem de erro