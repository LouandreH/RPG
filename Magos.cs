namespace Atividade.Entities
{
    public class Magos : Hero
    {

         public Magos(string Name, int Level, string HeroType, int Life)
        {
            this.Name = Name;
            this.HeroType = HeroType;
            this.Level = Level;
            this.Life = Life;
        }
         public override string Attack(){
            return this.Name + "Atacou com sua Magia";
        }
        public string Attack(int Bonus)
        {   
            if(Bonus > 6) {
                return this.Name + " Bonus de Ataque" + " " + Bonus;
            }
            else{
                return this.Name + " Lancou Magia fraca"+ " " + Bonus;
            }
            
        }
        
    }
}