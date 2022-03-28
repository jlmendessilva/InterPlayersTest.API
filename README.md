# InterPlayersTest.API
<h2><strong>Teste pr&aacute;tico Interplayers</strong></h2>
<p><span style="font-weight: 400;">------------------------------------------------</span></p>
<h4><strong>Desafio: Validar uma senha atrav&eacute;s de uma Web API, com os seguintes crit&eacute;rios:</strong></h4>
<ul>
<li style="font-weight: 400;" aria-level="1"><span style="font-weight: 400;">Nove ou mais caracteres</span></li>
<li style="font-weight: 400;" aria-level="1"><span style="font-weight: 400;">Ao menos 1 d&iacute;gito</span></li>
<li style="font-weight: 400;" aria-level="1"><span style="font-weight: 400;">Ao menos 1 letra min&uacute;scula</span></li>
<li style="font-weight: 400;" aria-level="1"><span style="font-weight: 400;">Ao menos 1 letra mai&uacute;scula</span></li>
<li style="font-weight: 400;" aria-level="1"><span style="font-weight: 400;">Ao menos 1 caractere especial (Considere como especial os seguintes caracteres: !@#$%^&amp;*()-+)</span></li>
<li style="font-weight: 400;" aria-level="1"><span style="font-weight: 400;">N&atilde;o possuir caracteres repetidos dentro do conjunto</span></li>
</ul>
<p><span style="font-weight: 400;">&nbsp;</span><span style="font-weight: 400;">Instru&ccedil;&otilde;es para testar o c&oacute;digo:</span></p>
<ol>
<li style="font-weight: 400;" aria-level="1"><span style="font-weight: 400;">Clone o reposit&oacute;rio e abra no visual studio prefer&ecirc;ncia 2019</span></li>
<li style="font-weight: 400;" aria-level="1"><span style="font-weight: 400;">Escolha o projeto InterPlayersTest.API como (projeto principal)</span></li>
<li style="font-weight: 400;" aria-level="1"><span style="font-weight: 400;">Execute o programa apertando F5.</span></li>
</ol>
<h4><span style="font-weight: 400;">Par&acirc;metros para testes que satisfazem todos os requisitos:&nbsp;</span></h4>
<p><strong>Teste: Vazio&nbsp;</strong></p>
<p><code><span style="font-weight: 400;">{</span></code></p>
<p><code><span style="font-weight: 400;">"Name": "",</span></code></p>
<p><code><span style="font-weight: 400;">"Password": ""</span></code></p>
<p><code><span style="font-weight: 400;">}</span></code></p>
<p><strong>Resultado:</strong></p>
<p><code><span style="font-weight: 400;">[</span></code></p>
<p><code><span style="font-weight: 400;">&nbsp;&nbsp;"Sua senha tem que ter no m&iacute;nimo 9 (nove) caracteres)",</span></code></p>
<p><code><span style="font-weight: 400;">&nbsp;&nbsp;"Sua senha tem que ter pelo menos 1 (um) n&uacute;mero",</span></code></p>
<p><code><span style="font-weight: 400;">&nbsp;&nbsp;"Sua senha tem que ter pelo menos 1 (um) caractere min&uacute;sculo",</span></code></p>
<p><code><span style="font-weight: 400;">&nbsp;&nbsp;"Senha deve ter pelo menos 1 (um) caractere mai&uacute;sculo",</span></code></p>
<p><code><span style="font-weight: 400;">&nbsp;&nbsp;"Senha tem que ter pelo menos 1 (um) caractere especial Ex.: (!@#$%^&amp;*()-+)",</span></code></p>
<p><code><span style="font-weight: 400;">&nbsp;&nbsp;"Sua senha n&atilde;o pode ser nula"</span></code></p>
<p><code><span style="font-weight: 400;">]</span></code></p>
<hr />
<p><strong>Teste: </strong><span style="font-weight: 400;">Sua senha tem que ter no m&iacute;nimo 9 (nove) caracteres)</span></p>
<p><code><span style="font-weight: 400;">{</span></code></p>
<p><code><span style="font-weight: 400;">"Name": "Maria",</span></code></p>
<p><code><span style="font-weight: 400;">"Password": "123456790"</span></code></p>
<p><code><span style="font-weight: 400;">}</span></code></p>
<p><strong>Resultado:</strong></p>
<p><code><span style="font-weight: 400;">[</span></code></p>
<p><code><span style="font-weight: 400;">&nbsp;&nbsp;"Sua senha tem que ter pelo menos 1 (um) caractere min&uacute;sculo",</span></code></p>
<p><code><span style="font-weight: 400;">&nbsp;&nbsp;"Senha deve ter pelo menos 1 (um) caractere mai&uacute;sculo",</span></code></p>
<p><code><span style="font-weight: 400;">&nbsp;&nbsp;"Senha tem que ter pelo menos 1 (um) caractere especial Ex.: (!@#$%^&amp;*()-+)",</span></code></p>
<p><code><span style="font-weight: 400;">&nbsp;&nbsp;</span></code></p>
<p><code><span style="font-weight: 400;">]</span></code></p>
<hr />
<p><strong>Teste: </strong><span style="font-weight: 400;">Sua senha tem que ter pelo menos 1 (um) caractere min&uacute;sculo</span></p>
<p><code><span style="font-weight: 400;">{</span></code></p>
<p><code><span style="font-weight: 400;">"Name": "Maria",</span></code></p>
<p><code><span style="font-weight: 400;">"Password": "123456790A"</span></code></p>
<p><code><span style="font-weight: 400;">}</span></code></p>
<p><strong>Resultado:</strong></p>
<p><code><span style="font-weight: 400;">[</span></code></p>
<p><code><span style="font-weight: 400;">&nbsp;&nbsp;"Senha deve ter pelo menos 1 (um) caractere mai&uacute;sculo",</span></code></p>
<p><code><span style="font-weight: 400;">&nbsp;&nbsp;"Senha tem que ter pelo menos 1 (um) caractere especial Ex.: (!@#$%^&amp;*()-+)",</span></code></p>
<p><code><span style="font-weight: 400;">&nbsp;</span><span style="font-weight: 400;">]</span></code></p>
<hr />
<p><strong>Teste: </strong><span style="font-weight: 400;">Senha deve ter pelo menos 1 (um) caractere mai&uacute;sculo</span></p>
<p><code><span style="font-weight: 400;">{</span></code></p>
<p><code><span style="font-weight: 400;">"Name": "Maria",</span></code></p>
<p><code><span style="font-weight: 400;">"Password": "123456790Aa"</span></code></p>
<p><code><span style="font-weight: 400;">}</span></code></p>
<p><strong>Resultado:</strong></p>
<p><code><span style="font-weight: 400;">[</span></code></p>
<p><code><span style="font-weight: 400;">&nbsp;&nbsp;"Senha tem que ter pelo menos 1 (um) caractere especial Ex.: (!@#$%^&amp;*()-+)"</span></code></p>
<p><code><span style="font-weight: 400;">&nbsp;</span><span style="font-weight: 400;">]</span></code></p>
<hr />
<p><strong>Teste: </strong><span style="font-weight: 400;">Senha tem que ter pelo menos 1 (um) caractere especial Ex.: (!@#$%^&amp;*()-+)</span></p>
<p><code><span style="font-weight: 400;">{</span></code></p>
<p><code><span style="font-weight: 400;">"Name": "Maria",</span></code></p>
<p><code><span style="font-weight: 400;">"Password": "123456790Aa$"</span></code></p>
<p><code><span style="font-weight: 400;">}</span></code></p>
<p><strong>Resultado:</strong></p>
<p><code><span style="font-weight: 400;">[</span></code></p>
<p><code><span style="font-weight: 400;">&nbsp;&nbsp;&ldquo;Cadastrado com sucesso! Usu&aacute;rio atende os crit&eacute;rios de senha&rdquo;</span></code></p>
<p><code><span style="font-weight: 400;">]</span></code></p>
<p>&nbsp;</p>
