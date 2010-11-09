using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

using System.Windows.Forms;


namespace Red_Neuronal
{
    /// <summary>
    /// Lleva el control de la red neuronal de retropropagacion
    /// </summary>
    class Control_CounterPropagation
    {

         //Variables globales
        private Red_Neuronal_CounterPropagation red_neuronal;
        private double[,] pesos_anteriores;
        private const double bin_uno = 0.99;
        private const double bin_cero = 0.01;
        private const int iteraciones_minimas = 100;

        /// <summary>
        /// Constructor
        /// </summary>
        public Control_CounterPropagation()
        {
            red_neuronal = null;
            pesos_anteriores = null;
        }

        /// <summary>
        /// Configura la red neuronal para prepararla en el aprendizaje
        /// </summary>
        /// <param name="cantEntrada">Cantidad de neuronas de la capa de entrada</param>
        /// <param name="cantOculta">Cantidad de neuronas de la capa oculta</param>
        /// <param name="cantSalida">Cantidad de neuronas de la capa de salida</param>
        public void configurar_red_aprendizaje(int cantEntrada, int cantOculta, int cantSalida)
        {
            if (red_neuronal != null)
            {
                red_neuronal = null;
            }
            red_neuronal = new Red_Neuronal_CounterPropagation(cantEntrada, cantOculta, cantSalida);//Inicializa la red
            inicializar_pesos_entrenamiento();                                                      //Inicializa los pesos para el entrenamiento, si falla sale                        
            pesos_anteriores = new double[cantEntrada, cantOculta];
        }

        /// <summary>
        /// Inicializa los pesos de la red para realizar el entrenamiento
        /// </summary>
        /// <param name="ruta_muestras">Ruta de las muestras con las que se desea entrenar</param>
        private void inicializar_pesos_entrenamiento()
        {
            double peso = bin_uno;
            Random r = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < red_neuronal.get_cantidad_neuronas_oculta(); ++i)                      //Para cada una de las neuronas ocultas, excepto umbral
            {
                for (int h = 0; h < red_neuronal.get_cantidad_neuronas_entrada(); ++h)                 //Para cada una de las neuronas de entrada
                {
                    //Calcula el peso
                    //if (i == 0) { peso = bin_uno; } else { peso = bin_cero + (r.NextDouble() * (bin_uno - bin_cero));}
                    if (i == 0)peso = bin_uno; 
                    else if (i == 1) peso = bin_uno - 0.01;
                    else if (i == 2) peso = bin_uno - 0.02;
                    else if (i == 3) peso = bin_uno - 0.03;
                    else if (i == 4) peso = bin_uno - 0.04;

                    red_neuronal.set_peso_oculta(h, i, peso);  //Establece el nuevo peso
                }
            }
        }

        /// <summary>
        /// Inicializa los pesos de la red con los que recibe por parametro
        /// </summary>
        /// <param name="pesos_oculta">Lista de pesos de la capa oculta</param>
        /// <param name="pesos_salida">Lista de pesos de la capa de salida</param>
        private void inicializar_pesos(double[,] pesos_oculta, double[,] pesos_salida)
        {
            if (red_neuronal != null) //Si la red existe
            {
                //Asigna los pesos de la capa oculta
                for (int h = 0; h < red_neuronal.get_cantidad_neuronas_entrada(); h++)
                {
                    for (int i = 0; i < red_neuronal.get_cantidad_neuronas_oculta(); i++)
                    {
                        red_neuronal.set_peso_oculta(h, i, pesos_oculta[h, i]);
                    }
                }

                //Asigna los pesos de la capa de salida
                for (int i = 0; i < red_neuronal.get_cantidad_neuronas_oculta(); i++)
                {
                    for (int j = 0; j < red_neuronal.get_cantidad_neuronas_salida(); j++)
                    {
                        red_neuronal.set_peso_salida(i, j, pesos_salida[i, j]);
                    }
                }
            }
        }

