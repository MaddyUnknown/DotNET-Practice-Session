using System;

namespace OOP
{

    
    // Classes for content
    public interface IContent
    {
        public int[] getContent();
    }

    public class Image : IContent
    {
        private int[] content = new int[0];
        private int height=0;
        private int width = 0;

        public int Height
        {
            get
            {
                return height;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
        }

        public Image(string filename)
        {   
            //dummy implementation
            getImage();
        }

        private void getImage()
        {
            int height = 5, width = 10;
            int[] tempImage = new int[height * width];
            Random random = new Random();
            for(int i=0; i<height*width; i++)
            {

                tempImage[i] = random.Next(256);
            }
            this.content = tempImage;
            this.height = height;
            this.width = width;
        }

        public int[] getContent()
        {
            int[] contentCopy = new int[height * width];
            for(int i=0; i<height*width; i++)
            {
                contentCopy[i] = content[i];
            }
            return contentCopy;
        }

        public int this[int i, int j]
        {
            get
            {
                if (j >= width || j < 0 || i >= height || i < 0) throw new ArgumentException("Custom: Index out of bound");
                return content[i * width + j];
            }

            set
            {
                if (j >= width || j < 0 || i >= height || i < 0) throw new ArgumentException("Custom: Index out of bound");
                content[i * width + j] = value;
            }
        }
    }

    public class Text : IContent
    {
        private int[] content = new int[0];

        public int Length
        {
            get { return content.Length; }
        }

        public Text(string content)
        {
            this.content = new int[content.Length];
            int i = 0;
            foreach(char c in content)
            {
                this.content[i] = (int) c;
            }
        }

        public char this[int index]
        {
            get
            {
                if (index >= Length || index < 0) throw new ArgumentException("Custom: Index not found");
                return (char) content[index];
            }
            set
            {
                if (index >= Length || index < 0) throw new ArgumentException("Custom: Index not found");
                content[index] = (int) value;
            }
        }
        public int[] getContent()
        {
            int[] contentCopy = new int[this.content.Length];

            for(int i=0; i<content.Length; i++)
            {
                contentCopy[i] = this.content[i];
            }
            return contentCopy;
        }

        public int[] getText()
        {
            int[] contentCopy = new int[this.content.Length];

            for (int i = 0; i < content.Length; i++)
            {
                contentCopy[i] = this.content[i];
            }
            return contentCopy;
        }
    }


    // MessageService Classes

    public abstract class MessageService
    {
        private IContent content;
        private List<string> receivers;

        public string Sender
        {
            get; set;
        }

        public MessageService(IContent content)
        {
            this.content = content;
        }


        public void sendMessage()
        {
            encodingProtocol();
            Console.Write("Sending message from here to all receivers");
        }

        protected abstract void encodingProtocol();
    }



    class Driver
    {
        static void Main(string[] args)
        {
            Image img = new Image(@"C:\test.png");
            img[0, 1] = 10;
            for(int i =0; i<img.Height; i++)
            {
                for(int j=0; j<img.Width; j++)
                {
                    Console.Write(img[i,j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}