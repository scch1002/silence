using Silence.Macro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilenceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            switch(args[0])
            {
                case "p":
                    PlayRecord(args[1]);
                    break;
                case "r":
                    RecordActions(args[1]);
                    break;
            }
        }

        private static void PlayRecord(string recordFilePath)
        {
            var player = new MacroPlayer();
            var loadedMacro = new Macro();
            loadedMacro.Load(recordFilePath);
            player.LoadMacro(loadedMacro);
            player.PlayMacro();
        }

        private static void RecordActions(string outputDirectory)
        {
            var recorder = new MacroRecorder();
            recorder.StartRecording();
            Console.Write("Press <Enter> to end recording... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            recorder.StartRecording();
        }

        //Will need to complete command line recorder. This is going to require more than trivial thread setup.
        private static void RunRecorder(MacroRecorder macroRecorder)
        {

        }
    }
}