        /// <summary>
        /// Se encarga del entrenamiento de la RN
        /// </summary>
        /// <param name="c_aprendizaje_alpha">Coeficiente de aprendizaje alpha para el ajuste de los pesos en la capa oculta</param>
        /// <param name="error_permitido_oculta">Error permitido en entrenamiento de capa oculta</param>
        /// <param name="ruta_muestras">Ruta del archivo de las muestras</param>
        /// <param name="num_iteracion">Guarda el numero de iteracion en la que se encuentra</param>
        /// <returns>0: falló, 1: exitoso</returns>
        public int entrenar(double c_aprendizaje_alpha, double error_permitido_oculta, String ruta_muestras, ref int num_iteracion)
        {
            if (entrenar_oculta(c_aprendizaje_alpha, ruta_muestras, error_permitido_oculta, ref num_iteracion) == 0) return 0;  //Entrena la capa oculta, y si falla sale
            if (entrenar_salida(ruta_muestras) == 0) return 0;                                                                  //Entrena la capa de salida, y si falla sale
            return 1;                                                                                                           //Si se entrena correctamente informa el exito
        }

        /// <summary>
        /// Inicializa la entrada para la ejecucion
        /// </summary>
        /// <param name="muestra">Hilera con la muestra de un valor de entrada</param>
        private void inicializar_entrada(String muestra)
        {
            double[] valor_entrada = new double[red_neuronal.get_cantidad_neuronas_entrada()];          //Guarda el valor de entrada de la muestra
            int i = red_neuronal.get_cantidad_neuronas_salida() + 1;                                    //Inicializa en el indice de las entradas
            for (; i < red_neuronal.get_cantidad_neuronas_salida() + red_neuronal.get_cantidad_neuronas_entrada() + 1; ++i) //Recorre la linea de entradas de la muestra
            {
                int valor = Convert.ToInt32(new string(muestra[i], 1));                                                     //Guarda el valor de la muestra
                if (valor == 1)                                                                                             //Codifica los valores del archivo a lo necesario en la ejecucion
                {
                    valor_entrada[i - (red_neuronal.get_cantidad_neuronas_salida()) -1 ] = bin_uno;
                }
                else
                {
                    valor_entrada[i - (red_neuronal.get_cantidad_neuronas_salida()) - 1] = bin_cero;
                }
            }
            normalizar(valor_entrada); //Normaliza
        }

        /// <summary>
        /// Normaliza la entrada de la red
        /// </summary>
        /// <param name="entrada"></param>
        private void normalizar(double[] entrada)
        {
            //Normaliza
            double denominador = 0.0;
            for (int h = 0; h < red_neuronal.get_cantidad_neuronas_entrada(); ++h)
            {
                denominador += Math.Pow(entrada[h], 2);                             //suma todas las entradas al cuadrado
            }
            denominador = Math.Sqrt(denominador);                                   //Calcula la raiz cuadrada

            for (int j = 0; j < red_neuronal.get_cantidad_neuronas_entrada(); ++j)  //para todas las neuronas de la capa de entrada
            {
                red_neuronal.set_valor_entrada(j, entrada[j] / denominador);        //guarda el valor de las y's de la capa de entrada
            }
        }

