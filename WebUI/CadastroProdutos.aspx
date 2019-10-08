<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CadastroProdutos.aspx.cs" Inherits="WebUI.CadastroProdutos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>:: Cadastro de Produtos</h3>
    <p>Código: <asp:TextBox ID="txt_Codigo" runat="server"></asp:TextBox></p>
    <p>Descrição:<asp:TextBox ID="txt_descricao" runat="server"></asp:TextBox>
    </p>
    <p>Valor Unitário:<asp:TextBox ID="txt_vlUnitario" runat="server"></asp:TextBox>
    </p>
    <p>Dt. Cadastro:<asp:TextBox ID="txt_dtCadastro" runat="server" TextMode="Date"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btn_inserir" runat="server" OnClick="btn_inserir_Click" Text="Inserir" />
&nbsp;<asp:Button ID="btn_excluir" runat="server" OnClick="btn_excluir_Click" Text="Excluir" />
&nbsp;<asp:Button ID="btn_atualizar" runat="server" OnClick="btn_atualizar_Click" Text="Atualizar" />
    </p>
    <p>
        <asp:Label ID="lbl_msg" runat="server" ForeColor="Red"></asp:Label>
    </p>
</asp:Content>
