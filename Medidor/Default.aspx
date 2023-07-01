<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Medidor.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">

    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajesLbl" CssClass="text-success"> </asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Medidor</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="nombreTxt">Número Medidor</label>
                        <asp:TextBox ID="nroMedidor" CssClass="form-control" runat="server"></asp:TextBox>

                        <div>
                            <label for="calendar 1" > Seleccione la fecha de la lectura</label>
                            <asp:Calendar ID="calendar1" runat="server">

                                <OtherMonthDayStyle ForeColor="LightGray"></OtherMonthDayStyle>

                                <TitleStyle BackColor="Blue"
                                    ForeColor="White"></TitleStyle>

                                <DayStyle BackColor="gray"></DayStyle>

                                <SelectedDayStyle BackColor="LightGray"
                                    Font-Bold="True"></SelectedDayStyle>

                            </asp:Calendar>
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="lecturaTxt">Lectura en kw/h</label>
                        <asp:TextBox ID="lecturaTxt" CssClass="form-control" runat="server"></asp:TextBox>
                     
                    </div>
                    <div class="form-group">
                        <label for="horaTxt">Hora de la lectura</label>
                        <asp:TextBox ID="horaTxt" CssClass="form-control" runat="server"></asp:TextBox>
                      
                    </div>
                    <div class="form-group">
                        <label for="minutoTxt">Minuto de la lectura</label>
                        <asp:TextBox ID="minutoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                         
                    </div>
                    <div class="form-group">
                        <label for="bebidaDbl">Tipo de medidor</label>
                        
                        <asp:DropDownList runat="server" ID="medidorDbl" CssClass="form-select" AppendDataBoundItems="true">
                            <asp:ListItem Text="Seleccione una opción"></asp:ListItem>

                        </asp:DropDownList>
                    </div>                 

                    <div class="form-group">
                        <asp:Button runat="server" ID="btnAgregar" OnClick="btnAgregar_Click" Text="Agregar" CssClass="btn btn-primary btn-lg" />

                    </div>
                </div>
            </div>
        </div>
    </div>



</asp:Content>
