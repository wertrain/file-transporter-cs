using System;
using Microsoft.Extensions.CommandLineUtils;

namespace FTPRCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new CommandLineApplication(throwOnUnexpectedArg: false);

            app.Name = nameof(FTPRCLI);
            app.Description = "FTPR is Simple file transporter.";
            app.HelpOption("-h|--help");

            var portOption = app.Option(
                template: "-p|--port",
                description: "Port number used for connection.",
                optionType: CommandOptionType.SingleValue
            );

            var fileOption = app.Option(
                template: "-f|--file",
                description: "Path to transfer file.",
                optionType: CommandOptionType.SingleValue
            );

            var addressArgument = app.Argument(
                name: "ip",
                description: "IP address of the connection destination.",
                multipleValues: false);

            app.OnExecute(() =>
            {
                var address = addressArgument.Value;
                if (address == null)
                {
                    app.ShowHelp();
                    return 1;
                }

                var port = 4567;
                if (portOption.HasValue())
                {
                    int.TryParse(portOption.Value(), out port);
                }

                bool bootServerMode = !fileOption.HasValue();
                if (bootServerMode)
                {
                    Console.WriteLine($"Start server on {address}:{port}");
                    Console.WriteLine($"waiting for connection.");

                    var server = new FTPLib.Server();
                    if (server.Receive(address, port))
                    {
                        Console.WriteLine($"File received.");
                    }
                    else
                    {
                        Console.WriteLine("Failed start server.");
                    }
                }
                else
                {
                    var filePath = fileOption.Value();
                    if (System.IO.File.Exists(filePath))
                    {
                        Console.WriteLine($"Connect server on {address}:{port}");

                        var client = new FTPLib.Client();
                        if (client.transfer(address, port, filePath))
                        {
                            Console.WriteLine($"Sent file {fileOption.Value()}");
                        }
                        else
                        {
                            Console.WriteLine("Failed send file.");
                        }
                    }

                }
                
                return 0;
            });

            app.Execute(args);
        }
    }
}
