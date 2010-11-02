using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace Red_Neuronal
{
    /// <summary>
    /// Lleva el control de la red neuronal de retropropagacion
    /// </summary>
    class Control_CounterPropagation
    {

         //Variables globales
        private Red_Neuronal_CounterPropagation red_neuronal;
        private const double bin_uno = 0.99;
        private const double bin_cero = 0.01;

        /// <summary>
        /// Constructor
        /// </summary>
        public Control_CounterPropagation()
        {
            red_neuronal = null;
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
            red_neuronal = new Red_Neuronal_CounterPropagation(cantEntrada, cantOculta, cantSalida); //Inicializa la red
            inicializar_pesos_aleatorios(); //Se inicializan los pesos de la red de manera aleatoria
        }

        /// <summary>
        /// Inicializa los pesos de la red con valores aleatorios entre los limites especificads
        /// </summary>
        private void inicializar_pesos_aleatorios()
        {
            //INICIALIZAR PESOS PARA APRENDIZAJE
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
        /// <param name="c_aprendizaje_beta">Coeficiente de aprendizaje beta para el ajuste de los pesos en la capa de salida</param>
        /// <param name="ruta_muestras">Ruta del archivo de las muestras</param>
        /// <param name="cont_entrenar">Anuncia si debe de continuar el entrenamiento</param>
        /// <returns>0: falló, 1: exitoso, 2:abortó</returns>
        public int entrenar(double c_aprendizaje_alpha, double c_aprendizaje_beta, String ruta_muestras,ref bool cont_entrenar)
        {
            try
            {
                //AQUI VA EL CODIGO DE ENTRENAR!!!
            }
            catch (Exception e)
            {
                return 0;           //Anuncia el error enviando 0
            }
            return 1;               //Anuncia que el proceso fue correcto enviando1
        }

        /// <summary>
        /// Iniciliza los valores para realizar el recorrido de una muestra
        /// </summary>
        /// <param name="muestra">Hilera con la muestra de un valor de entrada</param>
        /// <param name="valor_esperado">Arreglo para guardar el valor esperado</param>
        private void inicializar_recorrido_muestra(String muestra, ref double[]valor_esperado)
        {
            double[] valor_entrada = new double[red_neuronal.get_cantidad_neuronas_entrada()];          //Guarda el valor de entrada de la muestra
            int i = 0;
            for (; i < red_neuronal.get_cantidad_neuronas_salida(); ++i)                                //Recorre la linea de valor esperado de la muestra
            {
                int valor = Convert.ToInt32(new string(muestra[i],1));                                  //Guarda el valor esperado de la muestra
                if (valor == 1) { valor_esperado[i] = bin_uno; } else { valor_esperado[i] = bin_cero; } //Codifica los valores del archivo a lo necesario en la ejecucion
            }
            ++i; //Se brinca el separador
            for (; i < red_neuronal.get_cantidad_neuronas_salida() + red_neuronal.get_cantidad_neuronas_entrada() + 1; ++i) //Recorre la linea de entradas de la muestra
            {
                int valor = Convert.ToInt32(new string(muestra[i], 1));                                                     //Guarda el valor de la muestra
                if (valor == 1)                                                                                             //Codifica los valores del archivo a lo necesario en la ejecucion
                { 
                    valor_entrada[i - (red_neuronal.get_cantidad_neuronas_salida())] = bin_uno; 
                } else 
                {
                    valor_entrada[i - (red_neuronal.get_cantidad_neuronas_salida())] = bin_cero; 
                }                                
            }

            for (int j = 0; j < red_neuronal.get_cantidad_neuronas_entrada(); ++j) //para todas las neuronas de la capa de entrada
            {
                red_neuronal.set_valor_entrada(j, valor_entrada[j - 1]);            //guarda el valor de las y's de la capa de entrada
            }
        }

        /// <summary>
        /// Realiza la accion de la propagacion hacia adelante hacia la capa oculta
        /// </summary>
        private void propagar_oculta()
        {
            
        }

        /// <summary>
        /// Realiza la accion de la propagacion hacia adelante hacia la capa de salida
        /// </summary>
        private void propagar_salida()
        {

        }

        /// <summary>
        /// Calcula el ganador de la capa oculta
        /// </summary>
        /// <returns>Indice del ganador de la capa oculta, -1 si error</returns>
        private double calcular_ganador()
        {
            int ganador = -1;            //El indice de la neurona que tiene la salida mayor (ganadora)
            for (int h = 0; h < red_neuronal.get_cantidad_neuronas_entrada(); h++) //Sumatoria de los valores netos
            {
                if (red_neuronal.get_valor_oculta(h) > red_neuronal.get_valor_oculta(ganador))
                { // compara cual es el ganador de la capa oculta
                    red_neuronal.set_valor_oculta(ganador, bin_cero); //quita la salida ganadora del anterior
                    ganador = h;
                    red_neuronal.set_valor_oculta(ganador, bin_uno); //Coloca el valor de la nueva salida ganadora
                }
            }
            return ganador;
        }

        /// <summary>
        /// Calcula la salida de una neurona de la capa de salida
        /// </summary>
        /// <param name="neurona_salida">Indice de la neurona de la capa de salida </param>
        /// <returns>Valor de la salida de la neurona</returns>
        private double calcular_salida_salida(int neurona_salida)
        {
            double neto = 0.0;      //Guarda el valor neto
            double salida = 0.0;    //Guarda la salida
            for (int i = 0; i < red_neuronal.get_cantidad_neuronas_oculta(); i++) //Sumatoria de los valores netos
            {
                neto += red_neuronal.get_valor_oculta(i) * red_neuronal.get_peso_salida(i, neurona_salida); // oculta.Y[i] * salida.W[i,j]
            }
            salida = 1 / (1 + Math.Exp(-neto)); //aplicacion de la funcion sigmoidal
            return salida;                      //Retorna la salida
        }


        /****************************************************************************************************************************************************
                                                                POR AQUI VOY CAMBIANDO METODOS!!!
         *****************************************************************************************************************************************************/



    ///// <summary>
    ///// Ajusta los pesos de la red neuronal
    ///// </summary>
    ///// <param name="c_error">Coficiente del error (alpha)</param>
    ///// <param name="valor_esperado">Valores esperados en las salida (d[j])</param>
    //private void ajustar_pesos(double c_error, double[] valor_esperado)
    //{
    //    //Establece los nuevos pesos de la capa oculta
    //    for (int i = 1; i < red_neuronal.get_cantidad_neuronas_oculta(); ++i)                      //Para cada una de las neuronas ocultas, excepto umbral
    //    {
    //        for (int h = 0; h < red_neuronal.get_cantidad_neuronas_entrada(); ++h)                 //Para cada una de las neuronas de entrada
    //        {
    //            red_neuronal.set_peso_oculta(h,i, nuevo_peso_oculta(h, i,c_error,valor_esperado));  //Calcula y establece el nuevo peso
    //        }
    //    }

    //    //Establece los nuevos pesos de la capa de salida
    //    for (int j = 1; j < red_neuronal.get_cantidad_neuronas_salida(); ++j)                          //Para cada una de las neuronas de salida, excepto umbral
    //    {
    //        for (int i = 0; i < red_neuronal.get_cantidad_neuronas_oculta(); ++i)                      //Para cada una de las neuronas oculta
    //        {
    //            red_neuronal.set_peso_salida(i, j, nuevo_peso_salida(i, j, c_error, valor_esperado));   //Calcula y establece el nuevo peso
    //        }
    //    }
    //}

    ///// <summary>
    ///// Calcula el nuevo peso de la capa oculta entre la neurona de la capa de entrada y la neurona de la capa oculta
    ///// </summary>
    ///// <param name="neurona_entrada">Indice de la neurona de la capa de entrada</param>
    ///// <param name="neurona_oculta">Indice de la neurona de la capa oculta</param>
    ///// <param name="c_error">Recibe el coficiente del error (alpha)</param>
    ///// <param name="valor_esperado">Valores esperados en las salida (d[j])</param>
    ///// <returns>El nuevo peso calculado</returns>
    //private double nuevo_peso_oculta(int neurona_entrada, int neurona_oculta, double c_error, double[] valor_esperado)
    //{
    //    double peso = 0.0;      //Guarda el nuevo peso de la neurona
    //    double gradiente = 0.0; //Guarda el calcula del gradiente
    //    double prp_error = 0.0; //Guarda la sumatoria de la propagacion del error de salida

    //    for (int j = 1; j < red_neuronal.get_cantidad_neuronas_salida(); ++j)//Recorre todas las neuronas de salida 
    //    {
    //        double y = red_neuronal.get_valor_salida(j);
    //        prp_error += (valor_esperado[j - 1] - y) * y * (1 - y) * red_neuronal.get_peso_salida(neurona_oculta, j); // (d[j] - y[j])*y[j]*(1-y[j])*Salida.W[j,i]
    //    }
    //    gradiente = prp_error * (red_neuronal.get_valor_oculta(neurona_oculta) * (1 - red_neuronal.get_valor_oculta(neurona_oculta)) * red_neuronal.get_valor_entrada(neurona_entrada)); // prp_error*Oculta.y[i]*(1 - Oculta.y[i]) * Entrada.y[h]
    //    peso = red_neuronal.get_peso_oculta(neurona_entrada, neurona_oculta) + c_error * gradiente; //Oculta.W[h,i](t+1)= Oculta.W[h,i](t) + alpha*delta
    //    return peso;        //Retorna el peso
    //}

    ///// <summary>
    ///// Calcula el nuevo peso de la capa de salida entre la neurona de la capa oculta y la neurona de la capa de salida
    ///// </summary>
    ///// <param name="neurona_oculta">Indice de la neurona de la capa oculta</param>
    ///// <param name="neurona_salida">Indice de la neurona de la capa de salida</param>
    ///// <param name="c_error">Recibe el coficiente del error (alpha)</param>
    ///// <param name="valor_esperado">Valores esperados en las salida (d[j])</param>
    ///// <returns>El nuevo peso calculado</returns>
    //private double nuevo_peso_salida(int neurona_oculta, int neurona_salida, double c_error, double[] valor_esperado)
    //{
    //    double peso = 0.0;          //Guarda el nuevo peso de la neurona
    //    double gradiente = 0.0;     //Guarda el calcula del gradiente
    //    double y = red_neuronal.get_valor_salida(neurona_salida);
    //    gradiente = (valor_esperado[neurona_salida - 1] - y) * y * (1 - y) * red_neuronal.get_valor_oculta(neurona_oculta); // (d[j]-Salida.y[j])*Salida.y[j]*(1 - Salida.y[j]) * Oculta.y[i]
    //    peso = red_neuronal.get_peso_salida(neurona_oculta, neurona_salida) + c_error * gradiente; //Salida.W[i,j](t+1)= Salida.W[i,j](t) + alpha*delta
    //    return peso;        //Retorna el peso
    //}

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
            int[] resultado = new int[red_neuronal.get_cantidad_neuronas_salida()];         //Guarda el resultado de la ejecucion
            
            //AQUI SE REALIZA EL RECONOCIMIENTO 

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
