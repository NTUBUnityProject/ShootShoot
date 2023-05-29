using UnityEngine;

public class CubeColorizer : MonoBehaviour
{
    public Material lightGreenMaterial;  // 浅绿色材质
    public Material darkGreenMaterial;   // 深绿色材质

    void Start()
    {
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
    }
}
