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
        List<int> insertedPin;
        int[] genPass;
        public EjercicioParcial()
        {
            pin = new();
            password = new();
            insertedPin = new();
            genPass = new int[4];
        }

        public void DecriptPassword(int intentos)
        {
            if (intentos >= 10)
            {
                Console.WriteLine($"Has superado el numero maximo de intentos\n");
                TryAgain();
            }
            else
            {
                intentos += 1;
                insertedPin.Clear();
                Console.WriteLine($"Ingrese el PIN (4 digitos): ");
                var digitos = Console.ReadLine();
                for (int i = 0; i < 4; i++)
                    insertedPin.Add(int.Parse(digitos[i].ToString()));
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (insertedPin[j] == password[k] && insertedPin[j] != (password[j]))
                        {
                            Console.WriteLine($"-");
                        }
                    }
                    if (insertedPin[j].Equals(password[j]))
                    {
                        Console.WriteLine($"+ {insertedPin[j]} {password[j]}");
                    }

                }
                DecriptPassword(intentos);
            }
        }

        private void TryAgain()
        {
            Console.WriteLine("¿Deseas volver a intentarlo?\n" +
                    "1) Si\n" +
                    "2) No\n");
            var opt = int.Parse(Console.ReadLine());
            if (opt == 1)
            {
                password.Clear();
                GeneratePassword();
            }
            else if (opt == 2)
            {
                Console.WriteLine($"Hasta luego\n");
                return;
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
        }
            
    }
}
