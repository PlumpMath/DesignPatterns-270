using System.Collections.Generic;

namespace Flyweight
{
    class Image
    {
        private List<string> _imitatesHugeImage = new List<string>();
        public static Image Load(string fileName)
        {
            var img = new Image();
            for (int i = 0; i < 10000; i++)
            {
                img._imitatesHugeImage.Add(string.Format("abcdefgh:{0}", i));
            }
            return img;
        }
    }
}