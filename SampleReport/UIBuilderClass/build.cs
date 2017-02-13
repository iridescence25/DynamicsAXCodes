public void build()
{
    Dialog dialogLocal = this.dialog();
    contract           = this.dataContractObject();
    
    //Bind the dialog fields to the contract paramaters
    dialogSite         = this.addDialogField(methodStr(Contract, parmSiteId),contract);
    dialogFromDate     = this.addDialogField(methodStr(Contract, parmFromDate),contract);
    dialogToDate       = this.addDialogField(methodStr(Contract, parmToDate),contract);
    dialogItemId       = this.addDialogField(methodStr(Contract, parmItemId),contract);
    dialogFormulaItem  = this.addDialogField(methodStr(Contract, parmFormulaItemId),contract);
    dialogLocation     = this.addDialogField(methodStr(Contract, parmLocationId),contract);
    dialogShift        = this.addDialogField(methodStr(Contract, parmShift),contract);
}
