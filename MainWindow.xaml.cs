using System;
using System.Collections.Generic;
using System.IO;
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
using System.Data.SqlClient;
using TablaHash;

namespace WpfApp1
{


    public class TextBoxConsole : TextWriter
    {
        TextBox output = null; //Textbox used to show Console's output.

        /// <summary>
        /// Custom TextBox-Class used to print the Console output.
        /// </summary>
        /// <param name="_output">Textbox used to show Console's output.</param>
        public TextBoxConsole(TextBox _output)
        {
            output = _output;
        }

        //<summary>
        //Appends text to the textbox and to the logfile
        //</summary>
        //<param name="value">Input-string which is appended to the textbox.</param>
        public override void Write(char value)
        {
            base.Write(value);
            output.AppendText(value.ToString());//Append char to the textbox
        }


        public override Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        TablaExploracionCuadratica ht;






        public MainWindow()
        {
            InitializeComponent();
            ht = new TablaExploracionCuadratica();

            TextWriter writer = new TextBoxConsole(Salida);
            Console.SetOut(writer);

           
        }




        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            String s_nombre = Nombre.Text;
            String s_DNI = DNI.Text;
            Persona persona = new Persona(s_DNI, s_nombre);
            ht.insertar(persona);
           /* 
            SqlConnection cn = new SqlConnection("server=127.0.0.1;uid=Seba;pwd=1234;database=tp3");
            SqlCommand cmd = new SqlCommand("select * from [dbo].[Table]", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet2 set_Persona = new DataSet2();

            da.Fill(set_Persona, set_Persona.Tables[0].TableName);
            DataSet2.DataTableName[RowIndex].ColumnName
            */
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
