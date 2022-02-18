using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    public Text txtName;
    public Text txtSentence;

    Queue<string> sentences = new Queue<string>();

    public void Begin(Dialogue info)
    {
        sentences.Clear();

        txtName.text = info.name;
        
        foreach (var sentence in info.sentences)
        {
            sentences.Enqueue(sentence); //��ü�� ���κп� �߰�
        }

        Next();
    }

    private void Next()
    {
        if (sentences.Count == 0) ;
        {
            End();
        }

        txtSentence.text = sentences.Dequeue(); //���ۺκп��� ��ü�� �����ϰ� ��ȯ
    }

    private void End()
    {
       
    }
}
