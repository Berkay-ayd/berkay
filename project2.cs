using System;
using System.IO;

namespace cme_project2
{
    class Program
    {
       
      
        static void Main(string[] args)
        {

            /*Read */

            string[] DNA = new string[100];
            string textFile = @"D:\DNA.txt";
            DNA = File.ReadAllLines(textFile);
            produce_complemtDNA(DNA);
            for(int i = 0;i < DNA.Length - 1; i++)
            {
                var start = DNA[i].Split(null)[100];
                Console.WriteLine(start);
            }
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        
        static void generete_DNA_squence()
        {

        }
        
       
        

        static void check_gender(string DNA)
        {

        }
        /*is not working*/
        static void check_DNA(string[] DNA)
        {
            int count_nucliod = 0;

            for (int i = 0; i < DNA.Length; i++)
            {
                char[] chek_fisrt = new char[3];
                char[] chek_last = new char[3];
                for(int a = 0; a < 3; i++)
                {
                    chek_fisrt[a] = DNA[i][a];
                }
            }

            if(count_nucliod % 3 != 0)
            {
                Console.WriteLine("DNA standart" + DNA);
                Console.WriteLine("Codon Strucntures error");
            }
            Console.WriteLine(count_nucliod);
        }


        /*
        @Discription = This fucntion take complemet of the DNA strand
        @Retun[] = NONE
         */
        static void produce_complemtDNA(string[] DNA)
        {
            string DNA_part = " ";

            string[] Complemet_of_DNA = new string[DNA.Length];
            

            for(int i = 0;i < DNA.Length; i++)
            {
                DNA_part = DNA[i];
                Console.WriteLine("DNA strans = " + DNA_part);

                char[] DNA_comlemt_part = new char[DNA_part.Length];

                for (int a = 0; a < DNA_part.Length; a++)
                {
                   
                    if (DNA_part[a] == 'A') DNA_comlemt_part[a] ='T';
                    else if (DNA_part[a] == 'T') DNA_comlemt_part[a] = 'A';
                    else if (DNA_part[a] == 'G') DNA_comlemt_part[a] = 'C';
                    else if (DNA_part[a] == 'C') DNA_comlemt_part[a] = 'G';
                   
                }
                Complemet_of_DNA[i] = Convert.ToString(DNA_comlemt_part);
                Console.Write("Complement = ");
                Console.WriteLine(DNA_comlemt_part);
            }
          
        }

        static void Comploemt_DNA(string DNA)
        {
            char[] complement_DNA= new char[DNA.Length + 1];

            for (int i = 0; i < DNA.Length; i++)
            {
                if (DNA[i] == 'A') complement_DNA[i] = 'T';

                else if (DNA[i] == 'T') complement_DNA[i] = 'A';


                else if (DNA[i] == 'G') complement_DNA[i] = 'C';

                else if (DNA[i] == 'C') complement_DNA[i] = 'G';
            }
            Console.WriteLine("DNA strand = " + DNA);
            Console.Write("Complement = ");
            Console.Write(complement_DNA);
        }
        static void Determine_aminoacid(string[] DNA)
        {

        }
        static void shortest_gene()
        {

        }

        /*OPERATİON 5*/
        static bool DNA_BLOB(string[] DNA)
        {
            for(int i = 0;i < DNA.Length; i++)
            {

            }
            return true;
        }

        static int Hydrogen_Two_Bounds(string DNA)
        {
            int Hydron_two_bounds = 0;
            for(int i = 0;i < DNA.Length; i++)
            {
                if (DNA[i] == 'A' || DNA[i] == 'T') Hydron_two_bounds++;
            }
            return Hydron_two_bounds;
        }
        static int Hydrogen_Three_Bounds(string DNA)
        {
            int Hydron_three_bounds = 0;
            for (int i = 0; i < DNA.Length; i++)
            {
                if (DNA[i] == 'G' || DNA[i] == 'C') Hydron_three_bounds++;
            }
            return Hydron_three_bounds;
        }
    }
}
