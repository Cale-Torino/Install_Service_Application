# Install Service Application

[<img src="img/heading.jpg" width="500"/>](img/heading.jpg)

Simple example application which installs, uninstalls, starts, stops and restarts a service.

This application must start as Admin in order to satisfy these tasks.

The service must have the self install option.

This example was written in `.Net core 6.0` and doesn't require the `C:\Windows\Microsoft.NET\Framework\v4.0.30319` path or `InstallUtil.exe`.
since we are using `ManagedInstallerClass.InstallHelper`

E.G

```C#
/// <summary>
/// The main entry point for the application.
/// </summary>
static void Main(string[] args)
{
    if (Environment.UserInteractive)
    {

        if (args.Length > 0)
        {
            switch (args[0])
            {
                case "-install":
                    {
                        ManagedInstallerClass.InstallHelper(new string[] { Assembly.GetExecutingAssembly().Location });
                        StartService();
                        break;
                    }
                case "-uninstall":
                    {
                        ManagedInstallerClass.InstallHelper(new string[] { "/u", Assembly.GetExecutingAssembly().Location });
                        break;
                    }
            }
        }
    }
    else
    {
        ServiceBase[] ServicesToRun;
        ServicesToRun = new ServiceBase[]
        {
        new Service1()
        };
        ServiceBase.Run(ServicesToRun);
    }
}

private static bool IsInstalled()
{
    using (ServiceController controller = new ServiceController($"{AppDomain.CurrentDomain.FriendlyName}_Service"))
    {
        try
        {
            ServiceControllerStatus status = controller.Status;
        }
        catch
        {
            return false;
        }
        return true;
    }
}

private static void StartService()
{
    if (!IsInstalled()) return;
    using (ServiceController controller = new ServiceController($"{AppDomain.CurrentDomain.FriendlyName}_Service"))
    {
        try
        {
            if (controller.Status != ServiceControllerStatus.Running)
            {
                controller.Start();
                controller.WaitForStatus(ServiceControllerStatus.Running,TimeSpan.FromSeconds(10));
            }
        }
        catch
        {
            throw;
        }
    }
}
```
