namespace ClickerGame.Models.Tools;

public class Pickaxe : Tool
{
    public Pickaxe(bool isOwned)
    {
        IsOwned = isOwned;
    }
    
    public bool IsOwned { get; set; }

    public int Level { get; set; }
    
    public int Uses { get; set; }

    public int ResourcesHavestet { get; set; }

    public void EquipTool(Player player)
    {
        player.CurrentTool = player.ToolInventory.pickaxe;
    }

    public void OnClick(Player player)
    {
        player.Stone.Amount++;
        this.Uses++;
    }
}