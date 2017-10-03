using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.Modelos;
using Dominio.Contexto;
using Dominio.Contratos;
using Dominio.Servicos;

namespace Loteria.MA
{
    public partial class MegaSena : Form
    {
        List<int> numeros = new List<int>();
        IAposta _aposta;
        public MegaSena()
        {
            InitializeComponent();

            Aposta aposta = new Aposta();
            _aposta = aposta;

            numeros = GeraNumeros();
            cbNumeros.DataSource = numeros;
            gridNumeros.DataSource = null;
        }

        #region Eventos
        private void btnAddNum_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbNumeros.SelectedItem?.ToString()))
            {
                var numero = int.Parse(cbNumeros.SelectedItem.ToString());
                gridNumeros.Rows.Add(new object[] { numero });

                if (numeros.Contains(numero))
                    numeros.Remove(numero);

                cbNumeros.DataSource = null;
                cbNumeros.Items.Clear();
                cbNumeros.DataSource = numeros;
            }

            if (gridNumeros.Rows.Count == 6)
                EnabledButtons(true, false);

            else
                EnabledButtons(false, true);
        }

        private void gridNumeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var numero = int.Parse(gridNumeros.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (!numeros.Contains(numero))
                numeros.Add(numero);

            numeros.Sort();

            cbNumeros.DataSource = null;
            cbNumeros.DataSource = numeros;

            gridNumeros.Rows.Remove(gridNumeros.Rows[e.RowIndex]);

            if (gridNumeros.Rows.Count == 6)
                EnabledButtons(true, false);

            else
                EnabledButtons(false, true);
        }

        private void btnSurpresinha_Click(object sender, EventArgs e)
        {
            numeros = new List<int>();
            numeros = GeraNumeros();
            cbNumeros.DataSource = null;
            gridNumeros.DataSource = null;
            gridNumeros.Rows.Clear();

            var numerosAleatorios = GeraSurpresinha();

            foreach (int num in numerosAleatorios)
            {
                if (numeros.Contains(num))
                    numeros.Remove(num);
                gridNumeros.Rows.Add(new object[] { num });
            }
            numeros.Sort();
            cbNumeros.DataSource = numeros;

            EnabledButtons(true, false);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MegaSenaModel ms = new MegaSenaModel();
            var ultimaAposta = _aposta.ObterUltimaMegaSena();
            if (ultimaAposta == null)
                ms.id = 1;
            else
                ms.id = ultimaAposta.id + 1;
            ms.data = DateTime.Now;
            ms.numeros = ObterNumerosGrid();

            _aposta.CadastrarApostaMegaSena(ms);

            gridApostas.DataSource = null;
            gridApostas.Rows.Clear();

            var megas = _aposta.ObterTodasMegaSenas();
            foreach (var mega in megas)
            {
                string numerosFormatados = string.Empty;
                foreach (var num in mega.numeros)
                {
                    numerosFormatados += num.ToString() + " ";
                }
                gridApostas.Rows.Add(new object[] { mega.id, mega.data.ToString("dd/MM/yyyy hh:mm:ss"), numerosFormatados });
            }
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            gridNumerosSorteio.DataSource = null;
            gridNumerosSorteio.Rows.Clear();

            var numerosSorteio = GeraSurpresinha();

            foreach (int num in numerosSorteio)
            {
                gridNumerosSorteio.Rows.Add(new object[] { num });
            }

            btnConsultaAcertos.Enabled = true;
        }

        private void btnConsultaAcertos_Click(object sender, EventArgs e)
        {
            gridConsultaAcertos.DataSource = null;
            gridConsultaAcertos.Rows.Clear();

            var apostas = _aposta.ObterTodasMegaSenas();
            var numerosSorteados = ObterNumerosGridSorteio();

            foreach (var obj in apostas)
            {
                int quantidade = 0;
                string numerosFormatados = string.Empty;
                foreach (var num in obj.numeros)
                {
                    numerosFormatados += num.ToString() + " ";
                    if (numerosSorteados.Contains(num))
                        quantidade++;
                }
                gridConsultaAcertos.Rows.Add(new object[] { obj.id, obj.data.ToString("dd/MM/yyyy hh:mm:ss"), numerosFormatados, quantidade });
            }
        }
        #endregion

        #region Métodos Auxiliares
        private void EnabledButtons(bool cadastro, bool add)
        {
            btnAddNum.Enabled = add;
            btnCadastrar.Enabled = cadastro;
        }

        private List<int> GeraNumeros()
        {
            for (int i = 1; i <= 60; i++)
            {
                numeros.Add(i);
            }
            return numeros;
        }

        private List<int> GeraSurpresinha()
        {
            var lista = new List<int>();
            Random randNum = new Random();
            do
            {
                if (lista.Count() == 6)
                    break;
                var num = randNum.Next(1, 60);
                if (!lista.Contains(num)) //Para não repetir
                    lista.Add(num);
            }
            while (lista.Count() <= 6);

            return lista;
        }

        public List<int> ObterNumerosGrid()
        {
            List<int> numerosGrid = new List<int>();

            for (int i = 0; i < gridNumeros.Rows.Count; i++)
            {
                var numero = int.Parse(gridNumeros.Rows[i].Cells[0].Value.ToString());
                numerosGrid.Add(numero);
            }
            return numerosGrid;
        }

        public List<int> ObterNumerosGridSorteio()
        {
            List<int> numerosSorteados = new List<int>();

            for (int i = 0; i < gridNumerosSorteio.Rows.Count; i++)
            {
                var numero = int.Parse(gridNumerosSorteio.Rows[i].Cells[0].Value.ToString());
                numerosSorteados.Add(numero);
            }
            return numerosSorteados;
        }
        #endregion
    }
}
