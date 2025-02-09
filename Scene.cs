using Godot;

namespace NUG.Tests
{
  public partial class Scene : Node
  {
    public override async void _Ready()
    {
      var testRunner = new TestRunner(GetTree());

      await testRunner.Run(res =>
      {
        var name = $"{res.TestMethod.DeclaringType!.Name}.{res.TestMethod.Name}";
        if (res.Exception != null)
        {
          GD.PrintErr($"Failed {name}\n{res.Exception.Message}");
          throw res.Exception;
        }
        else
        {
          GD.Print($"Passed {name}");
        }
      });

      GetTree().Quit();
    }
  }
}