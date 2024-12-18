namespace School.Api
{
    public static class Calculate
    {
        public static int Calc(int x, int y)
        {
            return x * y;
        }

        public static async Task<int> CalcAsync(int x, int y)
        {
            int z = await Task.Run(() => Calc(x, y));
            return z;
        }
    }
}
