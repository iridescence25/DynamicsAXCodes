public void insertIntoTemp(ProdBOM prodBomTable, ProdTable prodTable, Inventdim inventDim, ItemId formulaItemId, InventLocationId locationId, Shift shift)
{
    BOMVersion bomVersionTable;
    NoYes isFormulaExistEnum;
    ;

        tempTable.BOMId = prodTable.ItemId;
        tempTable.BOMName = prodTable.Name;

        if(formulaItemId)
        {
            tempTable.FormulaItemId = prodTable.ItemId;
        }

        if(locationId)
        {
            tempTable.Warehouse  = locationId;
        }

        if(shift)
        {
            tempTable.Shift = shift;
        }

        tempTable.ItemId = prodBomTable.ItemId;
        tempTable.Name = prodBomTable.itemName();
        tempTable.TransDate = prodBomTable.SchedStart;
        tempTable.Shift = prodBomTable.Shift;
        tempTable.InventUnitId = prodBomTable.UnitId;
        tempTable.BOMConsump = prodBomTable.QtyBOMCalc;

        tempTable.ProdId = prodTable.ProdId;

        tempTable.SiteId = inventDim.InventSiteId;

        tempTable.insert();
}
