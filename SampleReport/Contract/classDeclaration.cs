[
    DataContractAttribute,
    SysOperationContractProcessingAttribute(classStr(UIBuilderClass))
]
class Contract implements SysOperationValidatable
{
    InventSiteId        siteId;
    TransDate           fromDate;
    TransDate           toDate;
    Shift               shift;
    InventLocationId    locationId;
    ItemId              itemId;

    ItemId              formulaItemId;
}
