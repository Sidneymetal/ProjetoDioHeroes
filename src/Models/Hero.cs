namespace ProjetoDioGame.src.Modes

{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HealthPoits, int MagicPoits)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoits = HealthPoits;
            this.MagicPoits = MagicPoits;
        }

        public string Name;

        public int Level;

        public string HeroType;

        public int HealthPoits;

        public int MagicPoits;

        public Hero()
        {

        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.HealthPoits + " " + this.MagicPoits;
        }

        public virtual string Attack()
        {
            return this.Name + "Atacou com a sua espada";
        }
    }
}