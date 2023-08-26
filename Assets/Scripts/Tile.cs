using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [System.Serializable]
    public class State
    {
        public Color fillColor;
        public Color outlineColor;
    }

    public State state { get; private set; }
    public char letter { get; private set; }

    private TextMeshProUGUI text;
    private Image fill;
    private Outline outline;

    private void Awake()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
        fill = GetComponent<Image>();
        outline = GetComponent<Outline>();
    }

    public void SetLetter(char letter)
    {
        this.letter = letter;
        text.text = letter.ToString();
    }

    public void SetState(State newState)
    {
        state = newState; 
        fill.color = state.fillColor;
        outline.effectColor = state.outlineColor;
    }


}
