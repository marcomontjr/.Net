Devemos aplicar o padr�o State quando precisamos de certa dinamicidade no estado de algo (Algum objeto: como no caso do
saldo da conta banc�ria ou na an�lise de or�amento). Fica muito mais f�cil de rastrear e manusear os dados com o State ao
inv�s de diversos "ifs".

A principal situa��o que faz emergir o Design Pattern State � a necessidade de implementa��o de uma m�quina de estados. 
Geralmente, o controle das poss�veis transi��es s�o v�rios e complexos, fazendo com que a implementa��o n�o seja simples.
O State auxilia a manter o controle dos estados simples e organizados atrav�s da cria��o de classes que representem cada 
estado e saiba controlar as transi��es.