using System;
using System.Drawing;

namespace SuperSize.Model
{
    public class LogicResult
    {
        public Rectangle Rectangle { get; private init; }

        public string NoResultMessage { get; private init; }

        public Exception? Exception { get; private init; }

        private LogicResult()
        {
            Rectangle = Rectangle.Empty;
            NoResultMessage = string.Empty;
        }

        public static LogicResult OK(Rectangle rectangle) => new()
        {
            Rectangle = rectangle,
        };

        public static LogicResult NoResult(string message) => new()
        {
            NoResultMessage = message,
        };

        public static LogicResult Error(Exception exception) => new()
        {
            Exception = exception,
        };

        public bool HasResult => !Rectangle.IsEmpty;

        public bool HasException => Exception is not null;

        public bool TryGetRectangle(out Rectangle rectangle)
        {
            rectangle = Rectangle;
            return rectangle != Rectangle.Empty;
        }
    }
}
