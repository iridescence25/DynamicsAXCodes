public void inventSiteLookup(FormControl _formControl, str _filterStr)
{
    SysTableLookup sysTableLookup = SysTableLookup::newParameters(tableNum(InventSite),_formControl);

    sysTableLookup.addLookupField(fieldNum(InventSite, SiteId));
    sysTableLookup.addLookupField(fieldNum(InventSite, Name));

    sysTableLookup.performFormLookup();
}
