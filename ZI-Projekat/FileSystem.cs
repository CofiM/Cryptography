using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

namespace ZI_Projekat
{
    class FileSystem
    {
        private string outputDirectory;
        //private bool isWatcherOn;
        //private bool algorythm; //rc-0 //tea-1
        public bool rc6;  //tea 
        public bool knapsack;  //tea 
        public bool bifid;  //tea 
        // private byte[] hashCRC32;
        //private string watchedDirectory;
        //private int BmpWidth, BmpHeight;
        public string key;
        public bool blockMode;

        public bool Rc6
        {
            get { return rc6; }
            set { rc6 = value; }
        }
        public bool Knapsack
        {
            get { return knapsack; }
            set { knapsack = value; }
        }
        public bool Bifid
        {
            get { return bifid; }
            set { bifid = value; }
        }
        public bool BlockMode
        {
            get { return blockMode; }
            set { blockMode = value; }
        }
        public FileSystem()
        {
            
        }
        public void SetOutputDirectory(string dir)
        {
            outputDirectory = dir;
        }
        public void SetKey(string k)
        {
            key = k;
        }
        public void EncodeFileFromPath(string path)
        {
            //byte[] all_bytes = ReadBinaryFile(path);
            //this.hashCRC32 = Crc32.Hash(all_bytes); //4*8 = 32 => Crc32

            if (outputDirectory.Length == 0)
                throw new Exception("Destination folder not set!");
            if (path.EndsWith(".txt"))
                EncodeTextFile(path, outputDirectory);
            else if (path.EndsWith(".bmp"))
                EncodeBmpFile(path, outputDirectory);
        }                                   //"C:\\Users\\asina\\Desktop\\zastita src\\ananas.txt        "C:\\Users\\asina\\Desktop\\zastita src
        private bool EncodeTextFile(string fullFileName, string outputDirectory)
        {
            string textForCoding = ReadTextFile(fullFileName);
            if (Rc6)
            {
                //string outputFileName1 = fullFileName.Remove(fullFileName.Length - 4, 4) + "Enc.rc6"; //string outputFileName = fullFileName.Remove(fullFileName.Length - 4, 4) + "Enc.rc4";
                //int lastBackslashIndex = outputFileName1.LastIndexOf('\\');

                //string outputFileName = fullFileName;
                //if (lastBackslashIndex >= 0)
                //{
                //    outputFileName = outputDirectory + "\\" + outputFileName1.Substring(lastBackslashIndex + 1);
                //}
                //RC4 rc4 = RC4.GetInstance();
                //byte[] encodedText = rc4.EncodeStream(textForCoding);

                //WriteToBinaryFile(outputFileName, encodedText);

                //return true;

                string outputFileName = outputDirectory + "\\Encrypted.txt";  //fullFileName.Replace(".txt", " Encrypted.txt");

                RC6 rc = new RC6(Encoding.UTF8.GetBytes(key));
                byte[] byteText = Encoding.UTF8.GetBytes(textForCoding);
                //string encodedText = Encoding.Default.GetString(rc.EncryptRc6(byteText));
                byte[] encoded = rc.EncryptRc6(byteText);
                //WriteToTextFile(outputFileName, encodedText);
                WriteToBinaryFile(outputFileName, encoded);

                return true;
            }
            else if(Bifid)
            {
                string outputFileName = outputDirectory + "\\Encrypted.txt";

                List<string> encryptedFileLines = new List<string>();
                Bifid cryptoAlgorithmBifid = new Bifid();
                encryptedFileLines.AddRange(cryptoAlgorithmBifid.Encrypt(fullFileName, textForCoding));

                WriteIntoDestinationFile(encryptedFileLines, outputFileName);

                return true;

            }
            else if (Knapsack)
            {
                string outputFileName = outputDirectory + "\\Encrypted.txt";

                List<string> encryptedFileLines = new List<string>();
                Knapsack cryptoAlgorithmKnapsack = new Knapsack();
                cryptoAlgorithmKnapsack.blockMode = BlockMode;
                encryptedFileLines.AddRange(cryptoAlgorithmKnapsack.Encrypt(fullFileName, textForCoding));

                WriteIntoDestinationFile(encryptedFileLines, outputFileName);

                return true;

            }
            return false;
            //else
            //{
            //    string outputFileName1 = fullFileName.Remove(fullFileName.Length - 4, 4) + "Enc.tea"; //string outputFileName = fullFileName.Remove(fullFileName.Length - 4, 4) + "Enc.rc4";
            //    int lastBackslashIndex = outputFileName1.LastIndexOf('\\');

            //    string outputFileName = fullFileName;
            //    if (lastBackslashIndex >= 0)
            //    {
            //        outputFileName = outputDirectory + "\\" + outputFileName1.Substring(lastBackslashIndex + 1);
            //    }

            //    //TEA tea = ZI_RC4_TEA.TEA.GetInstance();
            //    //string encodedText = tea.Encrypt(textForCoding);

            //    //WriteToTextFile(outputFileName, encodedText);

            //    return true;
            //}

        }


