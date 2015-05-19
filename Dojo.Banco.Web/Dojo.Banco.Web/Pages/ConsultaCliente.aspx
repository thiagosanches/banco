<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaCliente.aspx.cs" Inherits="Dojo.Banco.Web.Pages.ConsultaCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Consultar Cliente</h1>

    <div>
        <asp:GridView runat="server" ID="gdvClientes" DataKeyNames="Id" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField HeaderText="Nome">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="lblNome" Text='<%#Bind("Nome") %>'></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>
                <asp:BoundField HeaderText="RG" DataField="RG" />

            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
