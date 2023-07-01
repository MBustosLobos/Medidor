<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidor.aspx.cs" Inherits="Medidor.VerMedidor" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Contenido" runat="server">
            <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Medidores</h3>
                </div>
                <div class="card-body">
                    <asp:GridView CssClass="table table-hover table-bordered" runat="server" AutoGenerateColumns="true" ID="grillaCliente">
                        <Columns>
                            <asp:BoundField DataField="Rut" HeaderText="Rut del Cliente" />
                            <asp:BoundField DataField="nroMedidor" HeaderText="Número del medido" />
                            <asp:BoundField DataField="lecturaTxt" HeaderText="Lecturas" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button CommandName="elimina" CommandArgument='<%# Eval("Rut") %>'
                                        runat="server" CssClass="btn btn-danger" Text="Eliminar" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>


