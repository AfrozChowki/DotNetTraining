﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTraining
{
    public class NullCoalescing
    {
        #region NullCoalescingExample

        public void NullCoalescingExample()
        {
            List<int> numbers = null;
            int? a = null;
            // if numbers are null, then add 5 to numbers list
            (numbers ??= new List<int>()).Add(5);
            Console.WriteLine(string.Join(" ", numbers));

            numbers.Add(a ??= 1);
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(a);

        }

        #endregion NullCoalescingExample
    }
}
