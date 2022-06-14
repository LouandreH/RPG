namespace Atividade.Entities
{
    public class Guerreiro : Hero
    {
        public Guerreiro(string Name, int Level, string HeroType, int Life)

        {
            this.Name = Name;
            this.HeroType = HeroType;
            this.Level = Level;
            this.Life = Life;
        }    
        
    }
}