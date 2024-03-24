using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302223136
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String  title, int playCount)
        {
            Random i = new Random();
            this.id = i.Next(10000, 99999);

            if (title == "" || title == null)
            {
                System.Console.WriteLine("Title cannot be empty");
            } 
            else
            {
                this.title = title;
            }

            this.playCount = 0;
        }

        public void IncreasePlayCount(int x)
        {
            try
            {
                checked
                {
                    if (x > 10000000)
                    {
                        this.playCount += 10000000;
                    }
                    else
                    {
                        this.playCount += x;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void PrintVideoDetails()
        {
            System.Console.WriteLine("Video ID: " +  this.id);
            System.Console.WriteLine("Title: " + this.title);
            System.Console.WriteLine("Number of plays: " + this.playCount);
        }
    }
}
