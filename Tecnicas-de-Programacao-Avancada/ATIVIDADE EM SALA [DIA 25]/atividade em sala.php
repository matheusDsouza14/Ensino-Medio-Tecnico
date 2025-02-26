<?php
$hostname = "localhost"; 
$username = "Matheus_DellAreti";
$password = "";
$dbname = "matheusd_hobby";

try {
    $conn = new PDO("mysql:host=$hostname;dbname=$dbname", $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    // Inserir dados na tabela
    $stmt = $conn->prepare("INSERT INTO hobbies (nome, hobby) VALUES (:nome, :hobby)");
    $stmt->bindParam(':nome', $nome);
    $stmt->bindParam(':hobby', $hobby);
    $nome = "Matheus Dell Areti";
    $hobby = "Jogar Jogos Eletronicos";
    $stmt->execute();
    // Ler dados da tabela
    $query = $conn->query("SELECT * FROM hobbies");
    $result = $query->fetchAll(PDO::FETCH_ASSOC);
    foreach ($result as $row) {
        echo "ID: " . $row['id_hobbies'] . "<br>"; 
        echo "Nome: " . $row['nome'] . "<br>";
        echo "Hobby: " . $row['hobby'] . "<br><br>";
    }

} catch (PDOException $e) {
    echo "Erro: " . $e->getMessage();
}
?>
