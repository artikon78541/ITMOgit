<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.Master" AutoEventWireup="true" CodeBehind="StudentMarks.aspx.cs" Inherits="ITMO.ASP.SetOffTask.School.Forms.StudentMarks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <table style="width: 100%;">
        <tr>
            <td>&nbsp;
                <div style="margin-left: 20px">
                    <asp:Label ID="Label2" runat="server" Text="Введите фамилию студента: "></asp:Label>
                    <asp:TextBox ID="searchStudentTB" runat="server"></asp:TextBox>
                    <asp:Button ID="searchStudentButton" runat="server" Text="Поиск" OnClick="searchStudentButton_Click" />
                </div>

            </td>
        </tr>
        <tr style="min-height: 400px">
            <td style="height: 300px">&nbsp;
                <div style="margin-top=20px">
                    <div style="text-align: center; margin-bottom=10px;">
                        <asp:Label runat="server" ID="labelToChooseStud" Text="" Font-Size="16px"></asp:Label>
                    </div>

                    <asp:GridView ID="GridView1" HorizontalAlign="Center" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" TabIndex="1" Width="700px" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="False" Style="margin-top: 10px; margin-bottom: 20px;">
                        <AlternatingRowStyle BackColor="#F7F7F7" />
                        <Columns>
                            <asp:BoundField DataField="StudentId" HeaderText="№" />
                            <asp:BoundField DataField="SecondName" HeaderText="Фамилия" />
                            <asp:BoundField DataField="FirstName" HeaderText="Имя" />
                            <asp:BoundField DataField="Phone" HeaderText="Телефон" />
                            <asp:BoundField DataField="Email" HeaderText="Email" />
                            <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Выбрать" />
                        </Columns>
                        <EditRowStyle Height="15px" />
                        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <SortedAscendingCellStyle BackColor="#F4F4FD" />
                        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                        <SortedDescendingCellStyle BackColor="#D8D8F0" />
                        <SortedDescendingHeaderStyle BackColor="#3E3277" />
                    </asp:GridView>
                </div>
            </td>
        </tr>
        <tr>
            <td>&nbsp;
                <div style="margin-bottom: 50px; margin-top: 50px; text-align: center">
                    <asp:Label runat="server" ID="marklist" Text="" Font-Size="16px" Font-Bold="True"></asp:Label>
               </div>

            </td>
        </tr>
    </table>
        <div style="margin-bottom: 50px; text-align: center">
        <asp:Label ID="LabelError" runat="server" Visible="False" ForeColor="Red" Font-Size="16px"></asp:Label>
    </div>
</asp:Content>
