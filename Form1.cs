﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ModuloAluno
{
    public partial class frmIncluirAluno : Form
    {
        public frmIncluirAluno()
        {
            InitializeComponent();
        }

        #region Eventos
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                TextBox txtEmail = sender as TextBox;
                var validacaoEmail = ValidarEmail(txtEmail.Text);
                if (!validacaoEmail)
                {
                    MessageBox.Show("E-mail inválido");
                    txtEmail.Focus();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnIncluirAluno_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionStrings = "sua_string_de_conexao";
                using (SqlConnection connection = new SqlConnection(connectionStrings))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("InserirAluno", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Nome", ValidarCampoObrigatorio(txtNome.Text));
                        command.Parameters.AddWithValue("@Idade",
                            !String.IsNullOrEmpty(txtIdade.Text) ? Convert.ToInt16(txtIdade.Text) : 0);
                        command.Parameters.AddWithValue("@Curso", ValidarCampoObrigatorio(cbxCurso.Text));
                        command.Parameters.AddWithValue("@Email", ValidarCampoObrigatorio(txtEmail.Text));
                        command.Parameters.AddWithValue("@DataDeMatricula",
                            !String.IsNullOrEmpty(mskDataDeMatricula.Text) ? Convert.ToDateTime(mskDataDeMatricula.Text).Date : DateTime.Now.Date);
                        command.Parameters.AddWithValue("@Endereco", ValidarCampoObrigatorio(txtEndereco.Text));
                        command.Parameters.AddWithValue("@Telefone", ValidarCampoObrigatorio(mskTelefone.Text));

                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Aluno(a) Cadastrado(a) com Sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Não Foi Possível Cadastrar Aluno(a)");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o aluno: " + ex.Message);
            }
        }
        #endregion

        #region Métodos
        private bool ValidarEmail(string email)
        {
            try
            {
                string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                if (string.IsNullOrEmpty(email))
                {
                    return false;
                }

                Regex regex = new Regex(emailPattern);
                return regex.IsMatch(email);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private bool ValidarTelefone(string telefone)
        {
            bool validacaoTelefone = false;
            try
            {
                string padraoTelefone = @"^(\([0-9]{2}\))? [0-9]{4,5}-?[0-9]{4}$";

                if (string.IsNullOrEmpty(telefone))
                {
                    return false;
                }

                Match resultado = Regex.Match(telefone, padraoTelefone);

                if (resultado.Success)
                {
                    validacaoTelefone = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return validacaoTelefone;
        }
        private void ImpedirDigitacaoNumero(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
        private void ImpedirLetrasCaracteresEspeciais(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private string ValidarCampoObrigatorio(string texto)
        {
            try
            {
                if (String.IsNullOrEmpty(texto))
                {
                    MessageBox.Show("Campo Obrigatório");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return texto;
        }


        #endregion

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirDigitacaoNumero(e);
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirLetrasCaracteresEspeciais(e);
        }
    }
}
