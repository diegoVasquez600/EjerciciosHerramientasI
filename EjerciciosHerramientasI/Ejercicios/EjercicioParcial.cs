using EjerciciosHerramientasI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosHerramientasI.Ejercicios
{
    public class EjercicioParcial
    {
        Pin pin;
        List<int> password;
        int[] genPass;
        public EjercicioParcial()
        {
            pin = new();
            password = new();
            genPass = new int[4];
        }

        public void DecriptPassword()
        {
            Console.WriteLine($"");
            for (int i = 0; i < 10; i++)
            {

            }
        }

        public void GeneratePassword()
        {
            Random random = new();
            int digit = random.Next(0, 9);
            if (password.Contains(digit))
                GeneratePassword();
            else
            {
                password.Add(digit);
                genPass = password.ToArray();
                if (genPass.Length < 4)
                    GeneratePassword();
            }
            DecriptPassword();
        }
            
    }
}
