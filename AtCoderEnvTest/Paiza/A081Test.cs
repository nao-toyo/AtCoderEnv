// ============================================================
// Project Name   : AtCoderEnvTest
// File Name      : A081Test.cs
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

public class A081Test
{
    [Fact]
    public void Test()
    {

        var n = "3";
        var d = new List<string>()
                {
                    "2",
                    "2",
                    "1",
                    "1",
                    "3",
                    "3"
                };
        
        var runner = new A081();
        var output = runner.Run(n, d);
        
        Assert.Equal("0", output);
    }


    [Fact]
    public void Test1()
    {

        var n = "5";
        var d = new List<string>()
                {
                    "3",
                    "1",
                    "4",
                    "1",
                    "5",
                    "2",
                    "2",
                    "5",
                    "4",
                    "3",
                };
        
        var runner = new A081();
        var output = runner.Run(n, d);
        
        Assert.Equal("16", output);
    }
}

}