namespace _10_Sobreposicao
{
    public class Mario : Player
    {
        public override void correr (){
            base.correr();
            System.Console.WriteLine("Mario ultrapassa Luigi");
        }
    }
}