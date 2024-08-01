// ============================================================
// Project Name   : AtCoderEnvTest
// File Name      : A059Test.cs
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

public class A059Test
{
    [Fact]
    public void Test()
    {
        var line1 = "4 10";
        var lines = new List<string>() { "2 7", "7 1", "2 9", "4 7" };
        
        var runner = new A059();

        var output = runner.Run(line1, lines.ToArray());
        
        Assert.Equal("23", output);
    }
    
    [Fact]
    public void Test2()
    {
        var line1 = "5 20";
        var lines = new List<string>()
                    {
                        "19 10",
                        "19 19",
                        "7 6",
                        "7 3",
                        "13 15"
                    };
        
        var runner = new A059();

        var output = runner.Run(line1, lines.ToArray());
        
        Assert.Equal("19", output);
    }
}

}