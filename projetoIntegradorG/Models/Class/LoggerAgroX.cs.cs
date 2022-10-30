using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoIntegrador.Models.Class
{
    public class LoggerAgroX
    {
        public string StringLoggerAction { get; set; } = "'Action': '{0}', 'Method':'{1}', 'Class':'{2}', 'Section':'{3}', 'Parameters': {4}";
        public string StringLoggerInterneMetods { get; set; } = "'Method':'{0}', 'Class':'{1}','Section':'{2}', 'Parameters': {3}";
        public string StringLoggerError { get; set; } = "Error => 'Action': '{0}', 'Method':'{1}', 'Class':'{2}', 'Section':'{3}','Message': '{4}'";


        public string GetLoggerAction(string nameAction, string methodAction, string nameClass, string keySection = "'not use section this method'", string parametersAction = "{'not have parameters this method'}") =>
           string.Format(StringLoggerAction, nameAction, methodAction, nameClass, keySection, parametersAction);

        public string GetLoggerInterneMetods(string nameMethod, string nameClass, string keySection = "'not use section this method'", string parameters = "{'not have parameters this method'}") =>
            string.Format(StringLoggerInterneMetods.ToString(), nameMethod, nameClass, keySection, parameters);

        public string GetLoggerError(string nameAction, string methodAction, string nameClass, string keySection = "'not use section this method'", string messageOfError = "not have specific message of error") =>
            string.Format(StringLoggerError, nameAction, methodAction, nameClass, keySection, messageOfError);
    }
}
