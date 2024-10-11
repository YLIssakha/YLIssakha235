class Book{

    private string book_title;

    private List<Chapter> Chapters;

    public Book(string book_title){
        this.book_title = book_title;
        this.Chapters = new List<Chapter>();

    }

    public string Title{
        get { return book_title;}

    }

    public void addChapter( int Number, string title){
        Chapter.add( new Chapter(title, number));
    }


    // private string Chapters_as_str(){
    //     res += Chapter
    // }


}