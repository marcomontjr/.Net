Devemos aplicar o padrão Observer quando uma ação ou uma determinada funcionalidade do aplicativo ou sistema 
deve ser iniciado assim que outra ocorra, ou seja, uma ação dependente de outra.

No Exemplo demonstrado um e-mail da nota fiscal só pode ser gerado após a nota fiscal ser construída, portanto 
sem a construção da nota fiscal, a ação "envio de e-mail" nunca aconteceria, daí o nome Observer, uma ação fica
observando até que seja disparada pela ocorrência de outra.

Quando o acoplamento da nossa classe está crescendo, ou quando temos diversas ações diferentes a serem 
executadas após um determinado processo, podemos implementar o Observer.

Ele permite que diversas ações sejam executadas de forma transparente à classe principal, reduzindo o 
acoplamento entre essas ações, facilitando a manutenção e evolução do código.