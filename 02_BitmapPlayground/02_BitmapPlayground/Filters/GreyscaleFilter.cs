using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BitmapPlayground.Filters
{
    /// <summary>
    /// Greyscale filter.
    /// </summary>
    public class GreyscaleFilter : IFilter
    {
        public Color[,] Apply(Color[,] input)
        {
            int width = input.GetLength(0);
            int height = input.GetLength(1);
            Color[,] result = new Color[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    var p = input[x, y];
                    result[x, y] = Color.FromArgb(p.A, Convert.ToInt32((p.R)* 0.3+(p.G) * 0.59 + (p.B) * 0.11), Convert.ToInt32((p.R) * 0.3 + (p.G) * 0.59 + (p.B) * 0.11), Convert.ToInt32((p.R) * 0.3 + (p.G) * 0.59 + (p.B) * 0.11));
                }
            }

            return result;
        }

        public string Name => "Greyscale filter";

        public override string ToString()
            => Name;
    }
}
