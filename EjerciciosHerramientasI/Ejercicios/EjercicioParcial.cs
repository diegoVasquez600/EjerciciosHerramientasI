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

        public void DecriptPassword(int option)
        {

        }

        public void GeneratePassword()
        {
            Random random = new();
            int digit = random.Next(0,9);
            if (password.Contains(digit))
            {
                password.Add(digit);
            }
        }
    }
}
