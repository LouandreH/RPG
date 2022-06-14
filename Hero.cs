namespace Atividade.Entities
{
    public class Hero
    {   


        public  Hero (string Name, int Level, string HeroType, int Life)
        {
            this.Name = Name;
            this.HeroType = HeroType;
            this.Level = Level;
            this.Life = Life;
        }

        public Hero(){

        }
        public int Life;
        public string? Name;
        public int Level;
        public string? HeroType;


        public void Apresentar()
        {   System.Console.WriteLine("                     ");
            System.Console.WriteLine($"Me chamo {Name} sou um Heroi do Tipo {HeroType} do Level: {Level}");
            System.Console.WriteLine($"Vida: {Life}");
            
        }
        
        public virtual string Attack(){
            return this.Name + " Atacou com sua Espada" ;
        } 



    }
}