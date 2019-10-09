using System;
using Exceptions.Entities;
using Exceptions.Entities.Exceptions;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                //Estanciando uma Reserva;
                Reservation r1 = new Reservation(roomNumber, checkIn, checkOut);

                //Exibindo a Reserva;
                Console.WriteLine("Reservation " + r1);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation");

                Console.Write("Check in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                //Chamando o metodo UpdateDates da Classe Reservation
                r1.UpdateDates(checkIn, checkOut);

                //Exibindo o Update da Reserva;
                Console.WriteLine("Update_Reservation " + r1);
            }
            //Classe Criada;
            catch (DomainException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            //Format Exception;
            catch(FormatException e)
            {
                Console.WriteLine("Format Error: " + e.Message);
            }
            //Erro Genérico, Pegando todos os erros;
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
