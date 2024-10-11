public class Die
{
    public readonly int nbFaces; // constante
    private int visibleFace;
    private static Random generator = new Random();

    public int VisibleFace
    {
        get
        {
            return visibleFace;
        }
    }

    public Die() : this(6){} // appel de l'autre constructeur

    public Die(int faces)
    {
        nbFaces = faces;
        Roll();
    }

    public void Roll()
    {
        visibleFace = generator.Next(nbFaces) + 1;
    }
}



