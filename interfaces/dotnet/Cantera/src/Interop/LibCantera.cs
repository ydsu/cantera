using System.Runtime.InteropServices;

namespace Cantera.Interop;

static partial class LibCantera
{
#if IS_WINDOWS
    const string LibFile = "cantera.3.0.0.dll";
#elif IS_MACOS
    const string LibFile = "cantera.3.0.0.dylib";
#elif IS_LINUX
    const string LibFile = "cantera.3.0.0.so";
#endif

    public delegate void Writer(LogLevel logLevel, string category, string message);

    [DllImport(LibFile)]
    public static extern int ct_setLogWriter(Writer writer);
}