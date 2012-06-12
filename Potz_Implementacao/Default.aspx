<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <script type="text/javascript">
        function numerosETraco(objeto, evento) {
            if (evento.keyCode <= 46 && evento.keyCode != 0) {
                if (evento.keyCode != 8) {
                    if (objeto.value.length == 9)
                        objeto.value += "-";
                }
                return true;
            }
            if ((evento.charCode >= 48 && evento.charCode <= 57) || (evento.charCode == 88) || (evento.charCode == 120)) {
                if (objeto.value.length == 9)
                    objeto.value += "-";
                return true;
            }

            else {
                return false;
            }


        }
    </script>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <Controle:MensagemUsuario ID="MensagemUsuario" runat="server" />
    <span style="position: absolute; top: 370px; left: 491px;">Seu Nome:</span>
    <asp:TextBox runat="server" ID="TextNome" MaxLength="50" Style="position: absolute;
        top: 367px; left: 619px; width: 202px;"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorTextNome" runat="server" ErrorMessage="*"
        ControlToValidate="TextNome" Display="Dynamic" Style="position: absolute; top: 370px;
        right: 515px;" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:Label ID="LabelErroNome" runat="server" Style="position: absolute; top: 370px;
        right: 327px;" Font-Bold="True" ForeColor="Red"></asp:Label>
    <span style="position: absolute; top: 408px; left: 418px;">Número do seu cupom:</span>
    <asp:TextBox ID="TextCupom" onkeypress="return numerosETraco(this, event);" MaxLength="11"
        runat="server" Style="position: absolute; top: 407px; left: 620px;"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorTextCupom" runat="server" ErrorMessage="*"
        ControlToValidate="TextCupom" Display="Dynamic" Style="position: absolute; top: 410px;
        right: 573px;" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:Label ID="LabelErroCupom" runat="server" Style="position: absolute; top: 412px;
        right: 327px;" Font-Bold="True" ForeColor="Red"></asp:Label>
    <asp:Button Text="Consultar Pontos!" CssClass="button" Style="position: absolute;
        top: 482px; left: 609px;" runat="server" OnClick="ButtonConsultar_Click" />
    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Sem título.png" Width="100%" />
</asp:Content>
