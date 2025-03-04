using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAuslesen.Models
{
    internal class Config
    {
        //public string AnbieterNameNodea { get; set; } = "";

        //public string Auto { get; set; } = ;

        public string AnzeigeTitelNode { get; set; } = "//h2[@class='dNpqi']";
        public string AnzeigeKurzBeschreibungNode { get; set; } = "//div[@class='GOIOV fqe3L EevEz']";
        public string AnzeigeBeschreibungNode { get; set; } = "//article[@class='A3G6X lAeeF vTKPY']//div[@data-testid='vip-vehicle-description-content']";
        public string AnzeigePreisNode { get; set; } = "//div[@data-testid='vip-price-label']";

        public string AutoAusstattungNode { get; set; } = "//li[@class='FtSYW']";
        public string AutoTechnischeDatenNode { get; set; } = "//dl[@class='m4qzs']/dt";
        public string AutoTechnischeDatenFollowSibilingNode { get; set; } = "following-sibling::dd";


        public string AnbieterNameNode { get; set; } = "//h4[@class='QTTRi mIdDf']";
        public string AnbieterOrtNode { get; set; } = "//span[@class='olCKS']";
        public string AnbieterTelNrNode { get; set; } = "//div[@class='QbZvr']";
        public string AnbieterAngemeldetSeitNode { get; set; } = "//h4[@class='mIdDf' and @data-testid='I18N.HOMEPAGE.With_Mde_Since_value']/div";
        public string AnbieterInserateOnlineNode { get; set; } = "//h4[@class='mIdDf' and @data-testid='I18N.HOMEPAGE.X_Ads_Online_value']";
        public string AnbieterWeiterEmpfehlungsRateNode { get; set; } = "//h4[@class='mIdDf' and @data-testid='I18N.HOMEPAGE.Referrals_value']";
        public string AnbieterKfzWieBeschriebenNode { get; set; } = "//h4[@class='mIdDf' and @data-testid='I18N.HOMEPAGE.Vehicle_As_Described_value']";
    }
}
