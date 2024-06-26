using PricelistGenerator.Models;
using PricelistGenerator.Models.ExportAnalysisChanges;

namespace PricelistGenerator.Interfaces;

public interface IPricelistAnalysisService
{
    public PricelistAnalysisCatalog PopulateNDISSupportCatalogue(NdisSupportCatalogue oldNdisSupportCatalog,
        NdisSupportCatalogue newNdisSupportCatalogue
        , PricelistAnalysisCatalog pricelistAnalysisCatalog);
    
    public ExportAnalysisChanges MapPricelistAnalysisCatalogToExportAnalysis( 
        PricelistAnalysisCatalog pricelistAnalysisCatalog);
}