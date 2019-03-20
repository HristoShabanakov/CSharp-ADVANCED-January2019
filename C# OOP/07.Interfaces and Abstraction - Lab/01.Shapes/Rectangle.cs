namespace Shapes
{
    using System;
    using System.Text;

    public class Rectangle : IDrawable
    {
        private int height;
        private int width;

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width
        {
            get => this.width;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative!");
                }
                this.width = value;
            }
        }
        public int Height
        {
            get => this.height;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative!");
                }
                this.height = value;
            }
        }

        public string Draw()
        {
            var stringBuilder = new StringBuilder();

            DrawLine(this.Width, '*', '*', stringBuilder);

            for (int i = 1; i < this.Height - 1; i++)
            {
                DrawLine(this.Width, '*', ' ', stringBuilder);
            }

            DrawLine(this.Width, '*', '*', stringBuilder);

            return stringBuilder.ToString();
        }

        private void DrawLine(int width, char end, char mid, StringBuilder sb)
        {
            sb.Append(end);
            for (int i = 1; i < width - 1; i++)
            {
                sb.Append(mid);
            }
            sb.AppendLine(end.ToString());
        }
    }
}
