using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
/// <summary>
/// 此為角色射擊、生成火球及設定火球初始速度的專案
/// </summary>
public class CharacterShoot : MonoBehaviour
{
    /// <summary>
    /// 火球的物件
    /// </summary>
    public GameObject Level1Bullet;
    public GameObject Level2Bullet;
    public GameObject Level3Bullet;
    public GameObject Level4Bullet;
    public int Level;
    public Text ScoreText;
    public BulletModel Bullet;
    public GameObject BulletGameObject;
    public List<BulletModel> Bullets;


    /// <summary>
    /// 子彈速度，設定50以上看起來較有速度感
    /// </summary>
    public float speed ;

    public class BulletModel
    {
        public int BulletSpeed { get; set; }
        public int BulletWidth{ get; set; }
        public int Level { get; set; }
        public GameObject BulletGameObject { get; set; }
    };


    void Start()
    {
        Bullets = new List<BulletModel> ()
        {
            new BulletModel(){
                BulletSpeed = 50,
                BulletWidth = 1,
                Level = 1,
                BulletGameObject = Level1Bullet
            },
            new BulletModel(){
                BulletSpeed = 75,
                BulletWidth = 2,
                Level = 2,
                BulletGameObject = Level2Bullet
            },
            new BulletModel(){
                BulletSpeed = 100,
                BulletWidth = 3,
                Level = 3,
                BulletGameObject = Level3Bullet
            },
            new BulletModel(){
                BulletSpeed = 125,
                BulletWidth = 4,
                Level = 4,
                BulletGameObject = Level4Bullet
            },
        };
        

    }
    void Update()
    {
        Level = GetLevel();
        Bullet = Bullets.Find(x => x.Level == Level);
        BulletGameObject = Bullet.BulletGameObject;
        speed = Bullet.BulletSpeed;
        // 滑鼠左鍵點擊事件
        if (Input.GetMouseButtonDown(0))  
        {
            // 在角色前方生成 Cube ，營造發射火球的概念，利用position跟forward才能讓子彈朝斜前方飛行
            Vector3 cubePosition = transform.position + transform.forward;

            // 保持 Cube 的高度(y)為 5 ，避免直接撞到地板消失
            cubePosition.y = 8f; 
            GameObject cube = Instantiate(BulletGameObject, cubePosition, Quaternion.identity);
            Rigidbody cubeRigidbody = cube.GetComponent<Rigidbody>();

            if (cubeRigidbody != null)
            {
                // 設定火球的初始速度
                Vector3 cubeVelocity = transform.forward * speed;
                cubeVelocity.y = 0f; // 將y軸設定為 0
                cubeRigidbody.velocity = cubeVelocity;
            }
        }
    }
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
        if(_Level > 4)
        {
            _Level = 4;
        }
        return _Level;            
    }
}
