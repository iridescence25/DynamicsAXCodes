///<summary>
///Gets all table fields, label names and the data types from a specified table
///Code originally used for AX 2012 job codes
///Can also be used for AX 7 and D365, but it would require some modifications
///</summary>
static void getTableFieldInfo(Args _args)
{
    DictTable   dictTable = new SysDictTable(tableNum(TableId)); // Type in the Id of the table.
    FieldId     fieldId = dictTable.fieldNext(0); 
    DictField   dictField;

    while(fieldId)
    {
        dictField = dictTable.fieldObject(fieldId);

        info(strFmt("Label: %1, AX Field: %2, BASE EDT: %3, IS MANDATORY: %4",
        dictField.label(), //Show Field Label
        dictField.name(), // Show AX Field name
        dictField.baseType(), // Show AX Field Base type        
        dictfield.mandatory())); // Show if Mandatory
        fieldId = dictTable.fieldNext(fieldId);
     }
}
