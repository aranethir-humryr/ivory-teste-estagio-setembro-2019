using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Captura do nome.
            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine();      
            //Definição da matriz.
            int colunas=nome.Length+3;
            int linhas=3;
            string [,] matriz=new string[linhas,colunas];
            //Definição das variáveis de apoio: contCol1 > Ref. Genérica; contCol2>Ref. da última coluna; Contador > Números a preencher na matriz.
            int contCol1=0, contCol2=colunas-1,contador=1;
            //Preenchimento da primeira linha, da esquerda pra direita.
            for(int ind=0;ind<contCol2;ind++)
                matriz[contCol1,ind]=Convert.ToString(contador++);
            contCol1++;
            //Primeiro preenchimento da segunda linha, colocando o nome a partir do segundo campo e o número no último campo.
            matriz[contCol1,contCol2-1]=Convert.ToString(contador++);
            for(int ind=0;ind<contCol2-2;ind++)
                matriz[contCol1,ind+1]=Convert.ToString(nome[ind]);
            contCol1++;
            //Preenchimento da última linha, da direita pra esquerda.
            for(int ind=contCol2-1;ind>=0;ind--)
                matriz[contCol1,ind]=Convert.ToString(contador++);
            //Preenchimento da última célula (Primeira da segunda célula) com o último número.   
            matriz[contCol1-1,0]=Convert.ToString(contador++);
            //Impressão.
            for(int i=0;i<linhas;i++){
                for(int b=0;b<colunas;b++){
                    Console.Write("{0}\t",matriz[i,b]);
                }
                Console.Write("\n");
            }
        }
    }
}
