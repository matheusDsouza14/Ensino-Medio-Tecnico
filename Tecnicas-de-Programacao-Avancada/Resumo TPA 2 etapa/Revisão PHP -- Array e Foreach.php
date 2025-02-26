<?php
    $arraychose = "somanota";
    if($arraychose == "carros"){
        $carros = ["BMW","Chevrolet","Ferrari","MCLaren","Ford","Fiat","Lamborghini","Mercedes-Bens","Hyundai","Jeep","Mitsubishi","Nissan","Peugeot","Maserati","Porche","Volkswagen","Toyota","Suzuki","Volvo","Rols-Royce","Subaru","Renaut","RAM","Mini","Mercedes-AMG","Kia","Lexus","Land Rover","Honda","Jaguar","JAC","Iveco","Foton","Effa","Exeed","CAOA Cherry","BYD","Agrale","Aston Marin","Porsche"];
        $quant = count($carros);
        echo "Marcas de carro(lista) : <br>";
        foreach ($carros as $indice => $carros) {
            echo "($indice) $carros <br>";
        } 
    }elseif($arraychose == "somanota"){
        $notas = [5,7,8,9,13,12,11,4.5];
        $somanotas = array_sum($notas);
        echo "A soma das notas e $somanotas";
    }elseif($arraychose == "somanumeros"){
        $numeros = array(10, 20, 30, 40, 50);
        $soma = 0;
        foreach ($numeros as $numero) {
            $soma += $numero;
        }
        echo "A soma dos numeros e $soma";
    }
?>