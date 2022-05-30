namespace RPG.src
{
    public abstract class Hero
    {
        public Hero(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }
        public Hero()
        {
            
        }
      
       public string name;
       public int level;
       public string heroType;

       public override string ToString(){
           return "Nome:" + this.name + " Level:" + this.level + " Classe:" + this.heroType ;
       }


       public virtual string Attack(){
           return this.name + " Atacou com sua espada";
       }

    }
}