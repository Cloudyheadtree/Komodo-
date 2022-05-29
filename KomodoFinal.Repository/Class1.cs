namespace KomodoFinal.Repository;
public class SushiItem_Repo
{
private List<SushiItem> _menu = new List<SushiItem>();

public bool AddSushiItem(SushiItem sushi)
{
    int beginningCount = _menu.Count;

    _menu.Add(sushi);
    bool wasAdded = (_menu.Count > beginningCount) ? true : false;
    return wasAdded;
}
//All of the sushi items
public SushiItem GetSushiItemBySushiNum(int sushiNum)
{
    foreach (SushiItem sushiItem in _menu)
    {
        if (sushiItem.SushiNumber == sushiNum)
        {
            return sushiItem;
        }
    }
    return null;
}

//update section

public bool UpdateCurrentSushiItem(int oldSushiNum, SushiItem newSushi)
{
    SushiItem oldSushiItem = GetSushiItemBySushiNum(oldSushiNum);

    if (oldSushiItem != null)
    {
        oldSushiItem.SushiNumber = newSushi.SushiNumber;
        oldSushiItem.SushiName = newSushi.SushiName;
        oldSushiItem.Description = newSushi.Description;
        oldSushiItem.Ingredients = newSushi.Ingredients;
        oldSushiItem.Price = newSushi.Price;
        return true;
    }
    else 
    {
        return false;
    }
}
public bool DeleteSushi(SushiItem sushi)
{
    bool yeetSushi = _menu.Remove(sushi);
    return yeetSushi;
}
}
