<div>Exemplo de funcoes</div>
<hr>
<?php
$msg = function($nome){
    return "olá $nome, bem-vindo a sua primeira função!";
};

echo $msg('Alex');
echo '<br>'. __DIR__;