public void postBuild()
{
    super();

    dialogSite         = this.bindInfo().getDialogField(contract,methodStr(Contract, parmSiteId));
    dialogFrmDt        = this.bindInfo().getDialogField(contract,methodStr(Contract, parmFromDate));
    dialogToDt         = this.bindInfo().getDialogField(contract,methodStr(Contract, parmToDate));
    dialogItemId       = this.bindInfo().getDialogField(contract,methodStr(Contract, parmItemId));
    dialogFormulaItem  = this.bindInfo().getDialogField(contract,methodStr(Contract, parmFormulaItemId));
    dialogLocation     = this.bindInfo().getDialogField(contract,methodStr(Contract, parmLocationId));
    dialogShift        = this.bindInfo().getDialogField(contract,methodStr(Contract, parmShift));

    dialogSite.registerOverrideMethod(methodStr(FormStringControl, lookup), methodStr(UIBuilderClass, inventSiteLookup), this);
    dialogFormulaItem.registerOverrideMethod(methodStr(FormStringControl, lookup), methodStr(UIBuilderClass, formulaItemLookup), this);

    dialogItemId.registerOverrideMethod(methodStr(FormStringControl, lookup), methodStr(UIBuilderClass, itemLookup), this);
    dialogLocation.registerOverrideMethod(methodStr(FormStringControl, lookup), methodStr(UIBuilderClass, inventLocationLookup), this);
}
