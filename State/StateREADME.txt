Devemos aplicar o padrão State quando precisamos de certa dinamicidade no estado de algo (Algum objeto: como no caso do
saldo da conta bancária ou na análise de orçamento). Fica muito mais fácil de rastrear e manusear os dados com o State ao
invés de diversos "ifs".

A principal situação que faz emergir o Design Pattern State é a necessidade de implementação de uma máquina de estados. 
Geralmente, o controle das possíveis transições são vários e complexos, fazendo com que a implementação não seja simples.
O State auxilia a manter o controle dos estados simples e organizados através da criação de classes que representem cada 
estado e saiba controlar as transições.