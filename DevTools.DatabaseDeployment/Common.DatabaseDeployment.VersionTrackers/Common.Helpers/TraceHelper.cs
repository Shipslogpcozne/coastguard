namespace DevTools.Helpers
{
    using System;
    using System.Diagnostics;

    public static class TraceHelper
    {
        private static TraceSwitch _generalTraceSwitch = new TraceSwitch("General", "The general trace switch", "4");

        public static IDisposable Indent()
        {
            return new TraceIndentation();
        }

        public static void TraceError(Exception exception)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Error, exception.ToString());
        }

        public static void TraceError(string message)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Error, message);
        }

        public static void TraceError(TraceSwitch traceSwitch, Exception exception)
        {
            TraceInternal(traceSwitch, TraceLevel.Error, exception.ToString());
        }

        public static void TraceError(TraceSwitch traceSwitch, string message)
        {
            TraceInternal(traceSwitch, TraceLevel.Error, message);
        }

        public static void TraceError(Exception exception, string message)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Error, message + "\r\n\r\n" + exception.ToString());
        }

        public static void TraceError(string messageFormat, params object[] arguments)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Error, string.Format(messageFormat, arguments));
        }

        public static void TraceError(TraceSwitch traceSwitch, Exception exception, string message)
        {
            TraceInternal(traceSwitch, TraceLevel.Error, message + "\r\n\r\n" + exception.ToString());
        }

        public static void TraceError(TraceSwitch traceSwitch, string messageFormat, params object[] arguments)
        {
            TraceInternal(traceSwitch, TraceLevel.Error, string.Format(messageFormat, arguments));
        }

        public static void TraceError(Exception exception, string messageFormat, params object[] arguments)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Error, string.Format(messageFormat, arguments) + "\r\n\r\n" + exception.ToString());
        }

        public static void TraceError(TraceSwitch traceSwitch, Exception exception, string messageFormat, params object[] arguments)
        {
            TraceInternal(traceSwitch, TraceLevel.Error, string.Format(messageFormat, arguments) + "\r\n\r\n" + exception.ToString());
        }

        public static void TraceInformation(Exception exception)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Info, exception.ToString());
        }

        public static void TraceInformation(string message)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Info, message);
        }

        public static void TraceInformation(TraceSwitch traceSwitch, Exception exception)
        {
            TraceInternal(traceSwitch, TraceLevel.Info, exception.ToString());
        }

        public static void TraceInformation(TraceSwitch traceSwitch, string message)
        {
            TraceInternal(traceSwitch, TraceLevel.Info, message);
        }

        public static void TraceInformation(Exception exception, string message)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Info, message + "\r\n\r\n" + exception.ToString());
        }

        public static void TraceInformation(string messageFormat, params object[] arguments)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Info, string.Format(messageFormat, arguments));
        }

        public static void TraceInformation(TraceSwitch traceSwitch, Exception exception, string message)
        {
            TraceInternal(traceSwitch, TraceLevel.Info, message + "\r\n\r\n" + exception.ToString());
        }

        public static void TraceInformation(TraceSwitch traceSwitch, string messageFormat, params object[] arguments)
        {
            TraceInternal(traceSwitch, TraceLevel.Info, string.Format(messageFormat, arguments));
        }

        public static void TraceInformation(Exception exception, string messageFormat, params object[] arguments)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Info, string.Format(messageFormat, arguments) + "\r\n\r\n" + exception.ToString());
        }

        public static void TraceInformation(TraceSwitch traceSwitch, Exception exception, string messageFormat, params object[] arguments)
        {
            TraceInternal(traceSwitch, TraceLevel.Info, string.Format(messageFormat, arguments) + "\r\n\r\n" + exception.ToString());
        }

        private static void TraceInternal(TraceSwitch traceSwitch, TraceLevel traceLevel, string message)
        {
            switch (traceLevel)
            {
                case TraceLevel.Error:
                    if (traceSwitch.TraceError)
                    {
                        Trace.TraceError(message);
                    }
                    break;

                case TraceLevel.Warning:
                    if (traceSwitch.TraceWarning)
                    {
                        Trace.TraceWarning(message);
                    }
                    break;

                case TraceLevel.Info:
                    if (traceSwitch.TraceInfo)
                    {
                        Trace.TraceInformation(message);
                    }
                    break;

                case TraceLevel.Verbose:
                    if (traceSwitch.TraceVerbose)
                    {
                        Trace.TraceInformation(message);
                    }
                    break;
            }
        }

        public static void TraceVerbose(Exception exception)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Verbose, exception.ToString());
        }

        public static void TraceVerbose(string message)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Verbose, message);
        }

        public static void TraceVerbose(TraceSwitch traceSwitch, Exception exception)
        {
            TraceInternal(traceSwitch, TraceLevel.Verbose, exception.ToString());
        }

        public static void TraceVerbose(TraceSwitch traceSwitch, string message)
        {
            TraceInternal(traceSwitch, TraceLevel.Verbose, message);
        }

        public static void TraceVerbose(Exception exception, string message)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Verbose, message + "\r\n\r\n" + exception.ToString());
        }

        public static void TraceVerbose(string messageFormat, params object[] arguments)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Verbose, string.Format(messageFormat, arguments));
        }

        public static void TraceVerbose(TraceSwitch traceSwitch, Exception exception, string message)
        {
            TraceInternal(traceSwitch, TraceLevel.Verbose, message + "\r\n\r\n" + exception.ToString());
        }

        public static void TraceVerbose(TraceSwitch traceSwitch, string messageFormat, params object[] arguments)
        {
            TraceInternal(traceSwitch, TraceLevel.Verbose, string.Format(messageFormat, arguments));
        }

        public static void TraceVerbose(Exception exception, string messageFormat, params object[] arguments)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Verbose, string.Format(messageFormat, arguments) + "\r\n\r\n" + exception.ToString());
        }

        public static void TraceVerbose(TraceSwitch traceSwitch, Exception exception, string messageFormat, params object[] arguments)
        {
            TraceInternal(traceSwitch, TraceLevel.Verbose, string.Format(messageFormat, arguments) + "\r\n\r\n" + exception.ToString());
        }

        public static void TraceWarning(Exception exception)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Warning, exception.ToString());
        }

        public static void TraceWarning(string message)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Warning, message);
        }

        public static void TraceWarning(TraceSwitch traceSwitch, Exception exception)
        {
            TraceInternal(traceSwitch, TraceLevel.Warning, exception.ToString());
        }

        public static void TraceWarning(TraceSwitch traceSwitch, string message)
        {
            TraceInternal(traceSwitch, TraceLevel.Warning, message);
        }

        public static void TraceWarning(Exception exception, string message)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Warning, message + "\r\n\r\n" + exception.ToString());
        }

        public static void TraceWarning(string messageFormat, params object[] arguments)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Warning, string.Format(messageFormat, arguments));
        }

        public static void TraceWarning(TraceSwitch traceSwitch, Exception exception, string message)
        {
            TraceInternal(traceSwitch, TraceLevel.Warning, message + "\r\n\r\n" + exception.ToString());
        }

        public static void TraceWarning(TraceSwitch traceSwitch, string messageFormat, params object[] arguments)
        {
            TraceInternal(traceSwitch, TraceLevel.Warning, string.Format(messageFormat, arguments));
        }

        public static void TraceWarning(Exception exception, string messageFormat, params object[] arguments)
        {
            TraceInternal(_generalTraceSwitch, TraceLevel.Warning, string.Format(messageFormat, arguments) + "\r\n\r\n" + exception.ToString());
        }

        public static void TraceWarning(TraceSwitch traceSwitch, Exception exception, string messageFormat, params object[] arguments)
        {
            TraceInternal(traceSwitch, TraceLevel.Warning, string.Format(messageFormat, arguments) + "\r\n\r\n" + exception.ToString());
        }

        public static TraceSwitch General
        {
            get
            {
                return _generalTraceSwitch;
            }
        }

        private sealed class TraceIndentation : IDisposable
        {
            public TraceIndentation()
            {
                Trace.Indent();
            }

            public void Dispose()
            {
                Trace.Unindent();
                GC.SuppressFinalize(this);
            }
        }
    }
}

