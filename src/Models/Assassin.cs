namespace ProjetoDioGame.src.Modes

{
    public class Assassin : Hero
    {
        public Assassin(string Name, string HeroType, int Level, int HealthPoits, int MagicPoits)
        {
            this.Name = Name;
            this.HeroType = HeroType;
            this.Level = Level;
            this.HealthPoits = HealthPoits;
            this.MagicPoits = MagicPoits;
        }
        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada especial.";
        }
    }
}