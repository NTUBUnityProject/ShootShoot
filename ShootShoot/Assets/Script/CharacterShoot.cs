using UnityEngine;

/// <summary>
/// ��������g���B�ͦ����y�γ]�w���y��l�t�ת��M��
/// </summary>
public class CharacterShoot : MonoBehaviour
{
    /// <summary>
    /// ���y������
    /// </summary>
    public GameObject FireBall;

    /// <summary>
    /// �l�u�t�סA�]50�H�W�ݰ_�Ӥ�����t�׷P
    /// </summary>
    public float speed = 50f;

    void Update()
    {
        // �ƹ������I���ƥ�
        if (Input.GetMouseButtonDown(0))  
        {
            // �b����e��ͦ� Cube�A��y�o�g���y�������A�Q��position��forward�~�����l�u�±׫e�譸��
            Vector3 cubePosition = transform.position + transform.forward;

            // �O�� Cube ������(y)�� 3�A�קK��������a�O����
            cubePosition.y = 3f; 
            GameObject cube = Instantiate(FireBall, cubePosition, Quaternion.identity);
            Rigidbody cubeRigidbody = cube.GetComponent<Rigidbody>();

            if (cubeRigidbody != null)
            {
                // �]�w���y����l�t��
                Vector3 cubeVelocity = transform.forward * speed;
                cubeVelocity.y = 0f; // �Ny�b�t�׳]�� 0
                cubeRigidbody.velocity = cubeVelocity;
            }
        }
    }
}
