namespace ConsoleApp2
{
    internal class Converting
    {
        static void something()
        {
            // to string
            // anta varianle x - uansett datatype (av våre utvalgte)
            var x = true;
            string s = "" + x;
            double d = 99.123;
            string s2 = d.ToString("F");

            // to int
            int i = System.Convert.ToInt32(d);

            float f = System.Convert.ToSingle(i);
            float f2 = System.Convert.ToSingle(d);

            double d2 = System.Convert.ToDouble(s2);


        }
    }
}
