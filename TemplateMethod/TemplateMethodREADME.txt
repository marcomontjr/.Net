Quando temos diferentes algoritmos que possuem estruturas parecidas, o Template Method � uma boa solu��o. Com ele,
conseguimos definir, em um n�vel mais macro, a estrutura do algoritmo e deixar "buracos", que ser�o implementados
de maneira diferente por cada uma das implementa��es espec�ficas.

Dessa forma, reutilizamos ao inv�s de repetirmos c�digo, e facilitamos poss�veis evolu��es, tanto do algoritmo em
sua estrutura macro, quanto dos detalhes do algoritmo, j� que cada classe tem sua responsabilidade bem separada.

O Template Method � muito importante de ser usado quando temos um elemento com arcabou�o gen�rico s� mudando 
valores (que seriam validados com if else), pois assim escrevemos o c�digo apenas uma vez.