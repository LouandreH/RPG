namespace Atividade.Entities
{
    public class Curador : Hero
    {
        public Curador(string Name, int Level, string HeroType, int Life)

        {
            this.Name = Name;    
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
        }
        
        public override string Attack()
        {
            return this.Name + "Curou seu Aliado mais Proximo";
        }

        public string Attack(int Heal)
        {
            return this.Name + $" Curou {Heal} de seu Aliado mais proximo";
        }
    }
}