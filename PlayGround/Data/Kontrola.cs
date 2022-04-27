using PlayGround.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Data
{
    internal class Kontrola
    {
        public static /*string[]*/ List<string> StolenCars = new List<string>(); /* { "AB123", "AD123", "BB123", "CC123" }*///* 
        public static bool IsLoadedStolenCars = false;
        public static bool CanCheckStonelCars = true;
        public const string stolenCarsPath = @"C:\Users\WKOAEZF\source\repos\PlayGround\PlayGround\SPZ\kradene.txt";
        /// <summary>
        /// Pokud vrati true tak auto neni kradene
        /// </summary>
        /// <param name="Overeni"></param>
        /// <returns></returns>
        public static bool Overeni( Car car) 
        {
            if (!IsLoadedStolenCars  )
            {
                LoadStolenCars(stolenCarsPath);
            }
            //if (car.SPZ == "AB123") puvodni hodnoty, ktere platily když nebylo pole *
                //return true;
            //else
                //return false;
                foreach (string kradena_spz in StolenCars )
            { 
                if (car.SPZ == kradena_spz)
                    return true;
          
           }
           
            return false;
        }    

        public static void LoadStolenCars(string file)
        {
            string[] lines;
            try
            {

               
               lines = File.ReadAllLines(file);
            }
            catch (Exception ex)
            {
                IsLoadedStolenCars = false;
                CanCheckStonelCars = false;
                Console.WriteLine(ex.Message);

                return;
            }

            foreach (string line in lines)
            {
                StolenCars.Add(line);
                
            }
            IsLoadedStolenCars = true;
        }

        internal static bool IsCarStolen(Car c)
        {
            throw new NotImplementedException();
        }
    }
}
