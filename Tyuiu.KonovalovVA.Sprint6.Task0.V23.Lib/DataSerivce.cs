using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KonovalovVA.Sprint6.Task0.V23.Lib
{
    public class DataSerivce : ISprint6Task0V23
    {
        public double Calculate(int x)
        {
            double ans = 0;
            ans = Math.Log((x + 1) / (x + 2));
            return ans;
        }
    }
}
