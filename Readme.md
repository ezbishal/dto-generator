<Project Sdk='Microsoft.NET.Sdk'>

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <!-- <EmitCompilerGeneratedFiles>true</EmitCompilerGeneratedFiles>
    <CompilerGeneratedFilesOutputPath>Generated</CompilerGeneratedFilesOutputPath> -->
  </PropertyGroup>

  <Target Name='DisableAnalyzers'
    BeforeTargets='CoreCompile'>
    <ItemGroup>
      <Analyzer Remove='@(Analyzer)' />
    </ItemGroup>
  </Target>

  <ItemGroup>
    <ProjectReference Include='..\DtoGenerator\DtoGenerator.csproj'
      OutputItemType='Analyzer' />
  </ItemGroup>

</Project>