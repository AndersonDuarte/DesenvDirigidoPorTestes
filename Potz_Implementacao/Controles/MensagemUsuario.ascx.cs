using System;
using System.Web.UI;

public partial class Controles_MensagemUsuario : System.Web.UI.UserControl
{
    #region Variáveis

    public delegate void EventHandler(Object obj, EventArgs e);//Delegate eventos
    public string _titulo { get; set; }//Título da caixa de mensagem
    public string _mensagemCaixa { get; set; }//Mensagem foi definida a aparecer na caixa de mensagem
    public string _javascript = string.Empty;//Variável que recebe o javascript e por padrão é branco        
    public Tipo _tipoMensagem;

    //enum que significa enumeração e apresentam quatro elementos
    public enum Tipo
    {
        Info,
        Sucesso,
        Aviso,
        Erro,
    }

    #endregion

    #region Eventos

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    #endregion

    #region Métodos
    /// <summary>
    /// Mostra a mensagem do tipo padrão
    /// </summary>
    /// <param name="mensagem">Mensagem</param>
    public void Mostrar(string mensagem)
    {
        _tipoMensagem = Tipo.Info;//Tipo da mensagem padrão
        _mensagemCaixa = mensagem;//Mensagem que vai ser mostrada em tela
        AdicionaJavaScriptPagina();//Adiciona JavaScript na página 
    }
    /// <summary>
    /// Mostra mensagem sem o botão customizar
    /// </summary>
    /// <param name="tipo"></param>
    /// <param name="mensagem"></param>
    public void Mostrar(Tipo tipo, string mensagem)
    {
        _tipoMensagem = tipo;//Tipo da mensagem
        _mensagemCaixa = mensagem;//Mensagem que vai ser mostrada em tela
        AdicionaJavaScriptPagina();//Adiciona JavaScript na página 
    }
    /// <summary>
    /// Adiciona o JavaScript na página
    /// </summary>
    private void AdicionaJavaScriptPagina()
    {
        #region Template

        _javascript = "  ";
        _javascript += "  	$(function() { ";
        _javascript += "  		$( \"#dialog:ui-dialog\" ).dialog( \"destroy\" ); ";
        _javascript += "  		$( \"#lblMensagem\" ).append( \"MensagemCaixa\" ); ";//A mensagem que vai ser mostrada em tela
        _javascript += "  		$(\"#divFundoMensagem\").addClass(\"NomeClasse\"); ";//Adiciona o css que mostra a imagem e coloca a cor na fonte
        _javascript += "                 $(\"#divMensagem\").dialog({ ";//Mostra a mensagem na tela
        _javascript += "                     modal: true, ";//Mostra o fundo congelado = true ou remove o fundo congelado = false
        _javascript += "                     autoOpen: true, ";
        _javascript += "                     draggable: true, ";
        _javascript += "                     title: \"NomeTitulo\", ";//Título da Caixa de Mensagem
        _javascript += "                     open: function(type, data) { ";//Adicionando um evento para anexar a div ..
        _javascript += "                         $(this).parent().appendTo(\"form\"); "; //..no form, dessa forma o postback do botão irá funcionar
        _javascript += "                     } ";
        _javascript += "                 }); ";
        _javascript += "         }); ";

        #endregion

        #region Atribui o estilo/css, título e a mensagem e depois registra o Script na página

        switch (_tipoMensagem)
        {
            case Tipo.Info:
                _javascript = _javascript.Replace("NomeClasse", "info").Replace("NomeTitulo", "Informação").Replace("MensagemCaixa", _mensagemCaixa);
                break;

            case Tipo.Sucesso:
                _javascript = _javascript.Replace("NomeClasse", "successo").Replace("NomeTitulo", "Sucesso").Replace("MensagemCaixa", _mensagemCaixa); ;
                break;

            case Tipo.Aviso:
                _javascript = _javascript.Replace("NomeClasse", "aviso").Replace("NomeTitulo", "Aviso").Replace("MensagemCaixa", _mensagemCaixa); ;
                break;

            case Tipo.Erro:
                _javascript = _javascript.Replace("NomeClasse", "erro").Replace("NomeTitulo", "Erro").Replace("MensagemCaixa", _mensagemCaixa); ;
                break;
        }

        //Registra o JavaScript na página        
        AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), _javascript, true);

        #endregion
    }

    #endregion
}