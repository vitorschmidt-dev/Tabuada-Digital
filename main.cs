using System;

class Program {
  public static void Main (string[] args) {

    System.Console.Write("Você quer a tabuada de qual número? "); // Pergunta a tabuada de qual número o usuário quer.
    int n = Convert.ToInt32(Console.ReadLine()); // Declara a variável n e armazena o número escolhido na mesma.

    System.Console.WriteLine($"Tabuada do {n}"); // Escreve na tela o número escolhido.

    // Loop para mostrar a tabuada.
    // Declara a variável cont.
    // Loop repitirá enquanto a variável cont for menor ou igual a 10.
    // A variável cont irá receber mais 1 a cada iteração.
    for (int cont = 0; cont <= 10; cont++) 
    {
        Console.WriteLine($"{n} X {cont} = {n*cont}"); // Escreve na tela o número escolhido vezes o valor atual da variável cont.
    }

    
  }
}