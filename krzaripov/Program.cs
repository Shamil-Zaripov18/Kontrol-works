using System;
using System.Collections.Generic;

namespace krzaripov
{
    struct SetofStacks
    {
        public int Count { get; private set; }

        readonly int max;

        public List<Stack<int>> stacks;
        

        public SetofStacks(int maximumCountInStack)
        {
            max = maximumCountInStack;
            stacks = new List<Stack<int>>();
            Count = 0;
        }

        public void Push(int things)
        {
            if (stacks.Count == 0)
            {
                stacks[0] = new Stack<int>();
                stacks[0].Push(things);
                Count++;
            }

            if (Count % max == 0)
            {
                stacks[Count % max + 1] = new Stack<int>();
                stacks[Count % max + 1].Push(things);
                Count++;
            }
            else
            {
                stacks[Count % max].Push(things);
                Count++;
            }
        }

        public int Pop()
        {
            if (stacks.Count == 0)
                return 0;
            else
            {
                int a = stacks[Count % max].Pop();
                Count--;
                return a;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SetofStacks perk = new SetofStacks(20);
            Dictionary<char, int>[] massiv = new Dictionary<char, int>[5];
            for (int i = 0; i <= 4; i++)
            {
                massiv[i] = new Dictionary<char, int>();
                massiv[i].Add('a', 1);
                massiv[i].Add('b', 2);
                massiv[i].Add('c', 3);
                massiv[i].Add('d', 4);
                massiv[i].Add('e', 5);
            }
            for (int g = 0; g < 100; g++)
                perk.Push(new Random().Next(1, 100));
        }
    }
}
