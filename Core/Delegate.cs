using System;

namespace Core
{
    public class Delegate
    {
        Show show = null;

        public delegate string Show(string message);

        public string Info(string message)
        {
            return $"Info: {message}";
        }

        public string Warning(string message)
        {
            return $"Warning {message}";
        }

        public Delegate()
        {
            show = Info;
        }

        public void TestDelegate(string message)
        {
            if (show != null)
            {
                show(message); // cach 1
            }
            show?.Invoke(message); // cach 2
        }

        public void TestAction(string param1, int param2)
        {
        }

        public void TestDelegateNoiNhieuMethod()
        {
            show += Info;
            show += Warning;
            show += Warning;

            // Goi Warning 2 lan

            show.Invoke("Me");

            Action<string, int> action = TestAction;
            //action += method...
        }

        public string TestFunc(double d1, double d2)
        {
            return "Return Value";
        }

        public void TestFunc()
        {
            // param cuoi cung la return value
            Func<double, double, string> func = null;
            func = TestFunc;

            string reaturnValue = func.Invoke(1.5,1.3);
        }
    }
}