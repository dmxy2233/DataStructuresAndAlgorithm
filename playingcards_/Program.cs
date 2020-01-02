using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playingcards_
{
    class Program
    {
        enum Suit
        {
            Spade, Heart, Diamond, Club
        }
        enum Value
        {
            Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queue, King, Ace
        }
        class Card
        {
            public Suit suit;
            public Value value;
        }
        static void Main(string[] args)
        {
            Card[] c = new Card[52];
            for (int i = 0; i < 52; i++)   ///初始化一副扑克牌
            {
                c[i] = new Card();
                c[i].suit = (Suit)(i % 4);
                c[i].value = (Value)(i % 13);
            }
            for (int k = 51; k >= 0; k--)  //洗牌
            {
                Random rand = new Random();
                int p = rand.Next(k);
                Card temp = new Card();
                temp = c[p];
                c[p] = c[k];
                c[k] = temp;
            }
            Card[] E = new Card[13]; Card[] W = new Card[13];
            Card[] S = new Card[13]; Card[] N = new Card[13];
            int A = 0, B = 0, C = 0, D = 0;
            for (int j = 0; j < 52; j++)//分牌
            {
                switch (j % 4)
                {
                    case 0: { E[A++] = c[j]; break; }
                    case 1: { S[B++] = c[j]; break; }
                    case 2: { W[C++] = c[j]; break; }
                    case 3: { N[D++] = c[j]; break; }
                    default: { Console.WriteLine("error"); break; }
                }
            }
            Console.WriteLine("东：");
            for (int i = 0; i < 13; i++)
            { Console.Write("{0},{1} ", E[i].suit, E[i].value); }
            Console.WriteLine();
            Console.WriteLine("南：");
            for (int i = 0; i < 13; i++)
            { Console.Write("{0},{1} ", S[i].suit, S[i].value); }
            Console.WriteLine();
            Console.WriteLine("西：");
            for (int i = 0; i < 13; i++)
            { Console.Write("{0},{1} ", W[i].suit, W[i].value); }
            Console.WriteLine();
            Console.WriteLine("北：");
            for (int i = 0; i < 13; i++)
            { Console.Write("{0},{1} ", N[i].suit, N[i].value); }

            QuickSort(S);
            Console.WriteLine("排序后：");
            for (int i = 0; i < 13; i++)
            { Console.Write("{0},{1} ", S[i].suit, S[i].value); }
            Console.WriteLine();
            Console.ReadLine();


        }

        private static void QuickSort(Card[] Key)
        {
            Quick(Key, 0, Key.Length - 1);
        }

        private static void Quick(Card[] Key, int left, int right)
        {
            Value current = Key[left].value;
            int i = left;
            int j = right;

            if (left < right)
            {
                while (i < j) // 当i=j时，表示i之前的数均比current小，之后的数均比current大，即i是current在正确排序序列中的正确位置
                {
                    while (Key[j].value >= current && i < j)
                    {
                        j--;
                    }
                    while (Key[i].value <= current && i < j)
                    {
                        i++;
                    }
                    if (i < j)
                    {
                        Value temp = Key[i].value;
                        Key[i].value = Key[j].value;
                        Key[j].value = temp;
                    }

                }
                Key[left].value = Key[i].value;
                Key[i].value = current; // 将current放置到正确的位置上
                if (left < j - 1)
                    Quick(Key, left, j - 1);
                if (j + 1 < right)
                    Quick(Key, j + 1, right);
            }

        }

    }

   




}


