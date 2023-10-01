using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

            // Realizaremos 2 ciclos for para recorrer todo el tablero mediante filas y columnas.

            for (int i = 0; i < n; i++) // Recorrer filas.
            {
                left = 2; // 2 espacios alternos desde el lado izquierdo.
                if (i % 2 == 0) { colors[0] = Color.White; colors[1] = Color.Black; } // Cuando es de color negro.

                else { colors[0] = Color.Black; colors[1] = Color.White; } // En caso contrario cuando el espacio es de color blanco.

                for (int j = 0; j < n; j++) // Columnas.
                {
                    P[i, j] = new PictureBox(); // Creación del tablero.
                    P[i, j].BackColor = colors[(j % 2 == 0) ? 1 : 0]; // Colores de fondo para cada espacio.
                    P[i, j].Location = new Point(left, top); // Nueva posición (x, y).
                    P[i, j].Size = new Size(50, 50); // Tamaño del tablero.
                    left += 50; // Tamaño del ancho del tablero a incrementar.
                    P[i, j].Name = i + " " + j; // El nombre se le asigna a un especio vacío del tablero.

                    // Usaremos las condiciones "if" y "else" para que el tablero pueda interactuar con cada una de sus 3 fichas.

                    if (i < (n / 2) - 1 && P[i, j].BackColor == Color.Black) { P[i, j].Image = Properties.Resources.r; P[i, j].Name += " r"; } // Esto hace referencia a que la ficha roja estuviese en los cuadros negros del tablero por defecto.
                    else if (i > (n / 2) && P[i, j].BackColor == Color.Black) // En caso contrario...
                    {
                        P[i, j].Image = Properties.Resources.g; P[i, j].Name += " g"; // La ficha verde quedará en los mismos cuadros mencionados anteriormente.
                    }

                    // Asegurarse de que todas las fichas estén en el centro de cada cuadro.

                    P[i, j].SizeMode = PictureBoxSizeMode.CenterImage;

                    // Se añaden los controles por cada fila y/o columna del tablero a las fichas.

                    G.Controls.Add(P[i, j]);
                }
                top += 50;
            }
        }
    }
}
