# Local Terminal

A local terminal is available on any platform supported by Rider.

1. Open the local terminal by selecting _View \| Tool Windows \| Terminal_.
   Ctrl+Alt+1 (Visual Studio) or ^⌘1 (Rider Mac OS X)
2. Run some commands: `cd ..`, `echo Hello`, ...
3. The IDE supports multiple simultaneous sessions. Open a new terminal session clicking the _+_ button in the toolbar.
4. Go back in history: up/down arrows let us replay previous commands.
5. Configure a custom shell for the terminal. Under setting, find _Tools \| Terminal_ and configure a preferred shell.
   Close and re-open the terminal window to see the new shell in effect.
    * PowerShell: `powershell`
    * Cmder: `"cmd" /k ""%CMDER_ROOT%\vendor\init.bat""` (note the `CMDER_ROOT` environment variable has to be set)
    * Cygwin: `"C:\cygwin\bin\bash.exe" --login -i`
    * Zsh: `/bin/zsh`
    * Bash: `/bin/bash` (or bash for Windows: `bash.exe`)