        /// <summary>
        /// Se encarga del entrenamiento de la capa oculta
        /// </summary>
        /// <param name="c_aprendizaje_alpha">Coeficiente de aprendizaje</param>
        /// <param name="ruta_muestras">Ruta del archivo de las muestras</param>
        /// <param name="error_permitido_oculta">Error premitido en el entrenamiento</param>
        /// <param name="num_iteracion">Guarda el numero de iteracion en la que se encuentra</param>
        /// <returns>0: falló, 1: exitoso</returns>
        private int entrenar_oculta(double c_aprendizaje_alpha, String ruta_muestras, double error_permitido_oculta, ref int num_iteracion)
        {
            try
            {
                String muestra = "";                                                                //Guarda una muestra
                bool otra_iteracion = true;                                                         //Dice si se debe volver a iterar
                int iteraciones = 0;                                                                //Cuenta el numero de iteraciones
                int ganador = 0;                                                                    //Guarda el indice de la neurona ganadora en la capa oculta
                double alpha = c_aprendizaje_alpha;
                while (otra_iteracion)                                                              //Mientras deba iterar
                {
                    FileStream archivo = new FileStream(ruta_muestras, FileMode.Open, FileAccess.Read);
                    StreamReader archivo_muestras = new StreamReader(archivo);                      //Abre el archivo especificado
                    otra_iteracion = false;                                                         //Limpia la variable de la iteracion
                    while ((muestra = archivo_muestras.ReadLine()) != null)                         //Lleva el control de cada iteracion
                    {
                        inicializar_entrada(muestra);                                               //Ingresa los valores de entrada, normalizados
                        ganador = propagar_oculta();                                                //Propaga en la capa oculta
                        ajustar_pesos_oculta(ganador, alpha);                                       //Ajusta los pesos de la capa oculta
                    }
                    ++iteraciones;                              //Cuenta las iteraciones
                    archivo_muestras.Close();                   //Cierra el archivo
                    archivo.Close();
                    num_iteracion = iteraciones;                //Guarda las iteraciones que lleva
                    alpha = alpha - (alpha* 0.005);              //Disminuye el alpha en un 0,5% del anterior
                    if (iteraciones_minimas > iteraciones)      //Si no ha cumplido con la cantidad minima de iteraciones
                    {
                        otra_iteracion = true;                                      //Continua iterando
                    }
                    else
                    {
                        otra_iteracion = iterar_nuevamente(error_permitido_oculta); //Calcula si debe de iterar de nuevo
                    }
                }
            }
            catch (Exception e)
            {
                return 0;           //Anuncia el error enviando 0
            }
            return 1;               //Anuncia que el proceso fue correcto enviando1

        }


        /// <summary>
        /// Calcula si debe de iterar de nuevo
        /// </summary>
        /// <param name="error_permitido">El error que se permite en los pesos</param>
        /// <returns>True si debe de volver a iterar</returns>
        private bool iterar_nuevamente(double error_permitido)
        {
            double error_generado = 0.0;    //guarda el error general
            bool volver_iterar = false;     //Dice si se debe de volver a iterar
            for (int j = 0; j < red_neuronal.get_cantidad_neuronas_oculta(); ++j)       //recorre todas las neuronas de la capa oculta
            {
                for (int h = 0; h < red_neuronal.get_cantidad_neuronas_entrada(); ++h)  //recorre todas las neuronas de la capa de entrada
                {
                    double error_salida = Math.Abs(red_neuronal.get_peso_oculta(h,j) - pesos_anteriores[h,j]);  //Calcula el error de los pesos
                    error_generado += error_salida;
                    if (error_salida > error_permitido) volver_iterar = true; //Si no cumple con el error debe de volver a iterar

                }
            }
            error_generado /= (red_neuronal.get_cantidad_neuronas_oculta() * red_neuronal.get_cantidad_neuronas_entrada()); //Saca el promedio
            if (error_generado > error_permitido) volver_iterar = true; //Si no cumple con el error debe de volver a iterar

            for (int j = 0; j < red_neuronal.get_cantidad_neuronas_oculta(); ++j)       //recorre todas las neuronas de la capa oculta
            {
                for (int h = 0; h < red_neuronal.get_cantidad_neuronas_entrada(); ++h)  //recorre todas las neuronas de la capa de entrada
                {
                    pesos_anteriores[h, j] = red_neuronal.get_peso_oculta(h, j);
                }
            }

            return volver_iterar;           
        }

