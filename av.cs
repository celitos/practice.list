using System;
using System.IO;
using System.Security.Cryptography;

public class AntiVirus
{
    public static bool CheckFile(string filePath, string knownHash)
    {
        using (var md5 = MD5.Create())
        {
            using (var stream = File.OpenRead(filePath))
            {
                var hash = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                if (hash == knownHash.ToLower())
                {
                    Console.WriteLine("Arquivo seguro!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Arquivo suspeito!");
                    return false;
                }
            }
        }
    }

    public static void Main()
    {
        // Exemplo de uso
        string filePath = "Caminho/Para/Arquivo.exe";
        string knownHash = "4A4DDBF924C1BCF8FA5A2484E3663C53"; // Hash conhecido de um arquivo seguro

        bool isFileSafe = CheckFile(filePath, knownHash);

        if (isFileSafe)
        {
            // O arquivo é seguro, pode executar ações adicionais aqui
        }
        else
        {
            // O arquivo é suspeito, tome as medidas apropriadas aqui
        }
    }
}
