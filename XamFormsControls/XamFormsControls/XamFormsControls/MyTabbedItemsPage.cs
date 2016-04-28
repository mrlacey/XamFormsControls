using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamFormsControls
{
    public class MyTabbedItemsPage : TabbedPage
    {
        public MyTabbedItemsPage()
        {
            this.Title = "tabbed items";

            this.ItemsSource = new[] {new Number("one"), new Number("two"), new Number("three"), new Number("four")};

            this.ItemTemplate = new DataTemplate(() =>
            {
                return new NumberItemPage();
            });
        }
    }

    class Number
    {
        public Number(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    class NumberItemPage : ContentPage
    {
        public NumberItemPage()
        {
            this.SetBinding(ContentPage.TitleProperty, "Name");

            var label = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            label.SetBinding(Label.TextProperty, "Name");
            
            this.Content = label;
        }
    }
}
