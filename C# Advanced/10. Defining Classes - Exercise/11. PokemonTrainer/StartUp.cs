using System;
using System.Linq;
using System.Collections.Generic;

namespace PokemonTrainer
{
    class StartUp
    {
        static void Main()
        {
            List<Trainer> trainers = new List<Trainer>();
           
            string inputTrainers;
            while ((inputTrainers = Console.ReadLine()) != "Tournament")
            {
                string[] info = inputTrainers.Split(" ").ToArray();
                string name = info[0];
                string pokemonName = info[1];
                string pokemonElement = info[2];
                int pokemonHealth = int.Parse(info[3]);
                

                if (!trainers.Any(t => t.Name == name))
                {
                    List<Pokemon> pokemons = new List<Pokemon>();
                    Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                    pokemons.Add(pokemon);
                    int badges = 0;
                    Trainer trainer = new Trainer(name, badges, pokemons);
                    trainers.Add(trainer);
                }
                else
                {
                    if(trainers.Any(t => t.Name == name))
                    {
                        Trainer currentTrainer = trainers.FirstOrDefault(t => t.Name == name);
                        Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                        currentTrainer.Pokemons.Add(pokemon);
                    }
                }
            }

            Console.WriteLine();

            string command;
            while((command = Console.ReadLine()) != "End")
            {
                foreach (Trainer trainer in trainers)
                {
                    if(trainer.Pokemons.Any(p => p.Element == command))
                    {
                        trainer.Badges += 1;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Pokemons.Count; i++)
                        {
                            Pokemon currentPokemon = trainer.Pokemons[i];
                            currentPokemon.Health -= 10;
                            if(currentPokemon.Health <= 0)
                            {
                                trainer.Pokemons.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}
