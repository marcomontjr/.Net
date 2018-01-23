É interessante utilizar Decorator quando precisamos modificar um objeto para que ele implemente além de suas regras
de negócio também de um outro objeto, ou seja, decorar o objeto para que ele contenha além de suas próprias 
implementações, a de outros também.

Sempre que percebemos que temos comportamentos que podem ser compostos por comportamentos de outras classes 
envolvidas em uma mesma hierarquia, como foi o caso dos impostos, que podem ser compostos por outros impostos. 
O Decorator introduz a flexibilidade na composição desses comportamentos, bastando escolher no momento da 
instanciação, quais instancias serão utilizadas para realizar o trabalho.