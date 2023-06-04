using UnityEngine;

/// <summary>
/// 地板花色專案
/// </summary>
public class CubeColorizer : MonoBehaviour
{
    public Material lightGreenMaterial;  // 浅绿色材质
    public Material darkGreenMaterial;   // 深绿色材质
    public Material blackMaterial;  //  黑色材質

    void Start()
    {
        //  場地設定為70個Cube，這邊用迴圈依序變色，分為單雙號變色
        for (int i = 1; i <= 70; i++)
        {
            string cubeName = i.ToString();
            GameObject cube = GameObject.Find(cubeName);

            if (cube != null)
            {
                MeshRenderer renderer = cube.GetComponent<MeshRenderer>();
                Material material = (i % 2 == 0) ? darkGreenMaterial : lightGreenMaterial;
                renderer.material = material;
            }
        }

        for (int i = 71; i <= 73; i++)
        {
            string wallName = i.ToString();
            GameObject wall = GameObject.Find(wallName);

            MeshRenderer renderer2 = wall.GetComponent<MeshRenderer>();
            Material material2 = blackMaterial;
            renderer2.material = material2;
        }
    }
}
