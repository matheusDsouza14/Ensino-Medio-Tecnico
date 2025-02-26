<?php
// Funções
function somar($a, $b) {
    return $a + $b;
}
$resultado = somar(5, 3);
echo $resultado;
// Classes
class Pessoa {
    // Atributos
    public $nome;
    public $idade;
    
    // Métodos
    public function saudar() {
        echo "Olá, meu nome é {$this->nome} e eu tenho {$this->idade} anos.";
    }
}
$pessoa = new Pessoa();
$pessoa->nome = "João";
$pessoa->idade = 25;
$pessoa->saudar();
// Atributos
class Pessoa {
    public $nome; // Atributo público
    protected $email; // Atributo protegido
    private $senha; // Atributo privado
}
// Métodos
class Pessoa {
    public function saudar() {
        echo "Olá!";
    }
    
    protected function realizarTarefa() {
        echo "Realizando tarefa...";
    }
    
    private function informarSenha() {
        echo "Minha senha é secreta.";
    }
}
// Construtor
class Pessoa {
    public $nome;
    
    public function __construct($nome) {
        $this->nome = $nome;
    }
}
$pessoa = new Pessoa("João");
echo $pessoa->nome;
// Encapsulamento (setters e getters)
class Pessoa {
    private $nome;
    
    public function setNome($nome) {
        $this->nome = $nome;
    }
    
    public function getNome() {
        return $this->nome;
    }
}
$pessoa = new Pessoa();
$pessoa->setNome("Maria");
echo $pessoa->getNome();
// Herança
class Animal {
    public function comer() {
        echo "O animal está comendo.";
    }
}
class Cachorro extends Animal {
    public function latir() {
        echo "O cachorro está latindo.";
    }
}
$cachorro = new Cachorro();
$cachorro->comer();
$cachorro->latir();
// Polimorfismo (classes e métodos abstratos)
abstract class Animal {
    abstract public function emitirSom();
}
class Cachorro extends Animal {
    public function emitirSom() {
        echo "O cachorro está latindo.";
    }
}
class Gato extends Animal {
    public function emitirSom() {
        echo "O gato está miando.";
    }
}
$cachorro = new Cachorro();
$gato = new Gato();
$cachorro->emitirSom();
$gato->emitirSom();
// PDO - Conexão com banco
$dsn = 'mysql:host=localhost;dbname=meu_banco';
$usuario = 'usuario';
$senha = 'senha';
try {//Tenta executar uma ação
    $conexao = new PDO($dsn, $usuario, $senha);
    $consulta = $conexao->query('SELECT * FROM clientes');
    $clientes = $consulta->fetchAll(PDO::FETCH_ASSOC);
    foreach ($clientes as $cliente) {
        echo $cliente['nome'];
    }
} catch (PDOException $e) {//Se der erro
    echo 'Erro ao conectar com o banco de dados: ' . $e->getMessage();
}