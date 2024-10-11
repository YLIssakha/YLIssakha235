public class PairOfDice
{
    private readonly int nbFaces;
    private int visibleFace1, visibleFace2;
    private static Random generator = new Random();

    public PairOfDice(int faces)
    {
        nbFaces = faces;
        visibleFace1 = generator.Next(nbFaces) + 1;
        visibleFace2 = generator.Next(nbFaces) + 1;
        
    }

    public void PrintFaces()
    {
        Console.WriteLine(string.Format("{0}, {1}", visibleFace1, visibleFace2));
        
    }
}