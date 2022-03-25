using System;

namespace PhotoBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a default photo book and show the number of pages
            PhotoBook pb = new PhotoBook();
            Console.WriteLine(pb.GetNumberPages());

            //Create a photo book with 24 pages and show the number of pages
            PhotoBook pb1 = new PhotoBook(24);
            Console.WriteLine(pb1.GetNumberPages());

            //Create a large photo book and show the number of pages
            BigPhotoBook bpb = new BigPhotoBook();
            Console.WriteLine(bpb.GetNumberPages());
        }
    }
}
