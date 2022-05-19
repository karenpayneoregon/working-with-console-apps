# About

For a standard console project using .NET Core 5 the project file as shown below.

What is not shown in C# language version, many will say to use `lastest` but this means when a new version comes out this version is used unlike the second version below which indicates C#9.

```csharp
<Project Sdk="Microsoft.NET.Sdk">
   <PropertyGroup>
      <OutputType>Exe</OutputType>
      <TargetFramework>net5.0</TargetFramework>
   </PropertyGroup>
</Project>
```

Specifies C# versions

```csharp
<Project Sdk="Microsoft.NET.Sdk">
   <PropertyGroup>
      <OutputType>Exe</OutputType>
      <TargetFramework>net5.0</TargetFramework>
      <LangVersion>9.0</LangVersion>
   </PropertyGroup>
</Project>
```