using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());



            Pages.Add(new ResultPage());



            Pages.Add(new ConclusionPage());



            Pages.Add(new SummaryPage());



            Pages.Add(new BibliographyPage());

        }
    }
}
