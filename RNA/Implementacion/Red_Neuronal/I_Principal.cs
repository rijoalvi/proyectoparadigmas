using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Red_Neuronal
{
    public partial class I_Principal : Form
    {
        //Variables globales
        private Control_BackPropagation control;    //Objeto de control de la red neuronal
        private int[,] matriz_dibujo;               //Matriz que guarda el patron del dibujo
        private bool mouse_Presionado;              //Indica si un boton del mouse se encuentra presionado
        private String muestras_creadas;            //Guarda la muestra que se crea
        private bool guardar_muestras;              //Indica si se pueden guardar las muestras o no
        private int iteraciones;                    //Guarda el numero de iteraciones realizadas en el entrenamiento
        private double error_grafica;               //Guarda el error de la iteracion para graficar durante el entrenamiento
        private bool cont_entrenar;                 //Anuncia si debe de seguir entrenando
        private Point origen;                       //Punto de origen para la graficacion
        private int resultado_entrenamiento;        //Guarda el codigo generado por el fin del entrenamiento
        private int iteracion_graficacion;          //Guarda el numero de iteracion en el panel de graficacion
         
        
        /// <summary>
        /// Constructor
        /// </summary>
        public I_Principal()
        {
            matriz_dibujo = new int[15,15];
            limpiar_matriz();
            mouse_Presionado = false;
            muestras_creadas = "";
            guardar_muestras = false;
            control = new Control_BackPropagation();
            InitializeComponent();
            iteraciones = 0;
            error_grafica = 0.0 ;
            resultado_entrenamiento = 0;
            iteracion_graficacion = 0;
            cont_entrenar = true;
            origen = new Point(2, 0);
            campo_muestra.Text = "Círculo";
        }

        /// <summary>
        /// Carga de la interfaz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void I_Principal_Load(object sender, EventArgs e)
        {
            panel_muestra_entrenamiento_bp.Visible = panel_ejecucion.Visible = panel_crear_muestras.Visible = panel_entrenamiento_bp.Visible = panel_entrenamiento_cp.Visible = false;
            menu_entrenamiento.Enabled = menu_ejecucion.Enabled = true;
            CheckForIllegalCrossThreadCalls = false;
        }

        /// <summary>
        /// Limpia la matriz de dibujo
        /// </summary>
        private void limpiar_matriz()
        {
            for (int i = 0; i < 15; ++i)
            {
                for (int j = 0; j < 15; ++j)
                {
                    matriz_dibujo[i, j] = 0;
                }
            }
        }

        /// <summary>
        /// Realiza la accion del evento del menu entrenamiento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_entrenamiento_Click(object sender, EventArgs e)
        {
            panel_ejecucion.Visible = panel_crear_muestras.Visible = panel_muestra_entrenamiento_bp.Visible= false;        //Habilita y deshabilita los botones correspondientes
            panel_entrenamiento_cp.Visible = false;
            panel_entrenamiento_bp.Visible = true;
            menu_entrenamiento.Enabled = false;
            menu_ejecucion.Enabled = true;
            limpiar_matriz();
            campo_ruta_pesos_ejecucion_bp.Text = "";
            campo_muestra.BackgroundImage = imagenes_figuras.Images[0];
            campo_muestra.Text = "Círculo";
            guardar_muestras = false;
            boton_abortar_entrenamiento.Enabled = true;
        }

        /// <summary>
        /// Realiza la accion del evento del menu ejecucion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_ejecucion_Click(object sender, EventArgs e)
        {
            panel_ejecucion.Visible = true;         //Habilita y deshabilita los botones correspondientes
            panel_entrenamiento_bp.Visible = panel_crear_muestras.Visible = panel_muestra_entrenamiento_bp.Visible = false;
            panel_entrenamiento_cp.Visible = false;
            menu_entrenamiento.Enabled = true;
            menu_ejecucion.Enabled = false;
            limpiar_matriz();
            campo_tiempo_ejecucion_bp.Text = campo_resultado_ejecucion_bp.Text = campo_ruta_pesos_ejecucion_bp.Text = "";
        }

        /// <summary>
        /// Realiza la accion del evento del menu salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_salir_Click(object sender, EventArgs e)
        {
            this.Close();   //Cierra la ventana
        }

        /// <summary>
        /// Realiza la accion del evento del click en el boton de elegir ruta de los patrones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_elegir_ruta_patrones_Click(object sender, EventArgs e)
        {
            if (ventana_elegir_ruta_muestras.ShowDialog() == DialogResult.OK)       //Si se realizo click en ok
            {
                campo_ruta_muestras_bp.Text = ventana_elegir_ruta_muestras.FileName;   //Coloca la ruta del archivo
            }
        }

        /// <summary>
        /// Captura el evento del cambio de texto en el campo de la ruta de las muestras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void campo_ruta_muestras_TextChanged(object sender, EventArgs e)
        {
            if (campo_ruta_muestras_bp.Text != "")     //Si hay una ruta en el campo
            {
                boton_entrenar_bp.Enabled = true;      //Habilita la opcion de entrenar
            }
            else                                    //Sino
            {
                boton_entrenar_bp.Enabled = false;     //Deshabilita la opcion de entrenar
            }
        }

        /// <summary>
        /// Realiza la accion del evento del click en el boton de elegir ruta de los pesos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_elegir_pesos_ejecucion_Click(object sender, EventArgs e)
        {
            if (veantana_elegir_ruta_pesos.ShowDialog() == DialogResult.OK)             //Si se realizo click en ok
            {
                campo_ruta_pesos_ejecucion_bp.Text = veantana_elegir_ruta_pesos.FileName;  //Coloca la ruta del archivo
            }
        }

        /// <summary>
        /// Captura el evento del cambio de texto en el campo de la ruta de los pesos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void campo_ruta_pesos_ejecucion_bp_TextChanged(object sender, EventArgs e)
        {
            if (campo_ruta_pesos_ejecucion_bp.Text != "")              //Si hay una ruta en el campo
            {
                boton_estabalecer_pesos_ejecucion_bp.Enabled = true;   //Habilita la opcion de establecer
            }
            else                                                    //Sino
            {
                boton_estabalecer_pesos_ejecucion_bp.Enabled = false;  //Deshabilita la opcion de establecer
            }
        }

        /// <summary>
        /// Realiza la accion del evento del click en el boton de establecer pesos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_estabalecer_pesos_ejecucion_bp_Click(object sender, EventArgs e)
        {
            if (campo_ruta_pesos_ejecucion_bp.Text.EndsWith(".ap"))            //Si contiene la extension correcta
            {
                if (File.Exists(campo_ruta_pesos_ejecucion_bp.Text))           //Si el archivo existe
                {
                    if (control.configurar_red_ejecucion(campo_ruta_pesos_ejecucion_bp.Text))//Configura la red para la ejecucion
                    {
                        groupBox_Dibujo.Enabled = true;                         //Habilita el panel de dibujo            
                        boton_estabalecer_pesos_ejecucion_bp.Enabled = false;
                    }
                    else                                                        //Si se produce un error al establecer la configuracion de la red
                    {
                        groupBox_Dibujo.Enabled = false;                        //Deshabilita el panel de dibujo
                        MessageBox.Show("Se produjo un error al establecer la configuración de la red", "Error configuración de red", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo de pesos no existe", "Error archivo de pesos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else                                                            //Si la extension es incorrecta muestra el error
            {
                //groupBox_Dibujo.Enabled = false;                            //Deshabilita el panel de dibujo
                MessageBox.Show("El archivo de pesos es incorreto", "Error archivo de pesos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Realiza la accion del evento del click en el boton de entrenar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_entrenar_Click(object sender, EventArgs e)
        {
            if (campo_ruta_muestras_bp.Text.EndsWith(".cm"))              //Si contiene la extension correcta
            {
                if (File.Exists(campo_ruta_muestras_bp.Text))
                {
                    panel_muestra_entrenamiento_bp.Visible = true;
                    control.configurar_red_aprendizaje(Convert.ToInt32(campo_neuronas_entrada_bp.Value), Convert.ToInt32(campo_neuronas_intermedia_bp.Value), Convert.ToInt32(campo_neuronas_salida_bp.Value), Convert.ToDouble(campo_IniPesos_Hasta_bp.Value), Convert.ToDouble(campo_IniPesos_Desde_bp.Value));
                    iteraciones = 0;
                    error_grafica = 0.0;
                    cont_entrenar = true;
                    resultado_entrenamiento = 0;
                    iteracion_graficacion = 0;
                    
                    //Manda a entrenar la red
                    Thread p1;                                          //HIlo que se encarga del entrenamiento de la red
                    p1 = new Thread(new ThreadStart(this.entrenar));
                    p1.SetApartmentState(ApartmentState.STA);
                    p1.IsBackground = true;
                    p1.Start();

                    Thread p2;                                          //hilo que se encarga mostrar el entrenamiento en la interfaz
                    p2 = new Thread(new ThreadStart(this.mostrar_entrenamiento));
                    p2.SetApartmentState(ApartmentState.STA);
                    p2.IsBackground = true;
                    p2.Start(); 
                }
                else
                {
                    MessageBox.Show("El archivo de  muestras no existe", "Error archivo de muestras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else                                                       //Si la extension es incorrecta muestra el error
            {
                MessageBox.Show("El archivo de  muestras es incorreto", "Error archivo de muestras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Se encarga invocar el entrenamiento de la red neuronal
        /// </summary>
        private void entrenar()
        {
            DateTime inicio = DateTime.Now;                                 //Guarda la hora a la que inicio el entrenamiento
            resultado_entrenamiento = control.entrenar(Convert.ToDouble(campo_error_bp.Value), Convert.ToDouble(campo_aprendizaje_bp.Value), campo_ruta_muestras_bp.Text, ref iteraciones, ref error_grafica, ref cont_entrenar);
            DateTime final = DateTime.Now;                                  //Guarda la hora en la que finaliza el entrenamiento
            TimeSpan total = final - inicio;                                //Calcula el tiempo total
            campo_tiempo_entrenamiento.Text = total.TotalSeconds.ToString();//Muestra el tiempo total
            boton_abortar_entrenamiento.Enabled = false;
            if (resultado_entrenamiento == 1)    //Si se realiza bien
            {
                entrenamiento_finalizado();     //Finaliza el entrenamiento
                panel_ejecucion.Visible = true;
            }
            else
            {
                if (resultado_entrenamiento == 2)   //Si se decidio abortar
                {
                    MessageBox.Show("Se ha forzado la finalización del entrenamiento.\nA continuación puede guardar los pesos que se tienen  hasta el momento", "Entrenamiento abortado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    salvar_pesos(); //Envia a guardar los pesos de entrenamiento
                    menu_entrenamiento_Click(null, null);
                }
                else //Si el entrenamiento salio con error
                {
                    MessageBox.Show("Se ha producido un error durante el entrenamiento.", "Error en entrenamiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    menu_acerca_de.Enabled = true;
                    menu_entrenamiento_Click(null, null);
                }
            } 
        }

        /// <summary>
        /// Se encarga de mostrar en la interfaz el entrenamiento que se esta realizando de la RN
        /// </summary>
        private void mostrar_entrenamiento() {
            while (cont_entrenar)
            {
                if (campo_iteraciones_entrenamiento.Value != iteraciones)
                {
                    campo_iteraciones_entrenamiento.Value = iteraciones;
                    graficar_error(error_grafica,iteraciones);
                }
            }
        }

        /// <summary>
        /// Pinta el panel de dibujo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_dibujo_Paint(object sender, PaintEventArgs e)
        {
            Pen lapiz = new Pen(Color.Gray);            //Crea un lapiz para pintar la cuadricula
            for (int i = 0; i <= 300; i = i + 20)       //Recorre todo el panel para dibujar la cuadricula
            {
                ((Panel)sender).CreateGraphics().DrawLine(lapiz, 0, i, 300, i);
                ((Panel)sender).CreateGraphics().DrawLine(lapiz, i, 0, i, 300);
            }
            SolidBrush brocha = new SolidBrush(System.Drawing.Color.White);    //Crea la brocha para pintar
            for (int i = 0; i < 15; i++)                        //Recorre filas
            {
                for (int j = 0; j < 15; j++)                    //Recorre columnas
                {
                    if (matriz_dibujo[i, j] == 1)                //Si esta pintado
                    {
                        brocha.Color = (Color.DarkSlateGray);  //Cambia el color de la brocha
                    }
                    else
                    {
                        brocha.Color = (Color.White);  //Cambia el color de la brocha
                    }
                    ((Panel)sender).CreateGraphics().FillRectangle(brocha, (i * 20) + 1, (j * 20) + 1, 19, 19); //Pinta el cuadro
                }
            }
        }

        /// <summary>
        /// Captura el evento si se dejo de presionar un boton en el mouse para el panel de dibujo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_dibujo_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_Presionado = false;
        }

        /// <summary>
        /// Captura el evento si se presiona un boton en el mouse para el panel de dibujo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_dibujo_MouseDown(object sender, MouseEventArgs e)
        {
            //Habilita los botones
            boton_limpiar_panel.Enabled = boton_reconocer_figura.Enabled = boton_guardar_muestra.Enabled = boton_limpiar_panel_muestra.Enabled = true;
            mouse_Presionado = true;            //Muestra que el boton esta siendo presionado
            int fila = e.X / 20;                //Calcula la fila
            int columna = e.Y / 20;             //Calcula la columna
            if (e.Button == MouseButtons.Left)  //Si es el izquierdo quiere pintar
            {
                matriz_dibujo[fila, columna] = 1;   //Pone el la matriz la entrada como pintada
                ((Panel)sender).Refresh();          //Refresca el panel
            }
            else if (e.Button == MouseButtons.Right) //Si es el derecho quiere borrar
            {
                matriz_dibujo[fila, columna] = 0;   //Pone el la matriz la entrada como limpia
                ((Panel)sender).Refresh();          //Refresca el panel
            }
        }

        /// <summary>
        /// Captura el evento si del moviemiento del mouse para el panel de dibujo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_dibujo_MouseMove(object sender, MouseEventArgs e)
        {
            int fila = e.X / 20;                //Calcula la fila
            int columna = e.Y / 20;             //Calcula la columna
            if (mouse_Presionado && 0 < e.X && e.X < 300 && 0 < e.Y && e.Y < 300) //Si el mouse esta presionado y se encuentra dentro del panel
            {
                SolidBrush brocha = new SolidBrush(System.Drawing.Color.White);    //Crea la brocha para pintar
                if (e.Button == MouseButtons.Left)                                 //Si es el izquierdo quiere pintar
                {
                    brocha.Color = (Color.DarkSlateGray);  //Cambia el color de la brocha
                    ((Panel)sender).CreateGraphics().FillRectangle(brocha, (fila * 20) + 1, (columna * 20) + 1, 19, 19); //Pinta el cuadro
                    matriz_dibujo[fila, columna] = 1;

                }
                else if (e.Button == MouseButtons.Right)    //Si es el derecho quiere borrar
                {
                    brocha.Color = (Color.White);  //Cambia el color de la brocha
                    ((Panel)sender).CreateGraphics().FillRectangle(brocha, (fila * 20) + 1, (columna * 20) + 1, 19, 19); //Pinta el cuadro
                    matriz_dibujo[fila, columna] = 0;
                }
            }
        }

        /// <summary>
        /// Realiza la accion del click en el boton limpiar panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_limpiar_panel_Click(object sender, EventArgs e)
        {
            boton_limpiar_panel.Enabled = false;
            boton_reconocer_figura.Enabled = false;
            limpiar_matriz();
            panel_dibujo.Refresh();
            campo_resultado_ejecucion_bp.Text = campo_tiempo_ejecucion_bp.Text = "";
        }

        /// <summary>
        /// Reliza la accion de reconocer la figura ingresada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_reconocer_figura_Click(object sender, EventArgs e)
        {
            int[] entrada = new int[225];
            for (int i = 0; i < 15; ++i)                    //recorre las filas de la matriz de dibujo
            {
                for (int j = 0; j < 15; ++j)                //recorre las filas de la matriz de dibujo
                {
                    entrada[(i * 15 ) +j] = matriz_dibujo[i, j];   //Guarda el valor de la matriz en la entrada
                }
            }

            DateTime inicio = DateTime.Now;                                         //Guarda la hora a la que inicio el reconocimiento
            int[] resultado = control.reconocer(entrada);                           //Realiza la ejecucion y guarda el resultado
            DateTime final = DateTime.Now;                                          //Guarda la hora en la que finaliza el reconocimiento
            TimeSpan total = final - inicio;                                        //Calcula el tiempo total
            campo_tiempo_ejecucion_bp.Text = total.TotalSeconds.ToString();         //Muestra el tiempo total
            campo_resultado_ejecucion_bp.BackgroundImage = imagenes_figuras.Images[reconocer_codificacion(resultado)];//Coloca el resultato del procesamiento
        }

        /// <summary>
        /// Muestra la ventana para la creacion de muestras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_crear_muestras_Click(object sender, EventArgs e)
        {
            panel_ejecucion.Visible = panel_entrenamiento_bp.Visible = panel_muestra_entrenamiento_bp.Visible = false;
            panel_crear_muestras.Visible = true;
            campo_iteraciones_muestras.Value = 0;
        }

        /// <summary>
        /// Realiza la accion del click en el boton limpiar panel de muestras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_limpiar_panel_muestra_Click(object sender, EventArgs e)
        {
            boton_limpiar_panel_muestra.Enabled = boton_guardar_muestra.Enabled = false;
            limpiar_matriz();
            panel_dibujo_muestra.Refresh();
            
        }

        /// <summary>
        /// Guarda la accion del click en guardar muestra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_guardar_muestra_Click(object sender, EventArgs e)
        {
            muestras_creadas += codificacion_figura_muestra() + ";" + codificacion_muestra() + "\n";
            boton_limpiar_panel_muestra.Enabled = boton_guardar_muestra.Enabled = false;
            limpiar_matriz();
            panel_dibujo_muestra.Refresh();
            establer_proxima_muestra();
        }

        /// <summary>
        /// Retorna la codificacion de la muestra segun la figura ingresada
        /// </summary>
        /// <returns>Codificacion de la muestra</returns>
        private String codificacion_figura_muestra()
        {
            //Retorna la configuracion segun la figura
            switch (campo_muestra.Text)
            {
                case "Círculo":
                    return "10000";
                case "Triángulo":
                    return "01000";
                case "Cuadrilatero":
                    return "00100";
                case "Pentagono":
                    return "00010";
                case "Hexágono":
                    return "00001";
            }
            return "";
        }

        /// <summary>
        /// Reconoce la codificacino para cada salida
        /// </summary>
        /// <param name="entrada">Vector de salida de la red</param>
        /// <returns>Indice de la imagen a mostrar, 5 si no pudo codificar</returns>
        private int reconocer_codificacion(int[]entrada)
        {
            //Retorna la configuracion segun la figura
            if (entrada[0] == 1 && entrada[1] == 0 && entrada[2] == 0 && entrada[3] == 0 && entrada[4] == 0)        //Si es una A
            {
                return 0;
            }
            else if (entrada[0] == 0 && entrada[1] == 1 && entrada[2] == 0 && entrada[3] == 0 && entrada[4] == 0)   //Si es una B
            {
                return 1;
            }
            else if (entrada[0] == 0 && entrada[1] == 0 && entrada[2] == 1 && entrada[3] == 0 && entrada[4] == 0)   //Si es una I
            {
                return 2;
            }
            else if (entrada[0] == 0 && entrada[1] == 0 && entrada[2] == 0 && entrada[3] == 1 && entrada[4] == 0)   //Si es una O
            {
                return 3;
            }
            else if (entrada[0] == 0 && entrada[1] == 0 && entrada[2] == 0 && entrada[3] == 0 && entrada[4] == 1)   //Si es una U
            {
                return 4;
            }
            return 5;                                                                                             //No se reconoce
        }

        /// <summary>
        /// Retorna la codificacion de la muestra segun el dibujo
        /// </summary>
        /// <returns>Codificacion de la muestra</returns>
        private String codificacion_muestra()
        {
            //Retorna la configuracion del dibujo
            String resultado = "";
            for (int i = 0; i < 15; ++i)        //Recorre toda la matriz de dibujo
            {
                for (int j = 0; j < 15; ++j)
                {
                    resultado += matriz_dibujo[i,j].ToString();
                }
            }
            return resultado;
        }

        /// <summary>
        /// Realiza la accion de cancelar la creacion de muestras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_cancelar_muestras_Click(object sender, EventArgs e)
        {
            muestras_creadas = "";                  //Borra las muestras creadas
            menu_entrenamiento_Click(null, null);   //Muestra el panel de entrenamiento
        }

        /// <summary>
        /// Establece cual es la siguiente muestra a ingresar
        /// </summary>
        private void establer_proxima_muestra()
        {
            switch (campo_muestra.Text)
            {
                case "Círculo":
                    campo_muestra.Text = "Triángulo";
                    campo_muestra.BackgroundImage = imagenes_figuras.Images[1];
                    guardar_muestras = false;
                    break;
                case "Triángulo":
                    campo_muestra.Text = "Cuadrilatero";
                    campo_muestra.BackgroundImage = imagenes_figuras.Images[2]; 
                    guardar_muestras = false;
                    break;
                case "Cuadrilatero":
                    campo_muestra.Text = "Pentagono";
                    campo_muestra.BackgroundImage = imagenes_figuras.Images[3];
                    guardar_muestras = false;
                    break;
                case "Pentagono":
                    campo_muestra.Text = "Hexágono";
                    campo_muestra.BackgroundImage = imagenes_figuras.Images[4];
                    guardar_muestras = false;
                    break;
                case "Hexágono":
                    campo_muestra.Text = "Círculo";
                    guardar_muestras = true;
                    campo_muestra.BackgroundImage = imagenes_figuras.Images[0];
                    campo_iteraciones_muestras.UpButton();
                    break;   
            }
        }

        /// <summary>
        /// Realiza la accion cuando se desean guardar las muestras creadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_guardar_muestras_Click(object sender, EventArgs e)
        {
            if (guardar_muestras)   //Si se pueden guardar las muestras
            {
                if (ventana_salvar_muestras.ShowDialog() == DialogResult.OK)            //Si se realizo click en ok
                {
                    if (ventana_salvar_muestras.FileName.EndsWith(".cm"))               //Si contiene la extension correcta
                    {
                        if (control.guardar_muestras(ventana_salvar_muestras.FileName, muestras_creadas))
                        {
                            muestras_creadas = "";                                          //Borra las muestras creadas
                            campo_ruta_muestras_bp.Text = ventana_salvar_muestras.FileName;    //Coloca la ruta del archivo
                            menu_entrenamiento_Click(null, null);                           //Muestra el panel de entrenamiento
                        }
                        else
                        {
                            MessageBox.Show("Error al guardar las muestras. Intente de nuevo", "Error al guardar muestras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else                                                                //Si la extension es incorrecta muestra el error
                    {
                        MessageBox.Show("La extensión del archivo de  muestras es incorreto", "Error archivo de muestras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else                    //Si no pueden guardar las muestras
            {
                MessageBox.Show("No se ha completado la secuencia de muestras.\nLeer nota!", "Error la guardar muestras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Realiza la accion cuando el panel de muestra del entrenamiento se hace visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_muestra_entrenamiento_VisibleChanged(object sender, EventArgs e)
        {
            campo_tiempo_entrenamiento.Text = "";   //Limpia los campos
            campo_iteraciones_entrenamiento.Value = 0;
            if (panel_muestra_entrenamiento_bp.Visible == true)
            {
                panel_ejecucion.Visible = panel_entrenamiento_bp.Visible = panel_crear_muestras.Visible =  false;        //Habilita y deshabilita los botones correspondientes
                menu_entrenamiento.Enabled = menu_ejecucion.Enabled = menu_acerca_de.Enabled = false;
            }
            else
            {
                menu_acerca_de.Enabled = true;
                menu_ejecucion_Click(null, null);
            }
        }

        /// <summary>
        /// Anuncia que ha finalizado el entrenamiento
        /// </summary>
        public void entrenamiento_finalizado()
        {
            MessageBox.Show("El entrenamiento ha finalizado con exito.\nA continuacion debe de guardar los pesos resultado del entrenamiento", "Entrenamiento finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            salvar_pesos(); //Envia a guardar los pesos de entrenamiento
        }

        /// <summary>
        /// Gestiona el guardado de los pesos de entrenamiento
        /// </summary>
        private void salvar_pesos()
        {
            bool intentar_nuevamente = false;                                               //Indica si se desea intentar de nuevo el guardado
            if (ventana_salvar_pesos.ShowDialog() == DialogResult.OK)                       //Si se realizo click en ok
            {
                if (ventana_salvar_pesos.FileName.EndsWith(".ap"))                          //Si contiene la extension correcta
                {
                    if (control.guardar_pesos(ventana_salvar_pesos.FileName))      //Si se guardo correctamente
                    {
                        MessageBox.Show("Se ha salvado su entrenamiento.\nYa puede utilizarlo para su ejecución.", "Entrenamiento guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        campo_ruta_pesos_ejecucion_bp.Text = ventana_salvar_pesos.FileName;
                    }
                    else
                    {
                        DialogResult respuesta = MessageBox.Show("Se a producido un error al guardar los pesos.\nDesea intentar guardar los pesos de nuevo?", "Error al guardar archivo de pesos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (respuesta == DialogResult.Yes)
                        {
                            intentar_nuevamente = true;
                        }
                    }
                }
                else                                                                //Si la extension es incorrecta muestra el error
                {
                    MessageBox.Show("La extensión del archivo de pesos es incorreto", "Error archivo de pesos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentar_nuevamente = true;   
                }
            }
            else                                                                    //Si se cancelo el guardado
            {
                //Advierte y pregunta si desea intentarlo de nuevo
                DialogResult respuesta = MessageBox.Show("A decidido no guardar los pesos resultado del entrenamiento.\nPor lo cual el entrenamiento no será satisfactorio.\nDesea guardar los pesos?", "Error archivo de pesos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if ( respuesta == DialogResult.Yes)
                {
                    intentar_nuevamente = true;
                }
            }
            if (intentar_nuevamente)    //Si se desea intentar de nuevo
            {
                salvar_pesos();
            }
        }

        /// <summary>
        /// Realiza la accion del click en el menu Acerca de 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_acerca_de_Click(object sender, EventArgs e)
        {
            ventana_acerca_de info = new ventana_acerca_de();
            info.Show();
        }

        /// <summary>
        /// Grafica el error en el panel
        /// </summary>
        /// <param name="error">Error generado</param>
        /// <param name="itera">Numero de iteracion</param>
        public void graficar_error(double error, int itera)
        {
            if (itera% (panel_grafico_error.Size.Width - 2) == 0)
            {
                ++iteracion_graficacion;                                    //Aumenta el numero de iteraciones en la graficacion
                origen.X = origen.X - panel_grafico_error.Size.Width + 4;   //Da el nuevo punto de la coordenada X
                panel_grafico_error.CreateGraphics().Clear(Color.White);    //Limpia el panel
            }
            Pen lapiz = new Pen(Color.Red,2);                               
            Point p1 = new Point(itera + 1 - ((panel_grafico_error.Size.Width -2)* iteracion_graficacion), 200 - Convert.ToInt32(200 * error));
            panel_grafico_error.CreateGraphics().DrawLine(lapiz, origen, p1);//Dibuja en el panel
            origen = p1; 

        }

        /// <summary>
        /// Realiza la accion de abortar el entrenamiento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_abortar_entrenamiento_Click(object sender, EventArgs e)
        {
            boton_abortar_entrenamiento.Enabled = false;
            cont_entrenar = false;  //cambia la varaiable para que finalice el entrenamiento
        }

        /// <summary>
        /// Realiza la accion del campo del tipo de red a entrenar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void campo_elegir_tipo_red_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (campo_elegir_tipo_red.SelectedIndex == 0) //Si es el tipo bp
            {
                configuracion_red_bp.Visible = true;
                configuracion_red_cp.Visible = false;
            }
            else
            {
                configuracion_red_cp.Visible = true;
                configuracion_red_bp.Visible = false;
            }

        }

        /// <summary>
        /// Captura el evento del cambio de texto en el campo de la ruta de las muestras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void campo_ruta_muestras_cp_TextChanged(object sender, EventArgs e)
        {
            if (campo_ruta_muestras_cp.Text != "")     //Si hay una ruta en el campo
            {
                boton_entrenar_cp.Enabled = true;      //Habilita la opcion de entrenar
            }
            else                                            //Sino
            {
                boton_entrenar_cp.Enabled = false;     //Deshabilita la opcion de entrenar
            }
        }

        /// <summary>
        /// Realiza la accion del evento del click en el boton de elegir ruta de los patrones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_elegir_ruta_muestras_cp_Click(object sender, EventArgs e)
        {
            if (ventana_elegir_ruta_muestras.ShowDialog() == DialogResult.OK)       //Si se realizo click en ok
            {
                campo_ruta_muestras_cp.Text = ventana_elegir_ruta_muestras.FileName;   //Coloca la ruta del archivo
            }
        
        }

        /// <summary>
        /// Manda a entrenar la red de contrapropagacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_entrenar_cp_Click(object sender, EventArgs e)
        {
            if (campo_ruta_muestras_cp.Text.EndsWith(".cm"))              //Si contiene la extension correcta
            {
                if (File.Exists(campo_ruta_muestras_cp.Text))
                {
                    panel_entrenamiento_cp.Visible = true;
                    //control.configurar_red_aprendizaje(Convert.ToInt32(campo_neuronas_entrada_bp.Value), Convert.ToInt32(campo_neuronas_intermedia_bp.Value), Convert.ToInt32(campo_neuronas_salida_bp.Value), Convert.ToDouble(campo_IniPesos_Hasta_bp.Value), Convert.ToDouble(campo_IniPesos_Desde_bp.Value));
                    //iteraciones = 0;
                    //error_grafica = 0.0;
                    //cont_entrenar = true;
                    //resultado_entrenamiento = 0;
                    //iteracion_graficacion = 0;

                    ////Manda a entrenar la red
                    //Thread p1;                                          //HIlo que se encarga del entrenamiento de la red
                    //p1 = new Thread(new ThreadStart(this.entrenar));
                    //p1.SetApartmentState(ApartmentState.STA);
                    //p1.IsBackground = true;
                    //p1.Start();

                    //Thread p2;                                          //hilo que se encarga mostrar el entrenamiento en la interfaz
                    //p2 = new Thread(new ThreadStart(this.mostrar_entrenamiento));
                    //p2.SetApartmentState(ApartmentState.STA);
                    //p2.IsBackground = true;
                    //p2.Start();
                }
                else
                {
                    MessageBox.Show("El archivo de  muestras no existe", "Error archivo de muestras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else                                                       //Si la extension es incorrecta muestra el error
            {
                MessageBox.Show("El archivo de  muestras es incorreto", "Error archivo de muestras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Captura el evento del cambio de texto en el campo de la ruta de los pesos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void campo_ruta_pesos_ejecucion_cp_TextChanged(object sender, EventArgs e)
        {
            if (campo_ruta_pesos_ejecucion_cp.Text != "")              //Si hay una ruta en el campo
            {
                boton_estabalecer_pesos_ejecucion_cp.Enabled = true;   //Habilita la opcion de establecer
            }
            else                                                    //Sino
            {
                boton_estabalecer_pesos_ejecucion_cp.Enabled = false;  //Deshabilita la opcion de establecer
            }
        }

        /// <summary>
        /// Realiza la accion del evento del click en el boton de elegir ruta de los pesos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_elegir_pesos_ejecucion_cp_Click(object sender, EventArgs e)
        {
            if (veantana_elegir_ruta_pesos.ShowDialog() == DialogResult.OK)                 //Si se realizo click en ok
            {
                campo_ruta_pesos_ejecucion_cp.Text = veantana_elegir_ruta_pesos.FileName;  //Coloca la ruta del archivo
            }
        }

        /// <summary>
        /// Realiza la accion del evento del click en el boton de establecer pesos en CP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boton_estabalecer_pesos_ejecucion_cp_Click(object sender, EventArgs e)
        {
            if (campo_ruta_pesos_ejecucion_cp.Text.EndsWith(".ap"))            //Si contiene la extension correcta
            {
                if (File.Exists(campo_ruta_pesos_ejecucion_cp.Text))           //Si el archivo existe
                {
                    //if (control.configurar_red_ejecucion(campo_ruta_pesos_ejecucion_bp.Text))//Configura la red para la ejecucion
                    //{
                    //    groupBox_Dibujo.Enabled = true;                         //Habilita el panel de dibujo            
                    //    boton_estabalecer_pesos_ejecucion_bp.Enabled = false;
                    //}
                    //else                                                        //Si se produce un error al establecer la configuracion de la red
                    //{
                    //    groupBox_Dibujo.Enabled = false;                        //Deshabilita el panel de dibujo
                    //    MessageBox.Show("Se produjo un error al establecer la configuración de la red", "Error configuración de red", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                else
                {
                    MessageBox.Show("El archivo de pesos no existe", "Error archivo de pesos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else                                                            //Si la extension es incorrecta muestra el error
            {
                //groupBox_Dibujo.Enabled = false;                            //Deshabilita el panel de dibujo
                MessageBox.Show("El archivo de pesos es incorreto", "Error archivo de pesos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





    }//fin de la clase
}
