///<summary>
///This lookup code is based on the values selected from other dialog field
///For example, show only the warehouses related to the selected site
///</summary>
public void inventLocationLookup(FormControl _formControl, str _filterStr)
{
    QueryBuildDataSource    qbdsInventLoc;

    Query query = new Query();
    SysTableLookup sysTableLookup = SysTableLookup::newParameters(tableNum(InventLocation),_formControl);

    sysTableLookup.addLookupField(fieldNum(InventLocation, InventLocationId));
    sysTableLookup.addLookupField(fieldNum(InventLocation, Name));
    
    //Add a filter if a site value was specified
    if(dialogSite.value())
    {
        qbdsInventLoc = query.addDataSource(tableNum(InventLocation));
        qbdsInventLoc.addRange(fieldNum(InventLocation, InventSiteId)).value(dialogSite.value());
        sysTableLookup.parmQuery(query);
    }

    sysTableLookup.performFormLookup();
}
