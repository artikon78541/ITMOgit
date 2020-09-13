<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SummaryBD.aspx.cs" Inherits="ITMO.ASP.LAB.SummaryBD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Список участников<asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="ITMO.ASP.LAB.SampleContext" EntityTypeName="" Select="new (Name, Email, Phone, WillAttend, Rdata, Reports)" TableName="GuestResponses">
        </asp:LinqDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" ReadOnly="True" SortExpression="Name" />
                <asp:BoundField DataField="Email" HeaderText="Email" ReadOnly="True" SortExpression="Email" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" ReadOnly="True" SortExpression="Phone" />
                <asp:CheckBoxField DataField="WillAttend" HeaderText="WillAttend" ReadOnly="True" SortExpression="WillAttend" />
                <asp:BoundField DataField="Rdata" HeaderText="Rdata" ReadOnly="True" SortExpression="Rdata" />
            </Columns>
        </asp:GridView>
    </h2>
</asp:Content>
