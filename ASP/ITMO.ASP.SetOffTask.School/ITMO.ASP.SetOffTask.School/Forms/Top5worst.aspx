<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.Master" AutoEventWireup="true" CodeBehind="Top5worst.aspx.cs" Inherits="ITMO.ASP.SetOffTask.School.Forms.Top5worst" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align: center; margin-top: 20px">
        <h3 style="font: 600">Отстающие студенты</h3>
    </div>
    <div style="margin-top: 50px">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center" DataSourceID="SqlDataSource1" Width="400px" Height="150px" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <Columns>
                <asp:BoundField DataField="Фамилия" HeaderText="Фамилия" SortExpression="Фамилия" />
                <asp:BoundField DataField="Имя" HeaderText="Имя" SortExpression="Имя" />
                <asp:BoundField DataField="Средняя оценка" HeaderText="Средняя оценка" ReadOnly="True" SortExpression="Средняя оценка" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
    </div>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SchoolASP %>" SelectCommand="SELECT * FROM [TOP5Worst]"></asp:SqlDataSource>
</asp:Content>
