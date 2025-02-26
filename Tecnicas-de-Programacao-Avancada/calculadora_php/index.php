<?php
    $n1 = 0;
    $n2 = 0;
    $resultado = 0;
    $calcular = 'soma';
    if(isset($_GET['n1'],$_GET['n2'],$_GET['calcular'])){
        $n1 = $_GET['n1'];            
        $n2 = $_GET['n2'];        
        $calcular = $_GET['calcular'];
        switch ($calcular){
            case 'somar':
                $resultado = $n1 + $n2;
                break;
            case 'subtrair':
                $resultado = $n1 - $n2;
                break;
            case 'multiplicar':
                $resultado = $n1 * $n2;
                break;
            case 'dividir':
                $resultado = $n1 / $n2;
                break;
        }        
    }
?>
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
</head>
<body>
    <form method="get">
        Primeiro numero <br>
        <input type="number" name="n1" value= <?= $n1 ?> required > <br>
        Segundo numero  <br>
        <input type="number" name="n2" value= <?= $n2 ?> required  ><br><br>
        <button type="submit" name="calcular" value="somar">Somar</button>
        <button type="submit" name="calcular" value="subtrair">Subtrair</button>
        <button type="submit" name="calcular" value="multiplicar">Multiplicar</button>
        <button type="submit" name="calcular" value="dividir">Dividir</button>
        <br><br>
        <p>Resultado: <?= $resultado ?> </p>
    </form>
</body>
</html>