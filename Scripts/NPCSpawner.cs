using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    private INPC m_Farmer;
    private INPC m_Beggar;
    private INPC m_Shopowner;
    private INPC m_Guard;
    private INPC m_Thief;
    private INPC m_Blacksmith;

    public void SpawnVillagers()
    {
        m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);
        m_Guard = m_Factory.GetNPC(NPCType.Guard);
        m_Thief = m_Factory.GetNPC(NPCType.Thief);
        m_Blacksmith = m_Factory.GetNPC(NPCType.Blacksmith);

        m_Beggar.Speak();
        m_Farmer.Speak();
        m_Shopowner.Speak();
        m_Guard.Speak();
        m_Thief.Speak();
        m_Blacksmith.Speak();
    }
}