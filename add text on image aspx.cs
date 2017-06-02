<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 133px;
        }
        .auto-style4 {
            width: 133px;
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
            width: 356px;
        }
        .auto-style6 {
            width: 356px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table>
        <tr>
            <td class="auto-style3">Select Image : </td>
            <td class="auto-style6">
                <asp:FileUpload ID="FU1" runat="server" /></td>
 
        </tr>
        <tr>
            <td class="auto-style4">Enter the FONT size : </td><td class="auto-style5">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style3">Watermark Text : </td>
            <td class="auto-style6">
                <asp:TextBox ID="txtWatermarkText" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style6">
                <asp:Button ID="Button1" runat="server" Text="Generate" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr >
            <td colspan="2" align="center" style="rotation: inherit">
                <asp:Label ID="lblMsg" runat="server" ForeColor="Red" />
            </td>
        </tr>
        <tr style="color:blue">
            <td class="auto-style1" colspan="2">Step1: Save the below image.</td>
        </tr>
        <tr style="color:blue">
            <td class="auto-style1" colspan="2">Step2: After that, choose the downloaded image.</td>
        </tr>
        <tr style="color:blue">
            <td class="auto-style2" colspan="2">Step3: Enter the font size ( Below 70).</td>
        </tr>
        <tr style="color:blue">
            <td class="auto-style2" colspan="2">Step4: Type Text in the box. (For Eg. Your Name)</td>
        </tr>
        <tr style="color:blue">
            <td class="auto-style2" colspan="2">Step5: Click Generate and save.</td>
        </tr>
    </table>
    <asp:Image ID="Image1" runat="server" />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/img/j.png" Width="342px" />
    </form>
</body>
</html>
