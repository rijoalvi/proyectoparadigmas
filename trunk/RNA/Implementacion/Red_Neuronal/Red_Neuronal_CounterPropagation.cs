using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Red_Neuronal
{
    /// <summary>
    /// Red Neuronal de Contrapropagacion
    /// </summary>
    class Red_Neuronal_CounterPropagation
    {
        //Variables globales
        private int cant_neuronas_Capa_entrada; //Guarda la cantidad de neuronas de cada capa
        private int cant_neuronas_Capa_oculta;
        private int cant_neuronas_Capa_salida;
        private double[] valores_capa_entrada;  //Guarda los valores de salida de cada una de las capas
        private double[] valores_capa_oculta;   
        private double[] valores_capa_salida;
        private double[,] pesos_capa_oculta;    //Guarda los pesos de cada una de las capas
        private double[,] pesos_capa_salida;

        /// <summary>
        /// Constructor de la red neuronal de contrapropagacion
        /// </summary>
        /// <param name="cantEntrada">Cantidad de neuronas de capa de entrada</param>
        /// <param name="cantOculta">Cantidad de neuronas de capa oculta</param>
        /// <param name="cantSalida">Cantidad de neuronas de capa de salida</param>
        public Red_Neuronal_CounterPropagation(int cantEntrada, int cantOculta, int cantSalida)
        {
            cant_neuronas_Capa_entrada =  cantEntrada;                          //Guarda la cantidad de neuronas de cada capa
            cant_neuronas_Capa_oculta = cantOculta;
            cant_neuronas_Capa_salida = cantSalida;
            valores_capa_entrada = new double[cantEntrada];                 //Inicializa los vectores de las salidas de las capas, agrega uno por el umbral
            valores_capa_oculta = new double[cantOculta];                    
            valores_capa_salida = new double[cantSalida];
            pesos_capa_oculta = new double[cantEntrada, cantOculta];    //Inicializa las matrices de pesos. agrega uno por el umbral
            pesos_capa_salida = new double[cantOculta, cantSalida];     
        }

        /// <summary>
        /// Da un valor al peso entre la neurona oculta con el de la neurona de la capa de entrada
        /// </summary>
        /// <param name="neurona_oculta">Indice de la neurona de la capa oculta</param>
        /// <param name="neurona_entrada">Indice de la neurona de la capa de entrada</param>
        /// <param name="valor">Valor del peso</param>
        public void set_peso_oculta(int neurona_entrada, int neurona_oculta, double valor)
        {
            pesos_capa_oculta[neurona_entrada, neurona_oculta] = valor;
        }

        /// <summary>
        /// Da un valor al peso entre la neurona de salida con el de la neurona de la capa oculta
        /// </summary>
        /// <param name="neurona_salida">Indice de la neurona de la capa de salida</param>
        /// <param name="neurona_oculta">Indice de la neurona de la capa oculta</param>
        /// <param name="valor">Valor del peso</param>
        public void set_peso_salida(int neurona_oculta, int neurona_salida, double valor)
        {
            pesos_capa_salida[neurona_oculta, neurona_salida] = valor;
        }

        /// <summary>
        /// Retorna el valor del peso entre la neurona oculta con el de la neurona de la capa de entrada
        /// </summary>
        /// <param name="neurona_oculta">Indice de la neurona de la capa oculta</param>
        /// <param name="neurona_entrada">Indice de la neurona de la capa de entrada</param>
        /// <returns>W[h,i]</returns>
        public double get_peso_oculta(int neurona_entrada,int neurona_oculta)
        {
            return pesos_capa_oculta[neurona_entrada, neurona_oculta];
        }

        /// <summary>
        /// Retorna el valor del peso entre la neurona de salida con el de la neurona de la capa oculta
        /// </summary>
        /// <param name="neurona_salida">Indice de la neurona de la capa de salida</param>
        /// <param name="neurona_oculta"></param>
        /// <returns>W[i,j]</returns>
        public double get_peso_salida(int neurona_oculta,int neurona_salida)
        {
            return pesos_capa_salida[neurona_oculta, neurona_salida];
        }

        /// <summary>
        /// Da el valor a la salida de la neurona de entrada
        /// </summary>
        /// <param name="neurona_entrada">Indice de la neurona de entrada</param>
        /// <param name="valor">Valor de la salida</param>
        public void set_valor_entrada(int neurona_entrada, double valor)
        {
            valores_capa_entrada[neurona_entrada] = valor;
        }

        /// <summary>
        /// Retorna el valor de la salida de la neurona de entrada
        /// </summary>
        /// <param name="neurona_entrada">Indice de la neurona de entrada</param>
        /// <returns>El valor de la salida de la neurona</returns>
        public double get_valor_entrada(int neurona_entrada)
        {
            return valores_capa_entrada[neurona_entrada];
        }

        /// <summary>
        /// Da el valor a la salida de la neurona oculta
        /// </summary>
        /// <param name="neurona_oculta">Indice de la neurona oculta</param>
        /// <param name="valor">Valor de la salida</param>
        public void set_valor_oculta(int neurona_oculta, double valor)
        {
            valores_capa_oculta[neurona_oculta] = valor;
        }

        /// <summary>
        /// Retorna el valor de la salida de la neurona oculta
        /// </summary>
        /// <param name="neurona_oculta">Indice de la neurona oculta</param>
        /// <returns>El valor de la salida de la neurona</returns>
        public double get_valor_oculta(int neurona_oculta)
        {
            return valores_capa_oculta[neurona_oculta];
        }

        /// <summary>
        /// Da el valor a la salida de la neurona de salida
        /// </summary>
        /// <param name="neurona_salida">Indice de la neurona de salida</param>
        /// <param name="valor">Valor de la salida</param>
        public void set_valor_salida(int neurona_salida, double valor)
        {
            valores_capa_salida[neurona_salida] = valor;
        }

        /// <summary>
        /// Retorna el valor de la salida de la neurona de salida
        /// </summary>
        /// <param name="neurona_salida">Indice de la neurona de salida</param>
        /// <returns>El valor de la salida de la de salida</returns>
        public double get_valor_salida(int neurona_salida)
        {
            return valores_capa_salida[neurona_salida];
        }

        /// <summary>
        /// Retorna la cantidad de neuronas de la capa de entrada
        /// </summary>
        /// <returns>Cantidad de neuronas de la capa de entrada</returns>
        public int get_cantidad_neuronas_entrada()
        {
            return cant_neuronas_Capa_entrada;
        }

        /// <summary>
        /// Retorna la cantidad de neuronas de la capa oculta
        /// </summary>
        /// <returns>Cantidad de neuronas de la capa oculta</returns>
        public int get_cantidad_neuronas_oculta()
        {
            return cant_neuronas_Capa_oculta;
        }

        /// <summary>
        /// Retorna la cantidad de neuronas de la capa de salida
        /// </summary>
        /// <returns>Cantidad de neuronas de la capa de salida</returns>
        public int get_cantidad_neuronas_salida()
        {
            return cant_neuronas_Capa_salida;
        }

        /// <summary>
        /// Retorna la matriz con los pesos de la capa oculta
        /// </summary>
        /// <returns></returns>
        public double[,] get_pesos_oculta()
        {
            return pesos_capa_oculta;
        }

    }///Fin de la clase
}
