using ClickerGame.Models;
using ClickerGame.Models.Resources;
using ClickerGame.Models.Tools;

namespace ClickerGame.ViewModels;

public class MainWindowViewModel : ViewModelBase
{

    public Player player = new Player();

    public string Wood { get; set; } = "Wood : 0";

    public string Stone { get; set; } = "Stone : 0";
    
    
    

    public void ButtonClicked()
    {
        if (player.CurrentTool != null)
        {  
            player.CurrentTool.OnClick(player);
        }
        

        Wood = $"Wood : {player.Wood.Amount}";
        Stone = $"Stone : {player.Stone.Amount}";
        
        RaisePropertyChanged(nameof(Stone));
        RaisePropertyChanged(nameof(Wood));
        
    }

    public void EquipAxe()
    {
        player.ToolInventory.axe.EquipTool(player);
    }

    public void EquipPickAxe()
    {
        player.ToolInventory.pickaxe.EquipTool(player);
    }
    
#pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia!";
#pragma warning restore CA1822 // Mark members as static
}