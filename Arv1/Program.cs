
namespace Arv1
{
    /// <summary>
    /// 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //A a = new A(1);
            B b = new B(1);
            //C c = new C();

            A a  = new A(1);
            a.Test2(2, "lflkgkhfæ");

        }
    }


    /// <summary>
    /// Dette er klasse A
    /// </summary>
    class A {
        
        /// <summary>
        /// 
        /// </summary>
        public int felt1;

        /// <summary>
        /// 
        /// </summary>
        private int felt2;
        protected int felt3;

        public A()
        {
            Console.WriteLine("A");
        }
        public A(int felt1)
        {
            // lsdkfj
            Console.WriteLine("A med felt1");
        }

        /// <summary>
        /// Dette er Test1
        /// </summary>
        public void Test1()
        {
            this.felt2 = 1;
            this.felt3 = 2;

        }

        /// <summary>
        /// Dette er Test2
        /// </summary>
        /// <param name="a">a....</param>
        /// <param name="b">b....</param>
        public void Test2(int a, string b)
        {
            this.felt2 = 1;
            this.felt3 = 2;

        }


    }



    class B : A {

        public void Test2() { 
            this.felt1 = 2;
            this.felt3 = 3;
        }

        public B(int felt1) : base(felt1)
        {
            // slkdjfælaskdjfsldkf

        }

        public B()
        {
            Console.WriteLine("B");
        }
    }

    class C : B {
        public C()
        {
            Console.WriteLine("C");
        }
    }
}