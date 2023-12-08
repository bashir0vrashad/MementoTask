using MementoTask;

Player player = new Player("Tuncay",  100, 1);


GameManager gameManager = new GameManager();


gameManager.Memento = player.CreateMemento();


player.Health -= 20;
player.Level++;
player.RestoreMemento(gameManager.Memento);
Console.WriteLine("---------------------");

player.Health -= 20;
player.Level++;
gameManager.Memento = player.CreateMemento();
player.RestoreMemento(gameManager.Memento);
