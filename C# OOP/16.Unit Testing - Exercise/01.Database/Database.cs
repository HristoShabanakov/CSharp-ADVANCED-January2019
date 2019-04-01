namespace _01.Database
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Database
    { 
        //Database. It should store integers.
        private const int DefaultSize = 16;
        private int[] database;
        private int index;

        //Set the initial integers by constructor. Store them in array.
        public Database(params int[] collection)
            :this(collection.ToList())
        {
        }

        public Database(IEnumerable<int> collection)
        {
            this.ValidateCollectionSize(collection.ToArray());
            this.index = 0;
            this.database = new int[DefaultSize];
            this.DatabaseElements = collection.ToArray();
           
        }

        public int[] DatabaseElements
        {
            get
            {
                List<int> numbers = new List<int>();
                for (int i = 0; i < index; i++)
                {
                    numbers.Add(this.database[i]);
                }

                return numbers.ToArray();
            }

            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    this.database[this.index] = value[i];
                    this.index++;
                }
            }
        }

        

        public void Add(int number)
        {
            //Storing array's capacity must be exactly 16 integers
            if (index >= 16)
            {
                throw new InvalidOperationException("Database is full");
            }
            this.database[this.index] = number;
            this.index++;
        }

        public void Remove()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("Database is empty");
            }
            this.database[this.index - 1] = default(int);
            this.index--;
        }

        private void ValidateCollectionSize(int[] value)
        {
            if (value.Length > DefaultSize || value.Length < 1)
            {
                throw new InvalidOperationException("Invalid collection size");
            }
        }
    }
}
