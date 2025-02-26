 <?php 
    /*echo "<pre>";
    print_r($_GET);exit;
       if($_GET){
            $login = $_GET['login'];
            $senha = $_GET['senha'];
       } //Possui limite de dados , dados mostrados na url*/
       if($_POST) //Ilimitado, dados não mostrado na ur
       {
            $login = $_POST['login'];
            $senha = $_POST['senha'];
            if($login == "teste" & $senha=="1234")
            {
                echo "<h1>Acesso concedido<h1>";exit;
            }elseif ($login == "" & $senha == "")
            {
                echo "<h1>Senha ou Login faltando por favor digite novamente<h1>";exit;
            }else{
                echo "<h1>Senha ou login invalidos";exit;
            }
       }
       
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Revisão PHP -- Get Post If/Else</title>
</head>
<body> 
    <form action ="" method="post">Login <Br>
       <input type = "text" name="login"><br><br>
       Senha<br>
       <input type="password" name="senha"><br><br>
       <input type="submit" value="enviar">
    </form>
</body>
</html>