using System.Text;

namespace OctoPermission.Solution;
public class Program {
    // Tamanho de cada parte da string de permissão
    public const int PERMISSION_SIZE = 3;
    // Total de divisões na string de permissão
    public const int TOTAL_PERMISSIONS = 3;
    // Valores associados a cada tipo de permissão (none, exec, read, write)
    private static readonly IDictionary<char, int> _permissionValues = new Dictionary<char, int>
    {
        { '-', 0 },
        { 'x', 1 },
        { 'w', 2 },
        { 'r', 4 }
    };

    public static int PermissionToOctal(string permission)
    {
        var splitedPermissions = SplitPermissions(permission);

        var octalPermissionsList = new List<int>();
        foreach (var splitedPermission in splitedPermissions)
        {
            octalPermissionsList.Add(OctalPermissionSum(splitedPermission));
        }

        var octalPermissionString = new StringBuilder();
        foreach (var octalPermission in octalPermissionsList)
        {
            octalPermissionString.Append(octalPermission);
        }

        return int.Parse(octalPermissionString.ToString());
    }

    private static List<string> SplitPermissions(string permission)
    {
        var splitedPermissions = new List<string>();

        for (int i = 0; i < TOTAL_PERMISSIONS; i++)
        {
            splitedPermissions.Add(
                permission.Substring(i * PERMISSION_SIZE, PERMISSION_SIZE)
            );
        }

        return splitedPermissions;
    }

    private static int OctalPermissionSum(string splitedPermission)
    {
        var octalSum = 0;

        for (int i = 0; i < splitedPermission.Length; i++)
        {
            octalSum += _permissionValues[splitedPermission.ElementAt(i)];
        }

        return octalSum;
    }

    public static void Main()
    {
        Console.WriteLine(PermissionToOctal("r-xrwx--x").ToString("D3"));
        Console.WriteLine(PermissionToOctal("rwxrwxrwx").ToString("D3"));
        Console.WriteLine(PermissionToOctal("--x--x--x").ToString("D3"));
    }
}
