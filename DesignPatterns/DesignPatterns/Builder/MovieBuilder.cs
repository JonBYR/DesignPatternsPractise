using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class MovieBuilder : PresentationBuilder
    {
        private int duration = 3;
        private Movie movie = new Movie();
        public void addSlide(Slide slide)
        {
            movie.addFrame(slide.getText(), duration);
        }
        public Movie getMovie()
        {
            return movie;
        }
    }
}
