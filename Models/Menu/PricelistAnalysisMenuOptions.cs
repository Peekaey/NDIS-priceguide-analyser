using System.ComponentModel;

namespace PricelistGenerator.Models.Menu;

public enum PricelistAnalysisMenuOptions
{
    [Description("Preview All Changes")]
    PreviewChanges = 1,
    [Description("Export To Excel file")]
    ExportToExcel= 2,
    [Description("Return To Main Menu")]
    ReturnMainMenu = 3,
    
}