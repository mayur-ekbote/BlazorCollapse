namespace BlazorCollapse.Shared.SimpleCollapse;

public class CollapseState
{
    public bool IsCollapsed { get; set; } = true;
    public Action<object>? OnToggle {  get; set; }
    public void Collapse(object sender)
    {
        IsCollapsed = true;
        OnToggle?.Invoke(sender);
    }
    public void Exapand(object sender) 
    {
        IsCollapsed = false;
        OnToggle?.Invoke(sender);
    }
    public void Toggle(object sender)
    {
        IsCollapsed = !IsCollapsed;
        OnToggle?.Invoke(sender);
    }
}