        public string DecodeFile(string fullFileName)
        {
            if (fullFileName.Contains(".bmp"))
            {
                string OrgImgFileName = DecodeBmpFile(fullFileName, outputDirectory);
                return OrgImgFileName;
            }
            else if (Rc6)
            {
                string outputFileName = outputDirectory + "\\Decrypted.txt";

                RC6 rc = new RC6(Encoding.UTF8.GetBytes(key));
                byte[] all_bytes = ReadBinaryFile(fullFileName);
                string decodedText = Encoding.Default.GetString(rc.DecryptRc6(all_bytes));

                WriteToTextFile(outputFileName, decodedText);
                //File.WriteAllText("C:\\Users\\katar\\OneDrive\\Desktop\\Zastita informacija MOJ PROJEKAT\\testDecrypt.txt", text);
            }
            else if(Bifid)
            {
                string outputFileName = outputDirectory + "\\Decrypted.txt";
                bool sameHashes;
                List<string> decrytedFileLines;
                Bifid cryptoAlgorithmBifid = new Bifid();
                //string text = ReadTextFile(fullFileName);
                List<string> text = ReadFromDecryptedFile(fullFileName);
                decrytedFileLines = cryptoAlgorithmBifid.Decrypt(fullFileName, out sameHashes, text);

                if (!sameHashes)
                {
                    if (Knapsack)
                        MessageBox.Show("Hash values were not the same. This could be due to the nature of the algorithm.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Hash values were not the same.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                WriteIntoDestinationFile(decrytedFileLines, outputFileName);
            }
            else if (Knapsack)
            {
                string outputFileName = outputDirectory + "\\Decrypted.txt";
                bool sameHashes;
                List<string> decrytedFileLines;
                Knapsack cryptoAlgorithmKnapsack = new Knapsack();
                cryptoAlgorithmKnapsack.blockMode = BlockMode;
                //string text = ReadTextFile(fullFileName);
                List<string> text = ReadFromDecryptedFile(fullFileName);
                decrytedFileLines = cryptoAlgorithmKnapsack.Decrypt(fullFileName, out sameHashes, text);

                if (!sameHashes)
                {
                    if (Knapsack)
                        MessageBox.Show("Hash values were not the same. This could be due to the nature of the algorithm.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Hash values were not the same.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                WriteIntoDestinationFile(decrytedFileLines, outputFileName);
            }
           
            //if (fullFileName.Contains("Enc.rc4"))
            //{
            //    int lastBackslashIndex = fullFileName.LastIndexOf('\\');

            //    // Extract the portion of the string after the last '\' character
            //    string charsAfterLastBackslash = fullFileName.Substring(lastBackslashIndex + 1);

            //    string outputFileName = targetFolder + "\\" + charsAfterLastBackslash.Remove(charsAfterLastBackslash.Length - 7, 7) + "DecRC4.txt";

            //    byte[] codedText = ReadBinaryFile(fullFileName);

            //    var rc4 = RC4.GetInstance();
            //    string decodedText = rc4.DecodeStream(codedText);

            //    WriteToTextFile(outputFileName, decodedText);

            //    return outputFileName;
            //}
            //else if (fullFileName.Contains("Enc.tea"))
            //{
            //    int lastBackslashIndex = fullFileName.LastIndexOf('\\');
            //    string charsAfterLastBackslash = fullFileName.Substring(lastBackslashIndex + 1);

            //    string outputFileName = targetFolder + "\\" + charsAfterLastBackslash.Remove(charsAfterLastBackslash.Length - 7, 7) + "DecTEA.txt";

            //    string codedText = ReadTextFile(fullFileName);

            //    var TEA = ZI_RC4_TEA.TEA.GetInstance();


            //    string decodedText = TEA.Decrypt(codedText);

            //    WriteToTextFile(outputFileName, decodedText);

            //    return outputFileName;
            //}
            //else if (fullFileName.Contains("Cbc.tea"))
            //{
            //    int lastBackslashIndex = fullFileName.LastIndexOf('\\');
            //    string charsAfterLastBackslash = fullFileName.Substring(lastBackslashIndex + 1);

            //    string outputFileName = targetFolder + "\\" + charsAfterLastBackslash.Remove(charsAfterLastBackslash.Length - 7, 7) + "Cbc.txt";

            //    string codedText = ReadTextFile(fullFileName);


            //    //var CBC_Instacne = CBC_Class.GetInstance();

            //    string decodedText = CBC_Class.GetInstance().ENC_DEC("decoding", false);

            //    WriteToTextFile(outputFileName, decodedText);

            //    return outputFileName;
            //}
            //else if (fullFileName.Contains(".bmp"))
            //{
            //    string OrgImgFileName = DecodeBmpFile(fullFileName, targetFolder);
            //    return OrgImgFileName;
            //}

            return "";


        }

        private string ReadTextFile(string path)
        {
            //ReadBinaryFile(path); //zasto uopste onda ovo koristim
            //using StreamReader sr = new(path);
            //return sr.ReadToEnd().ToString();
            string text = File.ReadAllText(path);
            return text;
        }

        private byte[] ReadBinaryFile(string path)
        {
            //long fileLength = new FileInfo(path).Length;
            //FileStream fs = new(path, FileMode.Open, FileAccess.Read);
            //using BinaryReader br = new(fs);
            //byte[] all_bytes = br.ReadBytes((int)fileLength);
            //return all_bytes;
            //long fileLength = new FileInfo(path).Length;
            //FileStream fs = File.OpenRead(path);
            //byte[] all_bytes = File.ReadAllBytes(path);
            long fileLength = new FileInfo(path).Length;
            BinaryReader br = new BinaryReader(File.OpenRead(path));
            byte[] all_bytes = br.ReadBytes((int)fileLength);
            return all_bytes;

        }

        private static void WriteToTextFile(string path, string content)
        {
            //FileStream fs = null;
            //try
            //{
            //    fs = new FileStream(path, FileMode.OpenOrCreate);
            //    using StreamWriter sw = new(fs);
            //    sw.Write(content);
            //}
            //finally
            //{
            //    if (fs != null)
            //        fs.Dispose();
            //}
            
            //try
           // {
                if(!File.Exists(path))
                {
                   using(StreamWriter sw = File.CreateText(path))
                   {
                        sw.Write(content);
                   }
                }
          //  }
           // finally
           // {
            //    if (fs != null)
             //       fs.Dispose();
           // }
        }
        private List<string> ReadFromDecryptedFile( string fileName)
        {
            List<string> lines = new List<string>();

            using (StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite), Encoding.Unicode))
            {
                string line = sr.ReadLine();
                while (!String.IsNullOrEmpty(line))
                {
                    lines.Add(line);
                    line = sr.ReadLine();
                }
            }

            return lines;
        }
        private static void WriteIntoDestinationFile(List<string> fileLines, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite), Encoding.Unicode))
            {
                foreach (var item in fileLines)
                {
                    sw.WriteLine(item);
                }
            }
        }
        private static void WriteToBinaryFile(string path, byte[] content)
        {
            //FileStream fs = null;
            //try
            // {
            //  fs = new FileStream(path, FileMode.Create);
            //  using BinaryWriter bw = new(fs);
            //  bw.Write(content, 0, content.Length);

            // }
            // finally
            // {
            //     if (fs != null)
            //        fs.Dispose();
            // }

            File.WriteAllBytes(path, content);
        }

