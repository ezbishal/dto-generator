using DtoGenerator.Attributes;

namespace SampleLibrary;

[GenerateDto("CreateSampleModel", "GetSampleModel")]
public class SampleModel
{
    public string PropToInclude { get; set; }
    [ExcludeProperty("CreateSampleModel")]
    public string PropToExclude { get; set; }
}
