//liberías del programa.
using System;
//liberías del programa.
using System.Collections;
//liberías del programa.
using System.Collections.Generic;
//liberías del programa.
using System.ComponentModel;
//liberías del programa.
using System.Data;
//liberías del programa.
using System.Drawing;
//liberías del programa.
using System.Linq;
//liberías del programa.
using System.Text;
//liberías del programa.
using System.Threading.Tasks;
//liberías del programa.
using System.Windows.Forms;

//Controla el alcance de los nombres de las clases y métodos
namespace PIDETEC
{   //Esta es una clase que manda llamar a un constructor
    public partial class opciones : Form
    {
        //Instancia una clase.
        Menu menu = new Menu();
        //Nos permite almacenar información en colas de tipo FIFO (primero en entrar primero en salir).
        Queue colaSimple = new Queue();
        //Declarando un tipo de dato numérico entero.
        int contadorG = 0;
        //Declarando un tipo de dato numérico entero.
        int contadorL = 0;
        //Declarando un tipo de dato numérico entero.
        int contadorS = 0;
        //Declarando un tipo de dato numérico entero.
        int contadorF = 0;
        //Declarando un tipo de dato numérico entero.
        int totG;
        //Declarando un tipo de dato numérico entero.
        int totL;
        //Declarando un tipo de dato numérico entero.
        int totS;
        //Declarando un tipo de dato numérico entero.
        int totF;
        //Declarando un tipo de dato numérico entero.
        int totalGorditas;
        //Declarando un tipo de dato numérico entero.
        int totalLonches;
        //Declarando un tipo de dato numérico entero.
        int totalSandwich;
        //Declarando un tipo de dato numérico entero.
        int totalFlautas;
        //Declarando un tipo de dato numérico entero.
        int totalTotales;
        //Es un constructor
        public opciones()
        {
            //// Este es un método
            InitializeComponent();
        }
        //Es un evento llamado: Click, para el botón Gorditas 
        private void btnGorditas_Click(object sender, EventArgs e)
        {
            //Este es un incremento.
            contadorG++;
            //Guardamos el dato en una cola.
            colaSimple.Enqueue(contadorG);
            //Manda el número de clic´s a un label.
            lblGorditas.Text = contadorG.ToString();
            //Manda el número de clic´s a la barra. 
            barraG.Value = contadorG;
            //El número de clic´s se convierten en un tipo de dato llamado int.
            totG = Convert.ToInt32(contadorG);
            //Sacamos la cuenta de este platillo.
            totalGorditas = totG * 15;
            //Sacamos la cuenta de todo el menú.
            totalTotales = totalGorditas + totalLonches + totalSandwich + totalFlautas;
            //Mandamos el total a un label.
            totalTodo.Text = totalTotales.ToString();


        }

        //Este es un evento que ocrre cuando el usuario da un click
        private void btnLonches_Click(object sender, EventArgs e)
        {
            //Este es un incremento.
            contadorL++;
            //Guardamos el dato en una cola.
            colaSimple.Enqueue(contadorL);
            //Manda el número de clic´s a un label.
            lblLonche.Text = contadorL.ToString();
            //Manda el número de clic´s a la barra. 
            barraL.Value = contadorL;
            //El número de clic´s se convierten en un tipo de dato llamado int.
            totL = Convert.ToInt32(contadorL);
            //Sacamos la cuenta de este platillo.
            totalLonches = totL * 60;
            //Sacamos la cuenta de todo el menú.
            totalTotales = totalGorditas + totalLonches + totalSandwich + totalFlautas;
            //Mandamos el total a un label.
            totalTodo.Text = totalTotales.ToString();
        }

        //Este es un evento que ocrre cuando el usuario da un click
        private void btnSandwich_Click(object sender, EventArgs e)
        {
            //Este es un incremento.
            contadorS++;
            //Guardamos el dato en una cola.
            colaSimple.Enqueue(contadorS);
            //Manda el número de clic´s a un label.
            lblSandwich.Text = contadorS.ToString();
            //Manda el número de clic´s a la barra. 
            barraS.Value = contadorS;
            //El número de clic´s se convierten en un tipo de dato llamado int.
            totS = Convert.ToInt32(contadorS);
            //Sacamos la cuenta de este platillo.
            totalSandwich = totS * 25;
            //Sacamos la cuenta de todo el menú.
            totalTotales = totalGorditas + totalLonches + totalSandwich + totalFlautas;
            //Mandamos el total a un label.
            totalTodo.Text = totalTotales.ToString();
        }

