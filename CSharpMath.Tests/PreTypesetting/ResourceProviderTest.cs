﻿using CSharpMath.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharpMath.Tests.PreTypesetting {
  public class ResourceProviderTest {
    [Fact]
    public void ResourceProvider_FindsResource() {
      var content = ResourceProvider.ManifestContents("latinmodern-math.json");
      Assert.NotEmpty(content);
    }
    [Fact]
    public void ResourceProvider_FindsMathConfiguration() {
      var content = ResourceLoader.LatinMath;
      var root = content.Root;
      var rootType = root.GetType();
      var constants = root["constants"];
      var constantsType = constants.GetType();
      Assert.True(1 > 0);
    }
  }
}