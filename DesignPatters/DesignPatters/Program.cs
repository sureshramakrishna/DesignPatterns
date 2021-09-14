using System;
using DesignPatters.CreationalDesignPatterns;
using DesignPatters.CreationalDesignPatterns.AbstractFactory;
using DesignPatters.CreationalDesignPatterns.Builder;
using DesignPatters.CreationalDesignPatterns.FactoryMethod;
using DesignPatters.CreationalDesignPatterns.FluentInterface;
using DesignPatters.CreationalDesignPatterns.ProtoType;
using DesignPatters.Models;
using CreditCardFactory = DesignPatters.CreationalDesignPatterns.Factory.CreditCardFactory;

namespace DesignPatters
{
    public class Program
    {
        public static void Main()
        {
            //Factory Design Pattern
            ICard card = CreditCardFactory.GetCreditCard("Platinum");

            //Factory Method Design Pattern
            AbstractCreditCardFactory creditCardFactory = new DiamondFactory();
            card = creditCardFactory.GetCreditCard();

            //Abstract Factory Design Pattern
            AbstractCardFactory baseFactory = AbstractCardFactory.CreateCardFactory("Debit");
            card = baseFactory.GetCard("Gold");

            //Builder Design Pattern
            ReportDirector reportDirector = new ReportDirector();
            PdfReport pdfReport = new PdfReport();
            Report report = reportDirector.MakeReport(pdfReport);
            report.DisplayReport();

            //Fluent Interface Design Pattern
            FluentEmployee obj = new FluentEmployee();
            obj.NameOfTheEmployee("Suresh R")
                .Born("3/5/1994")
                .WorkingOn("IT")
                .StaysAt("Bengaluru-India");

            //Prototype Design Pattern
            Student emp = new Student {Department = "CSE", Name = "Suresh"};
            Student emp2 = emp.Clone();

            Console.ReadKey();
        }
    }
}