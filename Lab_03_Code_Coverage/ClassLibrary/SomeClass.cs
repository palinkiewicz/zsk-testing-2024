namespace ClassLibrary
{
    public class SomeClass : ISomeClass
    {
        public int SomeMethod(int x)
        {
            if (x < 0)
            {
                return -1;
            }
            else if (x == 1)
            {
                return 10;
            }
            else
            {
                return x * 100;
            }
        }
    }

    public interface ISomeClass
    {
        int SomeMethod(int x);
    }
}
