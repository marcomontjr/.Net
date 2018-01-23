� interessante utilizar Decorator quando precisamos modificar um objeto para que ele implemente al�m de suas regras
de neg�cio tamb�m de um outro objeto, ou seja, decorar o objeto para que ele contenha al�m de suas pr�prias 
implementa��es, a de outros tamb�m.

Sempre que percebemos que temos comportamentos que podem ser compostos por comportamentos de outras classes 
envolvidas em uma mesma hierarquia, como foi o caso dos impostos, que podem ser compostos por outros impostos. 
O Decorator introduz a flexibilidade na composi��o desses comportamentos, bastando escolher no momento da 
instancia��o, quais instancias ser�o utilizadas para realizar o trabalho.