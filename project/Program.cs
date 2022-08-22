namespace IndiabixConsoleApplication
{ 
    class index
    {
        protected int count;
        public index()
        {
            count = 0;
        }
    }
    class index1: index
    {
        public void increment()
        {
            count = count +1;
        }
    }
    class MyProgram
    {
        static void Main(string[] args)
        {
            index1 i = new index1(); 
            i.increment(); 
        }
    }
}