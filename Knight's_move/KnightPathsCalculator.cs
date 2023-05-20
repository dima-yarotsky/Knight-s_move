using Knight_s_move;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knight_s_move
{
    public class KnightPathsCalculator
    {
        private const int FinalPostion = 1;

        private int n;
        private int m;

        private int paths;

        public KnightPathsCalculator(int n, int m)
        {
            this.n = n;
            this.m = m;
        }

        public int GetPaths()
        {
            var startPositionX = this.n;
            var startPositionY = this.m;

            this.CountRoutes(startPositionX, startPositionY, 0, true);
            return this.paths;
        }
        private void CountRoutes(int x, int y, int movesCount, bool isFirst = false)
        {
            if (x < FinalPostion || y < FinalPostion)
            {
                return;
            }

            if (x == FinalPostion && y == FinalPostion && !isFirst)
            {
                this.paths += (int)Math.Pow(2, movesCount);
                return;
            }

            movesCount++;
            this.CountRoutes(x - 1, y - 2, movesCount);
            this.CountRoutes(x - 2, y - 1, movesCount);
        }
    }
}
