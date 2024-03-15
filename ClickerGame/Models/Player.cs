using ClickerGame.Models.Resources;
using ClickerGame.Models.Tools;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ClickerGame.Models;

public class Player
{
    public ToolInventory ToolInventory { get; set; } = new ToolInventory();

    public Wood Wood { get; set; } = new Wood();
    public Stone Stone { get; set; } = new Stone();

    public Tool CurrentTool { get; set; } 
}