        /// <summary>
        /// Se encarga del entrenamiento de la capa de salida
        /// </summary>
        /// <param name="ruta_muestras">Ruta del archivo de las muestras</param>
        /// <returns>0: falló, 1: exitoso</returns>
        private int entrenar_salida(String ruta_muestras)
        {
            try
            {
                String muestra = "";                                                                //Guarda una muestra
                int ganador = 0;                                                                    //Guarda el indice de la neurona ganadora en la capa oculta
                int[,] promedios = new int[red_neuronal.get_cantidad_neuronas_oculta(), red_neuronal.get_cantidad_neuronas_oculta()]; //Guarda los promedios para cada salida
                FileStream archivo = new FileStream(ruta_muestras, FileMode.Open, FileAccess.Read);
                StreamReader archivo_muestras = new StreamReader(archivo);                          //Abre el archivo especificado
                
                //Cuenta el numero de veces que es la ganadora para cada muestra
                int i = 0;
                while((muestra = archivo_muestras.ReadLine()) != null)                              //Lleva el control de cada iteracion
                {
                    inicializar_entrada(muestra);                                                   //Ingresa los valores de entrada, normalizados
                    ganador = propagar_oculta();                                                    //Propaga en la capa oculta
                    ++promedios[i, ganador];
                    ++i;
                    if(i >= red_neuronal.get_cantidad_neuronas_oculta())i = 0;
                }
                archivo_muestras.Close();           //Cierra el archivo
                archivo.Close();
                
                //Saca las neuronas ganadoras para cada una de los tipos de muestra
                int[] indices_ganador = new int[red_neuronal.get_cantidad_neuronas_oculta()];   //Guarda los indices la capa oculta que mapea cada tipo de salida, [muestra] = neurona
                for (int j = 0; j < red_neuronal.get_cantidad_neuronas_oculta(); ++j)           //Recorre para cada tipo de muestra
                {
                    int max = 0;                                                            //Guarda el maximo de indice de para cada muestra
                    int indice_ganador = 0;                                                 //Guarda el indice de la neurona oculta que contien el maximo 
                    for (int k = 0; k < red_neuronal.get_cantidad_neuronas_oculta(); ++k)   //Recorre para cada una de las neuronas de la capa oculta (clase)
                    {
                        if (promedios[j, k] > max)           //Si es un nuevo maximo
                        {
                            max = promedios[j, k];          //Guarda el nuevo maximo
                            indice_ganador = k;             //Guarda el indice del mayor
                        }
                    }
                    indices_ganador[j] = indice_ganador;    //Guarda el indice de la neurona ganadora para la muestra 
                }

                ajustar_pesos_salida(indices_ganador);      //Ajusta los pesos de la capa de salida
            }
            catch (Exception e)
            {
                return 0;           //Anuncia el error enviando 0
            }
            return 1;               //Anuncia que el proceso fue correcto enviando 1

        }

        /// <summary>
        /// Realiza la propagacion en la capa oculta
        /// </summary>
        /// <returns>retorna el indice del ganador</returns>
        private int propagar_oculta()
        {
            //Calcula las salidas de la capa oculta
            for (int i = 0; i < red_neuronal.get_cantidad_neuronas_oculta(); ++i)   //recorre todas las neuronas de la capa oculta
            {
                red_neuronal.set_valor_oculta(i, calcular_salida_oculta(i));        //calcula la salida de la neurona
            }

            //Busca la neurona ganadora
            int ganador = 0;
            for (int h = 0; h < red_neuronal.get_cantidad_neuronas_oculta(); h++)   //Recorre toda la capa oculta
            {
                if (red_neuronal.get_valor_oculta(h) > red_neuronal.get_valor_oculta(ganador))ganador = h;  //Guarda el ganador
            }

            //Coloca para el ganador el valor 1 y el resto en 0
            for (int h = 0; h < red_neuronal.get_cantidad_neuronas_oculta(); h++)   //Recorre toda la capa oculta
            {
                if (h == ganador) red_neuronal.set_valor_oculta(h, 1);        //Coloca el valor de la nueva salida ganadora
                else red_neuronal.set_valor_oculta(h, 0); 
            }

            return ganador;
        }

