using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Solucion_Lab_21_abril
{
    public class User
    {
        public delegate void EmailVerifiedEventHandler(object source, EmailVerifiedEventArgs args);

        public event EmailVerifiedEventHandler EmailVerified;

        public virtual void OnEmailVerified()
        {
            if (EmailVerified != null)
            {
                EmailVerified(this, new EmailVerifiedEventArgs());
            }
        }

        public virtual void OnEmailSent(object source, EmailSentEventArgs e)
        {
            Console.WriteLine("Deseas verificar tu correo?");
            Console.WriteLine("1: si");
            Console.WriteLine("2: no");
            string x = Console.ReadLine();
            if (x == "1")
            {
                OnEmailVerified();
                Thread.Sleep(2000);
            }
            else if (x == "2")
            {
                Console.WriteLine("Podras hacer esta operacion más tarde");
                Thread.Sleep(2000);
            }
        }
    }
}
