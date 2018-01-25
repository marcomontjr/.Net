Devemos utilizar o padr�o Builder quando um objeto tiver muitas informa��es para se construir, se no construtor 
da classe existem itens demais que precisam ser enviados para que ocorra sua constru��o, pode ser v�lido criar
uma classe construtora, vulgo Builder.

O Builder vai mais atrapalhar que ajudar quando a classe tiver poucos atributos a serem constru�dos, nos casos 
de 2 ou 3 atributos, um builder iria segurar uma responsabilidade muito pequena o que n�o justifica sua 
exist�ncia.
	Portanto tudo vai depender da an�lise moment�nea de constru��o.

Sempre que tivermos um objeto complexo de ser criado, que possui diversos atributos, ou que possui uma l�gica
de cria��o complicada, podemos esconder tudo isso em um Builder. Al�m de centralizar o c�digo de cria��o e 
facilitar a manuten��o, ainda facilitamos a vida das classes que precisam criar essa classe complexa, afinal a
interface do Builder tende a ser mais clara e f�cil de ser usada.