        /// <summary>
        /// Realiza la propagacion en la capa de salida
        /// </summary>
        /// <param name="neurona_ganadora">indice de la neurona ganadora en la capa oculta</param>
        private void propagar_salida(int neurona_ganadora)
        {
            //Calcula las salidas de la capa de salida
            for (int i = 0; i < red_neuronal.get_cantidad_neuronas_salida(); ++i)               //recorre todas las neuronas de la capa de salida
            {
                red_neuronal.set_valor_salida(i, calcular_salida_salida(i, neurona_ganadora));  //calcula la salida de la neurona
            }
        }

        /// <summary>
        /// Propaga en la capa oculta
        /// </summary>
        /// <param name="neurona_ganadora">Indice de la neurona ganadora</param>
        /// <param name="c_aprendizaje_alpha">Coeficiente de aprendizaje</param>
        private void ajustar_pesos_oculta(int neurona_ganadora, double c_aprendizaje_alpha)
        {
            //Establece los nuevos pesos de la capa oculta
            for (int h = 0; h < red_neuronal.get_cantidad_neuronas_entrada(); ++h)  //Para cada una de las neuronas de entrada
            {
                red_neuronal.set_peso_oculta(h, neurona_ganadora, nuevo_peso_oculta(h, neurona_ganadora, c_aprendizaje_alpha));  //Calcula y establece el nuevo peso
            }
        }

        /// <summary>
        /// Ajusta los pesos para la capa de salida
        /// </summary>
        /// <param name="indices_ganador">Neuronas ocultas ganadoras para cada tipo de muestra</param>
        private void ajustar_pesos_salida(int[] indices_ganador)
        {
            //Establece los nuevos pesos de la capa oculta
            for (int num_muestra = 0; num_muestra < red_neuronal.get_cantidad_neuronas_oculta(); ++num_muestra)  //Para cada una de las muestras
            {
                for (int i = 0; i < red_neuronal.get_cantidad_neuronas_salida(); ++i)       //Para cada una de las neuronas de salida
                {
                    if (i == num_muestra)                                                   //Si debe de ser 1, segun el numero de muestra
                    {
                        red_neuronal.set_peso_salida(indices_ganador[num_muestra], i, 1);
                    }
                    else
                    {
                        red_neuronal.set_peso_salida(indices_ganador[num_muestra], i, 0);
                    }
                }
            }
        }

        /// <summary>
        /// Calcula la salida de una neurona de la capa oculta
        /// </summary>
        /// <param name="neurona_oculta">Indice de la neurona de la capa oculta </param>
        /// <returns>Valor de la salida de la neurona</returns>
        private double calcular_salida_oculta(int neurona_oculta)
        {
            double neto = 0.0;      //Guarda el valor neto
            for (int h = 0; h < red_neuronal.get_cantidad_neuronas_entrada(); h++) //Sumatoria de los valores netos
            {
                neto += red_neuronal.get_valor_entrada(h) * red_neuronal.get_peso_oculta(h, neurona_oculta); // entrada.Y[h] * oculta.W[h,i]
            }
            return neto;
        }

        /// <summary>
        /// Calcula la salida de una neurona de la capa de salida
        /// </summary>
        /// <param name="neurona_salida">Indice de la neurona de la capa de salida </param>
        /// <param name="neurona_oculta">Indice de la neurona de la capa oculta </param>
        /// <returns>Valor de la salida de la neurona</returns>
        private double calcular_salida_salida(int neurona_salida, int neurona_oculta)
        {
            double salida = 0.0;    //Guarda la salida
            salida = red_neuronal.get_peso_salida(neurona_oculta, neurona_salida); //Asigna el peso de la cpa de salida como al salida
            return salida;          //Retorna la salida
        }

        /// <summary>
        /// Calcula el nuevo peso de la capa oculta entre la neurona de la capa de entrada y la neurona de la capa oculta
        /// </summary>
        /// <param name="neurona_entrada">Indice de la neurona de la capa de entrada</param>
        /// <param name="neurona_oculta">Indice de la neurona de la capa oculta</param>
        /// <param name="c_error">Recibe el coficiente del error (alpha)</param>
        /// <returns>El nuevo peso calculado</returns>
        private double nuevo_peso_oculta(int neurona_entrada, int neurona_oculta, double c_error)
        { 
            double w = red_neuronal.get_peso_oculta(neurona_entrada, neurona_oculta);
            return (w + (c_error * (red_neuronal.get_valor_entrada(neurona_entrada) - w)));
        }

