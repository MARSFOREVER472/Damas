using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public partial class Form1 : Form
    {
        // Método inicial de la interfaz.
        public Form1()
        {
            InitializeComponent(); // Método de ejecución inicial.
        }

        // Declaramos variables.

        int n; // Variable numérica para los colores de las casillas.
        PictureBox[,] P; // Variable para las Casillas del tablero.

        // Se carga la interfaz ejecutable.
        private void Form1_Load(object sender, EventArgs e)
        {
            n = 8; // Tamaño máximo del tablero de 8*8 cuadrados diferentes.
            P = new PictureBox[n, n]; // Se crea el tablero original similar a la de un tablero de ajedrez.
            int left = 2, top = 2; // 2 casillas desde la izquierda y 2 casillas desde arriba.
            Color[] colors = new Color[] { Color.White, Color.Black }; // Colores del tablero.

            // EN INSTANTES...
        }
    }
}
