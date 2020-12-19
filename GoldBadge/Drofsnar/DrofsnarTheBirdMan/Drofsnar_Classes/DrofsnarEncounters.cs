using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drofsnar_Classes
{
    public enum EncounterType
    {
        Bird = 1,
        Crested_Ibis,
        Great_Kiskudee,
        Red_Crossbill,
        Red_Necked_Phalarope,
        Evening_Grosbeak,
        Greater_Prairie_Chicken,
        Iceland_Gull,
        Orange_Bellied_Parrot,
        Invincible_Bird_Hunter,
        Vulnerable_Bird_Hunter
    }

    public interface IEncounter
    {
        EncounterType Type { get; }
        int Points { get; }
    }
    public class Bird : IEncounter
    {
        public EncounterType Type { get; }
        public int Points { get; }

        public Bird()
        {
            Type = EncounterType.Bird;
            Points = 10;
        }
    }

    public class CrestedIbis : IEncounter
    {
        public EncounterType Type { get; }
        public int Points { get; }

        public CrestedIbis() 
        {
            Type = EncounterType.Crested_Ibis;
            Points = 100;
        }
    }

    public class GreatKiskudee : IEncounter
    {
        public EncounterType Type { get; }
        public int Points { get; }

        public GreatKiskudee()
        {
            Type = EncounterType.Great_Kiskudee;
            Points = 300;
        }
    }

    public class RedCrossbill : IEncounter
    {
        public EncounterType Type { get; }
        public int Points { get; }

        public RedCrossbill()
        {
            Type = EncounterType.Red_Crossbill;
            Points = 500;
        }
    }

    public class RedNeckedPhalarope : IEncounter
    {
        public EncounterType Type { get; }
        public int Points { get; }

        public RedNeckedPhalarope()
        {
            Type = EncounterType.Red_Necked_Phalarope;
            Points = 700;
        }
    }

    public class EveningGrosbeak : IEncounter
    {
        public EncounterType Type { get; }
        public int Points { get; }

        public EveningGrosbeak()
        {
            Type = EncounterType.Evening_Grosbeak;
            Points = 1000;
        }
    }

    public class GreaterPrairieChicken : IEncounter
    {
        public EncounterType Type { get; }
        public int Points { get; }

        public GreaterPrairieChicken()
        {
            Type = EncounterType.Greater_Prairie_Chicken;
            Points = 2000;
        }
    }

    public class IcelandGull : IEncounter
    {
        public EncounterType Type { get; }
        public int Points { get; }

        public IcelandGull()
        {
            Type = EncounterType.Iceland_Gull;
            Points = 3000;
        }
    }

    public class OrangeBelliedParrot : IEncounter
    {
        public EncounterType Type { get; }
        public int Points { get; }

        public OrangeBelliedParrot()
        {
            Type = EncounterType.Orange_Bellied_Parrot;
            Points = 5000;
        }
    }

    public class InvincibleBirdHunter : IEncounter
    {
        public EncounterType Type { get; }
        public int Points { get; }

        public InvincibleBirdHunter()
        {
            Type = EncounterType.Invincible_Bird_Hunter;
            Points = 0;
        }
    }
    
    public class VulnerableBirdHunter : IEncounter
    {
        public EncounterType Type { get; }
        public int Points { get; }

        public VulnerableBirdHunter()
        {
            Type = EncounterType.Vulnerable_Bird_Hunter;
            Points = 200;
        }
    }

    public class Drofsnar
    {
        public int Lives { get; set; }
        public int Score { get; set; }
        public int BirdHuntersEaten { get; set; }

        public Drofsnar()
        {
            Lives = 3;
            Score = 5000;
            BirdHuntersEaten = 0;
        }
    }
}