        /// <summary>
        /// Configura la red neuronal para prepararla en la ejecucion
        /// </summary>
        /// <param name="ruta_pesos">Ruta del archivo que contiene los pesos de la red</param>
        /// <returns>'True' si se realizo correctamente</returns>
        public bool configurar_red_ejecucion(String ruta_pesos)
        {
            if (red_neuronal != null)
            {
                red_neuronal = null;
            }
            return establecer_pesos(ruta_pesos); //Se inicializan los pesos de la red
        }

        /// <summary>
        /// Establece los pesos de la red desde el archivo de pesos que recibe por parametro
        /// </summary>
        /// <param name="ruta_pesos">Ruta del directorio de los pesos para configurar la red</param>
        /// <returns>'True' si se realizo correctamente</returns>
        private bool establecer_pesos(String ruta_pesos)
        {
            try
            {
                FileStream archivo = new FileStream(ruta_pesos, FileMode.Open, FileAccess.Read);//que habra el archivo de muestras
                StreamReader archivo_pesos = new StreamReader(archivo);                         //Abre el archivo especificado
                String peso = "";                                                               //Guarda el peso leido desde el archivo

                //Obtiene los valores de configuracion
                int cantEntrada, cantOculta, cantSalida;
                peso = archivo_pesos.ReadLine();                //Lee la primera linea
                if (peso != "Configuracion") return false;      //El archivo debe de empezar con la etiqueta "Configuracion", sino sale
                peso = archivo_pesos.ReadLine();                //Lee la sigueinte linea
                if (peso != "CP") return false;                 //El archivo debe estar configurado como CP
                peso = archivo_pesos.ReadLine();                //Lee el valor
                cantEntrada = Convert.ToInt32(peso);            //Lo convierte
                peso = archivo_pesos.ReadLine();                //Lee el valor
                cantOculta = Convert.ToInt32(peso);             //Lo convierte
                peso = archivo_pesos.ReadLine();                //Lee el valor
                cantSalida = Convert.ToInt32(peso);             //Lo convierte
                red_neuronal = new Red_Neuronal_CounterPropagation(cantEntrada, cantOculta, cantSalida); //Inicializa la red

                peso = archivo_pesos.ReadLine();        //Lee la primera linea
                if (peso != "Oculta") return false;     //El archivo debe de empezar con la etiqueta "Oculta", sino sale

                double[,] pesos_oculta = new double[red_neuronal.get_cantidad_neuronas_entrada() , red_neuronal.get_cantidad_neuronas_oculta() ];
                double[,] pesos_salida = new double[red_neuronal.get_cantidad_neuronas_oculta() , red_neuronal.get_cantidad_neuronas_salida() ];

                //Asigna los pesos para la capa oculta
                for (int h = 0; h < red_neuronal.get_cantidad_neuronas_entrada(); h++)
                {
                    for (int i = 0; i < red_neuronal.get_cantidad_neuronas_oculta(); i++)
                    {
                        peso = archivo_pesos.ReadLine();
                        pesos_oculta[h, i] = Convert.ToDouble(peso);
                    }
                }

                peso = archivo_pesos.ReadLine();        //Lee la siguiente linea
                if (peso != "Salida") return false;     //El archivo continua con la etiqueta "Salida", sino sale

                //Asigna los pesos de la capa de salida
                for (int i = 0; i < red_neuronal.get_cantidad_neuronas_oculta(); i++)
                {
                    for (int j = 0; j < red_neuronal.get_cantidad_neuronas_salida(); j++)
                    {
                        peso = archivo_pesos.ReadLine();
                        pesos_salida[i, j] = Convert.ToDouble(peso);
                    }
                }

                peso = archivo_pesos.ReadLine();                //Lee la ultima linea
                if (peso != "Fin") return false;                //El archivo continua con la etiqueta "Fin", sino sale
                archivo_pesos.Close();                          //Cierra el archivo
                archivo.Close();
                inicializar_pesos(pesos_oculta, pesos_salida);  //Inicializa los pesos de la red
            }
            catch (Exception e)
            {
                return false;
            }
            return true;                                    //Informa del exito de la operacion
        }

