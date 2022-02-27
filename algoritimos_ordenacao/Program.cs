using System;

namespace algoritimo_ordenacao;
class Program
{
    static void Main(string[] args){
        int exercicio = 6;
        int[] arr = new int[5]{45,32,76,34,84};
        int valor = 45;

        switch(exercicio){
        case 0:
            int[] colecao = new int[]{78,45,83,63,55,100,23,67};

            ExibirArray(colecao);
            //Console.WriteLine("Aplicando o algoritimo Bubble Sort");
            //OrdenarBubbleSort(ref colecao);
            Console.WriteLine("Aplicando o metodo static Sort");
            OrdenarSort(ref colecao);
            ExibirArray(colecao);
            break;
        
        case 1:
            int[] arrCopia = new int[10];
            Console.WriteLine();
            ExibirArray(arrCopia);
            CopiarArray(ref arr,ref arrCopia);
            Console.WriteLine();
            ExibirArray(arrCopia);
            break;
        
        case 2:
            if (ExisteElemento(arr,valor)) {
                Console.WriteLine("Encontrei o valor {0}",valor);
            } else {
                Console.WriteLine("Nao encontrei o valor {0}",valor);
            }
            break;
        
        case 3:
            if (TodosSaoMaiorQue(arr,valor)) {
                Console.WriteLine("Todos os valores são maiores que {0}",valor);
            } else {
                Console.WriteLine("Exitem valores que são menores que {0}",valor);
            }
            break;
        case 4:
            int valorObtido = ObterValor(arr,valor);
            if (valorObtido>0) {
                Console.WriteLine("Achei {0} no array",valorObtido);
            } else {
                Console.WriteLine("{0} não encontrado no array",valorObtido);
            }
            break;
        case 5:
            int indice = ObterIndice(arr,valor);
            if (indice > -1) {
                Console.WriteLine("O indice de {0} é {1}",valor,indice);
            } else {
                Console.WriteLine("O array não possui {0}",valor);
            }

            break;
            
        case 6:
            Console.WriteLine("a capacidade atual do array é {0}", arr.Length);
            Console.WriteLine("Executando...");
            RedimensionarArray(ref arr,10);
            Console.WriteLine("a nova capacidade do array é {0}", arr.Length);
            break;
        }
    }

    static void OrdenarBubbleSort(ref int[] arr){
        int temp = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length-1; j++)
            {
                if(arr[j] > arr[j+1]){
                    temp = arr[j+1];
                    arr[j+1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }

    static void OrdenarSort(ref int[] arr){
        Array.Sort(arr);
    }

    static void ExibirArray(int[] arr){
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i].ToString()+" ");
        }
        Console.WriteLine();
    }

    static void CopiarArray(ref int[] arr,ref int[] arrDestino){
        Array.Copy(arr,arrDestino,arr.Length);
    }

    static bool ExisteElemento(int[] arr, int valor){
        return Array.Exists(arr, elemento => elemento == valor);
    }
    static bool TodosSaoMaiorQue(int[] arr, int valor){
        return Array.TrueForAll(arr, elemento => elemento > valor);
    }

    static int ObterValor(int[] arr, int valor){
        return Array.Find(arr, elemento => elemento == valor);
    }

     static int ObterIndice(int[] arr, int valor){
        return Array.IndexOf(arr, valor);
    }
    static void RedimensionarArray(ref int[] arr, int novoTamanho){
        Array.Resize(ref arr,novoTamanho);
    }
}