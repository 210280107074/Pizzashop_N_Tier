public class PermissionModel3{
    public int PermissionId{
        get;
        set;
    }

     public bool IsChecked { get; set; } // Track if the main permission is checked
    public bool can_view{
        get;
        set;
    }
    public bool can_edit{
        get;
        set;
    }
    public bool can_delete{
        get;
        set;
    }
}