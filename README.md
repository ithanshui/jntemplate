﻿
# JNTemplate
[![Build Status](https://travis-ci.org/jiniannet/jntemplate.svg?branch=master)](https://travis-ci.org/jiniannet/jntemplate)
[![GitHub stars](https://img.shields.io/nuget/v/JinianNet.JNTemplate.svg)](https://www.nuget.org/packages/JinianNet.JNTemplate/)
[![GitHub stars](https://img.shields.io/github/stars/jiniannet/jntemplate.svg)](https://github.com/jiniannet/jntemplate/stargazers)
[![GitHub license](https://img.shields.io/badge/license-Mit-blue.svg)](https://raw.githubusercontent.com/jiniannet/jntemplate/master/License.txt)
[![GitHub issues](https://img.shields.io/github/issues/jiniannet/jntemplate.svg)](https://github.com/jiniannet/jntemplate/issues)

[English](https://github.com/jiniannet/jntemplate/blob/master/README.md) | [中文](https://github.com/jiniannet/jntemplate/blob/master/README-zh-CN.md)

### What is JNTemplate?

JNTemplate is a .net template engine for generating html, xml, sql, or any other formatted text output.

### Features:
- faster
- so easy for using
- simpler 
- free

### Quickstart

**Get it on NuGet!**
```
PM> Install-Package JinianNet.JNTemplate

```
or
```
> dotnet add package JinianNet.JNTemplate
```




**Building the source**
```

git clone https://github.com/jiniannet/jntemplate.git
```

Windows:After cloning the repository, run build/build.bat

Linux:After cloning the repository, run build/build.sh

  
  
**Configuration**

You can configure JNTemplate with the EngineConfig class.
```csharp
Engine.Configure((conf)=>{
// .. configure your instance
});
```

**Basic Example**

**简单示例**
```csharp
var template = Engine.CreateTemplate("hello $model.Name");
template.Set("model", new User{
    Name = "jntemplate"
});
var result = template.Render(); 
```

### API
see: www.jiniannet.com


### Licenses
MIT