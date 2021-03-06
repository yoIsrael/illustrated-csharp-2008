﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_504
{
   class MyClass
   {
      public IEnumerator<string> GetEnumerator()
      {
         return BlackAndWhite();                         // Returns the enumerator.
      }

      public IEnumerator<string> BlackAndWhite()         // Iterator
      {
         yield return "black";
         yield return "gray";
         yield return "white";
      }
   }

   class Program
   {
      static void Main()
      {
         MyClass mc = new MyClass();

         foreach ( string shade in mc )
            Console.WriteLine( shade );
      }
   }
}
