using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 怪物專案
/// </summary>
public class GenMonster : MonoBehaviour
{
    public GameObject Level1Monster;
    public GameObject Level2Monster;
    public GameObject Level3Monster;
    public GameObject Level4Monster;
    public GameObject Level5Monster;
    public GameObject Level6Monster;
    public GameObject Level7Monster;
    public GameObject Level8Monster;

    private float spawnTimer = 0f; // 計時器
    private float speed ; // 怪物的移動速度
    public Text ScoreText;
    public int Level ;
    public MonsterModel Monster;
    public GameObject MonsterGameObject;
    public int MonsterScore;

    public class MonsterModel
    {
        public string MonsterName { get; set; }
        public int Level { get; set; }
        public int MovingSpeed { get; set; }
        public int Score { get; set; }
        public float MonsterspawnTimer { get; set; }
        public GameObject MonsterGameObject { get; set; }
    };

    public List<MonsterModel> Monsters;

    void Start()
    {
        Monsters = new List<MonsterModel> ()
        {
            new MonsterModel(){
                MonsterName = "麻雀",
                Level = 1,
                MovingSpeed = 10,
                Score = 3,
                MonsterspawnTimer =1.5f,
                MonsterGameObject = Level1Monster
            },
            new MonsterModel(){
                MonsterName = "魚",
                Level = 2,
                MovingSpeed = 15,
                Score = 4,
                MonsterspawnTimer =1.25f,
                MonsterGameObject = Level2Monster
            },
            new MonsterModel(){
                MonsterName = "猴子",
                Level = 3,
                MovingSpeed = 30,
                Score = 5,
                MonsterspawnTimer =1f,
                MonsterGameObject = Level3Monster
            },
            new MonsterModel(){
                MonsterName = "鹿",
                Level = 4,
                MovingSpeed = 35,
                Score = 6,
                MonsterspawnTimer =0.75f,
                MonsterGameObject = Level4Monster
            },
            new MonsterModel(){
                MonsterName = "小蛇",
                Level = 5,
                MovingSpeed = 40,
                Score = 7,
                MonsterspawnTimer =0.75f,
                MonsterGameObject = Level5Monster
            },
            new MonsterModel(){
                MonsterName = "鼠",
                Level = 6,
                MovingSpeed = 50,
                Score = 8,
                MonsterspawnTimer =0.75f,
                MonsterGameObject = Level6Monster
            },
            new MonsterModel(){
                MonsterName = "魷魚",
                Level = 7,
                MovingSpeed = 60,
                Score = 9,
                MonsterspawnTimer =0.75f,
                MonsterGameObject = Level7Monster
            },
            new MonsterModel(){
                MonsterName = "紅蛇",
                Level = 8,
                MovingSpeed = 80,
                Score = 10,
                MonsterspawnTimer =0.5f,
                MonsterGameObject = Level8Monster
            }
        };
        
    }

    //  怪物生成間隔 
    void Update()
    {
        Level = GetLevel();
        Monster = Monsters.Find(x => x.Level == Level);
        speed = Monster.MovingSpeed;
        spawnTimer += Time.deltaTime;
        MonsterGameObject = Monster.MonsterGameObject;
        MonsterScore = Monster.Score;
        if (spawnTimer >= Monster.MonsterspawnTimer) // 計時器2秒時做動作
        {
            SpawnMonster(); // 生成怪物
            spawnTimer = 0f; // 重置計時器
        }
    }

    void SpawnMonster()
    {       
        int[] XscopePoint = {0,10,20,30,40,50,60};
        int[] ZscopePoint =  {105,95,85};
        

        // 產生一個隨機的索引值
        int XrandomIndex = Random.Range(0, XscopePoint.Length);
        int ZrandomIndex = Random.Range(0, ZscopePoint.Length);
        var Xscope = XscopePoint[XrandomIndex];
        var Zscope = ZscopePoint[ZrandomIndex];
        Vector3 position = new Vector3(Xscope, 3, Zscope);
        Quaternion rotation = Quaternion.Euler(0f, 180f, 0f); // 設定朝下(玩家的方向)

        // 建立怪物物件
        GameObject monster = Instantiate(MonsterGameObject, position, rotation) as GameObject;
        // 怪物移動腳本
        if (monster != null)
        {          
            // 加入怪物移動的方法
            MonsterMovement monsterMovement = monster.AddComponent<MonsterMovement>();
            monsterMovement.speed = speed;
            // 設定物理模組
            Rigidbody monsterRigidbody = monster.AddComponent<Rigidbody>();
            //  y 座標固定
            monsterRigidbody.constraints = RigidbodyConstraints.FreezePositionY;
            // 禁用重力
            monsterRigidbody.useGravity = false;
            
            //  z座標 < 0 消失
            MonsterDisappear monsterDisappear = monster.AddComponent<MonsterDisappear>();
            monsterDisappear.ScoreText = ScoreText;
            monsterDisappear.MonsterScore = MonsterScore;
            //  怪物傷害(這邊設定為扣分)
            MonsterHit monsterHit = monster.AddComponent<MonsterHit>();
            monsterHit.MonsterScore = MonsterScore;
            monsterHit.ScoreText = ScoreText;
        }   
    }

    /// <summary>
    /// 關卡難度提升，怪物的移動速度跟生成變快
    /// </summary>
    /// <returns></returns>
    public int GetLevel()
    {
        var Score = int.Parse(ScoreText.text);
        var _Level = 0;
        if(Score < 90)
        {
            _Level = (Score/30)+1;
        }
        else if (Score >= 90 && Score < 240)
        {
            _Level = ((Score-90)/50)+4;
        }
        else if (Score >= 240)
        {
            _Level = ((Score-240)/80)+7;
        }       
        if(_Level > 8)
        {
            _Level = 8;
        }
        return _Level;            
    }
    
}



