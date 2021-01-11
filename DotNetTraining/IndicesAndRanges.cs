using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTraining
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
                Console.WriteLine(developer);
            }
            //Index
            Console.WriteLine($"Last element: {developers[^1]}");
            Console.WriteLine($"First element: {developers[0]}");
        }

        #endregion IndexAndRange
    }
}
