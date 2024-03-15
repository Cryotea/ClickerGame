namespace ClickerGame.Models.Tools;

public interface Tool
{
    public bool IsOwned { get; set; }
    
    public int Level { get; set; }
    
    public int Uses { get; set; }
    
    public int ResourcesHavestet { get; set; }
    
    public void EquipTool(Player player);

    public void OnClick(Player player);
}