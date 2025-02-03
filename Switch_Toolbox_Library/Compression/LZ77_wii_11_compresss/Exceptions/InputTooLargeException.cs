using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Library.Compression.LZ77_wii_11_compresss.Exceptions
{
    /// <summary>
    /// An exception indicating that the file cannot be compressed, because the decompressed size
    /// cannot be represented in the current compression format.
    /// </summary>
    public class InputTooLargeException : Exception
    {
        /// <summary>
        /// Creates a new exception that indicates that the input is too big to be compressed.
        /// </summary>
        public InputTooLargeException()
            : base("压缩比不够高，无法适应输入"
            + "在单个压缩文件中.")
        { }
    }
}
