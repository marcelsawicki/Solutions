function ensureTip() 
{
    var r = getContext().getRequest();
    var i = r.getBody();
    if(isNaN(i)["tip"] || i["tip"]===null) 
    {
        i["tip"] = 0;
    }
    r.setBody(i);
}