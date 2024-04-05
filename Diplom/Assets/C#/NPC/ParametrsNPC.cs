using System;
using UnityEngine;

public class ParametrsNPC : MonoBehaviour
{
    public GemLocate gemLocate;
    public string[] MassNameNPC;
    public int GemNPC;
    public string NameNPC;

    public void Start()
    {
        GeneratName(); // ���������� ��� ������ ����
        Array.Clear(MassNameNPC, 0, MassNameNPC.Length); // ����������� ����� � ������
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Gem")
        {
            Debug.Log("NPC gem up");
            other.gameObject.SetActive(false);
            gemLocate.gemLocations.RemoveAll(item => item == null);
            GemNPC++;
        }
    }


    // ��������� ��������� ��� ��� NPC
    public void GeneratName()
    {
        MassNameNPC = new string[] 
        {
            "����","������","�����","�����","�������","������","������","������","������","�������",
            "�������","�����","�����","�������","�����","���������","���","���������","������","���",
            "��������","�������","����","����","��������","Ը���","�����","���������","���������","�����",
            "����","�������","������","�����","���������","����������","������","�����","����","������","����",
            "�������","��������","������","��������","������","������","����","�����","����������","�����","������",
            "�����","�����","������","����","����","�����","������","����","������","���","������","��������","�������",
            "���","������","����","ϸ��","������","�������","����","�����","��������","����","�������","�����","������",
            "�������","����","������","�������","�������","������","�����","���������","�����","�������","�����","�����",
            "������","�����","������","�������","��������","����","����","���������","�����","������"
        };
        int Arr = 0;
        Arr = UnityEngine.Random.Range(0, MassNameNPC.Length);
        NameNPC = MassNameNPC[Arr];
        MassNameNPC = new string[0];
    }
}
