namespace GameForPraktika
{
    public class Character
    {
        private static int m_Counter = 0;
        private int id { get; }
        private string name { get; }
        private State state { get; set; }
        private bool isCanSpeek { get; set; }
        private bool isCanMove { get; set; }
        private Sex sex { get; }
        private Race race { get; }
        private int age { get; set; }
        private int curentHP { get; set; }
        private int maxHP { get; set; }
        private int curentXP { get; set; }
        
        public Character(string name, State state, bool isCanSpeek, bool isCanMove, Sex sex, Race race, int age, int curentHp, int maxHp, int curentXp)
        {
            this.id = System.Threading.Interlocked.Increment(ref m_Counter);
            this.name = name;
            this.state = state;
            this.isCanSpeek = isCanSpeek;
            this.isCanMove = isCanMove;
            this.sex = sex;
            this.race = race;
            this.age = age;
            curentHP = curentHp;
            maxHP = maxHp;
            curentXP = curentXp;
        }

        public void isLowHP()
        {
            if (this.curentHP < 10)
            {
                this.state = State.Ослаблен;
            }
            else if (this.curentHP > 10)
            {
                this.state = State.Нормальное;
            }
            else if (this.curentHP <= 0)
            {
                this.state = State.Мёртв;
            }
        }

        public override string ToString()
        {
            return "Персонаж : " + name + "; ID : " + id + "; Возраст : " + age + "; Состояние : " + state + "; Пол : " + sex + "; Раса : "
                   + race + "; Здоровье : " + curentHP + "/" + maxHP + "; Может ходить/говорить : " + isCanMove + "/" +
                   isCanSpeek +
                   "; Опыт : " + curentXP;
        }
    }
}