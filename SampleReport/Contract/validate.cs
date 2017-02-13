public boolean validate()
{

    if(this.parmFromDate() > this.parmTodate())
        return checkFailed("FromDate cannot be greater than ToDate");

    if(!this.parmLocationId())
        return checkFailed("The Warehouse parameter is missing a value.");

    if(!this.parmSiteId())
        return checkFailed("The Site parameter is missing a value.");

    if(!this.parmFromDate())
        return checkFailed("The FromDate parameter is missing a value.");

    if(!this.parmTodate())
        return checkFailed("The ToDate parameter is missing a value.");

    return true;

}
