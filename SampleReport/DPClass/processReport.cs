[SysEntryPointAttribute(true)]
public void processReport()
{
    Query                       query;
    QueryRun                    qr;
    Contract                    contract;
    ProdBOM                     prodBOMTable;
    ProdTable                   prodTable;
    InventTable                 inventTable;
    InventSiteId                siteId;
    TransDate                   fromDate;
    TransDate                   toDate;
    Shift                       shift;
    InventLocationId            locationId;
    ItemId                      itemId;
    ItemId                      formulaItemId;
    InventDim                   inventDim;
    QueryBuildDataSource        qbdsInventDim, qbdsProdTable, qbdsProdBOMTable;
 

    contract        = this.parmDataContract();
    siteId          = contract.parmSiteId();
    fromDate        = contract.parmFromDate();
    toDatw          = contract.parmTodate();
    shift           = contract.parmShift();

    locationId      = contract.parmLocationId();
    itemId          = contract.parmItemId();
    formulaItemId   = contract.parmFormulaItemId();

    query       = new Query(querystr(myQuery));

    if(siteId)
    {
        qbdsInventDim = query.dataSourceTable(tableNum(InventDim));
        qbdsInventDim.addRange(fieldNum(InventDim, InventSiteId)).value(siteId);
    }

    qbdsProdTable = query.dataSourceTable(tableNum(ProdTable));
    qbdsProdTable.addRange(fieldNum(ProdTable, ProdStatus)).value(enum2Value(ProdStatus::Scheduled));

    if(fromDate && toDate)
    {
        qbdsProdTable.addRange(fieldNum(ProdTable, SchedStart)).value(queryRange(frmDate, toDate));
    }

    if(shift)
    {
        qbdsProdTable.addRange(fieldNum(ProdTable, Shift)).value(queryvalue(shift));
    }

    if(formulaItemId)
    {
        qbdsProdTable.addRange(fieldNum(ProdTable, ItemId)).value(formulaItemId);
    }

    qbdsProdBOMTable = query.dataSourceTable(tableNum(ProdBOM));

    if(itemId)
    {
         qbdsProdBOMTable.addRange(fieldNum(ProdBOM, ItemId)).value(itemId);
    }

    if(locationId)
    {
        select firstOnly inventDim where inventDim.InventSiteId == siteId && inventDim.InventLocationId == locationId;
        qbdsProdBOMTable.addRange(fieldNum(ProdBOM, InventDimId)).value(inventDim.inventDimId);
    }

    qr = new QueryRun(query);

    while(qr.next())
    {
        inventDim      = qr.get(tableNum(InventDim));
        prodTable      = qr.get(tableNum(ProdTable));
        prodBOMTable   = qr.get(tableNum(ProdBOM));
        this.insertIntoTemp(prodBOMTable, prodTable, inventDim, formulaItemId, locationId, shift);
    } 
}
