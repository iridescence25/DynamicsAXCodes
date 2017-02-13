[
    DataMemberAttribute,
    SysOperationLabelAttribute(literalstr("@CUS0003"))
]
public ItemId parmItemId(ItemId _itemId = itemId)
{
    itemId = _itemId;
    return itemId;
}
