

namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<Trainer> trainers = new List<Trainer>();

            while(input != "Tournament")
            {
                string[] splitedInput = input.Split();

                string trainerName = splitedInput[0];
                string pokemonName = splitedInput[1];
                string element = splitedInput[2];
                int health = int.Parse(splitedInput[3]);

                Pokemon pokemon = new Pokemon(pokemonName, element, health);

                Trainer trainer = trainers
                     .FirstOrDefault(x => x.Name == trainerName);

                if (trainer ==null)
                {
                    trainer = new Trainer(trainerName);
                    trainers.Add(trainer);
                }

                trainer.Pokemons.Add(pokemon);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while(input != "End")
            {
                foreach (var trainer in trainers)
                {
                    //For every command you must check if a trainer has at least 1 pokemon with the given element.
                    if (trainer.Pokemons.Any(x=>x.Element == input))
                    {
                        //If he does, he receives 1 badge.
                        trainer.BadgesCount++;
                    }
                    else
                    {
                        //Otherwise, all of his pokemon lose 10 health.
                        ReduceHealth(trainer.Pokemons);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(
                string.Join(Environment.NewLine,trainers
                .OrderByDescending(x => x.BadgesCount)));
            
        }

       static void ReduceHealth(List<Pokemon> pokemons)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                Pokemon pokemon = pokemons[i];
                pokemon.Health -= 10;

                if (IsDead(pokemon.Health))
                {
                    pokemons.RemoveAt(i);
                    i--;
                }
            }
        }

        static bool IsDead(int pokemonHealth)
        {
            return pokemonHealth <= 0;
        }
    }
}
