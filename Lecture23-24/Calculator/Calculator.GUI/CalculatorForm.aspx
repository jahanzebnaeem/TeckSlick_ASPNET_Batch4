<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CalculatorForm.aspx.cs" Inherits="Calculator.GUI.CalculatorForm" %>

<asp:Content ID="CalculatorAdd" ContentPlaceHolderID="MainContent" runat="server">
    <table style="margin-top:15px">
        <tr>
            <td>Operand 1</td>
            <td>
                <asp:TextBox ID="txtOperand1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Operand 2</td>
            <td>
                <asp:TextBox ID="txtOperand2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Result</td>
            <td>
                <asp:Label ID="lblResult" runat="server" Text="0"></asp:Label>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
