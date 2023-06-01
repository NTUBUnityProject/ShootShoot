using System.Collections.Generic;

public class Monster
{
    public string MonsterName { get; set; }
    public int MaxHealth { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public string MonsterDress { get; set; }
    public int Level { get; set; }
    public int MovingSpeed { get; set; }

    public int Score { get; set; }
}

public class MonsterModel {
    public List<Monster> GetMonsters(){
        return new List<Monster> ()
        {
            new Monster(){
                MonsterName = "麻雀",
                MaxHealth = 200,
                Health = 200,
                Attack = 1,
                MonsterDress = "Sparrow_LOD0",
                Level = 1,
                MovingSpeed = 5,
                Score = 1
            },
            new Monster(){
                MonsterName = "魚",
                MaxHealth = 200,
                Health = 200,
                Attack = 1,
                MonsterDress = "Herring_LOD0",
                Level = 2,
                MovingSpeed = 7,
                Score = 2
            },
            new Monster(){
                MonsterName = "猴子",
                MaxHealth = 500,
                Health = 500,
                Attack = 1,
                MonsterDress = "Colobus_LOD0",
                Level = 3,
                MovingSpeed = 10,
                Score = 3
            },
            new Monster(){
                MonsterName = "BOSS鹿",
                MaxHealth = 1000,
                Health = 1000,
                Attack = 2,
                MonsterDress = "Pudu_LOD0",
                Level = 4,
                MovingSpeed = 15,
                Score = 4
            }
        };   
    }
}
