namespace Gamekit3D.GameCommands
{
    public class RespawnPlayer : GameCommandHandler
    {
        public Gamekit3D.PlayerController player;

        public override void PerformInteraction()//��д����ļ̳�ʱ�����������������¶��常���еķ����������еķ����͸���ķ�����һ���ģ���������������������ֵ���Ͷ���ͬ��ԭ�����ӣ�https://blog.csdn.net/kj297296053/java/article/details/8213550
        {
            player.Respawn();//���룺��λ��      ���ڴ���EllenRespawnEffect������
        }
    }
}
