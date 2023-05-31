using UnityEngine;

/// <summary>
/// �����������઺�M��
/// </summary>
public class MouseLook : MonoBehaviour
{
    public float rotateSpeed = 20f;
    public Transform cameraTransform;

    void Update()
    {
        // �Q����v�����o�ƹ����Цb�e���W����m
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = cameraTransform.position.y - transform.position.y;

        // �N�ƹ����Ъ���m�ഫ���C�������y��
        Vector3 targetPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // �N�ؼЦ�m��Y�b�P����O���@�P
        targetPosition.y = transform.position.y; 

        // �p�⨤��¦V�ؼФ�V���t�B
        Vector3 direction = targetPosition - transform.position;

        if (direction != Vector3.zero)
        {
            // �N����¦V�ؼФ�V
            Quaternion rotation = Quaternion.LookRotation(direction);

            // �����ؼФ�V
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotateSpeed * Time.deltaTime);
        }
    }
}