// void numbersfromNtoone(int N)
// {
//    if (N >= 1)
//    {
//         System.Console.WriteLine(N);
//         N = N-1;
//         numbersfromNtoone(N);
//    }
// }
// numbersfromNtoone(5);




// int sumfromMtoN(int m, int n)
// {int sum = m;
//     if (m<n)
//     {   m += 1;
//         sum = sum+sumfromMtoN(m, n);
//         return sum;
//     }
//     else
//     {
//         return sum;
//     }
// }
// int a = 1;
// int b = 15;
// System.Console.WriteLine($"{a}, {b} -> {sumfromMtoN(a, b)}"); 


//  int Ack(int m, int n)
//  {if (m == 0 && n>0)
//      {
//          return n+1;
//      }
//      else if(m>0 && n==0)
//      {
//          return Ack(m-1, 1);
//      }
//     else
//      {
//         return Ack(m-1, Ack(m, n-1));
//      }
//  }
//  int a = 3;
//  int b = 2;
//  System.Console.WriteLine(Ack(a,b));