using UnityEngine;

/// <summary>
/// ��������Cube�I���������M��
/// </summary>
public class CubeProjectile : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //  �o��g����������Ҭ����������ɡA�NCube����
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }

        //  �o��g����������Ҭ��a�O������ɡA�NCube����
        if (collision.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
    }
}
