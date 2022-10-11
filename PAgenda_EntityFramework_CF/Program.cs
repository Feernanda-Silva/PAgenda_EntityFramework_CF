using System;
using System.Collections.Generic;
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

                    //Verificar se ja existe esse nome

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

            }

            void Visualizar()
            {

            }

            void Remover()
            {

            }
        }
    }
}

