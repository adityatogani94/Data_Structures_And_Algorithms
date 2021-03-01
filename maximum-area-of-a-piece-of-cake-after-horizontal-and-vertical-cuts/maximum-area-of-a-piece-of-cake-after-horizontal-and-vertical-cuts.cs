public class Solution
    {
        public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts)
        {
            Array.Sort(horizontalCuts);
            Array.Sort(verticalCuts);

            long maxHor = horizontalCuts[0];
            long maxVert = verticalCuts[0];

            for (int i = 1; i < horizontalCuts.Length; i++)
            {
                maxHor = Math.Max(maxHor, horizontalCuts[i] - horizontalCuts[i - 1]);
            }
            maxHor = Math.Max(maxHor, h - horizontalCuts[horizontalCuts.Length - 1]);

            for (int i = 1; i < verticalCuts.Length; i++)
            {
                maxVert = Math.Max(maxVert, verticalCuts[i] - verticalCuts[i - 1]);
            }

            maxVert = Math.Max(maxVert, w - verticalCuts[verticalCuts.Length - 1]);

            BigInteger hor = new BigInteger(maxHor);
            BigInteger vert = new BigInteger(maxVert);
            BigInteger sq = hor * vert;
            sq = sq % 1_000_000_007;
            return  (int)sq;
        }
    }