Cria uma corrente de responsabilidades em condi��es p/ aplicar algoritmos de regra de neg�cio em situa��es em que precisamos testar todos os 
algoritmos envolvidos.

O padr�o Chain of Responsibility cai como uma luva quando temos uma lista de comandos a serem executados de acordo com algum cen�rio em espec�fico,
e sabemos tamb�m qual o pr�ximo cen�rio que deve ser validado, caso o anterior n�o satisfa�a a condi��o.

Nesses casos, o Chain of Responsibility nos possibilita a separa��o de responsabilidades em classes pequenas e enxutas, e ainda prov� uma maneira 
flex�vel e desacoplada de juntar esses comportamentos novamente.

O COR nos permite deixar todos os algoritmos necess�rios a disposi��o da regra de neg�cio, a fim de os mesmos serem executados at� que um deles 
se enquadro na necessidade da opera��o.