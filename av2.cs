using System;
using System.IO;
using System.Security.Cryptography;

public class FileAnalyzer
{
    public static string CalculateMD5(string filePath)
    {
        using (var md5 = MD5.Create())
        {
            using (var stream = File.OpenRead(filePath))
            {
                var hash = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                return hash;
            }
        }
    }

    public static void Main()
    {
        // Exemplo de uso
        string filePath = "Caminho/Para/Arquivo.exe";

        if (File.Exists(filePath))
        {
            string md5Hash = CalculateMD5(filePath);
            Console.WriteLine("Hash MD5 do arquivo: " + md5Hash);
        }
        else
        {
            Console.WriteLine("O arquivo não existe!");
        }
    }
}
