using System;
using System.Configuration.Install;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class Program
{
    public static void Main()
    {
    }

    public class Code
    {
        public static void Exec()
        {   
            var message = "Hello World"; 
            var title = "Hello World Message Box";
            MessageBox.Show(message, title);  
        }
    }
}