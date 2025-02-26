<?php
$host = 'localhost';
$dbname = 'aula_pdo';
$username = 'root';
$password = '';
try{
    $pdo = new PDO("mysql:host=$host;dbname=$dbname",$username,$password);
    $pdo -> setAtribute(PDO::ATTR_ERRMODE,PDO::ERRMODE_EXCEPTION);
    echo "Connected Successfuly"; 
}catch{
    die("Connection Failed: ".$e->getMessage())
}
?>