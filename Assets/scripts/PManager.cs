using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PCommand;
using TMPro;

public class PManager : MonoBehaviour
{

    public TextMeshProUGUI rem;

    Stack<CommPattern> pelletHistory;
    public static PManager instance { get; private set; }

    int pelletsRemaining = 15;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        pelletHistory = new Stack<CommPattern>();
    }

    // Update is called once per frame
    void Update()
    {
        rem.text = "Pellets remaining: " + pelletsRemaining.ToString();
        if(pelletsRemaining == 0)
        {
            rem.text = "win";
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ReplaceLast7();
        }
    }

    public void EatPellet(CommPattern p)
    {
        p.EatPellet();
        pelletHistory.Push(p);
        pelletsRemaining--;
        
    }

    public void ReplaceLast7()
    {
        int validIterations = (pelletHistory.Count > 7) ? 7 : pelletHistory.Count;

        for(int i = 0; i < validIterations; i++)
        {
            pelletHistory.Peek().ReplacePellet();
            pelletHistory.Pop();
            pelletsRemaining++;
        }
    }
}
