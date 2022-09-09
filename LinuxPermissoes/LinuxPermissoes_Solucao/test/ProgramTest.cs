using FluentAssertions;

namespace OctoPermission.Solution.Test;

public class ProgramTest
{
    [Theory]
    [InlineData("---------", 0)]
    [InlineData("--------x", 1)]
    [InlineData("-------w-", 2)]
    [InlineData("------r--", 4)]
    [InlineData("-------wx", 3)]
    [InlineData("------r-x", 5)]
    [InlineData("------rw-", 6)]
    [InlineData("------rwx", 7)]
    [InlineData("-----x---", 10)]
    [InlineData("----w----", 20)]
    [InlineData("---r-----", 40)]
    [InlineData("----wx---", 30)]
    [InlineData("---r-x---", 50)]
    [InlineData("---rw----", 60)]
    [InlineData("---rwx---", 70)]
    [InlineData("--x------", 100)]
    [InlineData("-w-------", 200)]
    [InlineData("r--------", 400)]
    [InlineData("-wx------", 300)]
    [InlineData("r-x------", 500)]
    [InlineData("rw-------", 600)]
    [InlineData("rwx------", 700)]
    public void Should_Return_Each_Parts_Permission_As_Octal_Numbers(
        string permissionString,
        int expectedOctalPermission
    )
    {
        var result = Program.PermissionToOctal(permissionString);
        result.Should().Be(expectedOctalPermission);
    }
}
