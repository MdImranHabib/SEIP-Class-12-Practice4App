<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BankAccountUI.aspx.cs" Inherits="BankAccount.BankAccountUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="container">
    <h2 class="alert bg-primary text-center">Bank Account</h2>
    <div class="row">
        <div class="col-md-6">
            <h3 class="alert bg-info text-center">Account Creation</h3>
            <hr />
            <label id="lblShowAccountCreateMsg" runat="server" class="control-label col-md-offset-3 text-info"></label>
            <br />
            <br />
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="col-md-3 control-label">Account Number: </label>
                    <input id="inputAccountNo" runat="server" class="col-md-6 form-control"/>
                </div>
                <div class="form-group">
                    <label class="col-md-3 control-label">Account Name: </label>
                    <input id="inputAccountName" runat="server" class="col-md-6 form-control"/>
                </div>
                <div class="col-md-offset-3">
                <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" />
                </div>
            </div>
        </div>
        <div class="col-md-6">
            <h3 class="alert bg-info text-center">Transaction</h3>
            <hr />
            <label id="lblShowTransactionMsg" runat="server" class="control-label col-md-offset-3 text-info"></label>
            <br />
            <br />
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="col-md-3 control-label">Amount: </label>
                    <input id="inputAmount" runat="server" class="col-md-6 form-control"/>
                </div>
                <div class="col-md-offset-3">
                    <asp:Button ID="btnDeposit" runat="server" Text="Deposit" OnClick="btnDeposit_Click" />
                    <asp:Button ID="btnWithdraw" runat="server" Text="WithDraw" OnClick="btnWithdraw_Click" />
                </div>
            </div>
        </div>
    </div>
    <br />
    <hr />
    <div class="row">
        <div class="col-md-8 col-md-offset-4">
            <asp:Button ID="btnReport" runat="server" Text="Report" Width="908px" OnClick="btnReport_Click" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-8 col-md-offset-3">
            <br />
   
            <label id="lblReport" runat="server" class="control-label text-center text-success"></label>
        </div>
    </div>
</div>
</asp:Content>
