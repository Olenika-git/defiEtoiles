using System;

namespace DefiEtoilesMagiques
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inGame = true;

            while (inGame)
            {
                int stars, ligne;
                string entry;
                string username = System.Environment.UserName;
                Console.WriteLine("Bienvenue dans notre système de simulation d'étoiles "+username+"\n\n\nQuel Simulation voulez vous lancer ?\n\n\n");
                Console.WriteLine("Choix n° 1 : La voie de l'Axe");
                Console.WriteLine("Choix n° 2 : La voie du Carré");
                Console.WriteLine("Choix n° 3 : La voie de l'Escalier");
                Console.WriteLine("Choix n° 4 : La voie de la Pyramide");
                Console.WriteLine("Choix n° 5 : La voie du Damier");
                Console.WriteLine("\n\n\nPour quitter veuillez saisir : quitter");
                Console.Write("\n\nVotre Choix : ");
                entry = Console.ReadLine();
                Console.Clear();

                switch (entry)
                {
                    case "1":
                        Console.WriteLine("Vous avez Choisit : La voie de l'Axe\n\n\n");
                        Console.Write("Veuillez saisir le nombre d'étoiles désiré : ");
                        entry = Console.ReadLine();
                        stars = int.Parse(entry);

                        while(stars < 1 || stars > 100)
                        {
                            Console.Write("Incorrect!\n\n\nVeuillez saisir un nombre d'étoiles entre 1 et 100 !");
                            entry = Console.ReadLine();
                            stars = int.Parse(entry);
                        }

                        for(int i = 0; i < stars; i++)
                        {
                            Console.WriteLine("*");
                        }

                        Console.WriteLine("\n\n\nGénération Terminé ...");
                        Console.Write("\n\n\nVoulez vous relancer une Simulation ?\n\n\noui ou non : ");
                        entry = Console.ReadLine();

                        if (entry == "oui" || entry == "Oui")
                        {
                            Console.WriteLine("\n\n\nGénération de la liste des Simulations ...\n\n\n");
                        }
                        else
                        {
                            Console.WriteLine("\n\n\nFermeture en Cours ...\n\nBonne Journée Mr - " + username);
                            inGame = false;
                            System.Environment.Exit(1);
                        }
                        break;

                    case "2":
                        Console.WriteLine("Vous avez Choisit : La voie du Carré");
                        Console.Write("Veuillez saisir le nombre d'étoiles désiré : ");
                        entry = Console.ReadLine();
                        stars = int.Parse(entry);
                        Console.Write("Veuillez saisir le nombre de Ligne désiré : ");
                        entry = Console.ReadLine();
                        ligne = int.Parse(entry);


                        while (stars < 1 || stars > 100)
                        {
                            Console.Write("\n\nIncorrect!\n\n\nVeuillez saisir un nombre d'étoiles entre 1 et 100 !");
                            entry = Console.ReadLine();
                            stars = int.Parse(entry);
                        }
                        while (ligne < 1 || ligne > 100)
                        {
                            Console.Write("\n\nIncorrect!\n\n\nVeuillez saisir un nombre de Ligne entre 1 et 100 !");
                            entry = Console.ReadLine();
                            ligne = int.Parse(entry);
                        }

                        for (int i = 0; i < ligne; i++)
                        {
                            Console.WriteLine();

                            for (int j = 0; j < stars; j++)
                            {
                                Console.Write("*");
                            }
                        }

                        Console.WriteLine("\n\n\nGénération Terminé ...");
                        Console.Write("\n\n\nVoulez vous relancer une Simulation ?\n\n\noui ou non : ");
                        entry = Console.ReadLine();

                        if (entry == "oui" || entry == "Oui")
                        {
                            Console.WriteLine("\n\n\nGénération de la liste des Simulations ...\n\n\n");
                        }
                        else
                        {
                            Console.WriteLine("\n\n\nFermeture en Cours ...\n\nBonne Journée !" + username);
                            inGame = false;
                            System.Environment.Exit(1);
                        }
                        break;

                    case "3":
                        Console.WriteLine("Vous avez Choisit : La voie de l'Escalier");
                        Console.Write("Veuillez saisir le nombre d'étoiles désiré : ");
                        entry = Console.ReadLine();
                        stars = int.Parse(entry);
                        Console.Write("Veuillez saisir le nombre de Ligne désiré : ");
                        entry = Console.ReadLine();
                        ligne = int.Parse(entry);

                        while (stars < 1 || stars > 100)
                        {
                            Console.Write("Incorrect!\n\n\nVeuillez saisir un nombre d'étoiles entre 1 et 100 !");
                            entry = Console.ReadLine();
                            stars = int.Parse(entry);
                        }

                        while (ligne < 1 || ligne > 100)
                        {
                            Console.Write("\n\nIncorrect!\n\n\nVeuillez saisir un nombre de Ligne entre 1 et 100 !");
                            entry = Console.ReadLine();
                            ligne = int.Parse(entry);
                        }

                        //Facon avec la condition la condition de la boucle
                        for (int i = 0; i < ligne; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }

                        //Facon avec la condition à l'intérieur de la boucle
                        //for (int i = 0; i < ligne; i++)
                        //{
                        //    Console.WriteLine();
                        //    for (int j = 0; j < stars; j++)
                        //    {
                        //        Console.Write("*");
                        //        if (i == j)
                        //        {
                        //            break;
                        //        }
                        //    }
                        //}

                        Console.WriteLine("\n\n\nGénération Terminé ...");
                        Console.Write("\n\n\nVoulez vous relancer une Simulation ?\n\n\noui ou non : ");
                        entry = Console.ReadLine();

                        if (entry == "oui" || entry == "Oui")
                        {
                            Console.WriteLine("\n\n\nGénération de la liste des Simulations ...\n\n\n");
                        }
                        else
                        {
                            Console.WriteLine("\n\n\nFermeture en Cours ...\n\nBonne Journée !" + username);
                            inGame = false;
                            System.Environment.Exit(1);
                        }
                        break;

                    case "4":
                        Console.WriteLine("Vous avez Choisit : La voie de la Pyramide");
                        Console.Write("Veuillez saisir le nombre d'étoiles désiré : ");
                        entry = Console.ReadLine();
                        stars = int.Parse(entry);
                        Console.Write("Veuillez saisir le nombre de Ligne désiré : ");
                        entry = Console.ReadLine();
                        ligne = int.Parse(entry);

                        while (stars < 1 || stars > 100)
                        {
                            Console.Write("Incorrect!\n\n\nVeuillez saisir un nombre d'étoiles entre 1 et 100 !");
                            entry = Console.ReadLine();
                            stars = int.Parse(entry);
                        }

                        while (ligne < 1 || ligne > 100)
                        {
                            Console.Write("\n\nIncorrect!\n\n\nVeuillez saisir un nombre de Ligne entre 1 et 100 !");
                            entry = Console.ReadLine();
                            ligne = int.Parse(entry);
                        }

                        for (int i = 0; i < ligne; i++)
                        {
                            //nbLigne - ligne actuel Affichage espace on enlève 1 chaque itération
                            for (int j = 0; j < ligne -i; j++)
                            {
                                Console.Write(" ");
                            }

                            for (int j = 0; j <= i; j++)
                            {
                                Console.Write("**");
                            }

                            Console.WriteLine();
                        }

                        Console.WriteLine("\n\n\nGénération Terminé ...");
                        Console.Write("\n\n\nVoulez vous relancer une Simulation ?\n\n\noui ou non : ");
                        entry = Console.ReadLine();

                        if (entry == "oui" || entry == "Oui")
                        {
                            Console.WriteLine("\n\n\nGénération de la liste des Simulations ...\n\n\n");
                        }
                        else
                        {
                            Console.WriteLine("\n\n\nFermeture en Cours ...\n\nBonne Journée !" + username);
                            inGame = false;
                            System.Environment.Exit(1);
                        }
                        break;

                    case "5":
                        Console.WriteLine("Vous avez Choisit : La voie du Damier");
                        Console.Write("Veuillez saisir le nombre d'étoiles désiré : ");
                        entry = Console.ReadLine();
                        stars = int.Parse(entry);
                        Console.Write("Veuillez saisir le nombre de Ligne désiré : ");
                        entry = Console.ReadLine();
                        ligne = int.Parse(entry);

                        while (stars < 1 || stars > 100)
                        {
                            Console.Write("Incorrect!\n\n\nVeuillez saisir un nombre d'étoiles entre 1 et 100 !");
                            entry = Console.ReadLine();
                            stars = int.Parse(entry);
                        }

                        while (ligne < 1 || ligne > 100)
                        {
                            Console.Write("\n\nIncorrect!\n\n\nVeuillez saisir un nombre de Ligne entre 1 et 100 !");
                            entry = Console.ReadLine();
                            ligne = int.Parse(entry);
                        }



                        //Avec modulo
                        //for (int i = 0; i < ligne; i++)
                        //{
                        //    Console.WriteLine();
                        //    for (int j = 0; j < stars; j++)
                        //    {
                        //        if(i%2 == 0)
                        //        {
                        //            Console.Write("*");
                        //            Console.Write(" ");
                        //        }
                        //        else
                        //        {
                        //            Console.Write(" ");
                        //            Console.Write("*");
                        //        }
                        //    }
                        //}

                        Console.WriteLine("\n\n\nGénération Terminé ...");
                        Console.Write("\n\n\nVoulez vous relancer une Simulation ?\n\n\noui ou non : ");
                        entry = Console.ReadLine();

                        if (entry == "oui" || entry == "Oui")
                        {
                            Console.WriteLine("\n\n\nGénération de la liste des Simulations ...\n\n\n");
                        }
                        else
                        {
                            Console.WriteLine("\n\n\nFermeture en Cours ...\n\nBonne Journée Mr - " + username);
                            inGame = false;
                            System.Environment.Exit(1);
                        }
                        break;

                    case "quitter":
                        Console.WriteLine("\n\n\nFermeture en Cours ... \n\n Bonne Journée Mr - " + username);
                        inGame = false;
                        System.Environment.Exit(1);
                        break;
                }
            }
        }
    }
}
