using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{

    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }

        public Person(string name, string email, DateTime birthDay)
        {
            Name = name;
            Email = email;
            BirthDay = birthDay;
        }   
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person("Julio", "blabla1@gmail.com", DateTime.ParseExact("19/10/1996", "dd/MM/yyyy", null)));
            persons.Add(new Person("Jorge", "blabla2@gmail.com", DateTime.ParseExact("20/11/1997", "dd/MM/yyyy", null)));
            persons.Add(new Person("Martin", "blabla3@gmail.com", DateTime.ParseExact("21/11/1998", "dd/MM/yyyy", null)));
            persons.Add(new Person("Carlos", "blabla4@gmail.com", DateTime.ParseExact("22/11/1999", "dd/MM/yyyy", null)));
            persons.Add(new Person("Luis", "blabla5@gmail.com", DateTime.ParseExact("23/11/1995", "dd/MM/yyyy", null)));
            persons.Add(new Person("Mario", "blabla6@gmail.com", DateTime.ParseExact("24/11/1994", "dd/MM/yyyy", null)));

            List<string> emails = persons.Select(person => person.Email).ToList();
            devolverEmails(persons).ForEach((email) => Console.WriteLine(email));
            devolverPrimerCumpleAnios(persons, DateTime.ParseExact("19/10/1996", "dd/MM/yyyy", null));
        }
        static List<string> devolverEmails(List<Person> personas)
        {
            return personas.Select(person => person.Email).ToList();
        }
        static DateTime devolverPrimerCumpleAnios(List<Person> personas, DateTime? fecha)
        {
            if (fecha == null) return personas[0].BirthDay;
            else
            {
                var fechaEncontrada = personas.Select(p => p.BirthDay).Where(b => b > fecha).FirstOrDefault();
                return fechaEncontrada;
            }
        }
    }
}
