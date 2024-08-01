// ============================================================
// Project Name   : AtCoderEnvTest
// File Name      : A052Test.cs
// Encoding       : utf-8
// Author         : n_uesugi@toyoseiko.co.jp (Naoya Uesugi)
// 
// Copyright (c) 2024- Toyoseiko Co., Ltd. All rights reserved.
// This source code or any portion thereof must not be
// reproduced or used in any manner whatsoever
// ============================================================

using AtCoderEnv.Paiza;

namespace AtCoderEnvTest.Paiza
{

public class A052Test
{
    [Theory]
    [InlineData("8", "3 5", "4")]
    [InlineData("10", "2 4", "5")]
    [InlineData("15", "4 6", "8")]
    [InlineData("7", "3 5", "3")]
    public void RunTest(string line1, string line2, string answer)
    {
        var runner = new A052();
        var output = runner.Run(line1, line2);
        
        Assert.Equal(answer, output);
    }
    
    [Fact]
    public void RunLowerBoundaryTest()
    {
        var runner = new A052();
        var output = runner.Run("1", "1 2");
        var expected = 0;
        
        Assert.Equal(expected.ToString(), output);
    }
    
    [Fact]
    public void RunUpperBoundaryTest()
    {
        var runner = new A052();
        var output = runner.Run("200000", "1 2");
        var expected = 0;
        
        Assert.Equal(expected.ToString(), output);
    }
    
    [Fact]
    public void RunOtherBoundaryTest()
    {
        var runner = new A052();
        var output = runner.Run("200000", "2 4");
        var expected = 200000 / 2;
        
        Assert.Equal(expected.ToString(), output);
    }
    
    [Fact]
    public void RunOtherBoundaryTest2()
    {
        var runner = new A052();
        var output = runner.Run("175457", "4 12");
        
        Assert.Equal("43864", output);
    }
}

}