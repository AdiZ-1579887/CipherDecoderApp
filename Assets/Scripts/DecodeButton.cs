using System;
using UnityEngine;

public class DecodeButton : MonoBehaviour
{
    ReadStringInput plaintextStringInput;
    ReadStringInput shuffleStringInput;

    Decoders decoderScript;

    void Awake()
    {
        // Instantiate GameObjects for each of the text box inputs (for the plaintext and the shuffle).
        GameObject plaintextGameObject = new GameObject("ReadStringInput");
        plaintextStringInput = gameObject.AddComponent<ReadStringInput>();

        GameObject shuffleGameObject = new GameObject("ReadStringInput");
        shuffleStringInput = gameObject.AddComponent<ReadStringInput>();

        // Instantiation for usage of other scripts
        GameObject decoderGameObject = new GameObject("Decoders");
        decoderScript = gameObject.AddComponent<Decoders>();
    }

    void OnClick()
    {
        int shuffle;
        Int32.TryParse(shuffleStringInput.input, out shuffle);
        string output = decoderScript.CaesarCipher(plaintextStringInput.input, shuffle);
    }
}
