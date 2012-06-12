using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void ButtonConsultar_Click(object sender, EventArgs e)
    {
        LabelErroCupom.Text = string.Empty;
        LabelErroNome.Text = string.Empty;
        bool erro = false;

        if (TextNome.Text != string.Empty || TextCupom.Text != string.Empty)
        {
            Metodos method = new Metodos();
            if (!method.validaUsuario(TextNome.Text))
            {
                LabelErroNome.Text = "Usuário não existe na base!";
                erro = true;
            }

            if (!method.validaQtdeCaracterCupom(TextCupom.Text))
            {
                LabelErroCupom.Text = "Cupom incorreto, faltam números!";
                erro = true;
            }
            else if (!method.validaDigitoVerificador(TextCupom.Text.Replace("-", string.Empty)))
            {
                LabelErroCupom.Text = "Dígito verificador incorreto!";
                erro = true;
            }
            else if (!method.validaQuantidadePontos(TextCupom.Text.Replace("-", string.Empty)))
            {
                LabelErroCupom.Text = "Cupom com valores incorretos!";
                erro = true;
            }

            

            if (!erro)
                MensagemUsuario.Mostrar(Controles_MensagemUsuario.Tipo.Sucesso, ("Parabêns " + TextNome.Text + ", você tem acumulados " +
                    method.quantidadePontos(TextCupom.Text.Replace("-", string.Empty)) + " potz para gastar como quiser em qualquer um dos estabelecimentos no mundo que aceitam o Potz."));
        }
    }
}
