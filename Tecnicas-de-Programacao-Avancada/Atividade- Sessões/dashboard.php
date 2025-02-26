<?php
session_start();
if(!isset($_SESSION['user_id'])) {
    echo "Sem permissão para acesso a página<br>";
    echo '<a href="index.php">Ir para página inicial</a>';
    exit;
}
?>
<!DOCTYPE html>
<html>
<head>

    <title>Painel do Usuário</title>
</head>
<body>
    <h2>Painel do Usuário</h2>
    <p>Bem-vindo, usuário!</p>
    <a href="logout.php">Sair</a>
</body>
</html>