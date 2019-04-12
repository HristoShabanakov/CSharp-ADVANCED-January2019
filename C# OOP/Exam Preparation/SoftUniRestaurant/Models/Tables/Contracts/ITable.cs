using SoftUniRestaurant.Models.Drinks.Contracts;
using SoftUniRestaurant.Models.Foods.Contracts;
using System.Collections.Generic;

namespace SoftUniRestaurant.Models.Tables.Contracts
{
    public interface ITable
    {
        //FoodOrders – collection of foods accessible only by the base class. 

        //DrinkOrders – collection of drinks accessible only by the base class.  

        //TableNumber – int the table number

        //Capacity – int the table capacity(capacity can’t be less than zero.In these cases, throw an ArgumentException with message "Capacity has to be greater than 0")

        //NumberOfPeople – int the count of people who want a table(number of people cannot be less or equal to 0. In these cases, throw an ArgumentException with message "Cannot place zero or less people!")

        //PricePerPerson – decimal the price per person for the table

        //IsReserved – bool returns true if the table is reserved

        //Price – calculated property, which calculates the price for all people

        ICollection<IFood> Foods { get;  }

        ICollection<IDrink> Drinks { get; }

        int TableNumber { get; set; }

        int Capacity { get; set; }

        int NumberOfPeople { get; set; }

        decimal PricePerPerson { get; set; }

        bool IsReserved { get; set; }

        decimal Price { get;  }
    }
}
