using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drofsnar_Classes;

namespace DrofsnarTheBirdMan
{
    public class DrofsnarUI
    {
        private Queue<IEncounter> _encounterSequence = new Queue<IEncounter>();

        public void Run()
        {
            GenerateEncounterSequence();
            ProgramSequence();
        }

        private void ProgramSequence()
        {
            Console.SetWindowSize(200, 50);
            var player = new Drofsnar();
            foreach (var encounter in _encounterSequence)
            {
                int multiplier = 1;
                if (encounter.Type == EncounterType.Invincible_Bird_Hunter)
                {
                    player.Lives -= 1;
                    player.Score = 0;
                    player.BirdHuntersEaten = 0;
                }
                else if (encounter.Type == EncounterType.Vulnerable_Bird_Hunter)
                {
                    player.BirdHuntersEaten += 1;
                    switch (player.BirdHuntersEaten)
                    {
                        case 1:
                            player.Score += encounter.Points * multiplier;
                            break;
                        case 2:
                            multiplier = 2;
                            player.Score += encounter.Points * multiplier;
                            break;
                        case 3:
                            multiplier = 4;
                            player.Score += encounter.Points * multiplier;
                            break;
                        case 4:
                            multiplier = 8;
                            player.Score += encounter.Points * multiplier;
                            break;
                    }
                }
                else
                {
                    player.Score += encounter.Points;
                }

                if(player.Score >= 10000)
                {
                    player.Lives += 1;
                }

                if (player.Lives == 0)
                {
                    Console.Beep(66, 1111);
                    Console.Clear();
                    Console.ForegroundColor= ConsoleColor.DarkRed;
                    Console.CursorSize = 100;
                    Console.SetCursorPosition(90, 22);
                    Console.CursorVisible = false;
                    Console.WriteLine("M    O    R    T    I    S");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                Console.WriteLine($"Encountered {encounter.Type.ToString().Replace('_', ' ').PadRight(25)}" + $"Got {encounter.Points} points!".PadRight(16) + $"\tTotal score: {player.Score}".PadRight(20) + $"\tHunters eaten in succession: {player.BirdHuntersEaten}".PadRight(30) + $"\tScore multiplier x{multiplier}".PadRight(16) + $"\tLives remaining: {player.Lives}");
                Console.ReadKey();
            }            
        }

        private void GenerateEncounterSequence()
        {
            string[] encountersFromTXT = System.IO.File.ReadAllText(@"C:\Users\johnc\OneDrive\Documents\ElevenFIftyProjects\GoldBadge\Drofsnar\game-sequence.txt").Split(',');
            foreach(var encounter in encountersFromTXT)
            {
                switch (encounter.ToLower())
                {
                    case "bird":
                        _encounterSequence.Enqueue(new Bird());
                        break;
                    case "crestedibis":
                        _encounterSequence.Enqueue(new CrestedIbis());
                        break;
                    case "greatkiskudee":
                        _encounterSequence.Enqueue(new GreatKiskudee());
                        break;
                    case "redcrossbill":
                        _encounterSequence.Enqueue(new RedCrossbill());
                        break;
                    case "red-neckedphalarope":
                        _encounterSequence.Enqueue(new RedNeckedPhalarope());
                        break;
                    case "eveninggrosbeak":
                        _encounterSequence.Enqueue(new EveningGrosbeak());
                        break;
                    case "greaterprairiechicken":
                        _encounterSequence.Enqueue(new GreaterPrairieChicken());
                        break;
                    case "icelandgull":
                        _encounterSequence.Enqueue(new IcelandGull());
                        break;
                    case "orange-belliedparrot":
                        _encounterSequence.Enqueue(new OrangeBelliedParrot());
                        break;
                    case "invinciblebirdhunter":
                        _encounterSequence.Enqueue(new InvincibleBirdHunter());
                        break;
                    case "vulnerablebirdhunter":
                        _encounterSequence.Enqueue(new VulnerableBirdHunter());
                        break;
                }
            }
        }
    }
}
