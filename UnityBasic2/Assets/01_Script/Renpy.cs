using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Renpy : MonoBehaviour
{
    [SerializeField] Image img_BG; //���
    [SerializeField] Image[] img_Character; // ĳ����

    [SerializeField] TextMeshProUGUI txt_Name; //ĳ���� �̸� : ȣ�ó�
    [SerializeField] TextMeshProUGUI txt_NameTitle; // ĳ���� Ÿ��Ʋ : ��å����ȸ
    [SerializeField] TextMeshProUGUI txt_Dialogue; // ��� : ���⿡ ��簡 ��µ˴ϴ�.

    int id = 1;

    void Start()
    {
        int characterID = SData.GetDialogueData(1).Character;

        txt_Name.text = SData.GetCharacterData(characterID).Name; // ��� ���̺��� 1�� ID�� ĳ���� ID Į���� ������ �´�
        txt_NameTitle.text = SData.GetCharacterData(characterID).Title; // ĳ���� ���̺��� ĳ���� ID�� �ش��ϴ� �̸��� ������ �´�.
        txt_Dialogue.text = SData.GetDialogueData(1).Dialogue; // ĳ���� ���̺��� ĳ���� ID�� Ÿ��Ʋ�� ������ �´�.
    }

    public void OnClickButton()
    {
        id++; // 2
        int characterID = SData.GetDialogueData(id).Character;

        txt_Name.text = SData.GetCharacterData(characterID).Name; // ��� ���̺��� 1�� ID�� ĳ���� ID Į���� ������ �´�
        txt_NameTitle.text = SData.GetCharacterData(characterID).Title; // ĳ���� ���̺��� ĳ���� ID�� �ش��ϴ� �̸��� ������ �´�.
        txt_Dialogue.text = SData.GetDialogueData(id).Dialogue; // ĳ���� ���̺��� ĳ���� ID�� Ÿ��Ʋ�� ������ �´�.

        img_BG.sprite = Resources.Load<Sprite>("Img/Renpy" + SData.GetDialogueData(id).BG);
    }

    void Update()
    {
        
    }

}
