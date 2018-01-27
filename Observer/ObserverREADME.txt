Devemos aplicar o padr�o Observer quando uma a��o ou uma determinada funcionalidade do aplicativo ou sistema 
deve ser iniciado assim que outra ocorra, ou seja, uma a��o dependente de outra.

No Exemplo demonstrado um e-mail da nota fiscal s� pode ser gerado ap�s a nota fiscal ser constru�da, portanto 
sem a constru��o da nota fiscal, a a��o "envio de e-mail" nunca aconteceria, da� o nome Observer, uma a��o fica
observando at� que seja disparada pela ocorr�ncia de outra.

Quando o acoplamento da nossa classe est� crescendo, ou quando temos diversas a��es diferentes a serem 
executadas ap�s um determinado processo, podemos implementar o Observer.

Ele permite que diversas a��es sejam executadas de forma transparente � classe principal, reduzindo o 
acoplamento entre essas a��es, facilitando a manuten��o e evolu��o do c�digo.