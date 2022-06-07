using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppPicture
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private List<string> listImage;

        //public List<string> ListImage
        //{
        //    get { return listImage; }
        //    set { listImage = value; }
        //}

        public MainWindow()
        {
            InitializeComponent();
        }

        private List<string> ListImages = new List<string>()
            { "https://www.imagesource.com/wp-content/uploads/2019/06/Rio.jpg",
              "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__480.jpg",
              "https://www.industrialempathy.com/img/remote/ZiClJf-1920w.jpg",
              "https://img6.thuthuatphanmem.vn/uploads/2022/02/14/background-3d-dep-cho-zoom_022130840.jpg",
              "https://file.qdnd.vn/data/images/0/2021/06/01/dieuthuy/anh%20vinh%20ha%20long%20-%20top%201.jpg?dpi=150&quality=100&w=575",
              "https://d1j8r0kxyu9tj8.cloudfront.net/images/156689768561v5qXVKd8jhdPO.jpg",
              "https://meta.vn/Data/image/2021/12/14/hinh-anh-con-ho-00.jpg"
            };

        private int Count = -1;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Count < ListImages.Count)
            {
                Count++;
            }

            var ListImagesOfString = ListImages[Count].ToString();
            label2.Content = (Count + 1).ToString();
            img.Source = new BitmapImage(new Uri(ListImagesOfString));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Count > 0)
            {
                Count--;
            }
            var ListImagesOfString = ListImages[Count].ToString();
            label2.Content = (Count + 1).ToString();
            img.Source = new BitmapImage(new Uri(ListImagesOfString));
        }
    }
}