<h1>Sobre o projeto:</h1>
<h2>API ValidatorPassword</h2>
<h4>API que válida se uma senha é válida ou não. Tendo como premissas as regras abaixo:</h4>
<ul>  
<li>Nove ou mais caracteres;</li>
<li>Ao menos 1 dígito;</li>
<li>Ao menos 1 letra minúscula;</li>
<li>Ao menos 1 letra maiúscula;</li>
<li>Ao menos 1 caractere especial;</li>
<li>Considere como especial os seguintes caracteres: !@#$%^&*()-+;</li>
<li>Não possuir caracteres repetidos dentro do conjunto;</li>
<li>Espaços em branco não devem ser considerados como caracteres válidos;</li>
</ul>
<h2>Iniciando a Solution</h2>
<p>Clonar repositório do git, configurar para iniciar o projeto da WebApi(PasswordValidatorLayerApi).<p>
<p>Veja as imagens abaixo:<p>
<br>
<img src="https://github.com/marcelocaselli/Frattina/blob/main/img/config_inicalizacao_solution.png">
![configuração1]()
<br>
![configuração2](https://github.com/marcelocaselli/Frattina/blob/main/img/config_inicializaosolution2.png)
<br>
<p>Feito isso, compilar o projeto e executá-lo. Será apresentado o swagger para que você possa fazer os testes de validação</p>
<br>
<p><b>Exemplo de mensagem sucesso pelo swagger</b></p>
<br>
![configuração3](https://github.com/marcelocaselli/Frattina/blob/main/img/swagger200.png)
<br>
<p><b>Exemplo de mensagem erro pelo swagger</b></p>
<br>
![configuração4](https://github.com/marcelocaselli/Frattina/blob/main/img/swagger400.png)
<br>
<br>
<br>


<p><b>Solução</b> - Utilizo camadas bem definidas (apresentação, negócio e dados). Na camada de dados estou utilizando uma lista pra armazenar as informações, mas poderia utilizar um arquivo, banco de dados, etc. Por ser mais simples a implementação coloquei em lista. Na camada de negocio após recuperar as regras, passo uma a uma para verificar se as mesmas estão sendo atendidas. Utilizo Regex pra solucao ficar mais limpa. Caso regra da senha não atendida eu incluo numa lista de erros de validação que será retornada a camada de apresentação. Procurei deixar código simples, legível. A API pode ser acessada pelo swagger.</p>
<br>
<p>
