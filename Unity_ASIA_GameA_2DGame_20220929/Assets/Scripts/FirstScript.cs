using UnityEngine;

namespace KID
{
    /// <summary>
    /// �Ĥ@�Ӹ}��
    /// 2022.10.13
    /// </summary>
    public class FirstScript : MonoBehaviour
    {
        #region ���Ѱϰ�
        // �Y�� �ֱ���GTab
        // �榡�Ƥ�� �ֱ���GCtrl + K D
        // ������

        /* �h�����
         * �h�����
         */

        // A a ���ۦP���r
        #endregion

        #region �ƥ�ϰ�
        // ����ƥ�G�C���}�l�ɰ���@��
        private void Awake()
        {
            // ��X(�T��)�F
            print("���o�A�U�w :D");
        }

        // �}�l�ƥ�GAwake �����@��
        private void Start()
        {
            print("<color=yellow>�}�l�ƥ�</color>");
        }

        // ��s�ƥ�GStart �������A����� 60 FPS
        private void Update()
        {
            print("<color=green>��s�ƥ�</color>");
        }
        #endregion
    }
}
