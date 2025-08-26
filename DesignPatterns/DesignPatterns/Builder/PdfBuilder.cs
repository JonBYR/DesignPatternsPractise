using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class PdfBuilder : PresentationBuilder
    {
        private Pdfdocument pdfdocument = new Pdfdocument();
        public void addSlide(Slide slide)
        {
            pdfdocument.addPage(slide.getText());
        }
        public Pdfdocument getPdfdocument()
        {
            return pdfdocument;
        }
    }
}
