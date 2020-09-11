<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.Master" AutoEventWireup="true" CodeBehind="Perform.aspx.cs" Inherits="ITMO.ASP.SetOffTask.School.Forms.Perform"  UnobtrusiveValidationMode="None"%>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                <div>
                    <div style="display:inline-flex">
                        <div style="margin:10px">
                            <asp:Label ID="labelId" runat="server" Text="№"></asp:Label>
                            <asp:TextBox ID="studentIdTB" runat="server" Height="18px" Width="150px"></asp:TextBox>
                        </div>
                        <div style="margin:10px">
                            <asp:Label ID="labelName" runat="server" Text="Имя" Width="50"></asp:Label>
                            <asp:TextBox ID="studentName" runat="server" Height="18px" Width="150px"></asp:TextBox>
                        </div>
                        <div style="margin:10px">
                            <asp:Label ID="LabelCourse" runat="server" Text="Курс" Width="50"></asp:Label>
                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="LinqDataSource1" DataTextField="CourseName" DataValueField="CourseName" Height="20px" Style="margin-left: 8px" Width="154px">
                            </asp:DropDownList>
                        </div>
                        <div style="margin:10px">
                            <asp:Label ID="labelMark" runat="server" Text="Оценка" Width="50"></asp:Label>
                            <asp:TextBox ID="MarkTB" runat="server" Height="18px" Width="150px"></asp:TextBox>
                        </div>
                        
                        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="DBModel.Context" EntityTypeName="" Select="new (CourseName)" TableName="Courses">
                        </asp:LinqDataSource>


                    </div>
                    <div style="margin-top:50px; margin-bottom:50px; text-align:center" >
                        <asp:Button ID="submit" runat="server" Text="Внести данные" OnClick="submit_Click" Height="24px" Style="text-align:center" Width="135px" />
                    </div>
                    <div>
                    </div>
                    <div Style="margin-bottom:50px; text-align:center">
                    <asp:Label ID="Label1" runat="server" Visible="False" ForeColor="Red" Font-Size="16px"></asp:Label>
                        </div>
                    <div Style="margin-bottom:50px; text-align:center">
                    <asp:Label ID="Label3" runat="server" Visible="False" ForeColor="Red" Font-Size="16px"></asp:Label>
                        </div>
                </div>

            </td>
        </tr>
    </table>






</asp:Content>
