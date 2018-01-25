Devemos utilizar o padrão Builder quando um objeto tiver muitas informações para se construir, se no construtor 
da classe existem itens demais que precisam ser enviados para que ocorra sua construção, pode ser válido criar
uma classe construtora, vulgo Builder.

O Builder vai mais atrapalhar que ajudar quando a classe tiver poucos atributos a serem construídos, nos casos 
de 2 ou 3 atributos, um builder iria segurar uma responsabilidade muito pequena o que não justifica sua 
existência.
	Portanto tudo vai depender da análise momentânea de construção.

Sempre que tivermos um objeto complexo de ser criado, que possui diversos atributos, ou que possui uma lógica
de criação complicada, podemos esconder tudo isso em um Builder. Além de centralizar o código de criação e 
facilitar a manutenção, ainda facilitamos a vida das classes que precisam criar essa classe complexa, afinal a
interface do Builder tende a ser mais clara e fácil de ser usada.