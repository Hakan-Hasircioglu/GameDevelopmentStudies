﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniAdventureStory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            bool dead = false;
            #endregion
            while (true)
            {
                #region Asking Name
                hr();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(
    @"\________\--------___       ___         ____----------/_________/
    \_______\----\\\\\\   //_ _ \\    //////-------/________/    
        \______\----\\|| (( ~|~ )))  ||//------/________/        
            \_____\---\\ ((\ = / ))) //----/_____/               
                 \____\--\_)))  \ _)))---/____/                  
                       \__/  (((     (((_/                       
                       |  -)))  -  ))                            
");
                Console.ForegroundColor = ConsoleColor.White;
                hr();
                Console.WriteLine(@break() + "Angel: Hello Shinsine, What is your name?");
                hr();
                #endregion

                #region Choosing Name
                Console.Write(@break() + "Player:  ");
                string playerName = Console.ReadLine();
                hr();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(
    @"\________\--------___       ___         ____----------/_________/
    \_______\----\\\\\\   //_ _ \\    //////-------/________/    
        \______\----\\|| (( ~|~ )))  ||//------/________/        
            \_____\---\\ ((\ = / ))) //----/_____/               
                 \____\--\_)))  \ _)))---/____/                  
                       \__/  (((     (((_/                       
                       |  -)))  -  ))                            
");
                Console.ForegroundColor = ConsoleColor.White;
                hr();
                Console.WriteLine(@break() + $"Angel: Hello {playerName}.");
                longhr();
                #endregion

                #region Waking
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"       
                  _,--~~~~~--,_gggrgM**M#mggg__ 
              __,---,_        `\ wgNN@""B*P""""mp""""@d#""@N#Nw__
              /~        ~~\    `.  g#@0F_a*F#  _*F9m_ ,F9*__9NG#g_
              |      /~~\   |    | _mN#F  aM""    #p""    !q@    9NL ""9#Qu_
              |     |   '   |    |  g#MF _pP""L  _g@""9L_  _g""""#__  g""9w_ 0N#p
              |     `\.__,-'    .' 0F jL*""   7_wF     #_gF     9gjF   ""bJ  9h_
               `\_             /  j#  gAF    _@NL     _g@#_      J@u_    2#_  #_
               `--,_____,--' ,FF_#"" 9_ _#""  ""b_  g@   ""hg  _#""  !q_ jF ""*_09_");
                Console.ForegroundColor = ConsoleColor.White;
                longhr();
                Console.WriteLine(@break() + $"Wake up! Wake up!");
                Thread.Sleep(1000);
                Console.WriteLine(@break() + $"Wake u... Wake...");
                hr();
                #endregion

                #region Begin Story
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"
           \\\     \\       \\     \      \\   \\
            \\\\    \\\  \\  \\\\\   \\  \ \\\\ \\   \\\\\
             \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\      \
                \\\\\\\\\\\\\\\\\\\\\     \\\\\\\\\\\\\\\\\      .
                   \\\\\\\\\\                     \\\\\\\\\\\
                      \\         \\\wWWWWWWWww.          \\\\\\\    `
                          \\ \\\WWW""""""::::::""""WWw         \\\\\    ,
                     \  \\ \\wWWW"" .,wWWWWWWw..  WWw.        \\\
                  ` ` \\\\\wWW""   W888888888888W  ""WXX.       `\\
                   . `.\\wWW""   M88888i#####888""8M  ""WWX.      `\`
                  \ \` wWWW""   M88888##d###""w8oo88M   WWMX.     `\
                   ` \wWWW""   :W88888####*  #88888M;   WWIZ.     ``
               - -- wWWWW""     W88888####42##88888W     WWWXx .
                   / ""WIZ       W8n889######98888W       WWXx.
                  ' '/""Wm,       W88888999988888W        >WWR"" :
                   '   ""WMm.      ""WW88888888WW""        mmMM"" '
                         ""Wmm.       ""WWWWWW""        ,whAT?""
                          """"MMMmm..            _,mMMMM""""""
                               """"MMMMMMMMMMMMMM""""""""");
                Console.ForegroundColor = ConsoleColor.White;
                longhr();
                Console.WriteLine(@break() + "Suddenly you open your eyes and realise you're dreaming.");
                longhr();
                Console.WriteLine(@"
.                             .-.    .  _   *     _   .      
                  *          /   \     ((       _/ \       *    .
                _    .   .--'\/\_ \     `      /    \  *    ___
            *  / \_    _/ ^      \/\'__        /\/\  /\  __/   \ *
              /    \  /    .'   _/  /  \  *' /    \/  \/ .`'\_/\   .
          .   /\/\  /\/ :' __  ^/  ^/    `--./.'  ^  `-.\ _    _:\ _
             /    \/  \  _/  \-' __/.' ^ _   \_   .'\   _/ \ .  __/ \
           /\  .-   `. \/     \ / -.   _/ \ -. `_/   \ /    `._/  ^  \
          /  `-.__ ^   / .-'.--'    . /    `--./ .-'  `-.  `-. `.  -  `.
        @/        `.  / /      `-.   /  .-'   / .   .'   \    \  \  .-  \%
         @&8jgs@@%% @)&@&(88&@.-_=_-=_-=_-=_-=_.8@% &@&&8(8%@%8)(8@%8 8%@)%
         @88:::&(&8&&8:::::%&`.~-_~~-~~_~-~_~-~~=.'@(&%::::%@8&8)::&#@8::::
         `::::::8%@@%:::::@%&8:`.=~~-.~~-.~~=..~'8::::::::&@8:::::&8:::::'
          `::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::.'");
                hr();
                Console.WriteLine(@break() + "You can barely observe the surroundings from the low light inside\n" +
                    @break() +
                    "and you can understand that you are in a cave in the mountains.");
                longhr();
                #endregion

                #region Look at the Giant Cat
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"
                                  (`.-,')                 _..._ 
                                .-'     ;              ./       \
                            _.-'   , `,-            -. /         \ .-
                      _ _.-'     .'  /.            -. /           \ .-
                   .' `  _.-.  /  ,'._;)          _ ;|             |;  _  
                   (       .  )-| (
                    )`,_ ,'_,'  \_;)
            ('_  _,'.'  (___,))
             `-:;.-'");
                Console.ForegroundColor = ConsoleColor.White;
                hr();
                Console.WriteLine(@break() + "You see the Giant Cat standing with its back turned");
                Console.WriteLine(@break() + "at the cave exit.");
                longhr();
                #endregion

                #region First Choose
                Console.WriteLine(
                    "A)\t Take a look around and see if there's anything useful.\n" +
                    "B)\t Walk up to the cat and say \"fuck you\".");
                hr();
                Console.Write(@break() +
                    $"{playerName}: ");
                string firstChoose = Console.ReadLine();
                hr();
                if (firstChoose == "A" || firstChoose == "a")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@"
               +--------------+
              /              /|
             *--+-----------* |
            |              |  |
            |              + -+
            |              |/
            *--------------*");
                    Console.ForegroundColor = ConsoleColor.White;
                    hr();
                    Console.WriteLine(@break() + "There's almost nothing in the cave, but a little ");
                    Console.WriteLine(@break() + "further on you can see a box.");
                    longhr();
                }
                else if (firstChoose == "B" || firstChoose == "b")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(@"
                   _                         _
                  |_|              Fuck You |_|
                  | |         /^^^\         | |
                 _| |_       (|""o""|)       _| |_
               _| | | | _    (_---_)    _ | | | |_ 
              | | | | |' |    _| |_    | `| | | | |
              \          /   / \ /   \  \         /
               \        /  / /| | |\ \   \       /
                 \    /  / /  |_|_|  \ \  \    /
                   \  \/ /    || ||    \ \/  /
                     \_/      || ||      \_/
                              () ()
                              || ||
                            ooO Ooo");
                    Console.ForegroundColor = ConsoleColor.White;
                    longhr();
                    Console.WriteLine(@break() + "Immediately after swearing, the giant cat turns");
                    Console.WriteLine(@break() + "to you and recognises you.");
                    longhr();
                    dead = Dead();
                    Console.WriteLine("Do you want try again? Y/N");
                    string again = Console.ReadLine();
                    if (again == "Y" || again == "y")
                    {
                        Console.WriteLine("Restarting...");
                    }
                    else
                    {
                        credits();
                        break;
                    }
                    
                }
                else
                {
                    Console.WriteLine(@break() + "You gave the wrong answer!\nStart again.");
                    continue;
                }
                #endregion

                #region Second Choose
                if (firstChoose == "A" || firstChoose == "a")
                {
                    Console.WriteLine(
                    "A)\t Run towards the box.\n" +
                    "B)\t Throw a stone into the box to attract the attention of the giant cat.");
                    hr();
                    Console.Write(@break() +
                        $"{playerName}: ");
                    string secondChoose = Console.ReadLine();
                    hr();
                    if (secondChoose == "A" || secondChoose == "a")
                    {
                        Console.WriteLine(@break() + "The giant cat spotted you.");
                        longhr();
                        dead = Dead();
                        Console.WriteLine("Do you want try again? Y/N");
                        string again = Console.ReadLine();
                        if (again == "Y" || again == "y")
                        {
                            Console.WriteLine("Restarting...");
                        }
                        else
                        {
                            credits();
                            break;
                        }
                        
                    }
                    else if (secondChoose == "B" || secondChoose == "b")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(@"
                    __        .-.
                 .-""` .`'.   /\|
         _(\-/)_"" ,  .   ,\ /\/
        {(#b^d#)} .   ./,  |/\/
        `-.(Y).-`  ,  |  , |\/
             /~/,_/~~~\,__.-`
            ////~    // ~\\
           ==`==`   ==`   ==`");
                        Console.ForegroundColor = ConsoleColor.White;
                        longhr();
                        Console.WriteLine(@break() + "You scared the cat and got its attention.");
                        longhr();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(@"
                    /)
                   //
                  //
                 ((
                  \\
                   ))
                  //
              _,-'""._
             /_  ,   \
             |   '   /
             \)    ,\'
             '|      \
             /   |   )
            /_   ,  /
           /  _  % (
           ) /    ' \
          /        \_)
          ),    )_   \_  ,
         _/    _/%     \/)
        ('  __/ \ ___    \,
         \   (   `""-  __  /
          '\  \   ((   >  \
            )  \   '-.-,_='~~~  ~
            ('  /         ' ~~ ~  ~~ ~~
           "" """"
");
                        Console.ForegroundColor = ConsoleColor.White;
                        longhr();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(@"
                                                         _...---.._
                                                     _.'`       -_  `.
                                                 .-'`                  \
                                              .-`                   -\  \
                                           _-`                       __  \
                                       .-'`                  . ' .   \ `;/
                                   _.-`                    /       `._`/
                           _...--'`                        \_
                        .'`                         -         `'--.._
                     . `                           \                  `-.
                    .                `              `-..__. ... - -.._`- 
                   '.                `  '_''---- -''`                 `-.`.
                 .` -                '`./
              .-` .` '             .`'.
          _.-` .-`   '            /
      _.-`  .-`       '         .`
(`''-'' _.-`          '        .'
 `'---''            .`       .`
                 .'     . '`
                .    .-`
              .`   ,`
             '   .'
           '   .`
          '  .`
          `  '.
          `.___;");
                        Console.ForegroundColor = ConsoleColor.White;
                        longhr();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(@"
          ,-.       _,---._ __  / \
         /  )    .-'       `./ /   \
        (  (   ,'            `/    /|
         \  `-""             \'\   / |
          `.              ,  \ \ /  |
           /`.          ,'-`----Y   |
          (            ;        |   '
          |  ,-.    ,-'         |  /
          |  | (   |            | /
          )  |  \  `.___________|/
          `--'   `--'");
                        Console.ForegroundColor = ConsoleColor.White;
                        longhr();
                        Console.WriteLine(@break() + "Giant cat inspects the inside of the box.");
                        hr();
                    }
                    else
                    {
                        Console.WriteLine(@break() + "You gave the wrong answer!\nStart again.");
                        continue;
                    }
                }
                #endregion

                #region Third Choose
                if (dead == false)
                {
                    Console.WriteLine(
                    "A)\t The giant cat's arse looks like it deserves a kick.\n" +
                    "B)\t Try to go out in quiet and calm steps.");
                    hr();
                    Console.Write(@break() +
                        $"{playerName}: ");
                    string secondChoose = Console.ReadLine();
                    hr();
                    if (secondChoose == "A" || secondChoose == "a")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(@"
         /\     /\
        {  `---'  }
        {  O   O  }
        ~~>  V  <~~
         \  \|/  /
          `-----'____
          /     \    \_
        {       }\  )_\_   _
        |  \_/  |/ /  \_\_/ )
          \__/  /(_/     \__/
          (__/");
                        longhr();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(@break() + "Really?");
                        Console.WriteLine(@break() + "The giant cat spotted you.");
                        longhr();
                        dead = Dead();
                        Console.WriteLine("Do you want try again? Y/N");
                        string again = Console.ReadLine();
                        if (again == "Y" || again == "y")
                        {
                            Console.WriteLine("Restarting...");
                        }
                        else
                        {
                            credits();
                            break;
                        }
                        
                    }
                    else if (secondChoose == "B" || secondChoose == "b")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(@"
    Y
  .-^-.
 /     \      .- ~ ~ -.
()     ()    /   _ _   `.                     _ _ _
 \_   _/    /  /     \   \                . ~  _ _  ~ .
   | |     /  /       \   \             .' .~       ~-. `.
   | |    /  /         )   )           /  /             `.`.
   \ \_ _/  /         /   /           /  /                `'
    \_ _ _.'         /   /           (  (
                    /   /             \  \
                   /   /               \  \
                  /   /                 )  )
                 (   (                 /  /
                  `.  `.             .'  /
                    `.   ~ - - - - ~   .'
                       ~ . _ _ _ _ . ~");
                        longhr();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(@break() + "You ran away like a snake without making a sound.");
                        longhr();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(@"
             .       .
             |\_---_/|
            /   o_o   \
            |    U    |
            \  ._I_.  /
             `-_____-'");
                        Console.ForegroundColor = ConsoleColor.White;
                        longhr();
                        Console.WriteLine(@break() + "Well done, you escaped from the cave.");
                        longhr();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(@"
            .               ,.
          T.""-._..---.._,-""/|
          l|""-.  _.v._   ("" |
          [l /.'_ \; _~""-.`-t
          Y "" _(o} _{o)._ ^.|
          j  T  ,--.  T  ]
          \  l ( /-^-\ ) !  !
           \. \.  ""~""  ./  /c-..,__
             ^r- .._ .- .-""  `- .  ~""--.
              > \.                      \
              ]   ^.                     \
              3  .  "">            .       Y  -Row
 ,.__.--._   _j   \ ~   .         ;       |
(    ~""-._~""^._\   ^.    ^._      I     . l
 ""-._ ___ ~""-,_7    .Z-._   7""   Y      ;  \        _
    /""   ""~-(r r  _/_--._~-/    /      /,.--^-._   / Y
    ""-._    '""~~~>-._~]>--^---./____,.^~        ^.^  !
        ~--._    '   Y---.                        \./
             ~~--._  l_   )                        \
                   ~-._~~~---._,____..---           \
                       ~----""~       \
                                      \");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(@break() + "Or were you kidnapped?");
                        longhr();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"
                   .'\   /`.
                 .'.-.`-'.-.`.
            ..._:   .-. .-.   :_...
          .'    '-.(o ) (o ).-'    `.
         :  _    _ _`~(_)~`_ _    _  :
        :  /:   ' .-=_   _=-. `   ;\  :
        :   :|-.._  '     `  _..-|:   :
         :   `:| |`:-:-.-:-:'| |:'   :
          `.   `.| | | | | | |.'   .'
            `.   `-:_| | |_:-'   .'
              `-._   ````    _.-'
                  ``-------''");
                        Console.ForegroundColor = ConsoleColor.White;
                        longhr();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@break() + "HE HE HE HE HE");
                        Console.ForegroundColor = ConsoleColor.White;
                        longhr();
                        longhr();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"
                     oOOO()
                     /  _)
                     |  (         \  \
                     \__)  ()OOOo  \  \____________________      
                            (_  \   \       HE HE HE HE HE |
                             )  |    \_____________________/
                     oOOO    (__/
                     /  _)
                     |  (
                     \__)  ()OOOo
                            (_  \
                             )  |
                     oOOO()  (__/
                     /  _)
                     |  (
                     \__)  ()OOOo
                            (_  \
                             )  |
                     oOOO()  (__/
                     /  _)
                     |  (
                     \__)  ()OOOo
                            (_  \
                             )  |
                             (__/");
                        Console.ForegroundColor = ConsoleColor.White;
                        longhr();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@break() + "HE HE HE HE HE");
                        Console.ForegroundColor = ConsoleColor.White;
                        longhr();
                        credits();
                    }
                    else
                    {
                        Console.WriteLine(@break() + "You gave the wrong answer!\nStart again.");
                        continue;
                    }
                }
                #endregion
            }
            
        }
        private static bool Dead()
        {
            bool dead;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
  -  -   -     -   -   --   -    -     - -   -  _  -    -  -      -  - -  -  -  -
  =-   - =- = - =  -  =- =   _.----~~~~~~-----..__ =   =-   -=-  - = =  -=--  = -
  =#-=  =-# - == ##= -__..------~~~~-     .._     ~~-. #== -#- = =-  ##=-= =#- -
#===#==___.--.--~~~~     --~~~~---~ __  ~~----.__   ~~~~~~~---...._____#== =##=
##(~~~~_..----~       ~~--=< O >- .----. -< O >=--~~             ..   .)#=#=##=
###~-..__..--         ..  ___-----_...__-----___        _.  ~-=___..-~#########
##==#===#==`   _    ..   (     "" :_.}{._; "" ""   )      _-     '==#=##=====#=#==
  =#-==-== =# \   ~~-      `   "" "" __###__  """"    '    -~     .'==-=#===#- -=- #=
  -= == -=  -= `-._  ~-.    _`--~~~VvvvvVV~~---'_     ~..    _. #= =  =  ==# - ==
  = -==  - = - == -.     `~##\(            )/###~' .     _.~    -=- = -= -=- -
  = -  -= -   - -    -    `.###\#    {     #/####.'    _-~  - =  - - -  -    = -
  -    -       -  -  -_    -####    !     #####-  ..    -    -       -   -   - -
                       -._  ~.###   }     ###-~ ___.-~
                          ~-  \##  / ""   ##.~ /~                      
                            \ |###  ""   ###' /   
                             \`/\#######/\' ;                               
                              ~-.^^^^^^^ .-~                                    
                                 ~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.White;
            longhr();
            Console.WriteLine(@break() + "The giant cat attacks you and rips you to shreds in seconds.");
            longhr();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
                .__---~~~(~~-_.
              _-'  ) -~~- ) _-"" )_
              (  ( `-,_..`.,_--_ '_,)_
            (  -_)  ( -_-~  -_ `,    )
            (_ -_ _-~-__-~`, ,' )__-'))--___--~~~--__--~~--___--__..
            _ ~`_-'( (____;--==,,_))))--___--~~~--__--~~--__----~~~'`=__-~+_-_.
            (@) (@) `````      `-_(())_-~  mn");
            Console.ForegroundColor = ConsoleColor.White;
            hr();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@break() + @break() + "Y O U   A R E   D E A D");
            dead = true;
            Console.ForegroundColor = ConsoleColor.White;
            longhr();
            
            return dead;
        }

        private static string @break()
        {
            return new string(' ', 15);
        }

        private static void hr()
        {
            Console.WriteLine(new string('-', 80));
            
        }

        private static void longhr()
        {
            Console.WriteLine(new string('-', 80));
           
        }

        private static void credits()
        {
            Console.WriteLine(@break() + @break() + "END");
            Console.WriteLine();
            Thread.Sleep(1500);
            Console.WriteLine(@break() + @break() + "Cast\n" +
                @break() + "Giant Cat\n" +
                @break() + "Player");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine(@break() + @break() + "Directed by\n" +
                @break() + "Hakan Hasircioglu");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine(@break() + @break() + "Produced by\n" +
                @break() + "Hakan Hasircioglu");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine(@break() + @break() + "Written by\n" +
                @break() + "Hakan Hasircioglu");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine(@break() + @break() + "Edited by\n" +
                @break() + "Hakan Hasircioglu");
            Console.WriteLine();
            Console.WriteLine(@break() + "Thanks for playing my game...");
            Console.WriteLine();
        }

    } 
}