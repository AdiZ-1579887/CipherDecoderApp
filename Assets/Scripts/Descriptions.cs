using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Descriptions
{
    public readonly string Caesar = "The Caesar Cipher involves shuffling each plaintext letter by a set number of places. If the numeric shuffle value is 3, for example, 'a' will become 'd' and 'h' will become 'k'. New letters that go past 'z' will just roll over, so 'y' will become 'b'. ";
    public readonly string MonoAlphabetic = "The Monoalphabetic Cipher involves changing each plaintext letter to another letter, as defined by a key. The cipher's key is always 26 letters, each letter representing what the concurrent letters of the ordered English alphabet will be changed to. A key such as 'qwerty...' and so on for 26 letters would mean that letter 'a' would be replaced with 'q', 'b' with 'w', 'c' with 'e', and so on.";
    public readonly string Rot13 = "Each plaintext letter is shifted by either 13 or -13 places, depending on its position. Any of the first 13 letters of the English alphabet will be moved forward 13 places, while any of the last 13 letters will be moved backward 13 places. Thus, no 'roll-overs' are ever executed.";
}
