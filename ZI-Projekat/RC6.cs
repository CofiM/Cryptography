using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_Projekat
{
    class RC6
    {
        //        using System;
        //using System.Linq;
        //using System.Text;

        //// not memory safe, constant time, etc. do not use on public computers

        //public class RC6
        //    {
        //        // Define helper functions for RC6
        //        // rotate right input x, by n bits
        //        private static uint ROR(uint x, int n, int bits = 32)
        //        {
        //            uint mask = (uint)((1 << n) - 1);
        //            uint maskBits = x & mask;
        //            return (x >> n) | (maskBits << (bits - n));
        //        }

        //        // rotate left input x, by n bits
        //        private static uint ROL(uint x, int n, int bits = 32)
        //        {
        //            return ROR(x, bits - n, bits);
        //        }

        //        private static uint[] BytesToWord(byte[] bytes)
        //        {
        //            uint[] result = new uint[bytes.Length / 4];
        //            for (int i = 0; i < result.Length; i++)
        //            {
        //                result[i] = BitConverter.ToUInt32(bytes, i * 4);
        //            }
        //            return result;
        //        }

        //        private static byte[] WordsToBytes(uint[] words)
        //        {
        //            byte[] result = new byte[words.Length * 4];
        //            for (int i = 0; i < words.Length; i++)
        //            {
        //                byte[] bytes = BitConverter.GetBytes(words[i]);
        //                Array.Copy(bytes, 0, result, i * 4, 4);
        //            }
        //            return result;
        //        }

        //        private static uint[] GenerateKey(byte[] userKey)
        //        {
        //            int r = 20;
        //            int t = 2 * r + 4;
        //            int w = 32;
        //            uint modulo = (uint)Math.Pow(2, w);
        //            uint[] encoded = BytesToWord(userKey);
        //            int enLength = encoded.Length;
        //            uint[] s = new uint[t];
        //            s[0] = 0xB7E15163;
        //            for (int i = 1; i < t; i++)
        //            {
        //                s[i] = (s[i - 1] + 0x9E3779B9) % (uint)Math.Pow(2, w);
        //            }

        //            int v = 3 * Math.Max(enLength, t);
        //            uint A = 0;
        //            uint B = 0;
        //            int i = 0;
        //            int j = 0;

        //            for (int index = 0; index < v; index++)
        //            {
        //                A = s[i] = ROL((s[i] + A + B) % modulo, 3, 32);
        //                B = encoded[j] = ROL((encoded[j] + A + B) % modulo, (A + B) % 32, 32);
        //                i = (i + 1) % t;
        //                j = (j + 1) % enLength;
        //            }
        //            return s;
        //        }

        //        private static byte[] EncryptBlock(byte[] sentence, uint[] s)
        //        {
        //            uint[] cipher = BytesToWord(sentence);
        //            uint A = cipher[0];
        //            uint B = cipher[1];
        //            uint C = cipher[2];
        //            uint D = cipher[3];

        //            int r = 20;
        //            int w = 32;
        //            uint modulo = (uint)Math.Pow(2, w);
        //            int lgw = 5;
        //            B = (B + s[0]) % modulo;
        //            D = (D + s[1]) % modulo;
        //            for (int i = 1; i < r + 1; i++)
        //            {
        //                uint tTemp = (B * (2 * B + 1)) % modulo;
        //                uint t = ROL(tTemp, lgw, 32);
        //                uint uTemp = (D * (2 * D + 1)) % modulo;
        //                uint u = ROL(uTemp, lgw, 32);
        //            }
        //            int tMod = (int)(t % 32);
        //            int uMod = (int)(u % 32);
        //            A = (ROL(A ^ t, uMod, 32) + s[2 * i]) % modulo;
        //            C = (ROL(C ^ u, tMod, 32) + s[2 * i + 1]) % modulo;
        //            (A, B, C, D) = (B, C, D, A);
        //        }
        //        A = (A + s[2 * r + 2]) % modulo;
        //C = (C + s[2 * r + 3]) % modulo;
        //cipher = new uint[] { A, B, C, D
        //    };
        //return WordsToBytes(cipher);
        //}
        //// Encrypt Block at a time
        //public static byte[] RC6Encrypt(byte[] data, byte[] key)
        //{
        //    uint[] s = GenerateKey(key);
        //    byte[] cipher = EncryptBlock(data, s);
        //    return cipher;
        //}

        //// Encrypt iterating counter in multiple blocks. Note: There is no nonce, each key is different due to salt appended
        //public static byte[] RC6CounterMode(byte[] key, int length = 16)
        //{
        //    int hashLen = 16;
        //    uint[] newKey = GenerateKey(key);
        //    length = int(length);
        //    byte[] t = new byte[0];
        //    byte[] okm = new byte[0];
        //    for (int i = 0; i < Math.Ceiling(length / hashLen); i++)
        //    {
        //        byte[] counter = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0x00, 0x00 };
        //        byte[] nonce = BitConverter.GetBytes(i);
        //        byte[] newData = new byte[key.Length + counter.Length + nonce.Length];
        //        key.CopyTo(newData, 0);
        //        counter.CopyTo(newData, key.Length);
        //        nonce.CopyTo(newData, key.Length + counter.Length);
        //        t = RC6Encrypt(newData, newKey);
        //        okm = okm.Concat(t).ToArray();
        //    }
        //    return okm.Take(length).ToArray();
        //}
        //    using System;
        //using System.Linq;
        //using System.Text;

        // not memory safe, constant time, etc. do not use on public computers

        //public class RC6
        //    {
        // Define helper functions for RC6
        // rotate right input x, by n bits
        //    private static uint ROR(uint x, int n, int bits = 32)
        //    {
        //        uint mask = (uint)((1 << n) - 1);
        //        uint maskBits = x & mask;
        //        return (x >> n) | (maskBits << (bits - n));
        //    }

        //    // rotate left input x, by n bits
        //    private static uint ROL(uint x, int n, int bits = 32)
        //    {
        //        return ROR(x, bits - n, bits);
        //    }

        //    private static uint[] BytesToWord(byte[] bytes)
        //    {
        //        uint[] result = new uint[bytes.Length / 4];
        //        for (int i = 0; i < result.Length; i++)
        //        {
        //            result[i] = BitConverter.ToUInt32(bytes, i * 4);
        //        }
        //        return result;
        //    }

        //    private static byte[] WordsToBytes(uint[] words)
        //    {
        //        byte[] result = new byte[words.Length * 4];
        //        for (int i = 0; i < words.Length; i++)
        //        {
        //            byte[] bytes = BitConverter.GetBytes(words[i]);
        //            Array.Copy(bytes, 0, result, i * 4, 4);
        //        }
        //        return result;
        //    }

        //    private static uint[] GenerateKey(byte[] userKey)
        //    {
        //        int r = 20;
        //        int t = 2 * r + 4;
        //        int w = 32;
        //        uint modulo = (uint)Math.Pow(2, w);
        //        uint[] encoded = BytesToWord(userKey);
        //        int enLength = encoded.Length;
        //        uint[] s = new uint[t];
        //        s[0] = 0xB7E15163;
        //        for (int ind = 1; ind < t; ind++)
        //        {
        //            s[ind] = (s[ind - 1] + 0x9E3779B9) % (uint)Math.Pow(2, w);
        //        }

        //        int v = 3 * Math.Max(enLength, t);
        //        uint A = 0;
        //        uint B = 0;
        //        int i = 0;
        //        int j = 0;

        //        for (int index = 0; index < v; index++)
        //        {
        //            A = s[i] = ROL((s[i] + A + B) % modulo, 3, 32);
        //            B = encoded[j] = ROL((encoded[j] + A + B) % modulo, (int)(A + B) % 32, 32);
        //            i = (i + 1) % t;
        //            j = (j + 1) % enLength;
        //        }
        //        return s;
        //    }
        //    private static byte[] EncryptBlock(byte[] sentence, uint[] s)
        //    {
        //        uint[] cipher = BytesToWord(sentence);
        //        uint A = cipher[0];
        //        uint B = cipher[1];
        //        uint C = cipher[2];
        //        uint D = cipher[3];

        //        int r = 20;
        //        int w = 32;
        //        uint modulo = (uint)Math.Pow(2, w);
        //        int lgw = 5;
        //        B = (B + s[0]) % modulo;
        //        D = (D + s[1]) % modulo;
        //        for (int i = 1; i < r + 1; i++)
        //        {
        //            uint tTemp = (B * (2 * B + 1)) % modulo;
        //            uint t = ROL(tTemp, lgw, 32);
        //            uint uTemp = (D * (2 * D + 1)) % modulo;
        //            uint u = ROL(uTemp, lgw, 32);
        //            int tMod = (int)(t % 32);
        //            int uMod = (int)(u % 32);
        //            A = (ROL(A ^ t, uMod, 32) + s[2 * i]) % modulo;
        //            C = (ROL(C ^ u, tMod, 32) + s[2 * i + 1]) % modulo;
        //            (A, B, C, D) = (B, C, D, A);
        //        }
        //        A = (A + s[2 * r + 2]) % modulo;
        //        C = (C + s[2 * r + 3]) % modulo;
        //        cipher = new uint[] { A, B, C, D };
        //        return WordsToBytes(cipher);
        //    }
        //    // Encrypt Block at a time
        //    public static byte[] RC6Encrypt(byte[] data, byte[] key)
        //    {
        //        uint[] s = GenerateKey(key);
        //        byte[] cipher = EncryptBlock(data, s);
        //        return cipher;
        //    }

        //    // Encrypt iterating counter in multiple blocks. Note: There is no nonce, each key is different due to salt appended
        //    //public static byte[] RC6CounterMode(byte[] key, int length = 16)
        //    //{
        //    //    int hashLen = 16;
        //    //    uint[] newKey = GenerateKey(key);
        //    //    //length = int(length);
        //    //    byte[] t = new byte[0];
        //    //    byte[] okm = new byte[0];
        //    //    for (int i = 0; i < Math.Ceiling(length / hashLen); i++)
        //    //    {
        //    //        byte[] counter = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0x00, 0x00 };
        //    //        byte[] nonce = BitConverter.GetBytes(i);
        //    //        byte[] newData = new byte[key.Length + counter.Length + nonce.Length];
        //    //        key.CopyTo(newData, 0);
        //    //        counter.CopyTo(newData, key.Length);
        //    //        nonce.CopyTo(newData, key.Length + counter.Length);
        //    //        t = RC6Encrypt(newData, newKey);
        //    //        okm = okm.Concat(t).ToArray();
        //    //    }
        //    //    return okm.Take(length).ToArray();
        //    //}




        //    ///DEKRIPTOVANJE


        //    //private static uint RotateRight(uint value, int shift)
        //    //{
        //    //    return (value >> shift) | (value << (32 - shift));
        //    //}
        //    //private static uint RotateLeft(uint value, int shift)
        //    //{
        //    //    return (value << shift) | (value >> (32 - shift));
        //    //}
        //    // Rotate right input x, by n bits
        //    public static uint ROR1(uint x, int n, int bits = 32)
        //    {
        //        uint mask = (uint)Math.Pow(2, n) - 1;
        //        uint maskBits = x & mask;
        //        return (x >> n) | (maskBits << (bits - n));
        //    }

        //    // Rotate left input x, by n bits
        //    public static uint ROL1(uint x, int n, int bits = 32)
        //    {
        //        return ROR1(x, bits - n, bits);
        //    }

        //    private static uint[] ConvertBytesToWords(byte[] bytes)
        //    {
        //        int numWords = bytes.Length / 4;
        //        uint[] words = new uint[numWords];
        //        for (int i = 0; i < numWords; i++)
        //        {
        //            words[i] = BitConverter.ToUInt32(bytes, i * 4);
        //        }
        //        return words;
        //    }

        //    private static byte[] ConvertWordsToBytes(uint[] words)
        //    {
        //        byte[] bytes = new byte[words.Length * 4];
        //        for (int i = 0; i < words.Length; i++)
        //        {
        //            byte[] wordBytes = BitConverter.GetBytes(words[i]);
        //            Array.Copy(wordBytes, 0, bytes, i * 4, 4);
        //        }
        //        return bytes;
        //    }

        //    private static uint[] GenerateKeyDecrypt(byte[] userKey)
        //    {
        //        int r = 20;
        //        int t = 2 * r + 4;
        //        uint w = 32;
        //        uint modulo = (uint)Math.Pow(2, w);
        //        uint[] encoded = ConvertBytesToWords(userKey);
        //        int enlength = encoded.Length;

        //        uint[] s = new uint[t];
        //        s[0] = 0xB7E15163;
        //        for (int i = 1; i < t; i++)
        //        {
        //            s[i] = (s[i - 1] + 0x9E3779B9) % modulo;
        //        }

        //        int v = 3 * Math.Max(enlength, t);
        //        uint A = 0;
        //        uint B = 0;
        //        int i1 = 0;
        //        int j = 0;

        //        for (int index = 0; index < v; index++)
        //        {
        //            A = s[i1] = ROL1((s[i1] + A + B) % modulo, 3, 32);
        //            B = encoded[j] = ROL1((encoded[j] + A + B) % modulo, (int)(A + B) % 32, 32);
        //            i1 = (i1 + 1) % t;
        //            j = (j + 1) % enlength;
        //        }
        //        return s;
        //    }

        //    private static byte[] EncryptBlockDecrypt(byte[] sentence, uint[] s)
        //    {
        //        uint[] cipher = ConvertBytesToWords(sentence);
        //        uint A = cipher[0];
        //        uint B = cipher[1];
        //        uint C = cipher[2];
        //        uint D = cipher[3];

        //        int r = 20;
        //        uint w = 32;
        //        uint modulo = (uint)Math.Pow(2, w);
        //        int lgw = 5;
        //        B = (B + s[0]) % modulo;
        //        D = (D + s[1]) % modulo;
        //        for (int i = 1; i < r + 1; i++)
        //        {
        //            uint tTemp = (B * (2 * B + 1)) % modulo;
        //            uint t = ROL1(tTemp, lgw, 32);
        //            uint uTemp = (D * (2 * D + 1)) % modulo;
        //            uint u = ROL1(uTemp, lgw, 32);
        //            int tmod = (int)(t % 32);
        //            int umod = (int)(u % 32);
        //            A = (ROL1(A ^ t, umod, 32) + s[2 * i]) % modulo;
        //            C = (ROL1(C ^ u, tmod, 32) + s[2 * i + 1]) % modulo;
        //            (A, B, C, D) = (B, C, D, A);
        //        }
        //        A = (A + s[2 * r + 2]) % modulo;
        //        C = (C + s[2 * r + 3]) % modulo;
        //        cipher = new uint[] { A, B, C, D };
        //        byte[] cipherbytes = ConvertWordsToBytes(cipher);
        //        return cipherbytes;
        //    }

        //    public static byte[] RC6EncryptDecrypt(byte[] data, byte[] key)
        //    {
        //        uint[] s = GenerateKeyDecrypt(key);
        //        byte[] cipher = EncryptBlockDecrypt(data, s);
        //        return cipher;
        //    }

        //    // Encrypt iterating counter in multiple blocks. Note: There is no nonce, each key is different due to salt appended
        //    public static byte[] RC6CounterMode(byte[] key, int length = 16)
        //    {
        //        int hashLen = 16;
        //        uint[] newKey = GenerateKey(key);
        //        length = length;
        //        byte[] t = new byte[0];
        //        byte[] okm = new byte[0];
        //        for (int i = 0; i < Math.Ceiling((double)length / hashLen); i++)
        //        {
        //            byte[] counter = BitConverter.GetBytes(i).Reverse().ToArray();
        //            t = RC6EncryptDecrypt(counter, key);
        //            okm = okm.Concat(t).ToArray();
        //        }
        //        return okm.Take(length).ToArray();
        //    }
        //}
        private const int R = 20; // колличество раундов
        private static uint[] RoundKey = new uint[2 * R + 4];  // ключ раунда
        private const int W = 32; // длина машинного слова в битах
        private static byte[] MainKey; // ключ
        private const uint P32 = 0xB7E15163; // константы экспоненты золотого сечения
        private const uint Q32 = 0x9E3779B9;
        //Конструктор для запуска тестов с заранее заданным ключом
        public RC6(byte[] key)
        {
            GenerateKey(key);
        }
        // Сдвиг вправо без потери
        private static uint RightShift(uint value, int shift)
        {
            return (value >> shift) | (value << (W - shift));
        }
        //Сдвиг влево без потери
        private static uint LeftShift(uint value, int shift)
        {
            return (value << shift) | (value >> (W - shift));
        }
        //Генерация main key и раундовых ключей
        private static void GenerateKey(byte[] keyCheck)
        {
            MainKey = keyCheck;
            int c = 0;
            int i, j;
            //В зависимости от размера ключа выбираем на сколько блоков разбивать main key
            //switch (Long)
            //{
            //    case 128:// длина ключа
            //        c = 4; // кол-во слов в ключе
            //        break;
            //    case 192:// длина ключа
            //        c = 6; // кол-во слов в ключе
            //        break;
            //    case 256: // длина ключа
            //        c = 8; // кол-во слов в ключе
            //        break;
            //}
            c = keyCheck.Length / 4;
            uint[] L = new uint[c];
            for (i = 0; i < c; i++)
            {
                L[i] = BitConverter.ToUInt32(MainKey, i * 4); // разбиваем ключ на слова
            }
            //Сама генерация раундовых ключей в соответствие с документацией
            RoundKey[0] = P32;
            for (i = 1; i < 2 * R + 4; i++)
                RoundKey[i] = RoundKey[i - 1] + Q32; // прибавление к раундовому ключу константу
            uint A, B; // регистры
            A = B = 0;
            i = j = 0;
            int V = 3 * Math.Max(c, 2 * R + 4);  // максимум из раундов или количества слов в ключе
            for (int s = 1; s <= V; s++)
            {
                A = RoundKey[i] = LeftShift((RoundKey[i] + A + B), 3); // сдвиг влево на 3
                B = L[j] = LeftShift((L[j] + A + B), (int)(A + B)); // сдвиг влево на a+b
                i = (i + 1) % (2 * R + 4);
                j = (j + 1) % c;
            }
        }
        // разбивает на массив байтов
        private static byte[] ToArrayBytes(uint[] uints, int Long)
        {
            byte[] arrayBytes = new byte[Long * 4];
            for (int i = 0; i < Long; i++)
            {
                byte[] temp = BitConverter.GetBytes(uints[i]);
                temp.CopyTo(arrayBytes, i * 4);
            }
            return arrayBytes;
        }
        public byte[] EncryptRc6(byte[] byteText)
        {
            uint A, B, C, D;
            //Преобразование полученного текста в массив байт
            //byte[] byteText = Encoding.UTF8.GetBytes(plaintext);
            int i = byteText.Length;
            while (i % 16 != 0)
                i++;
            //Создаем новый массив, кратность рамезрность которого кратна 16, так как алгоритм описывает работу с четырьмя блоками по 4 байта.
            byte[] text = new byte[i];
            //Записываем туда plaintext
            byteText.CopyTo(text, 0);
            byte[] cipherText = new byte[i];
            //Цикл по каждому блоку из 16 байт
            for (i = 0; i < text.Length; i = i + 16)
            {
                //Полученный блок из 16 байт разбиваем на 4 машинных слова(по 32 бита)
                A = BitConverter.ToUInt32(text, i);
                B = BitConverter.ToUInt32(text, i + 4);
                C = BitConverter.ToUInt32(text, i + 8);
                D = BitConverter.ToUInt32(text, i + 12);
                //Сам алгоритм шифрования в соответствии с документацией
                B = B + RoundKey[0];
                D = D + RoundKey[1];
                for (int j = 1; j <= R; j++)
                {
                    uint t = LeftShift((B * (2 * B + 1)), (int)(Math.Log(W, 2)));
                    uint u = LeftShift((D * (2 * D + 1)), (int)(Math.Log(W, 2)));
                    A = (LeftShift((A ^ t), (int)u)) + RoundKey[j * 2];
                    C = (LeftShift((C ^ u), (int)t)) + RoundKey[j * 2 + 1];
                    uint temp = A;
                    A = B;
                    B = C;
                    C = D;
                    D = temp;
                }
                A = A + RoundKey[2 * R + 2];
                C = C + RoundKey[2 * R + 3];
                //Обратное преобразование машинных слов в массив байтов
                uint[] tempWords = new uint[4] { A, B, C, D };
                byte[] block = ToArrayBytes(tempWords, 4);
                //Запись преобразованных 16 байт в массив байт шифр-текста
                block.CopyTo(cipherText, i);
            }
            return cipherText;
        }
        public byte[] DecryptRc6(byte[] cipherText)
        {
            uint A, B, C, D;
            int i;
            byte[] plainText = new byte[cipherText.Length];
            //Разбиение шифр-текста на блоки по 16 байт
            for (i = 0; i < cipherText.Length; i = i + 16)
            {
                //Разбиение блока на 4 машинных слова по 32 бита
                A = BitConverter.ToUInt32(cipherText, i);
                B = BitConverter.ToUInt32(cipherText, i + 4);
                C = BitConverter.ToUInt32(cipherText, i + 8);
                D = BitConverter.ToUInt32(cipherText, i + 12);
                //Сам процесс расшифрования в соответствии с документацией
                C = C - RoundKey[2 * R + 3];
                A = A - RoundKey[2 * R + 2];
                for (int j = R; j >= 1; j--)
                {
                    uint temp = D;
                    D = C;
                    C = B;
                    B = A;
                    A = temp;
                    uint u = LeftShift((D * (2 * D + 1)), (int)Math.Log(W, 2));
                    uint t = LeftShift((B * (2 * B + 1)), (int)Math.Log(W, 2));
                    C = RightShift((C - RoundKey[2 * j + 1]), (int)t) ^ u;
                    A = RightShift((A - RoundKey[2 * j]), (int)u) ^ t;
                }
                D = D - RoundKey[1];
                B = B - RoundKey[0];
                //Преобразование машинных слов обрано в массив байт
                uint[] tempWords = new uint[4] { A, B, C, D };
                byte[] block = ToArrayBytes(tempWords, 4);
                //Запись расшифрованных байт в массив байт расшифрованного текста
                block.CopyTo(plainText, i);
            }
            return plainText;
        }
    }
}
