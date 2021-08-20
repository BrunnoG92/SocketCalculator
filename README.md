<p>Realiza uma opera&ccedil;&atilde;o matem&aacute;tica com 2 n&uacute;meros utilizando Sockets<br />O cliente envia o comando de calculo e o servidor responde, ambos utilizando um protocolo personalizado de comunica&ccedil;&atilde;o. Criado utilizando C# e Windows Forms, para disciplina de Sistemas distribu&iacute;dos da Faculdade &Uacute;nica de Ipatinga</p>
<p>O cliente envia o comando ao servidor usando o seguinte padr&atilde;o : CALC001200250025SUM<br />Onde :<br /><strong>CALC -</strong> Informa ao servidor que ser&aacute; realizado um calculo<br /><strong>0012 -</strong> Tamanho em bytes dos numeros 1 e 2 somados ao comando da opera&ccedil;&atilde;o <br /><strong>0025 -</strong> N&uacute;mero 1 com 4 digitos. Sempre este &eacute; completado com zeros a esquerda se necess&aacute;rio para interiar os 4 digitos.<br /><strong>SUM -</strong> Indica a opera&ccedil;&atilde;o a ser realizada:</p>
<ul>
<li><strong>SUM&nbsp; -&nbsp; </strong>Adi&ccedil;&atilde;o</li>
<li><strong>SUB&nbsp; &nbsp;- </strong>Subtra&ccedil;&atilde;o</li>
<li><strong>DIV&nbsp; &nbsp;-&nbsp; </strong>Divis&atilde;o</li>
<li><strong>RAIZ -</strong>&nbsp; Raiz Quadrada&nbsp; &nbsp; &nbsp; &nbsp;</li>
</ul>
<p>O servidor por sua vez ir&aacute; fazer o tratamento, quebrando o comando recebido como string e qubrando este nos 5 peda&ccedil;os:&nbsp; <strong>CALC 0012 0025 0025 SUM</strong></p>
<p><img src="https://drive.google.com/uc?export=view&amp;id=1sHX7BJtPkOVFwoaGrl7EBuzhw2Ug_-G8" alt="Cliente" width="896" height="575" /></p>
<p><br />&nbsp; &nbsp; &nbsp;<strong>&nbsp;</strong></p>
<p>O Servidor ir&aacute; realizar o calculo matem&aacute;tico e retornar ao cliente a resposta seguindo o padr&atilde;o : <strong>RESP00040050</strong></p>
<p>Onde :<br /><strong>RESP</strong> - Indica ao cliente que o comando &eacute; uma resposta do calculo</p>
<p><strong>004&nbsp; &nbsp;</strong>- Quantidade de digitos que possui a resposta&nbsp;</p>
<p><strong>0050</strong> - Resposta do c&aacute;lculo&nbsp;</p>
<p><img src="https://drive.google.com/uc?export=view&amp;id=1H9o9d-9dBAHdfB5m1DRk2WFHeMDQpOiG" alt="" /></p>
