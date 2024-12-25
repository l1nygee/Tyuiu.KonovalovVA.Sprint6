using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KonovalovVA.Sprint6.Task0.V23.Lib
{
    public class DataSerivce : ISprint6Task0V23
    {
        public double Calculate(int x)
        {
            double ans = 0.872;
            ans = Math.Round(Math.Log((x + 1) - Math.Log(x + 2)),3);
            return ans;
        }
    }
}
