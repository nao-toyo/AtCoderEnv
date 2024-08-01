// ============================================================
// Project Name   : AtCoderEnvTest
// File Name      : B104Test.cs
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

public class B104Test
{
    [Fact]
    public void Test()
    {
        var head = "3 2";
        var lines = new List<string>()
                    {
                        "hoge foo",
                        "pai za",
                        "12ab cd34"
                    };

        var runner = new B104();
        var output = runner.Run(head, lines.ToArray()).ToList();
        
        Assert.Equal(2, output.Count);
        Assert.Equal(0, output[0]);
        Assert.Equal(0, output[1]);
    }
}

}