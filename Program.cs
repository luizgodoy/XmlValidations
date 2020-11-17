using System;
using System.IO;

namespace XmlValidations
{
    class Program
    {
        static void Main(string[] args)
        {   
            if(args.Length.Equals(2))
            {
                if (!args[0].ToUpper().Contains("XML"))
                    throw new Exception("O primeiro arquivo deve ser um .XML.");

                if(!args[1].ToUpper().Contains("XSD"))
                    throw new Exception("O segundo arquivo deve ser um .XSD.");

                XmlValidations.ValidateWithXSD(Path.GetFullPath(args[0]), Path.GetFullPath(args[1]));
            }
            else if(!args.Length.Equals(2))
            {
                throw new Exception("\nQuantida de parâmetros inválidos!\nInforme o nome do arquivo .XML e o nome do arquivo .XSD.");
            }
        }
    }
}
