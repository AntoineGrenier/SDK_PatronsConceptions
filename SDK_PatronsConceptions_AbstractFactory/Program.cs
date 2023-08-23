Application windowsApp = new Application(new WindowsUIFactory());
windowsApp.Run();

Application macApp = new Application(new MacUIFactory());
macApp.Run();

abstract class AbstractButton
{
    public abstract void Render();
}

class WindowsButton : AbstractButton
{
    public override void Render()
    {
        Console.WriteLine("Rendering a Windows button");
    }
}

class MacButton : AbstractButton
{
    public override void Render()
    {
        Console.WriteLine("Rendering a Mac button");
    }
}

abstract class AbstractCheckbox
{
    public abstract void Render();
}

class WindowsCheckbox : AbstractCheckbox
{
    public override void Render()
    {
        Console.WriteLine("Rendering a Windows checkbox");
    }
}

class MacCheckbox : AbstractCheckbox
{
    public override void Render()
    {
        Console.WriteLine("Rendering a Mac checkbox");
    }
}

abstract class AbstractUIFactory
{
    public abstract AbstractButton CreateButton();
    public abstract AbstractCheckbox CreateCheckbox();
}

class WindowsUIFactory : AbstractUIFactory
{
    public override AbstractButton CreateButton()
    {
        return new WindowsButton();
    }

    public override AbstractCheckbox CreateCheckbox()
    {
        return new WindowsCheckbox();
    }
}

class MacUIFactory : AbstractUIFactory
{
    public override AbstractButton CreateButton()
    {
        return new MacButton();
    }

    public override AbstractCheckbox CreateCheckbox()
    {
        return new MacCheckbox();
    }
}

class Application
{
    private AbstractUIFactory _uiFactory;

    public Application(AbstractUIFactory uiFactory)
    {
        _uiFactory = uiFactory;
    }

    public void Run()
    {
        AbstractButton button = _uiFactory.CreateButton();
        AbstractCheckbox checkbox = _uiFactory.CreateCheckbox();

        button.Render();
        checkbox.Render();
    }
}