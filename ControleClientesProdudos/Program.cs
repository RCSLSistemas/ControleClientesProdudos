using ControleClientesProdudos.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleClientesProdudos.Controls;

namespace ControleClientesProdudos
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConexaoDB conexao = new ConexaoDB();
            //conexao.ConectaBd();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mdiPrincipal());
        }

    }


}
