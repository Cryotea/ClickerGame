namespace ClickerGame.Models.Tools;

public class Axe : Tool
{
    public Axe(bool isOwned)
    {
        IsOwned = isOwned;
    }
    public bool IsOwned { get; set; } 

    public int Level { get; set; }
    
    public int Uses { get; set; }

    public int ResourcesHavestet { get; set; }

    public void EquipTool(Player player)
    {
        player.CurrentTool = player.ToolInventory.axe;
    }
    
    public void OnClick(Player player)
    {
        player.Wood.Amount++;
        this.Uses++;
    }
}