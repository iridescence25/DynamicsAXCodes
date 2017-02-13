[
    SRSReportDataSetAttribute('TableTmp')
]
public TableTmp getTableTmp()
{
    select * from tempTable;
    return tempTable;
}
