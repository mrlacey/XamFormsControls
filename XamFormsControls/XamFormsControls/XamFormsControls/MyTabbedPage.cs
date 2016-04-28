using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamFormsControls
{
    public class MyTabbedPage : TabbedPage
    {
        public MyTabbedPage()
        {
            this.Title = "MyTabbedPage";

            this.Children.Add(new MyTab1());
            this.Children.Add(new MyTab2());
        }
    }
}
