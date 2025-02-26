<?php
    function matematica($operacao){
        $numero1 = 23;
        $numero2 = 45;
        $resultado = 0;
        if ($operacao == "adicao"){
            $resultado = $numero1 + $numero2;
            echo "O resultado da adicao de $numero1 e $numero2 da $resultado";
        }elseif($operacao == "subtracao"){
            $resultado = $numero1 - $numero2;
            echo "O resultado da subtracao de $numero1 e $numero2 da $resultado";
        }elseif($operacao == "multiplicacao"){
            $resultado = $numero1 * $numero2;
            echo "O resultado da multiplicacao de $numero1 e $numero2 da $resultado";
        }elseif($operacao == "divisao"){
            $resultado = $numero1 / $numero2;
            echo "O resultado da divisao de $numero1 e $numero2 da $resultado";
        }else{
            echo "numero 1 = $numero1";
            echo "<br>numero 2 = $numero2";
            echo "<br><h1>Nenhuma operacao apresentada";
        }
    }
    matematica("");
?>