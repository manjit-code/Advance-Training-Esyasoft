using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Movie
    {
        public string movieName;
        public int totalSeats, bookedSeats;

        public Movie(string movieName, int totalSeats,  int bookedSeats)
        {
            this.movieName = movieName;
            this.totalSeats = totalSeats;
            this.bookedSeats = bookedSeats;
        }

        public void BookSeats(int number)
        {
            if (number > (totalSeats - bookedSeats))
            {
                Console.WriteLine($"We only have {totalSeats - bookedSeats}\n");
            }
            else
            {
                bookedSeats += number;
                Console.WriteLine($"Congratulations, we have booked {number} of seats for you. Thank You !");
            }
        }

        public void CancelSeats(int number)
        {
            bookedSeats -= number;
            Console.WriteLine($"We have cancelled {number} numbers of seats");
        }

        public void DisplayAvailableSeats()
        {
            Console.WriteLine($"Movie Name: {movieName}\nAvailable Seats:{totalSeats-bookedSeats}");
        }
    }
}
