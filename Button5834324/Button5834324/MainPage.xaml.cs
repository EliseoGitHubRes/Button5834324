using System;
using Xamarin.Forms;

namespace Button5834324
{
    public partial class MainPage : ContentPage
    {
        ///<Summary>
        ///<Createddate>21/07/2023</createddate>
        ///<company>INDEL</company>
        ///<lastmodificationdate>21/07/2023</lastmodificationdate>
        ///<lastmodificationdescription>
        ///PROPIEDADES DEL BUTTON
        ///</lastmodificationdescription>
        //////<lastmodifierautor>ELISEO</lastmodifierautor>
        ///</Summary>
        public MainPage()
        {
            InitializeComponent();
        }


        /// <summary>
        /// EVENTO QUE SE EJECUTA AL PRESIONAR EL BOTÓN
        /// </summary>
        private void Button_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Presioname de nuevo";
        }
        
    }
}
