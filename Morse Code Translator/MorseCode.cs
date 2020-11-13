using System;

namespace Morse_Code_Translator
{
    public static class MorseCode
    {
        public enum MorseAlphabet
        {
            SPACE = 0, ZERO = 22222, ONE = 12222, TWO = 11222, THREE = 11122, FOUR = 11112, FIVE = 11111,
            SIX = 21111, SEVEN = 22111, EIGHT = 22211, NINE = 22221, DOT = 121212, COMMA = 221122,
            A = 12, B = 2111, C = 2121, D = 211, E = 1, F = 1121, G = 221, H = 1111, I = 11,
            J = 1222, K = 212, L = 1211, M = 22, N = 21, O = 222, P = 1221, Q = 2212, R = 121,
            S = 111, T = 2, U = 112, V = 1112, W = 122, X = 2112, Y = 2122, Z = 2211
        }

        //Sorts the MorseAlphabet enum in order
        public static MorseAlphabet[] MorsCodeSortedArray = {MorseAlphabet.SPACE, MorseAlphabet.ZERO, MorseAlphabet.ONE, MorseAlphabet.TWO,MorseAlphabet.THREE, MorseAlphabet.FOUR, MorseAlphabet.FIVE,
                                                             MorseAlphabet.SIX, MorseAlphabet.SEVEN, MorseAlphabet.EIGHT,MorseAlphabet.NINE, MorseAlphabet.DOT, MorseAlphabet.COMMA,
                                                             MorseAlphabet.A, MorseAlphabet.B, MorseAlphabet.C,MorseAlphabet.D, MorseAlphabet.E, MorseAlphabet.F,
                                                             MorseAlphabet.G, MorseAlphabet.H, MorseAlphabet.I, MorseAlphabet.J, MorseAlphabet.K,MorseAlphabet.L, MorseAlphabet.M, MorseAlphabet.N,
                                                             MorseAlphabet.O, MorseAlphabet.P, MorseAlphabet.Q,MorseAlphabet.R, MorseAlphabet.S, MorseAlphabet.T,
                                                             MorseAlphabet.U, MorseAlphabet.V, MorseAlphabet.W,MorseAlphabet.X, MorseAlphabet.Y, MorseAlphabet.Z};

        //Gets the number value of the selected MorseAlphabet value
        public static string ToCodeValue(int Value)
        {
            int x = 0;
            try
            {           
                x = (int)MorsCodeSortedArray[Value];                
            }
            catch { x = 0; }
         
            return x.ToString();
        }

        //Converts MorseAlphabet values to morse code
        public static string ToMorseCode(string NumberValue)
        {
            string text = "";
            for (int i = 0; i < NumberValue.Length; i++)
            {
                if (NumberValue[i] == '1')
                {
                    text += ".";
                }
                else if (NumberValue[i] == '2')
                {
                    text += "-";
                }
                else
                {
                    text += "#";
                }

            }
            return text + " ";
        }

        static int Diffrence;
        static int DiffrenceAdd;
        static string MText;
        //Converts Text to morse code
        public static string NormalTextToMorse(string NText)
        {
            MText = "";
            for (int i = NText.Length - 1; i < NText.Length; i++)
            {
                if (IsNumb(NText[i]))
                {
                    Diffrence = 48;
                    DiffrenceAdd = 1;
                }
                else
                {
                    Diffrence = 65;
                    DiffrenceAdd = 13;
                }

                if ((int)NText.ToUpper()[i] == 32)
                    MText += "/";
                else
                {
                    MText += MorseCode.ToMorseCode(MorseCode.ToCodeValue((int)NText.ToUpper()[i] - Diffrence + DiffrenceAdd));
                }                    
            }
            
            return MText;
        }

        public static string FullTextToMorse(String NText)
        {
            string MText = "";

            for (int i = 0; i < NText.Length; i++)
            {
                if (IsNumb(NText[i]))
                {
                    Diffrence = 48;
                    DiffrenceAdd = 1;
                }
                else
                {
                    Diffrence = 65;
                    DiffrenceAdd = 13;
                }

                if ((int)NText.ToUpper()[i] == 32)
                    MText += "/";
                else
                    MText += MorseCode.ToMorseCode(MorseCode.ToCodeValue((int)NText.ToUpper()[i] - Diffrence + DiffrenceAdd));
            }
            return MText;
        }

        static string NormalText;
        // Converts morse code to text
        public static string MorseToNormalText(String MText)
        {
            string text = "";
            NormalText = "";
            int i = 0;
            while (i < MText.Length)
            {
                if (MText[i] == '.')
                {
                    text += "1";
                }
                else if (MText[i] == '-')
                {
                    text += "2";
                }

                if (MText[i] == ' ' || MText == null || i == MText.Length)
                {
                    
                    for (int j = 0; j < MorsCodeSortedArray.Length; j++)
                    {
                        try
                        {
                            if (int.Parse(text) == (int)MorsCodeSortedArray[j])
                            {
                                NormalText += MorsCodeSortedArray[j].ToString();
                                break;
                            }
                        }
                        catch
                        {
                            NormalText += " ";
                            break;
                        }

                    }
                    text = "";
                }
                    
                i++;
            }
            return NormalText;
        }
        //checks if a character is a number or not
        private static bool IsNumb(char Text)
        {
            if ((int)Text >= 48 && (int)Text <= 57)
                return true;

            return false;
        }
    }
}