        /// <summary>
        /// Obtiene la salida segun sea la entrada recibida
        /// </summary>
        /// <param name="entrada">Parametros de entrada para la red neuronal</param>
        /// <returns>Vector de salida generado por la RN</returns>
        public int[] reconocer(int[] entrada)
        {
            int[] resultado = new int[red_neuronal.get_cantidad_neuronas_salida()];             //Guarda el resultado de la ejecucion
            double[] valor_entrada = new double[red_neuronal.get_cantidad_neuronas_entrada()];  //Guarda el valor de entrada de la muestra
            for (int i = 0; i < red_neuronal.get_cantidad_neuronas_entrada(); ++i)              //Recorre la linea de entradas de la muestra
            {
                if (entrada[i] == 1)valor_entrada[i] = bin_uno;                                 //Codifica los valores del archivo a lo necesario en la ejecucion
                else valor_entrada[i] = bin_cero;
            }
            normalizar(valor_entrada);                                                      //Normaliza la entrada
            int ganadora = propagar_oculta();                                               //Propaga en la capa oculta
            propagar_salida(ganadora);                                                      //Propaga en la capa de salida
            
            //Toma la salida de la red (resultado)
            for (int j = 0; j < red_neuronal.get_cantidad_neuronas_salida(); ++j)           //Recorre todas las neuronas de la capa de salida
            {
                int valor = 0;
                if (red_neuronal.get_valor_salida(j) > 0.5) valor = 1;                      //Codifica los valores la red a lo necesario en la interfaz
                resultado[j] = valor;                                                       //Guarda el resultado
            }
            return resultado;
        }

        /// <summary>
        /// Guarda en un archivo los pesos actuales de la red en la ruta que recibe
        /// </summary>
        /// <param name="ruta">Ruta del archivo a crear</param>
        /// <returns>True si se realiza correctamente</returns>
        public bool guardar_pesos(String ruta)
        {
            int cant_entrada = red_neuronal.get_cantidad_neuronas_entrada();
            int cant_oculta = red_neuronal.get_cantidad_neuronas_oculta();
            int cant_salida = red_neuronal.get_cantidad_neuronas_salida();
            try
            {
                FileStream archivo = new FileStream(ruta, FileMode.Create, FileAccess.Write);
                StreamWriter archivo_salida = new StreamWriter(archivo);
                archivo_salida.WriteLine("Configuracion");
                archivo_salida.WriteLine("CP");
                archivo_salida.WriteLine(cant_entrada);
                archivo_salida.WriteLine(cant_oculta);
                archivo_salida.WriteLine(cant_salida);
                archivo_salida.WriteLine("Oculta");
                for (int h = 0; h < cant_entrada; h++)
                {
                    for (int i = 0; i < cant_oculta; i++)
                    {
                        archivo_salida.WriteLine(red_neuronal.get_peso_oculta(h, i));
                    }
                }
                archivo_salida.WriteLine("Salida");    //Agrega la etiqueta para los pesos de la capa de salida
                //Copia los pesos de la capa de salida
                for (int i = 0; i < cant_oculta; i++)
                {
                    for (int j = 0; j < cant_salida; j++)
                    {
                        archivo_salida.WriteLine(red_neuronal.get_peso_salida(i, j));
                    }
                }
                archivo_salida.WriteLine("Fin"); //Agrega la etiqueta del final del archivo
                archivo_salida.Close();
                archivo.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

    }//fin de la clase
}
