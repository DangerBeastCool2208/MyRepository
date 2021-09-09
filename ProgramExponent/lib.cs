namespace Library
{
    public class Exponent
    {
        public static decimal Exp 
        {get
         {
            return Number(100000);
         }
        }

        public static decimal Number(long prirost)
        {
            decimal num = 1;
            for (var i = 1; i < prirost; i++)
            {
                num *= (1 + 1/prirost);
           
            }
            return num;
        }
        
    }
}