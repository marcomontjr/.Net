O padr�o Strategy � muito �til quando temos um conjunto de algoritmos similares, e precisamos alternar entre eles em diferentes peda�os da aplica��o.
No exemplo do v�deo, temos diferentes maneira de calcular o imposto, e precisamos alternar entre elas.

O Strategy nos oferece uma maneira flex�vel para escrever diversos algoritmos diferentes, e de passar esses algoritmos para classes clientes que 
precisam deles. Esses clientes desconhecem qual � o algoritmo "real" que est� sendo executado, e apenas manda o algoritmo rodar. Isso faz com que
o c�digo da classe cliente fique bastante desacoplado das implementa��es concretas de algoritmos, possibilitando assim com que esse cliente consiga
trabalhar com N diferentes algoritmos sem precisar alterar o seu c�digo.

Devemos utilizar o Strategy quando nos depararmos com um aparente polimorfismo de alguma informa��o ou alguma massa de dados.