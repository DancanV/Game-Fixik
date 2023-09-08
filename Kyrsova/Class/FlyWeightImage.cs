using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsova.Class
{
    internal class FlyWeightImage
    {
        public List<Bitmap> imageList = new List<Bitmap>();
        int countImages;
        string name;
        int index;
        public FlyWeightImage() { }
        public FlyWeightImage(int countImages)
        {
            this.countImages = countImages;
        }
        public Bitmap getImage(int index)
        {
            this.index = index;
            return imageList[index];
        }
        public void GetBitmapsFromResourceFolder(string imageName)
        {
            bool a = true;
            int j = 0;
            for (int i = 0; i < countImages; i++)
            {
                string resourceName = $"{imageName}{i}";
                Bitmap bitmap = (Bitmap)Properties.Resources.ResourceManager.GetObject(resourceName);
                if (bitmap != null)
                {
                    imageList.Add(bitmap);
                }
                while (a)
                {
                    if (resourceName[j] != '_')
                    {
                        name += resourceName[j];
                        j++;
                    }
                    else a=false;
                }
            }
        }
        public string Name()
        {
            return name;
        }

        public int Index(Image Image)
        {
            for (int i = 0; i < imageList.Count; i++)
            {
                if (imageList[i] == Image)
                    return i;
            }
            return -1;
        }
    }
   
}
