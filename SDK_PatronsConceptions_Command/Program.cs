Light light = new Light();
ICommand turnOn = new TurnOnCommand(light);
ICommand turnOff = new TurnOffCommand(light);

RemoteControl remote = new RemoteControl();

remote.SetCommand(turnOn);
remote.PressButton();

remote.SetCommand(turnOff);
remote.PressButton();

// Command
interface ICommand
{
    void Execute();
}

// Receiver
class Light
{
    public void TurnOn()
    {
        Console.WriteLine("Light is on");
    }

    public void TurnOff()
    {
        Console.WriteLine("Light is off");
    }
}

// Concrete Commands
class TurnOnCommand : ICommand
{
    private Light light;

    public TurnOnCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        light.TurnOn();
    }
}

class TurnOffCommand : ICommand
{
    private Light light;

    public TurnOffCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        light.TurnOff();
    }
}

// Invoker
class RemoteControl
{
    private ICommand command;

    public void SetCommand(ICommand command)
    {
        this.command = command;
    }

    public void PressButton()
    {
        command.Execute();
    }
}