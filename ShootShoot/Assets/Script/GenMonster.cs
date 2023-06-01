using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GenMonster : MonoBehaviour
{
    public GameObject Level1Monster;
    public GameObject Level2Monster;
    public GameObject Level3Monster;
    public GameObject Level4Monster;
    private float spawnTimer = 0f; // 计时器
    private float speed = 5f; // 怪物的移动速度
    public Text ScoreText;
    public int Level ;
    public MonsterModel Monster;

    public class MonsterModel
    {
        public string MonsterName { get; set; }
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public string MonsterDress { get; set; }
        public int Level { get; set; }
        public int MovingSpeed { get; set; }
        public int Score { get; set; }
        public float MonsterspawnTimer { get; set; }
    };

    public List<MonsterModel> Monsters;

    void Start()
    {
        Monsters = new List<MonsterModel> ()
        {
            new MonsterModel(){
                MonsterName = "麻雀",
                MaxHealth = 200,
                Health = 200,
                Attack = 1,
                MonsterDress = "Sparrow_LOD0",
                Level = 1,
                MovingSpeed = 5,
                Score = 1,
                MonsterspawnTimer =2f
            },
            new MonsterModel(){
                MonsterName = "魚",
                MaxHealth = 200,
                Health = 200,
                Attack = 1,
                MonsterDress = "Herring_LOD0",
                Level = 2,
                MovingSpeed = 7,
                Score = 2,
                MonsterspawnTimer =1.75f
            },
            new MonsterModel(){
                MonsterName = "猴子",
                MaxHealth = 500,
                Health = 500,
                Attack = 1,
                MonsterDress = "Colobus_LOD0",
                Level = 3,
                MovingSpeed = 10,
                Score = 2,
                MonsterspawnTimer =1.5f
            },
            new MonsterModel(){
                MonsterName = "BOSS鹿",
                MaxHealth = 1000,
                Health = 1000,
                Attack = 2,
                MonsterDress = "Pudu_LOD0",
                Level = 4,
                MovingSpeed = 15,
                Score = 3,
                MonsterspawnTimer =1.25f
            }
        };
        
    }
    // Update is called once per frame
    void Update()
    {
        Level = GetLevel();
        Monster = Monsters.Find(x => x.Level == Level);
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= Monster.MonsterspawnTimer) // 当计时器达到2秒时
        {
            SpawnMonster(); // 生成怪物
            spawnTimer = 0f; // 重置计时器
        }

    }

    void SpawnMonster()
    {        
        
        var MonsterGameObject = GetMonsterGameObject(Level);
        int[] XscopePoint = {0,10,20,30,40,50,60};
        int[] ZscopePoint =  {105,95,85};
        

        // 產生一個隨機的索引值
        int XrandomIndex = Random.Range(0, XscopePoint.Length);
        int ZrandomIndex = Random.Range(0, ZscopePoint.Length);
        var Xscope = XscopePoint[XrandomIndex];
        var Zscope = ZscopePoint[ZrandomIndex];
        Vector3 position = new Vector3(Xscope, 0, Zscope);
        Quaternion rotation = Quaternion.Euler(0f, 180f, 0f); // 设置旋转角度

        // 创建怪物对象
        GameObject monster = Instantiate(MonsterGameObject, position, rotation) as GameObject;
        // 添加怪物移动脚本
        if (monster != null)
        {
            // 添加刚体组件
            Rigidbody monsterRigidbody = monster.AddComponent<Rigidbody>();
            // 禁用重力
            monsterRigidbody.useGravity = true;
            // 添加怪物移动脚本
            MonsterMovement monsterMovement = monster.AddComponent<MonsterMovement>();
            monsterMovement.speed = speed;
        }   
    }   
    
    public int GetLevel()
    {
        var Score = int.Parse(ScoreText.text);
        if(Score >= 0 && Score < 30 ){
            return 1;
        }
        else if (Score >=30  && Score <60)
        {
            return 2;
        }
        else if (Score >= 60 && Score <90)
        {
            return 3;
        }
        else if (Score >= 90)
        {
            return 4;
        }
        else
        {
            return 1;
        }        
    }
    public GameObject GetMonsterGameObject(int Level)
    {
        switch (Level)
        {
            case 1:
                return Level1Monster;
            case 2:
                return Level2Monster;
            case 3:
                return Level3Monster;
            case 4:
                return Level4Monster;
            default:
                return Level1Monster;
        }
    }
}



