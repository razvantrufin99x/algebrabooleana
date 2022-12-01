using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algebrabooleana
{
    public class adunarebooleanacucarry
    {
        /*

adunare binara
2 biti fara carry

d a b +    	= rez

0 0 0		00
1 0 1		01
2 1 0		01
3 1 1		11

adunare binara
cu carry in

//aduna carryin cu a si depune rezultatul in carrya si a
//aduna a cu b si depune rezultatul in carryb si rez


d c a b +	= rez  

0 0 0 0		00
1 0 0 1		01	
2 0 1 0		01
3 0 1 1		11

1 1 0 0		01
3 1 0 1		11
3 1 1 0		11
3 1 1 1		11





         */
        public int carryin = 0;
        public int carrya = 0;
        public int carryb = 0;
        public int a = 0;
        public int b = 0;
        public int rez = 0;

        public adunarebooleanacucarry() { }
        public adunarebooleanacucarry(int carry, int pa, int pb)
        {
            this.carryin = carry;
            a = pa;
            b = pb;
        }

        public void adunaCAB(int pc, int pa, int pb)
        {
            this.carryin = pc;
            a = pa;
            b = pb;
            addCarryinA();
            addCarryaAB();
        }
        //adunam carryin si a in carrya si a
        //adunam a si b in rez si carryb
        //
        public void addCarryinA()
        {
            if (carryin == 0 && a == 0)
            {
                carrya = 0;
                
            }
            else if(carryin == 1 && a == 0)
            {
                carrya = 0;
                a = 1;
                
            }
            else if (carryin == 0 && a == 1)
            {
                carrya = 0;
                a = 1;

            }

            else if(carryin == 1 && a == 1)
            {
                carryin = 0;
                carrya = 1;
                carryb = 1;
                a = 0;
                
            }

        }

        public void addCarryaAB()
        {
            if (b == 0 && a == 0)
            {
                rez = 0;

            }
            else if (b == 1 && a == 0)
            {
                rez = 1;
                

            }
            else if (b == 0 && a == 1)
            {
                rez = 1;

            }

            else if (b == 1 && a == 1)
            {
                rez = 0;
                carryb = 1;
                //si adunam in rez carrya
                if (carrya == 0 && rez == 0)
                {
                    rez = 0;                   
                    
                }
                if (carrya == 0 && rez == 1)
                {
                    rez = 1;
                }
                if (carrya == 1 && rez == 0)
                {
                    carrya = 0;
                    rez = 1;
                }
                if (carrya == 1 && rez == 1)
                {
                    //ilegal 1 + 1 + 1 + 1 > 3
                    carrya = 0;
                    rez = 1;
                }

            }

        }

    }
}