        //public bool IsValidCrc32(string path)
        //{
        //    // Compute the CRC of the transmitted file
        //    byte[] transmittedFileBytes = File.ReadAllBytes(path);
        //    byte[] transmittedHash = Crc32.Hash(transmittedFileBytes);

        //    if (hashCRC32 != null && transmittedHash.SequenceEqual(hashCRC32))  //deep check
        //        return true;
        //    else
        //        return false;
        //}


        //public byte[] ReadBMP(string filePath)
        //{

        //    byte[] byte_data;

        //    // Open the file in a binary reader
        //    using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        //    {
        //        // Skip the header and any other non-image data
        //        reader.BaseStream.Seek(54, SeekOrigin.Begin);

        //        // Read the image data
        //        byte_data = reader.ReadBytes((int)(reader.BaseStream.Length - reader.BaseStream.Position));

        //    }

        //    //taking the data from the header of the BMP image
        //    Bitmap bitmap = new Bitmap(filePath);
        //    BitmapData data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

        //    // Access the header information using the properties of the BitmapData object
        //    this.BmpWidth = data.Width;
        //    this.BmpHeight = data.Height;
        //    int stride = data.Stride;
        //    PixelFormat pixelFormat = data.PixelFormat;

        //    // Unlock the bits of the image
        //    bitmap.UnlockBits(data); //nzm sta ce mi ovo

