using APIEExamples;

Game loz = new Game();
loz.Play(3);
Movie Batman = new Movie();
Batman.Play();
Batman.Title = "The Batman";
loz.ChangeTitle(Batman.Title);
Batman.ChangeTitle("The Dark Knight Rises");