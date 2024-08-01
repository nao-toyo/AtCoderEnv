// ============================================================
// Project Name   : AtCoderEnvTest
// File Name      : A051Test.cs
// Encoding       : utf-8
// Author         : n_uesugi@toyoseiko.co.jp (Naoya Uesugi)
// 
// Copyright (c) 2024- Toyoseiko Co., Ltd. All rights reserved.
// This source code or any portion thereof must not be
// reproduced or used in any manner whatsoever
// ============================================================

using AtCoderEnv.Paiza;

namespace AtCoderEnvTest
{

public class A051Test
{
    [Fact]
    public void Test()
    {
        var n = "4 4";
        var data = new List<string>() { "5 4 3 10", "1 3 0 6", "9 0 3 2", "3 5 1 3" };

        var runner = new A051();
        var output = runner.Run(n, data);
        
        Assert.Equal("24", output);
    }
    
    [Fact]
    public void Test2()
    {
        var n = "3 4";
        var data = new List<string>() { "1 1 2 1", "2 1 1 2", "2 1 1 2", };

        var runner = new A051();
        var output = runner.Run(n, data);
        
        Assert.Equal("6", output);
    }
}

}