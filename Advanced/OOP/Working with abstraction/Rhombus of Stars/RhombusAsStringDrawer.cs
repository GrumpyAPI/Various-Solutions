using System;
using System.Collections.Generic;
using System.Text;

namespace Rhombus_of_Stars
{
    public class RhombusAsStringDrawer
    {
        public string Draw(int countOfStars)
        {
            StringBuilder sb = new StringBuilder();
            this.DrawTopPart(sb, countOfStars);
            this.DrawLineOfStars(sb, countOfStars);
            this.DrawBottomPart(sb, countOfStars);

            return sb.ToString();
        }

        private void DrawTopPart(StringBuilder sb, int n)
        {
            for (int i = 1; i < n; i++)
            {
                sb.Append(new string(' ', n - i));
                DrawLineOfStars(sb, i);
            }
        }

        private void DrawBottomPart(StringBuilder sb, int n)
        {
            for (int i = n; i >= 1; i--)
            {
                sb.Append(new string(' ', n - i));
                DrawLineOfStars(sb, i);
            }
        }

        private void DrawLineOfStars(StringBuilder sb, int numberOfStars)
        {
            for (int star = 0; star < numberOfStars; star++)
            {
                sb.Append('*');
                if (star < numberOfStars - 1)
                {
                    sb.Append(' ');
                }
            }

            sb.AppendLine();
        }
    }
}
