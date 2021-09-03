using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepositorio : iRepositorio<Series>
    {
        static List<Series> listadeSeries = new List<Series>();

        public void Atualiza(int id, Series objeto)
        {
            listadeSeries[id] = objeto;
        }

        public void Excluir(int id)
        {
            listadeSeries[id].Excluir();
        }

        public void Insere(Series objeto)
        {
            listadeSeries.Add(objeto);
        }
        
        public List<Series> Lista()
        {
            return listadeSeries;
        }

        public int ProximoId()
        {
            return listadeSeries.Count;
        }

        public Series retornaPorId(int id)
        {
            return listadeSeries[id];
        }
    }
}