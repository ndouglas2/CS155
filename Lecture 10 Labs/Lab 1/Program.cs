using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            
            Email email1 = new Email();
            Email email2 = new Email();

            email1.Sender = "Nate Douglas";
            email1.Recipient = "Mark Aloka";
            email1.Title = "CS 155 Homework";
            email1.Text = "I Hope this email finds you well professor. Please find attached my homework for the week: ";
            Console.WriteLine("Email 1: ");
            email1.toString();

            bool keyword = false;
            keyword = document.ContainsKeyword(email1, "homework");
            Console.WriteLine("Passing keyword homework through ContainsKeyword: " + keyword);

            Console.WriteLine();
            File file1 = new File();
            Console.WriteLine("File 1: ");
            file1.Path = "Users/Nate Douglas/Homework/Homework 10";
            file1.Text = "Coding samples in c#";
            file1.toString();

            keyword = document.ContainsKeyword(file1, "Users");
            Console.WriteLine("Passing keyword Users through ContainsKeyword: " + keyword);

            email2.Sender = "Mark Aloka";
            email2.Recipient = "Nate Douglas";
            email2.Title = "Re: CS 155 Homework";
            email2.Text = "Great work this week Nate!";

            Console.WriteLine();
            Console.WriteLine("Email 2: ");
            email2.toString();

            keyword = document.ContainsKeyword(email2, "bad");
            Console.WriteLine("Passing keyword bad through ContainsKeyword: " + keyword);

            Console.WriteLine();
            File file2 = new File();
            Console.WriteLine("File 2: ");
            file2.Path = "Users/Nate Douglas/Sample";
            file2.Text = "More Sample exercises";
            file2.toString();

            keyword = document.ContainsKeyword(file2, "Douglas");
            Console.WriteLine("Passing keyword Douglas through ContainsKeyword: " + keyword);
        }
    }
}
