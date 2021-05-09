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

namespace SloppyJoe_sApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }

        private void MakeTheMenu()
        {
            MenuItem[] menuItems = new MenuItem[5];
            string guacamolePrice;

            for (int i = 0; i < 5; i++)
            {
                menuItems[i] = new MenuItem();
                if (i >= 3)
                {
                    menuItems[i].breads = new string[] { "plain bagel", "onion bagel", "pumpernickel bagel", "everything bagel" };
                }
                menuItems[i].Generate();
            }

            item1.Text = menuItems[0].description;
            price1.Text = menuItems[0].price;
            item2.Text = menuItems[1].description;
            price2.Text = menuItems[1].price;
            item3.Text = menuItems[2].description;
            price3.Text = menuItems[2].price;
            item4.Text = menuItems[3].description;
            price4.Text = menuItems[3].price;
            item5.Text = menuItems[4].description;
            price5.Text = menuItems[4].price;

            MenuItem specialMenuItem = new MenuItem()
            {
                proteins = new string[] { "Organic ham", "Mushroom patty", "Mortadella" },
                breads = new string[] { "a gluten free roll", "a wrap", "pita" },
                condiments = new string[] { "dijon mustard", "miso dressing", "au jus" }
            };
            specialMenuItem.Generate();

            item6.Text = specialMenuItem.description;
            price6.Text = specialMenuItem.price;

            MenuItem guacamoleMenuItem = new MenuItem();
            guacamoleMenuItem.Generate();
            guacamolePrice = guacamoleMenuItem.price;

            guacamole.Text = "Add guacamole for " + guacamoleMenuItem.price;



        }
    }
}
