using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xadriz
{
    [Serializable]
    public partial class Form1 : Form
    {
        Panel selecionado = null;

        List<Panel> pecas = new List<Panel>();

        Peao p = new Peao();

        Torre t = new Torre();

        Cavalo c = new Cavalo();

        Bispo b = new Bispo();

        Rainha rainha = new Rainha();

        Rei rei = new Rei();

        Guardar g = new Guardar();

        Xeque x = new Xeque();

        //Color cor1, cor2;

        int madeiraComida = 0;

        private bool turnos = false;

        public Form1(String ccor1, String ccor2)
        {
            InitializeComponent();
            switch(ccor1)
            {
                case "Vermelho": 
                    pnH1.BackColor = Color.Red;
                    pnH3.BackColor = Color.Red;
                    pnH5.BackColor = Color.Red;
                    pnH7.BackColor = Color.Red;

                    pnG2.BackColor = Color.Red;
                    pnG4.BackColor = Color.Red;
                    pnG6.BackColor = Color.Red;
                    pnG8.BackColor = Color.Red;

                    pnF1.BackColor = Color.Red;
                    pnF3.BackColor = Color.Red;
                    pnF5.BackColor = Color.Red;
                    pnF7.BackColor = Color.Red;

                    pnE2.BackColor = Color.Red;
                    pnE4.BackColor = Color.Red;
                    pnE6.BackColor = Color.Red;
                    pnE8.BackColor = Color.Red;

                    pnD1.BackColor = Color.Red;
                    pnD3.BackColor = Color.Red;
                    pnD5.BackColor = Color.Red;
                    pnD7.BackColor = Color.Red;

                    pnC2.BackColor = Color.Red;
                    pnC4.BackColor = Color.Red;
                    pnC6.BackColor = Color.Red;
                    pnC8.BackColor = Color.Red;

                    pnB1.BackColor = Color.Red;
                    pnB3.BackColor = Color.Red;
                    pnB5.BackColor = Color.Red;
                    pnB7.BackColor = Color.Red;

                    pnA2.BackColor = Color.Red;
                    pnA4.BackColor = Color.Red;
                    pnA6.BackColor = Color.Red;
                    pnA8.BackColor = Color.Red;
                    break;


                case "Amarelo": pnH1.BackColor = Color.Yellow;
                    pnH3.BackColor = Color.Yellow;
                    pnH5.BackColor = Color.Yellow;
                    pnH7.BackColor = Color.Yellow;

                    pnG2.BackColor = Color.Yellow;
                    pnG4.BackColor = Color.Yellow;
                    pnG6.BackColor = Color.Yellow;
                    pnG8.BackColor = Color.Yellow;

                    pnF1.BackColor = Color.Yellow;
                    pnF3.BackColor = Color.Yellow;
                    pnF5.BackColor = Color.Yellow;
                    pnF7.BackColor = Color.Yellow;

                    pnE2.BackColor = Color.Yellow;
                    pnE4.BackColor = Color.Yellow;
                    pnE6.BackColor = Color.Yellow;
                    pnE8.BackColor = Color.Yellow;

                    pnD1.BackColor = Color.Yellow;
                    pnD3.BackColor = Color.Yellow;
                    pnD5.BackColor = Color.Yellow;
                    pnD7.BackColor = Color.Yellow;

                    pnC2.BackColor = Color.Yellow;
                    pnC4.BackColor = Color.Yellow;
                    pnC6.BackColor = Color.Yellow;
                    pnC8.BackColor = Color.Yellow;

                    pnB1.BackColor = Color.Yellow;
                    pnB3.BackColor = Color.Yellow;
                    pnB5.BackColor = Color.Yellow;
                    pnB7.BackColor = Color.Yellow;

                    pnA2.BackColor = Color.Yellow;
                    pnA4.BackColor = Color.Yellow;
                    pnA6.BackColor = Color.Yellow;
                    pnA8.BackColor = Color.Yellow;
                    break;


                case "Azul": 
                    pnG1.BackColor = Color.Blue;
                    pnG3.BackColor = Color.Blue;
                    pnG5.BackColor = Color.Blue;
                    pnG7.BackColor = Color.Blue;

                    pnH2.BackColor = Color.Blue;
                    pnH4.BackColor = Color.Blue;
                    pnH6.BackColor = Color.Blue;
                    pnH8.BackColor = Color.Blue;

                    pnE1.BackColor = Color.Blue;
                    pnE3.BackColor = Color.Blue;
                    pnE5.BackColor = Color.Blue;
                    pnE7.BackColor = Color.Blue;

                    pnF2.BackColor = Color.Blue;
                    pnF4.BackColor = Color.Blue;
                    pnF6.BackColor = Color.Blue;
                    pnF8.BackColor = Color.Blue;

                    pnC1.BackColor = Color.Blue;
                    pnC3.BackColor = Color.Blue;
                    pnC5.BackColor = Color.Blue;
                    pnC7.BackColor = Color.Blue;

                    pnD2.BackColor = Color.Blue;
                    pnD4.BackColor = Color.Blue;
                    pnD6.BackColor = Color.Blue;
                    pnD8.BackColor = Color.Blue;

                    pnA1.BackColor = Color.Blue;
                    pnA3.BackColor = Color.Blue;
                    pnA5.BackColor = Color.Blue;
                    pnA7.BackColor = Color.Blue;

                    pnB2.BackColor = Color.Blue;
                    pnB4.BackColor = Color.Blue;
                    pnB6.BackColor = Color.Blue;
                    pnB8.BackColor = Color.Blue;
                    break;

                case "Verde": pnH1.BackColor = Color.Green;
                    pnH3.BackColor = Color.Green;
                    pnH5.BackColor = Color.Green;
                    pnH7.BackColor = Color.Green;

                    pnG2.BackColor = Color.Green;
                    pnG4.BackColor = Color.Green;
                    pnG6.BackColor = Color.Green;
                    pnG8.BackColor = Color.Green;

                    pnF1.BackColor = Color.Green;
                    pnF3.BackColor = Color.Green;
                    pnF5.BackColor = Color.Green;
                    pnF7.BackColor = Color.Green;

                    pnE2.BackColor = Color.Green;
                    pnE4.BackColor = Color.Green;
                    pnE6.BackColor = Color.Green;
                    pnE8.BackColor = Color.Green;

                    pnD1.BackColor = Color.Green;
                    pnD3.BackColor = Color.Green;
                    pnD5.BackColor = Color.Green;
                    pnD7.BackColor = Color.Green;

                    pnC2.BackColor = Color.Green;
                    pnC4.BackColor = Color.Green;
                    pnC6.BackColor = Color.Green;
                    pnC8.BackColor = Color.Green;

                    pnB1.BackColor = Color.Green;
                    pnB3.BackColor = Color.Green;
                    pnB5.BackColor = Color.Green;
                    pnB7.BackColor = Color.Green;

                    pnA2.BackColor = Color.Green;
                    pnA4.BackColor = Color.Green;
                    pnA6.BackColor = Color.Green;
                    pnA8.BackColor = Color.Green;
                    break;
            }


            switch (ccor2)
            {
                case "Vermelho":
                    pnG1.BackColor = Color.Red;
                    pnG3.BackColor = Color.Red;
                    pnG5.BackColor = Color.Red;
                    pnG7.BackColor = Color.Red;

                    pnH2.BackColor = Color.Red;
                    pnH4.BackColor = Color.Red;
                    pnH6.BackColor = Color.Red;
                    pnH8.BackColor = Color.Red;

                    pnE1.BackColor = Color.Red;
                    pnE3.BackColor = Color.Red;
                    pnE5.BackColor = Color.Red;
                    pnE7.BackColor = Color.Red;

                    pnF2.BackColor = Color.Red;
                    pnF4.BackColor = Color.Red;
                    pnF6.BackColor = Color.Red;
                    pnF8.BackColor = Color.Red;

                    pnC1.BackColor = Color.Red;
                    pnC3.BackColor = Color.Red;
                    pnC5.BackColor = Color.Red;
                    pnC7.BackColor = Color.Red;

                    pnD2.BackColor = Color.Red;
                    pnD4.BackColor = Color.Red;
                    pnD6.BackColor = Color.Red;
                    pnD8.BackColor = Color.Red;

                    pnA1.BackColor = Color.Red;
                    pnA3.BackColor = Color.Red;
                    pnA5.BackColor = Color.Red;
                    pnA7.BackColor = Color.Red;

                    pnB2.BackColor = Color.Red;
                    pnB4.BackColor = Color.Red;
                    pnB6.BackColor = Color.Red;
                    pnB8.BackColor = Color.Red;
                    break;


                case "Amarelo": pnG1.BackColor = Color.Yellow;
                    pnG3.BackColor = Color.Yellow;
                    pnG5.BackColor = Color.Yellow;
                    pnG7.BackColor = Color.Yellow;

                    pnH2.BackColor = Color.Yellow;
                    pnH4.BackColor = Color.Yellow;
                    pnH6.BackColor = Color.Yellow;
                    pnH8.BackColor = Color.Yellow;

                    pnE1.BackColor = Color.Yellow;
                    pnE3.BackColor = Color.Yellow;
                    pnE5.BackColor = Color.Yellow;
                    pnE7.BackColor = Color.Yellow;

                    pnF2.BackColor = Color.Yellow;
                    pnF4.BackColor = Color.Yellow;
                    pnF6.BackColor = Color.Yellow;
                    pnF8.BackColor = Color.Yellow;

                    pnC1.BackColor = Color.Yellow;
                    pnC3.BackColor = Color.Yellow;
                    pnC5.BackColor = Color.Yellow;
                    pnC7.BackColor = Color.Yellow;

                    pnD2.BackColor = Color.Yellow;
                    pnD4.BackColor = Color.Yellow;
                    pnD6.BackColor = Color.Yellow;
                    pnD8.BackColor = Color.Yellow;

                    pnA1.BackColor = Color.Yellow;
                    pnA3.BackColor = Color.Yellow;
                    pnA5.BackColor = Color.Yellow;
                    pnA7.BackColor = Color.Yellow;

                    pnB2.BackColor = Color.Yellow;
                    pnB4.BackColor = Color.Yellow;
                    pnB6.BackColor = Color.Yellow;
                    pnB8.BackColor = Color.Yellow;
                    break;


                case "Azul":
                    pnH1.BackColor = Color.Blue;
                    pnH3.BackColor = Color.Blue;
                    pnH5.BackColor = Color.Blue;
                    pnH7.BackColor = Color.Blue;

                    pnG2.BackColor = Color.Blue;
                    pnG4.BackColor = Color.Blue;
                    pnG6.BackColor = Color.Blue;
                    pnG8.BackColor = Color.Blue;

                    pnF1.BackColor = Color.Blue;
                    pnF3.BackColor = Color.Blue;
                    pnF5.BackColor = Color.Blue;
                    pnF7.BackColor = Color.Blue;

                    pnE2.BackColor = Color.Blue;
                    pnE4.BackColor = Color.Blue;
                    pnE6.BackColor = Color.Blue;
                    pnE8.BackColor = Color.Blue;

                    pnD1.BackColor = Color.Blue;
                    pnD3.BackColor = Color.Blue;
                    pnD5.BackColor = Color.Blue;
                    pnD7.BackColor = Color.Blue;

                    pnC2.BackColor = Color.Blue;
                    pnC4.BackColor = Color.Blue;
                    pnC6.BackColor = Color.Blue;
                    pnC8.BackColor = Color.Blue;

                    pnB1.BackColor = Color.Blue;
                    pnB3.BackColor = Color.Blue;
                    pnB5.BackColor = Color.Blue;
                    pnB7.BackColor = Color.Blue;

                    pnA2.BackColor = Color.Blue;
                    pnA4.BackColor = Color.Blue;
                    pnA6.BackColor = Color.Blue;
                    pnA8.BackColor = Color.Blue;
                    break;

                case "Verde": pnG1.BackColor = Color.Green;
                    pnG3.BackColor = Color.Green;
                    pnG5.BackColor = Color.Green;
                    pnG7.BackColor = Color.Green;

                    pnH2.BackColor = Color.Green;
                    pnH4.BackColor = Color.Green;
                    pnH6.BackColor = Color.Green;
                    pnH8.BackColor = Color.Green;

                    pnE1.BackColor = Color.Green;
                    pnE3.BackColor = Color.Green;
                    pnE5.BackColor = Color.Green;
                    pnE7.BackColor = Color.Green;

                    pnF2.BackColor = Color.Green;
                    pnF4.BackColor = Color.Green;
                    pnF6.BackColor = Color.Green;
                    pnF8.BackColor = Color.Green;

                    pnC1.BackColor = Color.Green;
                    pnC3.BackColor = Color.Green;
                    pnC5.BackColor = Color.Green;
                    pnC7.BackColor = Color.Green;

                    pnD2.BackColor = Color.Green;
                    pnD4.BackColor = Color.Green;
                    pnD6.BackColor = Color.Green;
                    pnD8.BackColor = Color.Green;

                    pnA1.BackColor = Color.Green;
                    pnA3.BackColor = Color.Green;
                    pnA5.BackColor = Color.Green;
                    pnA7.BackColor = Color.Green;

                    pnB2.BackColor = Color.Green;
                    pnB4.BackColor = Color.Green;
                    pnB6.BackColor = Color.Green;
                    pnB8.BackColor = Color.Green;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Jogador1.Visible = false;

            Jogador2.Visible = false;

            sc1.Visible = false;
            sc2.Visible = false;
            sc3.Visible = false;

            sb1.Visible = false;
            sb2.Visible = false;
            sb3.Visible = false;

            pecas.Add(pnH1);
            pecas.Add(pnH2);
            pecas.Add(pnH3);
            pecas.Add(pnH4);
            pecas.Add(pnH5);
            pecas.Add(pnH6);
            pecas.Add(pnH7);
            pecas.Add(pnH8);


            pecas.Add(pnG1);
            pecas.Add(pnG2);
            pecas.Add(pnG3);
            pecas.Add(pnG4);
            pecas.Add(pnG5);
            pecas.Add(pnG6);
            pecas.Add(pnG7);
            pecas.Add(pnG8);

            pecas.Add(pnF1); 
            pecas.Add(pnF2);
            pecas.Add(pnF3);
            pecas.Add(pnF4);
            pecas.Add(pnF5);
            pecas.Add(pnF6);
            pecas.Add(pnF7);
            pecas.Add(pnF8);

            pecas.Add(pnE1);
            pecas.Add(pnE2);
            pecas.Add(pnE3);
            pecas.Add(pnE4);
            pecas.Add(pnE5);
            pecas.Add(pnE6);
            pecas.Add(pnE7);
            pecas.Add(pnE8);

            pecas.Add(pnD1);
            pecas.Add(pnD2);
            pecas.Add(pnD3);
            pecas.Add(pnD4);
            pecas.Add(pnD5);
            pecas.Add(pnD6);
            pecas.Add(pnD7);
            pecas.Add(pnD8);

            pecas.Add(pnC1);
            pecas.Add(pnC2);
            pecas.Add(pnC3);
            pecas.Add(pnC4);
            pecas.Add(pnC5);
            pecas.Add(pnC6);
            pecas.Add(pnC7);
            pecas.Add(pnC8);

            pecas.Add(pnB1);
            pecas.Add(pnB2);
            pecas.Add(pnB3);
            pecas.Add(pnB4);
            pecas.Add(pnB5);
            pecas.Add(pnB6);
            pecas.Add(pnB7);
            pecas.Add(pnB8);

            pecas.Add(pnA1);
            pecas.Add(pnA2);
            pecas.Add(pnA3);
            pecas.Add(pnA4);
            pecas.Add(pnA5);
            pecas.Add(pnA6);
            pecas.Add(pnA7);
            pecas.Add(pnA8);

            //----------------------------------------------------------------------
            //linha de cima 1
            pnH1.Name = "TorreMadeira";
            pnH2.Name = "CavaloMadeira";
            pnH3.Name = "BispoMadeira";
            pnH4.Name = "ReiMadeira";
            pnH5.Name = "RainhaMadeira";
            pnH6.Name = "BispoMadeira";
            pnH7.Name = "CavaloMadeira";
            pnH8.Name = "TorreMadeira";
            //linha de cima 2
            pnG1.Name = "PeaoMadeira";
            pnG2.Name = "PeaoMadeira";
            pnG3.Name = "PeaoMadeira";
            pnG4.Name = "PeaoMadeira";
            pnG5.Name = "PeaoMadeira";
            pnG6.Name = "PeaoMadeira";
            pnG7.Name = "PeaoMadeira";
            pnG8.Name = "PeaoMadeira";

            //linha de baixo 1
            pnA1.Name = "TorrePapel";
            pnA2.Name = "CavaloPapel";
            pnA3.Name = "BispoPapel";
            pnA4.Name = "ReiPapel";
            pnA5.Name = "RainhaPapel";
            pnA6.Name = "BispoPapel";
            pnA7.Name = "CavaloPapel";
            pnA8.Name = "TorrePapel";
            //linha de baixo 2
            pnB1.Name = "PeaoPapel";
            pnB2.Name = "PeaoPapel";
            pnB3.Name = "PeaoPapel";
            pnB4.Name = "PeaoPapel";
            pnB5.Name = "PeaoPapel";
            pnB6.Name = "PeaoPapel";
            pnB7.Name = "PeaoPapel";
            pnB8.Name = "PeaoPapel";

            //Vazios
            pnC1.Name = "Vazio";
            pnC2.Name = "Vazio";
            pnC3.Name = "Vazio";
            pnC4.Name = "Vazio";
            pnC5.Name = "Vazio";
            pnC6.Name = "Vazio";
            pnC7.Name = "Vazio";
            pnC8.Name = "Vazio";

            //-------------------------------------

            pnD1.Name = "Vazio";
            pnD2.Name = "Vazio";
            pnD3.Name = "Vazio";
            pnD4.Name = "Vazio";
            pnD5.Name = "Vazio";
            pnD6.Name = "Vazio";
            pnD7.Name = "Vazio";
            pnD8.Name = "Vazio";

            //-----------------------------------

            pnE1.Name = "Vazio";
            pnE2.Name = "Vazio";
            pnE3.Name = "Vazio";
            pnE4.Name = "Vazio";
            pnE5.Name = "Vazio";
            pnE6.Name = "Vazio";
            pnE7.Name = "Vazio";
            pnE8.Name = "Vazio";

            //-----------------------------------

            pnF1.Name = "Vazio";
            pnF2.Name = "Vazio";
            pnF3.Name = "Vazio";
            pnF4.Name = "Vazio";
            pnF5.Name = "Vazio";
            pnF6.Name = "Vazio";
            pnF7.Name = "Vazio";
            pnF8.Name = "Vazio";


         

        }



        private void pnG1_MouseClick(object sender, MouseEventArgs e)
        {

            label33.Text = ((Panel)sender).Name;
            if(selecionado == null)         //se n esta selecionado ent seleciona
            {
                if (((Panel)sender).BackgroundImage != null)     //quando ele clica a 1ª vez so pode clicar numa peça
                {
                    selecionado = (Panel)sender;
                }
                else
                {
                    MessageBox.Show("Escolha a peça que quer jogar por favor");
                }
            }
            else
            {//ent joga e desseleciona
                
                switch(selecionado.Name)
                {
                    case "PeaoMadeira":
                        if (turnos == true)
                        {
                            Jogador2.ForeColor = Color.Green;
                            Jogador1.ForeColor = Color.Gray;
                            if (p.jogar(selecionado.Location, ((Panel)sender).Location, selecionado.Name, ((Panel)sender).Name, pecas))
                            {
                                if (((Panel)sender).Name != "Vazio")
                                {
                                    madeiraComida++;
                                    Comidas.Text = "" + madeiraComida;
                                }
                               
                                jogadasCima.Text = "" + (Int32.Parse(jogadasCima.Text) + 1);
                                
                                ((Panel)sender).BackgroundImage = selecionado.BackgroundImage;
                                ((Panel)sender).Name = selecionado.Name;
                                selecionado.Name = "Vazio";
                                selecionado.BackgroundImage = null;
                                turnos = false;

                                sc1.Visible = false;
                                sc2.Visible = false;
                                sc3.Visible = false;

                                sb1.Visible = true;
                                sb2.Visible = true;
                                sb3.Visible = true;

                                

                            }
                        }
                        else
                        {
                            MessageBox.Show("Nao é a tua vez de jogar");
                        }
                        break;

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    case "PeaoPapel":
                        if (turnos == false)
                        {
                            
                            //MessageBox.Show(selecionado.Location.ToString() + ((Panel)sender).Location.ToString());
                            if (p.jogar(selecionado.Location, ((Panel)sender).Location, selecionado.Name,((Panel)sender).Name, pecas))
                            {
                                if (((Panel)sender).Name != "Vazio")
                                {
                                    madeiraComida++;
                                    ComidasBaixo.Text = "" + madeiraComida;
                                }

                                jogadasBaixo.Text = "" + (Int32.Parse(jogadasBaixo.Text) + 1);
                               
                                ((Panel)sender).BackgroundImage = selecionado.BackgroundImage;
                                ((Panel)sender).Name = selecionado.Name;
                                selecionado.Name = "Vazio";
                                selecionado.BackgroundImage = null;
                                turnos = true;
                                sc1.Visible = true;
                                sc2.Visible = true;
                                sc3.Visible = true;

                                sb1.Visible = false;
                                sb2.Visible = false;
                                sb3.Visible = false;

                                

                            }
                        }
                        else
                        {
                            MessageBox.Show("Nao é a tua vez de jogar");
                        }

                        break;

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    case "TorreMadeira":
                        if (turnos == true)
                        {
                            if (t.jogar(selecionado.Location, ((Panel)sender).Location, selecionado.Name, ((Panel)sender).Name, pecas))
                            {
                                if (((Panel)sender).Name != "Vazio")
                                {
                                    madeiraComida++;
                                    Comidas.Text = "" + madeiraComida;
                                }

                                jogadasCima.Text = "" + (Int32.Parse(jogadasCima.Text) + 1);
                                
                                ((Panel)sender).BackgroundImage = selecionado.BackgroundImage;
                                ((Panel)sender).Name = selecionado.Name;
                                selecionado.Name = "Vazio";
                                selecionado.BackgroundImage = null;
                                turnos = false;

                                sc1.Visible = false;
                                sc2.Visible = false;
                                sc3.Visible = false;

                                sb1.Visible = true;
                                sb2.Visible = true;
                                sb3.Visible = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nao é a tua vez de jogar");
                        }
                        break;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    case "TorrePapel":
                        if (turnos == false)
                        {
                            if (t.jogar(selecionado.Location, ((Panel)sender).Location,selecionado.Name,((Panel)sender).Name, pecas))
                            {
                                if (((Panel)sender).Name != "Vazio")
                                {
                                    madeiraComida++;
                                    ComidasBaixo.Text = "" + madeiraComida;
                                }

                                jogadasBaixo.Text = "" + (Int32.Parse(jogadasBaixo.Text) + 1);
                               
                                ((Panel)sender).BackgroundImage = selecionado.BackgroundImage;
                                ((Panel)sender).Name = selecionado.Name;
                                selecionado.Name = "Vazio";
                                selecionado.BackgroundImage = null;
                                turnos = true;

                                sc1.Visible = true;
                                sc2.Visible = true;
                                sc3.Visible = true;

                                sb1.Visible = false;
                                sb2.Visible = false;
                                sb3.Visible = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nao é a tua vez de jogar");
                        }
                        break;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    case "CavaloMadeira":
                        if (turnos == true)
                        {
                            if (c.jogar(selecionado.Location, ((Panel)sender).Location, selecionado.Name,((Panel)sender).Name, pecas))
                            {
                                if (((Panel)sender).Name != "Vazio")
                                {
                                    madeiraComida++;
                                    Comidas.Text = "" + madeiraComida;
                                }

                                jogadasCima.Text = "" + (Int32.Parse(jogadasCima.Text) + 1);
                               
                                ((Panel)sender).BackgroundImage = selecionado.BackgroundImage;
                                ((Panel)sender).Name = selecionado.Name;
                                selecionado.Name = "Vazio";
                                selecionado.BackgroundImage = null;
                                turnos = false;

                                sc1.Visible = false;
                                sc2.Visible = false;
                                sc3.Visible = false;

                                sb1.Visible = true;
                                sb2.Visible = true;
                                sb3.Visible = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nao é a tua vez de jogar");
                        }
                        break;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    case "CavaloPapel":
                        if (turnos == false)
                        {
                            if (c.jogar(selecionado.Location, ((Panel)sender).Location, selecionado.Name,((Panel)sender).Name, pecas))
                            {
                                if (((Panel)sender).Name != "Vazio")
                                {
                                    madeiraComida++;
                                    ComidasBaixo.Text = "" + madeiraComida;
                                }

                                jogadasBaixo.Text = "" + (Int32.Parse(jogadasBaixo.Text) + 1);
                                
                                ((Panel)sender).BackgroundImage = selecionado.BackgroundImage;
                                ((Panel)sender).Name = selecionado.Name;
                                selecionado.Name = "Vazio";
                                selecionado.BackgroundImage = null;
                                turnos = true;

                                sc1.Visible = true;
                                sc2.Visible = true;
                                sc3.Visible = true;

                                sb1.Visible = false;
                                sb2.Visible = false;
                                sb3.Visible = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nao é a tua vez de jogar");
                        }
                        break;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    case "BispoMadeira":
                        if (turnos == true)
                        {
                            //MessageBox.Show(selecionado.Location.ToString() + ((Panel)sender).Location.ToString());
                            if (b.jogar(selecionado.Location, ((Panel)sender).Location, selecionado.Name, ((Panel)sender).Name, pecas))
                            {
                                if (((Panel)sender).Name != "Vazio")
                                {
                                    madeiraComida++;
                                    Comidas.Text = "" + madeiraComida;
                                }

                                jogadasCima.Text = "" + (Int32.Parse(jogadasCima.Text) + 1);
                              
                                ((Panel)sender).BackgroundImage = selecionado.BackgroundImage;
                                ((Panel)sender).Name = selecionado.Name;
                                selecionado.Name = "Vazio";
                                selecionado.BackgroundImage = null;
                                turnos = false;

                                sc1.Visible = false;
                                sc2.Visible = false;
                                sc3.Visible = false;

                                sb1.Visible = true;
                                sb2.Visible = true;
                                sb3.Visible = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nao é a tua vez de jogar");
                        }
                        break;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    case "BispoPapel":
                        if (turnos == false)
                        {
                            //MessageBox.Show(selecionado.Location.ToString() + ((Panel)sender).Location.ToString());
                            if (b.jogar(selecionado.Location, ((Panel)sender).Location, selecionado.Name, ((Panel)sender).Name, pecas))
                            {
                                if (((Panel)sender).Name != "Vazio")
                                {
                                    madeiraComida++;
                                    ComidasBaixo.Text = "" + madeiraComida;
                                }

                                jogadasBaixo.Text = "" + (Int32.Parse(jogadasBaixo.Text) + 1);
                               
                                ((Panel)sender).BackgroundImage = selecionado.BackgroundImage;
                                ((Panel)sender).Name = selecionado.Name;
                                selecionado.Name = "Vazio";
                                selecionado.BackgroundImage = null;
                                turnos = true;

                                sc1.Visible = true;
                                sc2.Visible = true;
                                sc3.Visible = true;

                                sb1.Visible = false;
                                sb2.Visible = false;
                                sb3.Visible = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nao é a tua vez de jogar");
                        }
                        break;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    case "RainhaMadeira":
                        if (turnos == true)
                        {
                            //MessageBox.Show(selecionado.Location.ToString() + ((Panel)sender).Location.ToString());
                            if (rainha.jogar(selecionado.Location, ((Panel)sender).Location, selecionado.Name, ((Panel)sender).Name, pecas))
                            {
                                if (((Panel)sender).Name != "Vazio")
                                {
                                    madeiraComida++;
                                    Comidas.Text = "" + madeiraComida;
                                }

                                jogadasCima.Text = "" + (Int32.Parse(jogadasCima.Text) + 1);
                                
                                ((Panel)sender).BackgroundImage = selecionado.BackgroundImage;
                                ((Panel)sender).Name = selecionado.Name;
                                selecionado.Name = "Vazio";
                                selecionado.BackgroundImage = null;
                                turnos = false;

                                sc1.Visible = false;
                                sc2.Visible = false;
                                sc3.Visible = false;

                                sb1.Visible = true;
                                sb2.Visible = true;
                                sb3.Visible = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nao é a tua vez de jogar");
                        }
                        break;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    case "RainhaPapel":
                        if (turnos == false)
                        {
                            //MessageBox.Show(selecionado.Location.ToString() + ((Panel)sender).Location.ToString());
                            if (rainha.jogar(selecionado.Location, ((Panel)sender).Location, selecionado.Name, ((Panel)sender).Name, pecas))
                            {
                                if (((Panel)sender).Name != "Vazio")
                                {
                                    madeiraComida++;
                                    ComidasBaixo.Text = "" + madeiraComida;
                                }

                                jogadasBaixo.Text = "" + (Int32.Parse(jogadasBaixo.Text) + 1);
                          
                                ((Panel)sender).BackgroundImage = selecionado.BackgroundImage;
                                ((Panel)sender).Name = selecionado.Name;
                                selecionado.Name = "Vazio";
                                selecionado.BackgroundImage = null;
                                turnos = true;

                                sc1.Visible = true;
                                sc2.Visible = true;
                                sc3.Visible = true;

                                sb1.Visible = false;
                                sb2.Visible = false;
                                sb3.Visible = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nao é a tua vez de jogar");
                        }
                        break;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    case "ReiMadeira":
                        if (turnos == true)
                        {
                            //MessageBox.Show(selecionado.Location.ToString() + ((Panel)sender).Location.ToString());
                            if (rei.jogar(selecionado.Location, ((Panel)sender).Location,selecionado.Name,((Panel)sender).Name, pecas))
                            {
                                if (((Panel)sender).Name != "Vazio")
                                {
                                    madeiraComida++;
                                    Comidas.Text = "" + madeiraComida;
                                }

                                jogadasCima.Text = "" + (Int32.Parse(jogadasCima.Text) + 1);
                            
                                ((Panel)sender).BackgroundImage = selecionado.BackgroundImage;
                                ((Panel)sender).Name = selecionado.Name;
                                selecionado.Name = "Vazio";
                                selecionado.BackgroundImage = null;
                                turnos = false;

                                sc1.Visible = false;
                                sc2.Visible = false;
                                sc3.Visible = false;

                                sb1.Visible = true;
                                sb2.Visible = true;
                                sb3.Visible = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nao é a tua vez de jogar");
                        }
                        break;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    case "ReiPapel":
                        if (turnos == false)
                        {
                            //MessageBox.Show(selecionado.Location.ToString() + ((Panel)sender).Location.ToString());
                            if (rei.jogar(selecionado.Location, ((Panel)sender).Location,selecionado.Name,((Panel)sender).Name, pecas))
                            {
                                if (((Panel)sender).Name != "Vazio")
                                {
                                    madeiraComida++;
                                    ComidasBaixo.Text = "" + madeiraComida;
                                }

                                jogadasBaixo.Text = "" + (Int32.Parse(jogadasBaixo.Text) + 1);
                                
                                ((Panel)sender).BackgroundImage = selecionado.BackgroundImage;
                                ((Panel)sender).Name = selecionado.Name;
                                selecionado.Name = "Vazio";
                                selecionado.BackgroundImage = null;
                                turnos = true;

                                sc1.Visible = true;
                                sc2.Visible = true;
                                sc3.Visible = true;

                                sb1.Visible = false;
                                sb2.Visible = false;
                                sb3.Visible = false;
                                
                                
                            }

                        }
                        else
                        {
                            MessageBox.Show("Nao é a tua vez de jogar");
                        }
                        break;
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    default:
                        selecionado = (Panel)sender;
                        break;
                }
                
                if(turnos == true)
                {
                    Jogador2.ForeColor = Color.Green;
                    Jogador1.ForeColor = Color.Gray;
                    
                }
                else
                {
                    Jogador2.ForeColor = Color.Gray;
                    Jogador1.ForeColor = Color.Green;
                }
                if (x.xequie(selecionado, ((Panel)sender), turnos, pecas))
                {
                    MessageBox.Show("-----------------XEQUE---------------");
                }
                selecionado = null;
           }
        }
        static void SerializeWithBinaryFormat(Object obj, SaveFileDialog fileLocation)
        {
            try{
                Stream streamToFile = File.OpenWrite(fileLocation.FileName);         //
                BinaryFormatter bf = new BinaryFormatter();                 //
                bf.Serialize(streamToFile, obj);                            //
                streamToFile.Close();             
            }
            catch(System.ArgumentNullException)
            {
                MessageBox.Show("O ficheiro nao pode ser vazio");
            }
            catch (System.Runtime.Serialization.SerializationException)
            {
                MessageBox.Show("O ficheiro nao pode ser vazio");
            }
            catch (System.Security.SecurityException)
            {
                MessageBox.Show("O ficheiro nao pode ser vazio");
            }//
        }

        static Object DeserializeWithBinaryFormatter(OpenFileDialog fileLocation)
        {
            /*try
            {*/
                Stream streamFromFile = File.OpenRead(fileLocation.FileName);       //
                BinaryFormatter bf = new BinaryFormatter();                 //
                Object obj = bf.Deserialize(streamFromFile);                //
                streamFromFile.Close();                                     //
                return obj;   
            /*}
            catch(System.ArgumentNullException)
            {
                MessageBox.Show("O ficheiro nao pode ser vazio");
            }
            catch (System.Runtime.Serialization.SerializationException)
            {
                MessageBox.Show("O ficheiro nao pode ser vazio");
            }
            catch (System.Security.SecurityException)
            {
                MessageBox.Show("O ficheiro nao pode ser vazio");
            }
            */
                                                          //
        }

        private void save_Click(object sender, EventArgs e)
        {

            g.preencher(pecas);

            saveFileDialog1.Filter = "chess(dados do jogo currente) | *.chess";
            saveFileDialog1.FileName = "meuJogo";
            saveFileDialog1.ShowDialog();

            SerializeWithBinaryFormat(g, saveFileDialog1);
        }

        private void read_Click(object sender, EventArgs e)
        {
            try{
                openFileDialog1.Filter = "chess(dados do jogo currente) | *.chess";
                openFileDialog1.FileName = "meuJogo";
                openFileDialog1.ShowDialog();
                g = (Guardar)DeserializeWithBinaryFormatter(openFileDialog1);//objeto save
                pecas = g.devolver(pecas);
            }
            catch (System.IO.FileNotFoundException erro)
            {
                MessageBox.Show("Voltar ao jogo?");
            }

            foreach(Panel peca in pecas)
            {
                switch(peca.Name)
                {
                    case "PeaoMadeira":
                        peca.BackgroundImage = Properties.Resources.peaoMadeira;
                        break;
                    case "PeaoPapel":
                        peca.BackgroundImage = Properties.Resources.peaoPapel;
                        break;
                    case "TorreMadeira":
                        peca.BackgroundImage = Properties.Resources.torreMadeira;
                        break;
                    case "TorreoPapel":
                        peca.BackgroundImage = Properties.Resources.torrePapel;
                        break;
                    case "BispoMadeira":
                        peca.BackgroundImage = Properties.Resources.bispoMadeira;
                        break;
                    case "BispoPapel":
                        peca.BackgroundImage = Properties.Resources.bispoPapel;
                        break;
                    case "CavaloMadeira":
                        peca.BackgroundImage = Properties.Resources.cavaloMadeira;
                        break;
                    case "CavaloPapel":
                        peca.BackgroundImage = Properties.Resources.cavaloPapel;
                        break;
                    case "RainhaMadeira":
                        peca.BackgroundImage = Properties.Resources.rainhaMadeira;
                        break;
                    case "RainhaPapel":
                        peca.BackgroundImage = Properties.Resources.rainhaPapel;
                        break;
                    case "ReiMadeira":
                        peca.BackgroundImage = Properties.Resources.reiMadeira;
                        break;
                    case "ReiPapel":
                        peca.BackgroundImage = Properties.Resources.reiPapel;
                        break;
                    case "Vazio":
                        peca.BackgroundImage = new Bitmap(1,1);
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jogador1.Text = tb1.Text;
            tb1.Visible = false;
            button1.Visible = false;
            Jogador1.Visible = true;
            sb1.Visible = true;
            sb2.Visible = true;
            sb3.Visible = true;

            textBox1.BackColor = Color.Green;


            //----------------------------------------------------------------------
            
            //linha de baixo 1
            pnA1.Visible = true;
            pnA2.Visible = true;
            pnA3.Visible = true;
            pnA4.Visible = true;
            pnA5.Visible = true;
            pnA6.Visible = true;
            pnA7.Visible = true;
            pnA8.Visible = true;
            //linha de baixo 2
            pnB1.Visible = true;
            pnB2.Visible = true;
            pnB3.Visible = true;
            pnB4.Visible = true;
            pnB5.Visible = true;
            pnB6.Visible = true;
            pnB7.Visible = true;
            pnB8.Visible = true;
        }

        private void verificarXeque()
        {
            /*foreach (Panel peca in pecas)
            {
                switch (peca.Name)
                {
                    case "ReiMadeira":
                        if(peca.Location.X != peca.Location.X + 58 && peca.Location.Y != peca.Location.Y - 58)
                        {
                            if(peca.Name == "PeaoPapel")
                            {
                                MessageBox.Show("Xeque");
                            }
                        }
                        break;
                    case "ReiPapel":
                        break;
                }
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Jogador2.Text = textBox1.Text;
            textBox1.Visible = false;
            button2.Visible = false;
            Jogador2.Visible = true;

            //linha de cima 1
            pnH1.Visible = true;
            pnH2.Visible = true;
            pnH3.Visible = true;
            pnH4.Visible = true;
            pnH5.Visible = true;
            pnH6.Visible = true;
            pnH7.Visible = true;
            pnH8.Visible = true;
            //linha de cima 2
            pnG1.Visible = true;
            pnG2.Visible = true;
            pnG3.Visible = true;
            pnG4.Visible = true;
            pnG5.Visible = true;
            pnG6.Visible = true;
            pnG7.Visible = true;
            pnG8.Visible = true;

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }
    }
}
