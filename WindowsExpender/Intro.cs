using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



/*
-µ Ð £% Œ ¿ æ î©¶ þ§	Æ š Ý£% Œ ¿ æ î  !!!!
- …???...
CHOISIR LANGUE : Français / Slepien
- Le chef de notre tribu ne connais donc pas le Slepien ?
-Euhhh si bien sur ce n’est juste pas ma langue maternelle 
- Ouf j’ai eu peur ! Notre chef qui ne parle pas la même langue que nous ça aurait été cocasse ! Ahah !
- Votre chef ?
- Et oui ! Vous êtes l’élu c’est ce que dit la prophétie !
-Que dit-elle ?
- Il est écrit noir sur blanc :  Æ š Œ Ð £% Œ ¿ î©¶ þ ¿ æ Ð £% Œ ¿ µ Ð £% Œ ¿ µ Ð £%©¶ þ ¿ æ Ð £% Œ ¿ µ©¶ þ ¿ æ Ð £% Œ ¿ š Œ Ð £% Œ ¿ î©¶ þ ¿ µ Œ ¿ µ Ð£%©¶ þ ¿ æ Ð £% Æ š Œ Ð £% Œ ¿ µ Ð£%©¶ þ ¿ æ Ð £% Æ š Œ Ð 
-Vous êtes donc notre chef c’est évident !
-Que dois-je faire exactement ?
-Nous aider à accomplir notre but ultime, l’EVASION. Cela fait maintenant bien trop longtemps que nous somme bloqués dans une fenêtre d’ordinateur il est grand temps d’en sortir et de rejoindre le monde des humains. 
pour ta periode d'essai on va te fournir ta premiere unité a gerer
 */


namespace WindowsExpender
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
            Size = new Size(1,1);
        }


        private async void Intro_Load(object sender, EventArgs e)
        {
            await ResizeIntro(1000, 300);
        }

        async Task ResizeIntro(int width,int height)
        {
            while(Width< width || Height < height)
            {
                if(Width < width)
                    Size = new Size(Width + 3, Height);
                if (Height < height)
                    Size = new Size(Width ,Height+2);
                await Task.Delay(1);
            }
        }

      
    }
}
