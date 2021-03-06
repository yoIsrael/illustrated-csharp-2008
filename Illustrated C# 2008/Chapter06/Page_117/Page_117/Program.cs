﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page_117
{
   class C1
   {
      private int TheRealValue = 10;   // Backing Field: memory allocated
      public int MyValue               // Property: no memory allocated
      {
         set
         {
            TheRealValue = value;      // Sets the value of field TheRealValue
         }
         get
         {
            return TheRealValue;       // Gets the value of the field
         }
      }
   }

   class Program
   {
      static void Main()
      {
         C1 c = new C1();
         Console.WriteLine( "MyValue: {0}", c.MyValue );

         c.MyValue = 20;
         Console.WriteLine( "MyValue: {0}", c.MyValue );
      }
   }
}
