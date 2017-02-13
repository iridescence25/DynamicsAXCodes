public void formulaItemLookup(FormControl _formControl, str _filterStr)
{
    Query query = new Query();
    QueryBuildDataSource qbdsProdTable;
    QueryBuildRange qbr;

    //Set TableLookup for dropdown
    SysTableLookup sysTableLookup = SysTableLookup::newParameters(tableNum(InventTable),_formControl);
    
    //Set a query for filtering
    qbdsProdTable = query.addDataSource(tableNum(InventTable));
    
    //Set lookup fields, set the field that contains the needed value to true
    sysTableLookup.addLookupField(fieldNum(InventTable, ItemId),true);
    sysTableLookup.addLookupField(fieldNum(InventTable, NameAlias),false);
    
    //Add a range to the query as a filter
    qbr = qbdsProdTable.addRange(fieldNum(InventTable, PmfProductType));
    qbr.value(enum2Value(PmfProductType::Formula));
    
    //Set parmUseLookupValue to false to prevent duplicates
    sysTableLookup.parmUseLookupValue(false);
    sysTableLookup.parmQuery(query);

    sysTableLookup.performFormLookup();
}