        //    return byte_data;
        //}
        public void EncodeBmpFile(string fullFileName, string outputDirectory)
        {
            byte[] all_data = File.ReadAllBytes(fullFileName);
            byte[] header = new byte[54];
            Array.Copy(all_data, header, 54);

            //Enkriptuje podatke o pikselima
            //var rc4 = RC4.GetInstance();            //skipujemo header
            // byte[] data = rc4.Run(all_data.Skip(54).ToArray());

            RC6 rc = new RC6(Encoding.UTF8.GetBytes(key));
            //byte[] byteText = Encoding.UTF8.GetBytes(textForCoding);
            //string encodedText = Encoding.Default.GetString(rc.EncryptRc6(byteText));
            byte[] data = rc.EncryptRc6(all_data.Skip(54).ToArray());
            //WriteToTextFile(outputFileName, encodedText);
            //WriteToBinaryFile(outputFileName, encoded);

            // Spajamo header i enkriptovane podatke u novi niz bajtova
            byte[] encryptedData = new byte[header.Length + data.Length];//duzina header-a i tela, naravno
            Array.Copy(header, encryptedData, header.Length); //u encryptedData iskopiraj header
            Array.Copy(data, 0, encryptedData, header.Length, data.Length); //u encryptedData iskopiraj data, pocevsi od 54 indexa

            using (MemoryStream stream = new MemoryStream(encryptedData))
            {
                Bitmap image = new Bitmap(stream);
                string outputFileName1 = fullFileName.Remove(fullFileName.Length - 4, 4) + "Enc.bmp"; //string outputFileName = fullFileName.Remove(fullFileName.Length - 4, 4) + "Enc.rc4";
                int lastBackslashIndex = outputFileName1.LastIndexOf('\\');

                string outputFileName = fullFileName;
                if (lastBackslashIndex >= 0)
                {
                    outputFileName = outputDirectory + "\\" + outputFileName1.Substring(lastBackslashIndex + 1);
                }
                image.Save(outputFileName);
            }

        }

        public string DecodeBmpFile(string fullFileName, string outputDirectory)
        {
            byte[] all_data = File.ReadAllBytes(fullFileName);
            byte[] header = new byte[54];
            Array.Copy(all_data, header, 54);

            //Decrypting the pixels
            //var rc4 = RC4.GetInstance(); //skipping header
            //byte[] data = rc4.Run(all_data.Skip(54).ToArray());
            RC6 rc = new RC6(Encoding.UTF8.GetBytes(key));
            //byte[] all_bytes = ReadBinaryFile(fullFileName);
            byte[] data = rc.DecryptRc6(all_data.Skip(54).ToArray());

            //WriteToTextFile(outputFileName, decodedText);

            //Concate header and Decrypted pixels into new array
            byte[] decryptedData = new byte[header.Length + data.Length];//duzina header-a i tela, naravno
            Array.Copy(header, decryptedData, header.Length); //u encryptedData iskopiraj header
            Array.Copy(data, 0, decryptedData, header.Length, data.Length); //u encryptedData iskopiraj data, pocevsi od 54 indexa

            using (MemoryStream stream = new MemoryStream(decryptedData))
            {
                Bitmap image = new Bitmap(stream);
                //string outputFileName = fullFileName.Remove(fullFileName.Length - 7, 7) + "Dec.bmp";

                string outputFileName1 = fullFileName.Remove(fullFileName.Length - 7, 7) + "Dec.bmp"; //string outputFileName = fullFileName.Remove(fullFileName.Length - 4, 4) + "Enc.rc4";
                int lastBackslashIndex = outputFileName1.LastIndexOf('\\');

                string outputFileName = fullFileName;
                if (lastBackslashIndex >= 0)
                {
                    outputFileName = outputDirectory + "\\" + outputFileName1.Substring(lastBackslashIndex + 1);
                }

                image.Save(outputFileName);
                return outputFileName;
            }

        }

