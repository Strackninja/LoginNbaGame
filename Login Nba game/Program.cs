using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Login_Nba_game
{
    class Program
    {
        static void Main(string[] args)
        {

            //choice används för loopen för att skapa username och password
            string choice = "no";
            //var är en datatyp som definerar saker åt dig, gör koden finare. 
            var username = new Login();
            var password = new Login();
            while (choice == "no")
            {
                Console.WriteLine("Please enter a username");
                //lägger till det användaren skriver in i username listan
                username.Username.Add(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Please enter a password");
                //lägger till det användaren skriver in i username listan
                password.Password.Add(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Are you sure?");
                choice = YesNo();
                //ifall användaren väljer no kommer listorna rensas
                if (choice == "no")
                {
                    username.Username.Clear();
                    password.Password.Clear();
                }
                Console.Clear();
            }
            Console.WriteLine("Username:");
            //skriver ut allt som finns i username listan, i detta fall det användaren skrev in 
            username.Username.ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Password:");
            //skriver ut allt som finns i password listan, i detta fall det användaren skrev in 
            password.Password.ForEach(Console.WriteLine);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please enter your username");
            //userlogin blir det användaren skriver in, ifall det inte stämmer överens med vad som finns i listan kommer användaren tvingas skriva om 
            username.userlogin = Console.ReadLine();
            while (username.Username.Contains(username.userlogin) == false)
            {
                Console.WriteLine("Wrong Username");
                username.userlogin = Console.ReadLine();
                Console.Clear();
            }
            Console.Clear();
            //passlogin blir det användaren skriver in, ifall det inte stämmer överens med vad som finns i listan kommer användaren tvingas skriva om 
            Console.WriteLine("Please enter your password");
            password.passlogin = Console.ReadLine();
            while (password.Password.Contains(password.passlogin) == false)
            {
                Console.WriteLine("Wrong Password");
                password.passlogin = Console.ReadLine();
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("Do you want to start the game?");
            //använder sig av metoden YesNo vilket tvingar användaren att bara skriva in yes eller no
            //ifall spelaren väljer no kommer spelet stängas av
            string playgame = YesNo();

            while (playgame == "yes")
            {
                Console.Clear();
                //Spelarens spelare
                Player pg = new Player();
                Player sg = new Player();
                Player sf = new Player();
                //Datorns spelare
                Player cpg = new Player();
                Player csg = new Player();
                Player csf = new Player();

                Console.WriteLine("MAKE YOUR OWN 3");
                //Sätter en delay på texten
                Thread.Sleep(600);
                //rensar konsolen när spelaren klicka rpå en knapp
                AnyKey();
                Console.Clear();
                Console.WriteLine("You are creating your own squad made up of three teammates");
                Thread.Sleep(600);
                Console.WriteLine("The team is going to consist of a PointGuard, a ShootingGuard and a SmallForward");
                Thread.Sleep(600);
                Console.WriteLine("You are to choose between three players in every role and create your squad");
                Thread.Sleep(600);
                AnyKey();
                Console.WriteLine("The first thing you are going to do is choose a PointGuard");
                Thread.Sleep(600);
                Console.WriteLine("The PointGuards you can choose from are");
                Console.WriteLine();
                Thread.Sleep(600);
                Console.WriteLine("Kyrie Erving");
                Thread.Sleep(600);
                Console.WriteLine("Russel Westbrook");
                Thread.Sleep(600);
                Console.WriteLine("Damian Lillard");
                Console.WriteLine();
                Thread.Sleep(600);
                Console.WriteLine("Now its time for you to choose a player");
                Console.WriteLine("Please enter a number between 1-3 to choose a player!");
                //Answers ser till att spelaren bara kan välja siffror och bara välja mellan 1-3. 
                int pointanswer = Answers();

                //Det första valet spelaren gör, spelaren väljer 1 pointguard utav 3 genom att skriva en siffra mellan 1-3
                if (pointanswer == 1)
                {
                    pg = new Kyrie();
                }
                else if (pointanswer == 2)

                {
                    pg = new Russel();
                }
                else if (pointanswer == 3)
                {
                    pg = new Damian();
                }
                Console.Clear();
                Console.WriteLine("Great job!");
                Thread.Sleep(600);
                Console.WriteLine("These are your players stats: ");
                Thread.Sleep(600);
                //Kallar på metoden i Player som printar ut statsen för spelaren
                pg.Getstats();
                AnyKey();
                Console.WriteLine("It is time to choose a ShootinGguard");
                Thread.Sleep(600);
                Console.WriteLine("The ShootingGuards you can choose from are");
                Console.WriteLine();
                Thread.Sleep(600);
                Console.WriteLine("James Harden");
                Thread.Sleep(600);
                Console.WriteLine("Donovan Mitchell");
                Thread.Sleep(600);
                Console.WriteLine("Devin Booker");
                Console.WriteLine();
                Thread.Sleep(600);
                Console.WriteLine("Now its time for you to choose a player");
                Thread.Sleep(600);
                Console.WriteLine("Please enter a number between 1-3 to choose a player!");
                int shootinganswer = Answers();
                //Samma sak som för pointguard men för shootingguard
                if (shootinganswer == 1)
                {
                    sg = new James();
                }
                else if (shootinganswer == 2)
                {
                    sg = new Donovan();
                }
                else if (shootinganswer == 3)
                {
                    sg = new Devin();
                }
                Console.Clear();
                Console.WriteLine("Great job!");
                Thread.Sleep(600);
                Console.WriteLine("These are your players stats: ");
                Thread.Sleep(600);
                sg.Getstats();
                AnyKey();
                Console.Clear();
                Console.WriteLine("And finally, time to choose a SmallForward");
                Thread.Sleep(600);
                Console.WriteLine("The SmallForwards you can choose from are");
                Console.WriteLine();
                Thread.Sleep(600);
                Console.WriteLine("Lebron James");
                Thread.Sleep(600);
                Console.WriteLine("Kawhi Leonard");
                Thread.Sleep(600);
                Console.WriteLine("Luka Doncic");
                Console.WriteLine();
                Thread.Sleep(600);
                Console.WriteLine("Now its time for you to choose a player");
                Thread.Sleep(600);
                Console.WriteLine("Please enter a number between 1-3 to choose a player!");
                int smallanswer = Answers();
                //samma sak som för pointguard men för SmallForward
                if (smallanswer == 1)
                {
                    sf = new Lebron();
                }
                else if (smallanswer == 2)
                {
                    sf = new Kawhi();
                }
                else if (smallanswer == 3)
                {
                    sf = new Luka();
                }
                Console.Clear();
                Console.WriteLine("Great job!");
                Thread.Sleep(600);
                Console.WriteLine("These are your players stats: ");
                Thread.Sleep(600);
                sf.Getstats();
                AnyKey();
                Console.WriteLine("This is your final team:");
                Thread.Sleep(600);
                Console.WriteLine(pg.name);//Printar ut pointguardens namn
                Thread.Sleep(600);
                Console.WriteLine(sg.name);//Printar ut shootingguardens namn
                Thread.Sleep(600);
                Console.WriteLine(sf.name);//Printar ut smallforwardens namn
                AnyKey();
                Thread.Sleep(600);
                Console.WriteLine("Now the computer will assemble its own team");

                //En random gen som får fram en siffra mellan 1-3 för att välja spelare
                var randomGen = new Random();
                var randomPlayer = randomGen.Next(1, 3);
                //Datorns pointgguard
                if (randomPlayer == 1)
                {
                    cpg = new Kyrie();
                }
                else if (randomPlayer == 2)

                {
                    cpg = new Russel();
                }
                else if (randomPlayer == 3)
                {
                    cpg = new Damian();
                }

                //Datorns shootingguard
                if (randomPlayer == 1)
                {
                    csg = new James();
                }
                else if (randomPlayer == 2)
                {
                    csg = new Donovan();
                }
                else if (randomPlayer == 3)
                {
                    csg = new Devin();
                }
                //Datorns smallforward
                if (randomPlayer == 1)
                {
                    csf = new Lebron();
                }
                else if (randomPlayer == 2)
                {
                    csf = new Kawhi();
                }
                else if (randomPlayer == 3)
                {
                    csf = new Luka();
                }
                Console.Clear();
                Thread.Sleep(600);
                Console.WriteLine("This is the computers team:");
                Console.WriteLine();
                Thread.Sleep(600);
                Console.WriteLine(cpg.name);//Printar ut dator pointguardens namn
                Thread.Sleep(600);
                Console.WriteLine(csg.name);//Printar ut dator shootingguardens namn 
                Thread.Sleep(600);
                Console.WriteLine(csf.name);//Printar ut dator smallforwardens namn
                Thread.Sleep(600);
                AnyKey();
                Thread.Sleep(600);
                Console.WriteLine("Now its time for the teams to play and crown the winner!");
                //kallar på metoden för att lägga ihop ditt lags stats och delar det på 3 för att få en avarage
                int playerTeam = (pg.AddStats() + sg.AddStats() + sf.AddStats()) /3;
                //kallar på metoden för att lägga ihop datorns lags stats och delar det på 3 för att få en avarage
                int computerTeam = (cpg.AddStats() + csg.AddStats() + csf.AddStats()) / 3;

                //ifall ditt lag har mer stats vinner du
                if( playerTeam > computerTeam)
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations!!");
                    Console.WriteLine();
                }
                //blir det lika många stats blir det lika
                else if (playerTeam == computerTeam)
                {
                    Console.WriteLine();
                    Console.WriteLine("A TIE!");
                    Console.WriteLine();
                }
                //annars förlorar du
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You lost...");
                    Console.WriteLine();
                }

                Thread.Sleep(600);
                Console.WriteLine("Do you want to play again?");
                //Kollar om du vill spela igen eller inte
                playgame = YesNo();
            }
        }


        static string YesNo()//Metod för att få användaren att bara kunna skriva in svaret yes eller now
        {
            string yesno = Console.ReadLine().ToLower();//får texten till lower case

            while ((yesno != "no") && (yesno != "yes"))//ifall svaret inte är yes eller no tvingas användaren skriva om
            {
                Console.WriteLine("Please write only Yes or No.");

                yesno = Console.ReadLine().ToLower();
            }

            return (yesno);
        }
        static void AnyKey()
        {
            Console.WriteLine("-->Press Any Key to Continue<--");
            Console.ReadKey();
            Console.Clear();
        }
        // En metod som kontrollerar ifall spelaren väljer en siffra mellan 1-3
        // Ifall spelaren väljer en siffra som inte är mellan 1-3 kommer spelet att fråga om ett svar igen
        static int Answers()
        {
            int playerchoice = 0;//Det värde som kommer att användas i val av spelare
            string playeranswer = Console.ReadLine();//Spelarens input
            int.TryParse(playeranswer, out playerchoice);//Konverterar spelarens string input till en int
            bool correct = int.TryParse(playeranswer, out playerchoice);//Ser till att konverteringen blev korrekt

            while (correct == false || playerchoice != 1 && playerchoice != 2 && playerchoice != 3)
            {
                Console.WriteLine("Please enter a number between 1-3");

                playerchoice = 0;
                playeranswer = Console.ReadLine();
                correct = int.TryParse(playeranswer, out playerchoice);
            }

            if (playerchoice == 1)//Ifall spelaren klickar 1 kommer spelet returnera värdet 1 och välja den första spelaren
            {
                return 1;
            }
            else if (playerchoice == 2)// Samma sak fast för 2
            {
                return 2;
            }
            else if (playerchoice == 3)//Samma sak fast för 3
            {
                return 3;
            }

            return 0;

        }
    }
}