        //Este es un evento que ocrre cuando el usuario da un click
        private void btnFlautas_Click(object sender, EventArgs e)
        {
            //Este es un incremento.
            contadorF++;
            //Guardamos el dato en una cola.
            colaSimple.Enqueue(contadorF);
            //Manda el número de clic´s a un label.
            lblFlauta.Text = contadorF.ToString();
            //Manda el número de clic´s a la barra. 
            barraF.Value = contadorF;
            //El número de clic´s se convierten en un tipo de dato llamado int.
            totF = Convert.ToInt32(contadorF);
            //Sacamos la cuenta de este platillo.
            totalFlautas = totF * 15;
            //Sacamos la cuenta de todo el menú.
            totalTotales = totalGorditas + totalLonches + totalSandwich + totalFlautas;
            //Mandamos el total a un label.
            totalTodo.Text = totalTotales.ToString();
            
        }

        //Evento que ocurre cuando el mouse permanece quieto dentro del control
        private void btnGorditas_MouseHover(object sender, EventArgs e)
        {
            //Cambia de form
            //Muestra el control
            menu.Show();
            //Establece la imagen que aparece en el control
            menu.BackgroundImage = Properties.Resources.Gorditas;
        }
        //Evento que ocurre cuando el mouse ya no está en la parte visible del control
        private void btnGorditas_MouseLeave(object sender, EventArgs e)
        {//Oculta el control
            menu.Hide();
        }

        //Evento que ocurre cuando el mouse permanece quieto dentro del control
        private void btnLonches_MouseHover(object sender, EventArgs e)
        {
            //Muestra el control
            menu.Show();
            //Establece la imagen que aparece en el control
            menu.BackgroundImage = Properties.Resources.Lonche;
        }
        //Evento que ocurre cuando el mouse ya no está en la parte visible del control
        private void btnLonches_MouseLeave(object sender, EventArgs e)
        {
            //Muestra el control
            menu.Hide();
        }
        //Evento que ocurre cuando el mouse permanece quieto dentro del control
        private void btnSandwich_MouseHover(object sender, EventArgs e)
        {//Muestra el control
            menu.Show();
            //Establece la imagen que aparece en el control
            menu.BackgroundImage = Properties.Resources.sandwich;
        }
        //Evento que ocurre cuando el mouse ya no está en la parte visible del control
        private void btnSandwich_MouseLeave(object sender, EventArgs e)
        {//Oculta el control
            menu.Hide();
        }
        //Evento que ocurre cuando el mouse permanece quieto dentro del control
        private void btnFlautas_MouseHover(object sender, EventArgs e)
        {//Muestra el control
            menu.Show();
            //Establece la imagen que aparece en el control
            menu.BackgroundImage = Properties.Resources.Flautas;
        }
        //Evento que ocurre cuando el mouse ya no está en la parte visible del control
        private void btnFlautas_MouseLeave(object sender, EventArgs e)
        {//Oculta el control
            menu.Hide();
        }


        // Tiene lugar cuando el usuario carga el formulario.
        private void opciones_Load(object sender, EventArgs e)
        {//Establece el texto que se mostrará en el elemento
            toolStripLabel2.Text = Form1.NomUsuario;
        }

        //Este es un evento que ocrre cuando el usuario da un click
        private void toolStripButton2_Click(object sender, EventArgs e)
        {//se instancia una clase 
            Form1 login = new Form1();
            //cierra la ventana
            this.Close();
            //Muestra el control
            login.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (contadorG == 0 && contadorL == 0 && contadorS == 0 && contadorF == 0)
            {
                MessageBox.Show("No se puede confirmar el pedido", "Advertncia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Estás seguro que deseas confirmar tu pedido?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                // Reiniciar los contadores
                contadorG = 0;
                contadorL = 0;
                contadorS = 0;
                contadorF = 0;

                // Actualizar los labels
                lblGorditas.Text = contadorG.ToString();
                lblLonche.Text = contadorL.ToString();
                lblSandwich.Text = contadorS.ToString();
                lblFlauta.Text = contadorF.ToString();

                // Actualizar las barras de progreso
                barraG.Value = contadorG;
                barraL.Value = contadorL;
                barraS.Value = contadorS;
                barraF.Value = contadorF;

                // Reiniciar los totales
                totalGorditas = 0;
                totalLonches = 0;
                totalSandwich = 0;
                totalFlautas = 0;
                totalTotales = 0;

                // Actualizar el label de total
                totalTodo.Text = totalTotales.ToString();

                // Vaciar la cola
                colaSimple.Clear();
            }
        }
    }
}
