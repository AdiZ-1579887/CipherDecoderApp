using System;
using UnityEngine;

public class DecodeButton : MonoBehaviour
{
    ReadStringInput plaintextStringInput;
    ReadStringInput shuffleStringInput;

    void Awake()
    {
        // Instantiate GameObjects for each of the text box inputs (for the plaintext and the shuffle).
        GameObject plaintextGameObject = new GameObject("ReadStringInput");
        plaintextStringInput = gameObject.AddComponent<ReadStringInput>();

        GameObject shuffleGameObject = new GameObject("ReadStringInput");
        shuffleStringInput = gameObject.AddComponent<ReadStringInput>();
    }

    void OnClick()
    {
        int shuffle;
        Int32.TryParse(shuffleStringInput.input, out shuffle);
        string output = Decoders.CaesarCipher(plaintextStringInput.input, shuffle);
    }
}
