using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;



namespace C__Basics_Session05
{
    public enum Gender
    {
        Male = 1,
        Female = 2
    }
    public enum MembershipType
    {
        Standart = 1,
        Premium = 2,
    }
    internal class Membership
    {
        public int id;
        public string name;
        public int age;
        public int price;
        public Gender gender;
        public MembershipType membership;
        public void EnterInfo()
        {
            do
            {
                Console.WriteLine("Enter Id: ");

            } while (!int.TryParse(Console.ReadLine(), out id));
            Console.WriteLine("---------------------------------");
            do
            {
                Console.WriteLine("Enter Your Name: ");
                name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(name));
            Console.WriteLine("---------------------------------");
            do
            {
                Console.WriteLine("Enter Your Age: ");

            } while (!int.TryParse(Console.ReadLine(), out age));
            Console.WriteLine("---------------------------------");
            int genderInput;
            bool isValidGender;
            do
            {
                Console.WriteLine("Choose Gender:");
                Console.WriteLine("1. Male");
                Console.WriteLine("2. Female");
                Console.Write("Choice: ");

                isValidGender = int.TryParse(Console.ReadLine(), out genderInput)
                                && Enum.IsDefined(typeof(Gender), genderInput);

            } while (!isValidGender);
            gender = (Gender)genderInput;
            Console.WriteLine("---------------------------------");

            int Memberinput;
            bool isValidmemberinput;
            do
            {
                Console.WriteLine("Choose Membership Type:");
                Console.WriteLine("1. Standard");
                Console.WriteLine("2. Premium");
                Console.Write("Choice: ");

                isValidmemberinput = int.TryParse(Console.ReadLine(), out Memberinput)
                                && Enum.IsDefined(typeof(MembershipType), Memberinput);

            } while (!isValidmemberinput);
            membership = (MembershipType)Memberinput;
            Console.WriteLine("---------------------------------");
            if (membership == MembershipType.Standart)
                price = 500;
            else price = 1000;
        }
        public void Print()
        {
            Console.WriteLine("====== Member Data ======");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender.ToString().ToLower()}");
            Console.WriteLine($"Membership: {membership.ToString().ToLower()}");
            Console.WriteLine($"Membership Price: {price}");
        }
    }
}
