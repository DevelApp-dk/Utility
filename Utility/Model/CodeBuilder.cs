using DevelApp.Utility.Exceptions;
using System;
using System.Text;

namespace DevelApp.Utility.Model
{
    /// <summary>
    /// Wrapped StringBuilder to avoid it taking too much attention
    /// </summary>
    public sealed class CodeBuilder
    {
        private StringBuilder _stringBuilder;
        private int _indentSpacesPerIndent;

        public CodeBuilder(int indentSpacesPerIndent = 4)
        {
            _stringBuilder = new StringBuilder();
            _indentSpacesPerIndent = indentSpacesPerIndent;
        }

        /// <summary>
        /// Appends a line to internal string builder and returns itself to allow for chained calls
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public CodeBuilder L(string line)
        {
            if(_indent > 0)
            {
                _stringBuilder.Append(new string(' ', _indent * _indentSpacesPerIndent));
            }
            _stringBuilder.AppendLine(line);
            return this;
        }

        /// <summary>
        /// Appends an empty line
        /// </summary>
        public CodeBuilder EmptyLine()
        {
            _stringBuilder.AppendLine();
            return this;
        }

        /// <summary>
        /// Called in the end of the code build to translate builder code into string
        /// </summary>
        /// <returns></returns>
        public string Build()
        {
            if (_indent == 0)
            {
                return _stringBuilder.ToString();
            }
            else
            {
                throw new CodeBuilderException($"Indent has not been reset to zero indication an error in generated code");
            }
        }

        private int _indent = 0;

        /// <summary>
        /// Increase indent for the code
        /// </summary>
        public CodeBuilder IndentIncrease()
        {
            _indent += 1;
            return this;
        }

        /// <summary>
        /// Decrease indent for the code
        /// </summary>
        public CodeBuilder IndentDecrease()
        {
            _indent -= 1;
            return this;
        }
    }
}
