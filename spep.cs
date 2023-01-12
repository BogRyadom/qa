 static int Step(int a, int b)
        {
 
            int per = a;

            for (int i = 1; i < b; i++)
            {
                a *= per;
            }
            return a;
        }