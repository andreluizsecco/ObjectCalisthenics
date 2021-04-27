namespace DontUseElseKeyword
{
    public class Class1
    {
        public bool AvaliarPermissao(int idade)
        {
            if (idade > 18)
                return true;
            else
                return false;
        }

        public bool AvaliarPermissao2(int idade)
        {
            if (idade > 18)
                return true;
            
            return false;
        }

        public bool AvaliarPermissao3(int idade)
        {
            return idade > 18;
        }
    }
}
