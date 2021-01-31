using MyDictionary;
using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
          MyDictionary<int ,string> sehirler=new MyDictionary<int, string>();
            sehirler.Add(35,"İzmir");
            sehirler.Add(34, "İstanbul");
            sehirler.Add(06, "Ankara");
            sehirler.List(sehirler);
        }
    }
}
