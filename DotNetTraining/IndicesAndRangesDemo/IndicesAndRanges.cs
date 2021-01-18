using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTraining.IndicesAndRangesDemo
{
    public class IndicesAndRanges
    {
        #region IndexAndRange

        public void IndexAndRange()
        {
            string[] developers = { "Maneesha", "Chaitanya", "VenkatSai", "Afroz", "kamal", "SaiTej" };

            //Range
            foreach (var developer in developers[1..4])
            {
                //it will print 1st, 2nd and 3rd element
                Console.WriteLine(developer);
            }
            //Index
            Console.WriteLine($"Last element: {developers[^((developers.Length))]}");
            Console.WriteLine($"First element: {developers[0]}");
        }

        #endregion IndexAndRange
    }
}
