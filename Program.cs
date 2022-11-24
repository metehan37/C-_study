namespace C__study;
class Program
{
    static void Main(string[] args)
    {
        // Ödev1

        //  1.Soru
         Console.Write("Kaç sayı gireceksin? ");
         string first = Console.ReadLine();
         bool sonuc = int.TryParse(first,out int outFirst);
         int[] sayilar=new int[outFirst];
         for(int i=1;i<outFirst+1;i++){
             Console.Write("{0}. sayıyı giriniz: ",i);
             sayilar[i-1]= int.Parse(Console.ReadLine());
         }
         Console.Write("Çift olanlar :");
         for(int j=0;j<outFirst;j++){
             if (sayilar[j] %2==0)Console.Write(" "+sayilar[j]);
         }

        // 2.Soru
         Console.Write("Kaç sayı gireceksin? ");
         int n= int.Parse(Console.ReadLine());
         Console.Write("Hangi sayı ile karşılaştıracağız ? ");
         int m= int.Parse(Console.ReadLine());
         int[] sayilar1=new int[n];
         for (int i= 1;i<n+1;i++){
             Console.Write("{0}. Sayı: ",i);
             sayilar1[i-1]=int.Parse(Console.ReadLine());
         }
         for (int j = 0; j < n; j++)
         {
             if(sayilar1[j] % m==0 || sayilar1[j]==m){
                 Console.WriteLine(sayilar1[j]);
             }
         }

        // 3.soru
         Console.Write("Kaç Kelime Gireceksin? ");
         int n1= int.Parse(Console.ReadLine());
         string[] kelimeler=new string[n1];
         for (int i = 0; i < n1; i++)
         {
             Console.Write("{0}. kelimeyi giriniz: ",i+1);
             kelimeler[i]=Console.ReadLine();
         }
         for (int j = 0; j < n1; j++)
         {
             Console.Write(kelimeler[n1-1-j]);
         }

        // 4.soru
        Console.Write("Bir cümle giriniz: ");
        string cumle=Console.ReadLine();
        string[] kelimeler1 = cumle.Split(' ');
        int toplamharf=0;
        for (int i = 0; i < kelimeler1.Length; i++){
            toplamharf += kelimeler1[i].Length;
        }
        Console.WriteLine("Bu cümlede {0} adet kelime ve {1} adet harf vardır.",kelimeler1.Length,toplamharf);
    }
}
