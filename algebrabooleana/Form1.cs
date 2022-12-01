using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace algebrabooleana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           adunarebooleanacucarry addAB = new adunarebooleanacucarry();
           addAB.adunaCAB(1, 1, 1);
           button1.Text = "";
           button1.Text += "1,1,1";
           button1.Text += "\r\n";
           button1.Text += "a:" + addAB.a.ToString();
           button1.Text += "\r\n";
           button1.Text += "b:" + addAB.b.ToString();
           button1.Text += "\r\n";
           button1.Text += "rez:" + addAB.rez.ToString();
           button1.Text += "\r\n";
           button1.Text += "carrya:" + addAB.carrya.ToString();
           button1.Text += "\r\n";
           button1.Text += "carryb:" + addAB.carryb.ToString();
           button1.Text += "\r\n";
           button1.Text += "carryin:" + addAB.carryin.ToString();
           button1.Text += "\r\n";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            adunarebooleanacucarry addAB = new adunarebooleanacucarry();
            addAB.adunaCAB(1, 1, 1);
            button2.Text = "";
            button2.Text += "\r\n";
            button2.Text += "1,1,1";
            button2.Text += "\r\n";
            button2.Text += "a:" + addAB.a.ToString();
            button2.Text += "\r\n";
            button2.Text += "b:" + addAB.b.ToString();
            button2.Text += "\r\n";
            button2.Text += "rez:" + addAB.rez.ToString();
            button2.Text += "\r\n";
            button2.Text += "carrya:" + addAB.carrya.ToString();
            button2.Text += "\r\n";
            button2.Text += "carryb:" + addAB.carryb.ToString();
            button2.Text += "\r\n";
            button2.Text += "carryin:" + addAB.carryin.ToString();
            button2.Text += "\r\n";

        }

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

        /*
         
         sistemul de numeratie binar
         * nu incurcati adunarea binara cu sistemul binar sau tabelul de adevar
         * 
         * d    d   c   b   a   hex oct     
         * 0    0   0   0   0   0   00  
         * 1    0   0   0   1   1   01
         * 2    0   0   1   0   2   02
         * 3    0   0   1   1   3   03
         * 4    0   1   0   0   4   04
         * 5    0   1   0   1   5   05            
         * 6    0   1   1   0   6   06
         * 7    0   1   1   1   7   07
         * 8    1   0   0   0   8   10     
         * 9    1   0   0   1   9   11
         * 10   1   0   1   0   A   12
         * 11   1   0   1   1   B   13
         * 12   1   1   0   0   C   14    
         * 13   1   1   0   1   D   15
         * 14   1   1   1   0   E   16
         * 15   1   1   1   1   F   17
         */
    }
}
