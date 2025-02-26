<?php
//Página 42
function CalculaMedia($notatotal) {
    $media = $notatotal / 3;
    return $media;
}
function MostraResultado($aluno, $notatotal) {
    if ($notatotal >= 60)
        $mensagem = "$aluno, você está aprovado";
    else if ($notatotal >= 45)
        $mensagem = "$aluno, você deve fazer recuperação";
    else
        $mensagem = "$aluno, você está reprovado";
        return $mensagem; // Retorna a mensagem
}
$nome = "Joaquim Pereira";
$nota = 48;
echo MostraResultado($nome, $nota); // Exibe a mensagem
// Página 43
$nome = "Cotemig";
$pos = strpos($nome, "o");
echo substr($nome, 1, 3); // Corrigido índice de início
// Página 44
$text = 'teste de substring COTEMIG';
echo strlen($text);
echo substr_count($text, 'te');
echo substr_count($text, 'te', 3);
echo substr_count($text, 'te', 4, 4); // Corrigido índices
$var = 'ABCDEFGH:/COTEMIG/';
echo "Original: $var<hr />\n";
echo substr_replace($var, 'Tecnico', 0) . "<br />\n";
echo substr_replace($var, 'Tecnico', 0, strlen($var)) . "<br />\n";
echo substr_replace($var, 'Tecnico', 0, 0) . "<br />\n";
echo substr_replace($var, 'Tecnico em Informatica', 10) . "<br />\n";
echo substr_replace($var, 'Tecnico em Informatica', -1) . "<br />\n";
echo substr_replace($var, '', 0, -9) . "<br />\n";
//Página 45
$nome = "Cotemig";
echo strtoupper($nome);
$nomes = array(1 => "João", 4 => "Maria", 7 => "José");
echo $nomes[1];
echo $nomes[4];
echo $nomes[7];
$nomes = array("pai" => "João", "mae" => "Maria", "filho" => "José");
echo $nomes["pai"];
echo $nomes["mae"];
echo $nomes["filho"];
//Página 46
$nomes = array("João", "Maria", "José");
echo $nomes[0];
echo $nomes[1];
echo $nomes[2];
$nomes[] = "Madalena";
echo $nomes[3];
echo count($nomes);
$vetor = array(10, 81, 92);
list($primeiro, $segundo, $terceiro) = $vetor;
echo $primeiro;
echo $segundo;
echo $terceiro;
foreach ($nomes as $valor) {
    echo $valor;
}
foreach ($nomes as $indice => $valor) {
    echo $indice . ": " . $valor;
}
//Página 47
$nomes = array("pai" => "João", "mae" => "Maria", "filho" => "José");
foreach ($nomes as $parentesco => $nome) {
    echo "Parentesco: $parentesco | Nome: $nome <br>";
}// Form está no final do código
// Página 48
print_r($_POST);
class Projeto {
    private $id;
    private $nome;
    private $descricao;
    public function __construct($id = NULL){
        $this->id = $id;
    }
}
// Página 49
class ProjetoController {
    public function all(){
        $obj = new Projeto();
        $projetos = $obj->all(); // Aqui precisa ser implementada a função "all()"
        require_once('view/Projeto_all.php');
    }
}
class Projeto {
    private $id;
    private $nome;
    public function __construct($id = NULL){
        $this->id = $id;
        $this->con = new PDO(SERVIDOR, USUARIO, SENHA); // Você precisa definir SERVIDOR, USUARIO e SENHA
    }
}
?>
<form method="post" action="paginaDeDestino.php">
    Nome: <input type="text" name="nome"> <br> 
    E-mail: <input type="text" name="email"> <br> 
    Sexo: <input type="radio" name="sexo" value="M"> Masculino
    <input type="radio" name="sexo" value="F"> Feminino
    <br>
    <input type="submit" name="acao" value="Enviar"> <br> 
</form>