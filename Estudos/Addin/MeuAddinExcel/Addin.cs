using System.IO;
using System.Xml.Linq;
using ExcelDna.Integration;

public class FuncoesExcel
{
    [ExcelFunction(Description = "Soma dois números")]
    public static double Soma(double a, double b)
    {
        return a + b;
    }

    [ExcelFunction(Description = "Gera o XML")]
    public static string GerarXmlProduto(string id, string nomeProduto, double notional)
    {
        try
        {
            var produto = new XElement("Produto",
                new XElement("ID", id),
                new XElement("Nome", nomeProduto),
                new XElement("Notional", notional)
            );

            string caminho = Path.Combine(Path.GetTempPath(), $"produto_{id}.xml");
            produto.Save(caminho);
            return $"XML salvo em: {caminho}";
        }
        catch (System.Exception ex)
        {
            return $"Erro ao gerar XML: {ex.Message}";
        }
    }




}
