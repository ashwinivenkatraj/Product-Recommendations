// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Recommendations.Client.Entities
{
    using System.Linq;

    /// <summary>
    /// A file parsing report information
    /// </summary>
    public partial class ParsingReport
    {
        /// <summary>
        /// Initializes a new instance of the ParsingReport class.
        /// </summary>
        public ParsingReport() { }

        /// <summary>
        /// Initializes a new instance of the ParsingReport class.
        /// </summary>
        /// <param name="successfullyParsedLinesCount">The total number of
        /// lines parsed successfully</param>
        /// <param name="parsingErrorsSample">A sample list of line parsing
        /// errors</param>
        /// <param name="itemsWithUnknownIdCount">The number of items with an
        /// unknown id</param>
        /// <param name="unknownItemIdsSample">A sample list of unknown item
        /// ids found during parsing</param>
        /// <param name="parsingDuration">The total parsing duration</param>
        public ParsingReport(int? successfullyParsedLinesCount = default(int?), System.Collections.Generic.IList<LineParsingError> parsingErrorsSample = default(System.Collections.Generic.IList<LineParsingError>), long? itemsWithUnknownIdCount = default(long?), System.Collections.Generic.IList<string> unknownItemIdsSample = default(System.Collections.Generic.IList<string>), string parsingDuration = default(string))
        {
            SuccessfullyParsedLinesCount = successfullyParsedLinesCount;
            ParsingErrorsSample = parsingErrorsSample;
            ItemsWithUnknownIdCount = itemsWithUnknownIdCount;
            UnknownItemIdsSample = unknownItemIdsSample;
            ParsingDuration = parsingDuration;
        }

        /// <summary>
        /// Gets or sets the total number of lines parsed successfully
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "successfullyParsedLinesCount")]
        public int? SuccessfullyParsedLinesCount { get; set; }

        /// <summary>
        /// Gets or sets a sample list of line parsing errors
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "parsingErrorsSample")]
        public System.Collections.Generic.IList<LineParsingError> ParsingErrorsSample { get; set; }

        /// <summary>
        /// Gets or sets the number of items with an unknown id
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "itemsWithUnknownIdCount")]
        public long? ItemsWithUnknownIdCount { get; set; }

        /// <summary>
        /// Gets or sets a sample list of unknown item ids found during parsing
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "unknownItemIdsSample")]
        public System.Collections.Generic.IList<string> UnknownItemIdsSample { get; set; }

        /// <summary>
        /// Gets or sets the total parsing duration
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "parsingDuration")]
        public string ParsingDuration { get; set; }

    }
}
