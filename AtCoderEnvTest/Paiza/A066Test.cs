// ============================================================
// Project Name   : AtCoderEnvTest
// File Name      : A066Test.cs
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

public class A066Test
{
    [Fact]
    public void Test()
    {
        var n = "2";
        var d = new List<string>() { "1 4", "5 7" };

        var runner = new A066();
        var output = runner.Run(n, d);
        
        Assert.Equal("7", output);
    }
    
    [Fact]
    public void Test1()
    {
        var n = "4";
        var d = new List<string>()
                {
                    "1 2", "2 3", "5 7", "8 15",
                };

        var runner = new A066();
        var output = runner.Run(n, d);
        
        Assert.Equal("11", output);
    }
    
    [Fact]
    public void Test2()
    {
        var n = "3";
        var d = new List<string>()
                {
                    "1 4", "5 6", "3 7"
                };

        var runner = new A066();
        var output = runner.Run(n, d);
        
        Assert.Equal("7", output);
    }
}

}