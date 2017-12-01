using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Configuration;
using Newtonsoft.Json;

namespace FoodCore.Domain
{
    public class Configuracao
    {
        #region Singleton
        private static Lazy<Configuracao> _instancia = new Lazy<Configuracao>(() =>
        {
            if (!File.Exists(FilePath))
                throw new FileNotFoundException("Arquivo de configuração não foi encontrado na raiz do projeto.", FilePath);

            return JsonConvert.DeserializeObject<Configuracao>
                (File.ReadAllText(FilePath));
        });

        private static string FilePath => Path.Combine(ConfigurationManager.AppSettings["ContentRootPath"], "configuracao.json");
        public static Configuracao Instancia => _instancia.Value;
        #endregion
    }
}