        public void Parallel_Loading(List<string> PathLines, int Number_of_Threads)
        {
            int numThreads = Number_of_Threads;

            ParallelOptions options = new ParallelOptions();
            options.MaxDegreeOfParallelism = numThreads;

            Parallel.ForEach(PathLines, options, line => {
                if (!File.Exists(line))
                {
                    MessageBox.Show("Invalid file path:\n" + line, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //fs.SetOutputDirectory(this.directory);
                //EncodeFileFromPath(line);
                string textForCoding = ReadTextFile(line);
                // Parallelize_Encoding(Number_of_Threads, text);

                // string outputFileName = outputDirectory + "\\Encrypted.txt";  //fullFileName.Replace(".txt", " Encrypted.txt");
                string outputFileName = line.Replace(".txt", "Encrypted.txt");

                RC6 rc = new RC6(Encoding.UTF8.GetBytes(key));
                byte[] byteText = Encoding.UTF8.GetBytes(textForCoding);
                //string encodedText = Encoding.Default.GetString(rc.EncryptRc6(byteText));
                byte[] encoded = rc.EncryptRc6(byteText);

                WriteToBinaryFile(outputFileName, encoded);

            });
        }
        //public string Parallelize_Encoding(int BROJ_NITI, string org_text)
        //{
        //    //fs.Rc6 = true;
        //    //fs.SetKey("kacam");
        //    //fs.SetOutputDirectory(this.directory);
        //    //fs.EncodeFileFromPath(this.file);
        //    //fs.Rc6 = false;

        //    //CBC_Class cbc = CBC_Class.GetInstance();
        //    string outputFileName = outputDirectory + "\\Encrypted.txt";  //fullFileName.Replace(".txt", " Encrypted.txt");

        //    RC6 rc = new RC6(Encoding.UTF8.GetBytes(key));
        //    byte[] byteText = Encoding.UTF8.GetBytes(textForCoding);
        //    //string encodedText = Encoding.Default.GetString(rc.EncryptRc6(byteText));
        //    byte[] encoded = rc.EncryptRc6(byteText);
        //    //WriteToTextFile(outputFileName, encodedText);
        //    WriteToBinaryFile(outputFileName, encoded);

        //    return true;

        //    string encoded = String.Empty;
        //    //string org_text = tbOrgText.Text;
        //    int n = org_text.Length;
        //    int i = 0;
        //    for (; i == 0 || i < n;)
        //    {
        //        // create a list of delegate methods to invoke in parallel
        //        List<Action> actions = new List<Action>();

        //        if (i + 8 >= n)
        //        {
        //            // actions.Add(() => encoded += cbc.ENC_DEC(org_text.Substring(i, n - i)));
        //            actions.Add(() => encoded += cbc.ENC_DEC(org_text.Substring(i, n - i)));
        //        }
        //        else
        //        {
        //            //actions.Add(() => encoded += cbc.ENC_DEC(org_text.Substring(i, 8)));
        //        }

        //        // invoke the delegate methods in parallel, using numThreads threads
        //        Parallel.Invoke(new ParallelOptions { MaxDegreeOfParallelism = BROJ_NITI }, actions.ToArray());

        //        i += 8;
        //    }
        //    return encoded.ToString();
        //}

        //public void Parallel_Writing(string[] PathLines, int Number_of_Threads)
        //{
        //    int numThreads = Number_of_Threads;

        //    ParallelOptions options = new ParallelOptions();
        //    options.MaxDegreeOfParallelism = numThreads;

        //    Parallel.ForEach(PathLines, options, line => {
        //        if (!File.Exists(line))
        //        {
        //            MessageBox.Show("Invalid file path:\n" + line, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        fs.DecodeFile(this.file);
        //    });
        //}
    }
}
