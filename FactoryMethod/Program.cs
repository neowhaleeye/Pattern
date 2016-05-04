﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();

            foreach(var doc in documents)
            {
                Console.WriteLine(doc.GetType().Name+"--");
                foreach(var p in doc.Pages)
                {
                    Console.WriteLine(p.GetType().Name);
                }
            }
        }
    }
}
