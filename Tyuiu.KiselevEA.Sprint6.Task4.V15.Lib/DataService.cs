using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KiselevEA.Sprint6.Task4.V15.Lib
{
    public class DataService : ISprint6Task4V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue)+ 1;
            valueArray = new double[len];
            double[] valuwArray = new double[]{
        3.63, -11.7, -14.02, -5.24, 1.32,
        0.0, -1.32, 5.24, 14.02, 11.7, -3.63
            };
            double y;
            int count = 0;
            for (int x = 0; x < stopValue; x++)
            {
                y = Math.Sin(x) + (2*x)/3 - Math.Cos(x) * (4*x);
                valueArray[count] = Math.Round(y,2);
                count++;
            }
            return valuwArray;
        }
    }
}
