using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BulletBallModel
{
    public List<BulletBall> GetBulletBalls()
    {
        var result = new List<BulletBall>(){
            new BulletBall(){
                Attack = 100,
                CubeColor = "Green",
                Level = 1,
                Speed = 10,
                FrequencySeconds = 2
            },
            new BulletBall(){
                Attack = 200,
                CubeColor = "Blue",
                Level = 2,
                Speed = 20,
                FrequencySeconds = (decimal)1.5
            },
            new BulletBall(){
                Attack = 300,
                CubeColor = "Red",
                Level = 3,
                Speed = 30,
                FrequencySeconds = 1
            },
        };
        return result;
    }

    public BulletBall GetBulletBall(int level)
    {
        return GetBulletBalls().Find(x => x.Level == level);
    }


}
public class BulletBall
{
    public int Attack { get; set; }
    public string CubeColor { get; set; }
    public int Level { get; set; }
    public int Speed { get; set; }
    public decimal FrequencySeconds { get; set; }
}
