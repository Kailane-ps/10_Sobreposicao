namespace _10_Sobreposicao
{   
    public class Luigi : Player
    {
         public override void pular(){
            base.pular();
            System.Console.WriteLine("e voltou a liderança");
        }
    }
}