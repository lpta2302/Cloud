public class QueryFilter
{
    public string[] StringFiltersKey{get;set;}
    public string[] StringFilters{get;set;}
    public QueryFilter(){
        
    }

    public QueryFilter(string[] stringFiltersKey, string[] stringFilters)
    {
        StringFiltersKey = stringFiltersKey;
        StringFilters = stringFilters;
    }
}