<?php
class Aluno{
    public $nomealuno;
    public $idade;
    public $nota = [];
    public function media(){
        $somanota = array_sum($this->nota);
        $media = $somanota / count($this->nota);
        $media_round = round($media,1);
        echo "A média de $this->nomealuno é $media_round";
    }
}
$matheus = new Aluno();
$matheus->nomealuno = "Matheus Dell Areti de Souza";
$matheus->idade = 18;
$matheus->nota = [12, 14, 6, 20, 17, 23];
$matheus->media();
//var_dump($matheus);
?>