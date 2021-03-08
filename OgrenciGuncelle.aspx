<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="YazOkuluDersler.WebForm4" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">

        <div class="form-group">

              <div>
                <strong>
            <asp:Label for="Txtid" runat="server" Text="Öğrenci ID:"></asp:Label>
                </strong>
            <asp:TextBox ID="Txtid" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

            <div>
                <strong>
            <asp:Label for="TxtAd" runat="server" Text="Öğrenci Adı:"></asp:Label>
                </strong>
            <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
            <asp:Label for="TxtSoyad" runat="server" Text="Öğrenci Soyadı:"></asp:Label>
                </strong>
            <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
            <asp:Label for="TxtNumara" runat="server" Text="Öğrenci Numara:"></asp:Label>
                </strong>
            <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
            <asp:Label for="TxtSifre" runat="server" Text="Öğrenci Şifre:"></asp:Label>
                </strong>
            <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
            <asp:Label for="TxtFoto" runat="server" Text="Öğrenci Fotoğraf:"></asp:Label>
                </strong>
            <asp:TextBox ID="TxtFoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

        </div>


    <asp:Button ID="Button1" runat="server" Text="Güncelle"  CssClass="btn btn-success" OnClick="Button1_Click" />
        </form>
</asp:Content>
