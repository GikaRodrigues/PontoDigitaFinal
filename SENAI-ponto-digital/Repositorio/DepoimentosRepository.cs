using System;
using System.Collections.Generic;
using System.IO;
using SENAI_ponto_digital.Models;

namespace SENAI_ponto_digital.Repositorio
{
    public class DepoimentosRepository
    {
        public static uint CONT = 0;
        private const string PATH = "Database/Depoimentos.csv";

        private List<Depoimentos> depoimentos = new List<Depoimentos>();

        public DepoimentosRepository()
        {
            if (!File.Exists(PATH)){
                File.Create(PATH).Close();
            }

            var ultimoIndice = File.ReadAllText(PATH);
            uint ind = 0;
            uint.TryParse(ultimoIndice, out ind);
            CONT = ind;
        }

        public bool Inserir (Depoimentos depoimentos) {
            CONT++;
            File.WriteAllText(PATH, CONT.ToString());

            string linha = RegistrarDepoimentos (depoimentos);
            File.AppendAllText (PATH, linha);

            return true;
        }

        private string RegistrarDepoimentos (Depoimentos depoimentos) {
            return $"id={CONT};nome={depoimentos.Nome};comentario={depoimentos.Comentario};data_depoimento={DateTime.Now}\n";
        }
    }
}