<%@ Page Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeBehind="CourseCreation.aspx.cs" Inherits="ITMO.ASP.SetOffTask.School.Forms.CourseCreation" UnobtrusiveValidationMode="None" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align: center; margin-top: 100px">
        <div>
            <label>Введите название нового курса:</label>
        </div>
        <div style="margin-top: 20px">
            <asp:TextBox ID="newCourseTB" runat="server"></asp:TextBox>

        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="newCourseTB" ErrorMessage="Введите название курса" ForeColor="Red">Поле курс должно быть заполнено</asp:RequiredFieldValidator>
        <asp:ValidationSummary ID="ValidationSummary2" runat="server" ShowModelStateErrors="true" ForeColor="Red" />
        <div style="margin-top: 20px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Сохранить" type="submit" />
        </div>
    </div>

    <div style="margin-bottom: 50px; text-align: center">
        <asp:Label ID="LabelError" runat="server" Visible="False" ForeColor="Red" Font-Size="16px"></asp:Label>
    </div>
</asp:Content>
