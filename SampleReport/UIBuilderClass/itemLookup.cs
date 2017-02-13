public void itemLookup(FormControl _formControl, str _filterStr)
{
    SysTableLookup          sysTableLookup;
    ;

    //Set TableLookup for dropdown
    sysTableLookup = SysTableLookup::newParameters(tableNum(InventTable),_formControl);
    
    //Set lookup fields, set the field that contains the needed value to true
    sysTableLookup.addLookupField(fieldNum(InventTable, ItemId),true);
    sysTableLookup.addLookupField(fieldNum(InventTable, NameAlias),false);
    
    //Set parmUseLookupValue to false to prevent duplicates
    sysTableLookup.parmUseLookupValue(false);
    sysTableLookup.performFormLookup();
}
