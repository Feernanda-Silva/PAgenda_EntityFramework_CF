using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAgenda_EntityFramework_CF.Context;
using PAgenda_EntityFramework_CF.Models;

namespace PAgenda_EntityFramework_CF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Telephone telephone = new Telephone();

            Menu();

            void Menu()
            {
                int opc;
                do
                {
                    Console.WriteLine("--Agenda--");
                    Console.WriteLine("1-Cadastrar");
                    Console.WriteLine("2-Editar");
                    Console.WriteLine("3-Visualizar");
                    Console.WriteLine("4-Remover");

                    opc = int.Parse(Console.ReadLine());


                    switch (opc)
                    {
                        case 1:
                            Cadastrar();
                            break;
                        case 2:
                            Editar();
                            break;
                        case 3:
                            Visualizar();
                            break;
                        case 4:
                            Remover();
                            break;
                    }
                } while (opc > 0 && opc < 5);

            }

            void Cadastrar()
            {
                using (var context = new PhoneBook())
                {

                    Console.WriteLine("Nome: ");
                    person.name = Console.ReadLine();

                    Console.WriteLine("Telefone: ");
                    telephone.phone = Console.ReadLine();

                    Console.WriteLine("Celular: ");
                    telephone.mobile = Console.ReadLine();
                    telephone.name = person;

                    context.Person.Add(person);
                    context.Telephones.Add(telephone);
                    context.SaveChanges();
                }
            }

            void Editar()
            {
                using (var context = new PhoneBook())
                {
                    Console.WriteLine("Digite o nome para mudar o telefone: ");
                    person.name = Console.ReadLine();

                    Telephone find = context.Telephones.FirstOrDefault(t => t.name.name == person.name);

                    Console.WriteLine("Telefone: ");
                    find.phone = Console.ReadLine();

                    Console.WriteLine("Celular: ");
                    find.mobile = Console.ReadLine();

                    context.Entry(find).State = EntityState.Modified;
                    context.Telephones.AddOrUpdate(find);

                    context.SaveChanges();
                }
            }

            void Visualizar()
            {
                using (var context = new PhoneBook())
                {
                    Console.WriteLine("Digite o nome para pesquisar o telefone: ");
                    person.name = Console.ReadLine();

                    var find = context.Telephones.FirstOrDefault(t => t.name.name == person.name);

                    Console.WriteLine("Id: {0}", find.Id);
                    Console.WriteLine("Phone: {0}", find.phone);
                    Console.WriteLine("Mobile: {0}", find.mobile);
                }
            }

            void Remover()
            {

            }
        }
    }
}

