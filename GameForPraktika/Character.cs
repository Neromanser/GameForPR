namespace GameForPraktika
{
    public class Character
    {
        private int id { get; }
        private string name { get; }
        private State state { get; set; }
        private bool isCanSpeek { get; set; }
        private bool isCanMove { get; set; }
        private Sex sex { get; }
        private int age { get; set; }
        private int curentHP { get; set; }
        private int maxHP { get; set; }
        private int curentXP { get; set; }
        
        public Character(int id, string name, State state, bool isCanSpeek, bool isCanMove, Sex sex, int age, int curentHp, int maxHp, int curentXp)
        {
            this.id = id;
            this.name = name;
            this.state = state;
            this.isCanSpeek = isCanSpeek;
            this.isCanMove = isCanMove;
            this.sex = sex;
            this.age = age;
            curentHP = curentHp;
            maxHP = maxHp;
            curentXP = curentXp;
            if()
        }

    }
}