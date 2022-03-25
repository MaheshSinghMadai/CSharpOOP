using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoBook
{
    class PhotoBook
    {
        private int numPages;

        public PhotoBook()
        {
            numPages = 16;
        }

        public PhotoBook(int numPage)
        {
            this.numPages = numPage;
        }
        public int GetNumberPages()
        {
            return numPages;
        }
    }

    class BigPhotoBook
    {
        private int numPages;

        public BigPhotoBook()
        {
            numPages = 64;
        }
        public int GetNumberPages()
        {
            return numPages;
        }
    }
}
