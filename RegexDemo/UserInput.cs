using System.Text.RegularExpressions;

namespace RegexDemo;

internal class UserInput
{
    public void UserInputs()
    {
        /*FirstName*/
        Console.WriteLine("Enter First Name");
        string FirstName = Console.ReadLine();
        string name = @"^[A-Z]{1}[a-z]{2,}$";
        Regex rg = new Regex(name);

        if (rg.IsMatch(FirstName))
        {
            Console.WriteLine("First Name : " + FirstName);
        }
        else
        {
            Console.WriteLine("invalid First Name");
        }

        /*LastName*/
        Console.WriteLine("Enter the Last Name : ");
        string LastName = Console.ReadLine();
        if (rg.IsMatch(LastName))
        {
            Console.WriteLine("Last Name : " + LastName);
        }
        else
        {
            Console.WriteLine("invalid Last Name");
        }


        /*emailid*/
        Console.WriteLine("Enter Email");
        string email = @"^\w[a-z]{2,}\.\w[a-z]{2,}@[a-z]{1,}\.[a-z]{2}\.[a-z]{2}$";
        Regex re = new Regex(email);
        string emailid = Console.ReadLine();
        if (re.IsMatch(emailid))
        {
            Console.WriteLine("Email ID : " + emailid);
        }
        else
        {
            Console.WriteLine("Invalied email");
        }


        /*PhoneNumber*/
        Console.WriteLine("Enter The Phone number : ");
        string phone = @"\d{2}\s\d{10}$";
        string PhoneNumber = Console.ReadLine();
        Regex rp = new Regex(phone);
        if (rp.IsMatch(PhoneNumber))
        {
            Console.WriteLine("Phone Number : " + PhoneNumber);
        }
        else
        {
            Console.WriteLine("Invalid Phone Number");
        }


        /*password*/
        Console.WriteLine("Enter the Password : ");
        string PassWord1 = @".{8,}$";
        string PassWord2 = @"(?=.*[A-Z]).{8,}$";
        string PassWord3 = @"(?=.*[A-Z])(?=.*[0-9])$";
        string PassWord4 = @"(?=.*[A-Z])(?=.*[0-9])(?=.*[\W_]).{8,}$";

        Regex rpass = new Regex(PassWord4);
        string passwordid = Console.ReadLine();
        if (rpass.IsMatch(passwordid)) { Console.WriteLine("Password : " + passwordid); }
        else { Console.WriteLine("invalid Password"); }

    }
}
