using UnityEditor.PackageManager;
using UnityEngine;

public class Player : MonoBehaviour
{
    public BulletBallModel _bulletBallModel;

    public PlayerModel playerModel = new();

    public class PlayerModel
    {
        public int MaxHealth { get { return 3; } }
        public int Health { get; set; }
        public BulletBall BulletBall { get; set; }
    }
    void Start()
    {
        var BulletBall = _bulletBallModel.GetBulletBall(1);

        this.playerModel = new()
        {
            Health = 3,
            BulletBall = BulletBall
        };
    }
}
