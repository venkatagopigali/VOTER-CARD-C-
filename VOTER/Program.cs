namespace Gali
{
    class Gopi
    {
        static void Main(string[] args)
        {
            int s, age, s1, c = 0, r = 0, v = 0, s2,s3;
            string name, fname, mname, add, email, vno, ph, login, pass,login1,pass1;
            Console.WriteLine("       VOTER REGISTRATION        ");
            Console.WriteLine();
            Console.WriteLine("       WELCOME VOTER PORTRAl      ");
            Console.WriteLine();
            Console.WriteLine("if you new register");
            Console.WriteLine("1.Yes\n2.No");
            s = Convert.ToInt32(Console.ReadLine());
            if (s == 1)
            {
                Console.WriteLine("   WELCOME TO REGISTRATION     ");
                Console.WriteLine();
                Console.Write("NAME        :");
                name = Console.ReadLine();
                Console.WriteLine();
                Console.Write("FATHER NAME :");
                fname = Console.ReadLine();
                Console.WriteLine();
                Console.Write("MOTHER NAME :");
                mname = Console.ReadLine();
                Console.WriteLine();
                Console.Write("AGE         :");
                age = Convert.ToInt32(Console.ReadLine());
                if (age >= 18)
                {
                    Console.WriteLine("You are eligible for application");
                }
                else
                {
                    Console.WriteLine("NOT ELIGIBLE FOR VOTE");
                    
                }
                Console.WriteLine();
                Console.Write("PHONE NUMBER:");
                ph = Console.ReadLine();
                Console.WriteLine();
                Console.Write("ADDRESS     :");
                add = Console.ReadLine();
                Console.WriteLine();
                Console.Write("E-Mail      :");
                email = Console.ReadLine();
                Console.WriteLine();
                Console.Write("VOTE NUMBER :");
                vno = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("You want to login:");
                Console.WriteLine("1.Yes\n2.No");
                s1 = Convert.ToInt32(Console.ReadLine());
                if (s1 == 1)
                {
                    Console.Write("User id    :");
                    login1 = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("password   :");
                    pass1 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("         LOGIN SUCCESSFULLY      ");
                    if (login1==vno && pass1=="GOPI")
                    {
                        Console.WriteLine("NAME        :"+name);
                        Console.WriteLine();
                        Console.WriteLine("FATHER NAME :"+fname);
                        Console.WriteLine();
                        Console.WriteLine("MOTHER NAME :"+mname);
                        Console.WriteLine();
                        Console.WriteLine("AGE         :"+age);
                        Console.WriteLine();
                        Console.WriteLine("Ph.no       :"+ph);
                        Console.WriteLine();
                        Console.WriteLine("E-Mail      :"+email);
                        Console.WriteLine();
                        Console.WriteLine("ADDRESS     :"+add);
                        Console.WriteLine();
                        Console.WriteLine("            YOUR DETAILS ARE VERIFIED        ");
                        Console.WriteLine();
                        Console.WriteLine("            choose one of section            ");
                        Console.WriteLine("1.CIET\n2.RVRJC\n3.VVIT");
                        s3 = Convert.ToInt32(Console.ReadLine());
                        if (s3==1)
                        {
                            c = c + 1;
                            Console.WriteLine("            YOU VOTED TO CIET             ");
                        }
                        else if(s3==2)
                        {
                            r = r + 1;
                            Console.WriteLine("            YOU VOTED TO RVRJC             ");
                        }
                        else if(s3==3)
                        {
                            v = v + 1;
                            Console.WriteLine("            YOU VOTED TO VVIT             ");
                        }
                        else
                        {
                            Console.WriteLine("Enter valid option");
                        }
                        Console.WriteLine("              THANKYOU FOR YOUR VOTE         ");

                    }

                }
                else if (s1 == 2)
                {
                    Console.WriteLine("            THANKYOU FOR REGISTER         ");
                }
                    

            }
            else if(s==2)
            {
                Console.Write("User id    :");
                login = Console.ReadLine();
                Console.WriteLine();
                Console.Write("password   :");
                pass = Console.ReadLine();
                Console.WriteLine();
                if (login == "GOPI" && pass == "GOPI")
                {
                    Console.WriteLine("NAME        :GALI VENKATA GOPI");
                    Console.WriteLine();
                    Console.WriteLine("FATHER NAME :GALI VENKATESWRALU");
                    Console.WriteLine();
                    Console.WriteLine("MOTHER NAME :GALI VENKATA RAJYAM");
                    Console.WriteLine();
                    Console.WriteLine("AGE         :18");
                    Console.WriteLine();
                    Console.WriteLine("Ph.no       :7989086886");
                    Console.WriteLine();
                    Console.WriteLine("E-Mail      :venkatagopigali6@gmail.com");
                    Console.WriteLine();
                    Console.WriteLine("ADDRESS     :NAMASSIVAYAPURAM");
                    Console.WriteLine();
                    Console.WriteLine("            YOUR DETAILS ARE VERIFIED        ");
                    Console.WriteLine();
                    Console.WriteLine("            choose one of section            ");
                    Console.WriteLine("1.CIET\n2.RVRJC\n3.VVIT");
                    s2 = Convert.ToInt32(Console.ReadLine());
                    if (s2 == 1)
                    {
                        c = c + 1;
                        Console.WriteLine("            YOU VOTED TO CIET             ");
                    }
                    else if (s2 == 2)
                    {
                        r = r + 1;
                        Console.WriteLine("            YOU VOTED TO RVRJC            ");
                    }
                    else if (s2 == 3)
                    {
                        v = v + 1;
                        Console.WriteLine("            YOU VOTED TO VVIT              ");
                    }
                    else
                    {
                        Console.WriteLine("Enter valid option");
                    }
                    Console.WriteLine("                 THANKS FOR VOTE                ");


                }
                else
                {
                    Console.WriteLine("           USER NOT FOUND           ");
                }

            }
            else
            {
                Console.WriteLine("Enter valid option:");
            }
        }

        }
    }