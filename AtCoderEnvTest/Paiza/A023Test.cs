// ============================================================
// Project Name   : AtCoderEnvTest
// File Name      : A023Test.cs
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

public class A023Test
{
    [Fact]
    public void Test()
    {
        var n = "11";
        var d = "1 1 1 0 1 1 1 0 1 1 0";

        var runner = new A023();
        var output = runner.Run(n, d);
        Assert.Equal("10", output);
    }
    
    [Fact]
    public void Test2()
    {
        var n = "9";
        var d = "1 0 1 1 1 1 1 1 0";

        var runner = new A023();
        var output = runner.Run(n, d);
        Assert.Equal("0", output);
    }
    
    [Fact]
    public void Test3()
    {
        var n = "9";
        var d = "1 0 1 1 1 1 1 1 0";

        var runner = new A023();
        var output = runner.Run(n, d);
        Assert.Equal("0", output);
    }
    
    [Fact]
    public void Test4()
    {
        var n = "9";
        var d = "1 0 0 0 1 1 1 1 1 1 0 1 0 0 0 1 1 1 1 1 1 0";

        var runner = new A023();
        var output = runner.Run(n, d);
        Assert.Equal("9", output);
    }
}

}