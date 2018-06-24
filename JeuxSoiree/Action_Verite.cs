using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JeuxSoiree
{
    public partial class Action_Verite : Form
    {
        private int labelheight = 1;
        private string selectedValue;
        private int playerMax = 8;

        //Constructeur
        public Action_Verite()
        {
            InitializeComponent();
            action_verite_property();
            componentsOnWindow();
            get_Actions();

        }

        //Methode d'ajout de joueurs dans la combobox
        private void creationNbrPlayer()
        {
            for (int i = 2; i < playerMax + 1; i++)
            {
                nbrPersonnes.Items.Add(i);
            }
        }

        //propriété de la form 
        private void action_verite_property()
        {
            this.Size = new Size(600, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Action Verite";
            creationNbrPlayer();
        }

        //Methode des propriétés des composants
        private void componentsOnWindow()
        {
            LabelTitle.Size = new Size(10, 30);
            LabelTitle.Left = 10;
            LabelTitle.Font = new Font("Verdana", 16);
            LabelTitle.Text = "Action Verite";

            labelPlayer.Size = new Size(10, 10);
            labelPlayer.Top = 75;
            labelPlayer.Left = 10;
            labelPlayer.Font = new Font("Calibri", 12);
            labelPlayer.Text = "Nombre de joueurs";
        }

        private void getValueTextBox()
        {

            selectedValue = this.nbrPersonnes.GetItemText(this.nbrPersonnes.SelectedItem);
            int var = Convert.ToInt32(selectedValue);

            foreach (System.Windows.Forms.Control t in this.Controls)
            {
                if (t.Name == "Joueur" + this.labelheight.ToString())
                {
                    this.Controls.Remove(t);
                }
            }

        }

        //Methode pour ajouter de nouvelles TextBox 
        private System.Windows.Forms.TextBox addNewTextBox()
        {
            System.Windows.Forms.TextBox myNewTextBox = new System.Windows.Forms.TextBox();
            this.Controls.Add(myNewTextBox);

            myNewTextBox.Top = 150;
            myNewTextBox.Top = labelheight * 30;
            myNewTextBox.Left = 350;
            myNewTextBox.Text = "Joueur " + this.labelheight.ToString();
            myNewTextBox.Name = "Joueur " + this.labelheight.ToString();
            labelheight++;

            return myNewTextBox;
        }

        private System.Windows.Forms.TextBox deleteTextBox()
        { 
            foreach (System.Windows.Forms.Control t in this.Controls)
            {
                if (t.Name == "Joueur" + this.labelheight.ToString())
                {
                    this.Controls.Remove(t);                    
                }
            }

            return null; 
        }

        //Methode pour créer des textbox en fonction du nombre de joueurs
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedValue = this.nbrPersonnes.GetItemText(this.nbrPersonnes.SelectedItem);
            int var = Convert.ToInt32(selectedValue);

            for (int i = 1; i < var + 1; i++)
            {
                addNewTextBox();
            }

            deleteTextBox();
        }

        //methode pour recuperer les actions
        private string get_Actions()
        {
            String line;
            string words_Actions = "";

            try
            {             
                StreamReader sr = new StreamReader("D://workspace unity/JeuxSoiree/JeuxSoiree/data/actions.txt");

                //Read the first line of text
                line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                    words_Actions = line;
                }
                
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            return words_Actions;
        }

        //methode pour récupérer les verites
        private string get_Verite()
        {
            String line;
            string words_Verite = "";

            try
            {
                StreamReader sr = new StreamReader("D://workspace unity/JeuxSoiree/JeuxSoiree/data/verites.txt");

                //Read the first line of text
                line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                    words_Verite = line;
                }

                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            return words_Verite;

        }

        private void Action_Verite_Load(object sender, EventArgs e)
        {

        }

    }
}
