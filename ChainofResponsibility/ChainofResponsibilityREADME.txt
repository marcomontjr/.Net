Cria uma corrente de responsabilidades em condições p/ aplicar algoritmos de regra de negócio em situações em que precisamos testar todos os 
algoritmos envolvidos.

O padrão Chain of Responsibility cai como uma luva quando temos uma lista de comandos a serem executados de acordo com algum cenário em específico,
e sabemos também qual o próximo cenário que deve ser validado, caso o anterior não satisfaça a condição.

Nesses casos, o Chain of Responsibility nos possibilita a separação de responsabilidades em classes pequenas e enxutas, e ainda provê uma maneira 
flexível e desacoplada de juntar esses comportamentos novamente.

O COR nos permite deixar todos os algoritmos necessários a disposição da regra de negócio, a fim de os mesmos serem executados até que um deles 
se enquadro na necessidade da operação.