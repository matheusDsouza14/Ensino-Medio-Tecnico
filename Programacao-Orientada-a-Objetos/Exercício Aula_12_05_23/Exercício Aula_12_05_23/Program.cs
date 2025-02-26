using Exercício_Aula_12_05_23;
using System;
class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();
        aluno.setNome("Maria Regina");
        Console.WriteLine(aluno.getNome());

        Professor professor = new Professor();
        professor.setNome("João Silva");
        Console.WriteLine(professor.getNome());

        Curso curso = new Curso();
        curso.setDescricao("Ciência da Computação");
        Console.WriteLine(curso.getDescricao());

        Disciplinas disciplina = new Disciplinas();
        disciplina.setNome("Programação Orientada a Objetos");
        Console.WriteLine(disciplina.getNome());
    }
}