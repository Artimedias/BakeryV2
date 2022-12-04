using System.Collections;
using System.Collections.Generic;
using System;

namespace PastryCalc
{
    public class Pastry
    {
        public int PastryPrice(int food, int price)
        {      
             while (food > 0)
            { 
                if (food >= 3)
                {
                    if((food % 3) == 0)
                    {
                        price += ((food / 3) * 5);
                        food = 0;  
                    }
                    else
                    {
                        price = price + (((food -(food % 3)) / 3) * 5);
                        food = (food % 3);
                    }
                }
                else
                {
                    price = price + (food * 2);
                    food = 0;
                }       
            }
            return price;
        }
    }
}