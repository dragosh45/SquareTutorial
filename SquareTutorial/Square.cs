using System;
using System.Collections.Generic;
using System.Text;

namespace SquareModel
{
    public class Square
    {
        private double latura;

        public Square(double latura)
        {
            this.latura = latura;
        }

        /*public double getLatura()
        {
            return this.latura;
        }

        public void setLatura(double latura)
        {
            this.latura = latura;
        }*/

        public double Latura
        {
            get { return this.latura; }
            set { latura = value; }
        }

        public double calcArie()
        {
            return Math.Pow(latura, 2);
        }

        public static string colorInfo = "red";

        public static void transformColor()
        {
            colorInfo = "blue";
        }
    }
}
